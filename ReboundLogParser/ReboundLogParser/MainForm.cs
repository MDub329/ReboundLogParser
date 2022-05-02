using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using CefSharp.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReboundLogParser {
    public partial class MainForm : Form
    {
        static List<stats> _homeTeamPlayers = new List<stats>();
        static List<stats> _awayTeamPlayers = new List<stats>();
        static int _homeScore;
        static int _awayScore;
        static int _period;
        static string _currentPeriod;
        static bool _overTime = false;
        static string _loadedFile;
        static List<string> _loadedFiles = new List<string>();
        static List<string> _lastLoadedFiles = new List<string>();
        static bool _multipleFiles = false;
        const string WRONGPERIODTEXT = "Period 3 log not found!";
        const string MULTIPLEFILESTEXT = "Multiiple logfile mode!";
        const string INVALIDJSONTEXT = "Invalid JSON, try again!";
        private ChromiumWebBrowser _browser;
        private List<ComboBox> _homePlayerBoxes;
        private List<ComboBox> _awayPlayerBoxes;

        public MainForm()
        {
            CefSettings cefSettings = new CefSettings();
            CefSharp.Cef.EnableHighDPISupport();
            CefSharp.Cef.Initialize(cefSettings);

            InitializeComponent();
            _homePlayerBoxes = new List<ComboBox>() { homePlayerBox1, homePlayerBox2, homePlayerBox3, homePlayerBox4, homePlayerBox5 };
            _awayPlayerBoxes = new List<ComboBox>() { awayPlayerBox1, awayPlayerBox2, awayPlayerBox3, awayPlayerBox4, awayPlayerBox5 };
            _homePlayerBoxes.ForEach(box => box.Enabled = false);
            _awayPlayerBoxes.ForEach(box => box.Enabled = false);
            loadHomePlayersButton.Enabled = false;
            loadAwayPlayersButton.Enabled = false;
            SendHomeStatsButton.Enabled = false;
            SendAwayStatsButton.Enabled = false;

            _browser = new ChromiumWebBrowser("https://a.leaguerepublic.com/myaccount/login/index.html?lver=2");
            cefPanel1.Controls.Add(_browser);
        }

        private void LoadLogsButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var fileTemp = dialog.FileNames.ToList();
                    if (!_loadedFiles.Any(x => fileTemp.Contains(x)))
                    {
                        _loadedFiles.AddRange(fileTemp);
                    }
                    LoadLogFiles(_loadedFiles);
                }
            }
        }

        private void LoadLogFiles(List<string> fileNames = null)
        {
            ResetFormData();
            bool success = LoadAndParseLogFiles(fileNames);
            SetLoadedFileDisplays();
            if (!success)
            {
                MultipleFiles.Text = INVALIDJSONTEXT;
                MultipleFiles.Visible = true;
                if (fileNames != null)
                {
                    _loadedFiles.RemoveAll(file => fileNames.Contains(file) && !_lastLoadedFiles.Contains(file));
                }  
            }
            SetTeamAndPeriodLabels();
            CheckOvertimeWin();
            PopulateDataGrid();
            _lastLoadedFiles = new List<string>(_loadedFiles);

            if (homeDataGrid.Rows.Count > 0)
            {
                loadHomePlayersButton.Enabled = true;
            }
            if (awayDataGrid.Rows.Count > 0)
            {
                loadAwayPlayersButton.Enabled = true;
            }
        }

        private void ResetFormData()
        {
            _homeTeamPlayers.Clear();
            ClearTeamComboBoxes(true);
            _awayTeamPlayers.Clear();
            ClearTeamComboBoxes(false);

            homeDataGrid.DataSource = null;
            awayDataGrid.DataSource = null;
            homeDataGrid.Rows.Clear();
            awayDataGrid.Rows.Clear();
            loadHomePlayersButton.Enabled = false;
            loadAwayPlayersButton.Enabled = false;
            MultipleFiles.Visible = false;

            _multipleFiles = false;
            _loadedFile = String.Empty;
            _homeScore = 0;
            _awayScore = 0;
            _period = 0;
            SetTeamAndPeriodLabels();
            _overTime = false;
            CheckOvertimeWin();
            _loadedFile = String.Empty;
            LogFileName.Text = String.Empty;
        }

        static bool LoadAndParseLogFiles(List<string> fileNames = null)
        {
            bool success = false;
            fileNames = fileNames ?? new List<string>();
            foreach (var fileName in fileNames)
            {
                success = ParseJson(fileName);
                if (!success)
                {
                    return success; // Will return false here
                }
                _loadedFile += $"{fileName}; ";
            }

            _multipleFiles = fileNames.Count > 1;
            _loadedFile = (fileNames.Count() < 1) ? "Problem Loading Files!" : _loadedFile;

            return success; // True if successful, false if no files
        }

        private void SetLoadedFileDisplays()
        {
            MultipleFiles.Text = MULTIPLEFILESTEXT;
            MultipleFiles.Visible = _multipleFiles;
            LogFileName.Text = _loadedFile;
        }

        private void SetTeamAndPeriodLabels()
        {
            HomeTeam.Text = $"Home Team: {_homeScore}";
            AwayTeam.Text = $"Away Team: {_awayScore}";
            periodLabel.Text = _period.ToString();

            if (_currentPeriod != "3")
            {
                MultipleFiles.Text = WRONGPERIODTEXT;
                MultipleFiles.Visible = true;
            }
        }

        private void CheckOvertimeWin()
        {
            if (_overTime)
            {
                bool isHomeWinningOvertimeTeam = _homeScore > _awayScore;
                HomeOT.Visible = isHomeWinningOvertimeTeam;
                AwayOT.Visible = !isHomeWinningOvertimeTeam;
            }
            else
            {
                HomeOT.Visible = false;
                AwayOT.Visible = false;
            }
        }

        private void PopulateDataGrid()
        {
            homeDataGrid.DataSource = _homeTeamPlayers;
            awayDataGrid.DataSource = _awayTeamPlayers;
        }

        static bool ParseJson(string fileName)
        {
            dynamic o1 = new JObject();
            try
            {
                o1 = JObject.Parse(File.ReadAllText(fileName));
            }
            catch (JsonReaderException jex)
            {
                _loadedFile = $"Problem Loading Files: {jex.Message}";
                return false;
            }
            catch (Exception ex)
            {
                _loadedFile = $"Problem Loading Files: {ex.Message}";
                return false;
            }

            _overTime = CheckOvertime(o1);
            string homeScoreString = o1.score.home;
            string awayScoreString = o1.score.away;
            string periodString = o1.current_period;
            _homeScore += int.Parse(homeScoreString);
            _awayScore += int.Parse(awayScoreString);
            _period = int.Parse(periodString);
            _currentPeriod = o1.current_period;
            foreach (dynamic player in o1.players)
            {
                var isHomeTeam = player.team == "home";
                var teamToBuild = isHomeTeam ? _homeTeamPlayers : _awayTeamPlayers;
                if (PlayerExists(player, teamToBuild))
                {
                    for (int p = 0; p < teamToBuild.Count; p++)
                    {
                        if (teamToBuild[p].PlayerName == player.username.ToString())
                        {
                            teamToBuild[p].addValues(player);
                        }
                    }
                }
                else
                {
                    teamToBuild.Add(new stats(player));
                }
            }
            _homeTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });
            _awayTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });

            return true;
        }

        static bool CheckOvertime(dynamic statsObject)
        {
            bool returnBool = false;
            double homeTeamOT = 0;
            double awayTeamOT = 0;
            
            for (int i = 0; i < 5; i++)
            {
                if (statsObject.players[i].team == "away")
                {
                    break;
                }

                try
                {
                    homeTeamOT = statsObject.players[i].stats.overtime_wins;
                }
                catch
                {
                    homeTeamOT = 0;
                }

                if (homeTeamOT == 0)
                {
                    try
                    {
                        awayTeamOT = statsObject.players[i].stats.overtime_losses;
                    }
                    catch
                    {
                        awayTeamOT = 0;
                    }
                }

                if (homeTeamOT == 1 || awayTeamOT == 1)
                {
                    break;
                }
            }

            if (awayTeamOT == 1 || homeTeamOT == 1)
            {
                returnBool = true;
            }

            return returnBool;
        }

        static bool PlayerExists(dynamic passedPlayer, List<stats> playerArray)
        {
            bool returnValue = false;
            for (int j = 0; j < playerArray.Count; j++)
            {
                if (playerArray[j].PlayerName == passedPlayer.username.ToString())
                {
                    returnValue = true;
                }
            }
            return returnValue;
        }

        private async void TeamPlayersLoadButton_Click(object sender, EventArgs e)
        {
            // Find out what team should have names loaded to ComboBoxes
            var isHomeTeam = (sender as Button).Name == "loadHomePlayersButton";

            CefSharp.JavascriptResponse result = await _browser.GetBrowser().MainFrame.EvaluateScriptAsync(
                "function foo() {players = new Array();" +
                "rows = document.getElementsByClassName(\"sticky-col\")[0].getElementsByTagName(\"tr\");" +
                "for (i = 0; i < rows.length; i++)" +
                "{" +
                "players.push(rows[i].getElementsByTagName(\"th\")[0].innerHTML.toString().trim());" +
                "}" +
                "return players;}" +
                "foo();"
            );

            if (result != null && result.Success)
            {
                var playerNames = result.Result as List<object>;
                playerNames.RemoveAt(0); // Remove the "Name" column heading.
                List<string> playerNameStringList = playerNames.OfType<string>().ToList();
                PopulateComboBoxes(playerNameStringList, isHomeTeam);
            }
        }

        private void PopulateComboBoxes(List<string> players, bool isHomeTeam)
        {
            var playerBoxes = isHomeTeam ? _homePlayerBoxes : _awayPlayerBoxes;
            ClearTeamComboBoxes(isHomeTeam);
            foreach (var box in playerBoxes)
            {
                var dataGrid = isHomeTeam ? homeDataGrid : awayDataGrid;
                if (!dataGrid.Rows.Count.Equals(0) && playerBoxes.IndexOf(box) < dataGrid.Rows.Count)
                {
                    box.Enabled = true;
                    box.Items.AddRange(players.ToArray<object>());
                }
            }
        }

        private void ClearTeamComboBoxes(bool isHomeTeam)
        {
            var playerBoxes = isHomeTeam ? _homePlayerBoxes : _awayPlayerBoxes;
            foreach (var box in playerBoxes)
            {
                box.SelectedIndex = -1;
                box.Items.Clear();
                box.Enabled = false;
            }
        }

        private void SendStatsButton_Click(object sender, EventArgs e)
        {
            var isHomeTeam = (sender as Button).Name == "SendHomeStatsButton";
            var playerBoxesFilled = !(isHomeTeam ? _homePlayerBoxes : _awayPlayerBoxes)
                .Any(box => box.SelectedIndex.Equals(-1) && box.Enabled.Equals(true));
            if (playerBoxesFilled)
            {
                FillStatsInWebForm(isHomeTeam);
            }
        }

        private void FillStatsInWebForm(bool isHomeTeam)
        {
            var teamPlayerBoxes = isHomeTeam ? _homePlayerBoxes : _awayPlayerBoxes;
            var teamPlayers = isHomeTeam ? _homeTeamPlayers : _awayTeamPlayers;
            var frame = _browser.GetBrowser().MainFrame;

            foreach (var cb in teamPlayerBoxes)
            {
                if (cb.SelectedIndex > -1)
                {
                    var values = Enum.GetValues(typeof(StatsEnum));
                    foreach (StatsEnum stat in values)
                    { 
                        var cbIndex = teamPlayerBoxes.IndexOf(cb);
                        frame.ExecuteJavaScriptAsync(
                            $"document.getElementsByTagName(\"tbody\")[0]" +
                            $".getElementsByTagName(\"tr\")[{cb.SelectedIndex}]" +
                            $".getElementsByTagName(\"td\")[{(int)stat}]" +
                            $".getElementsByTagName(\"input\")[0].value = {teamPlayers[cbIndex].GetPropertyValueByEnum(stat)};"
                        );
                    }
                }
            }
        }

        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changedComboBox = (sender as ComboBox);
            var isHomeTeamBox = _homePlayerBoxes.Any(box => box.Name.Equals(changedComboBox.Name));
            var teamBoxes = (isHomeTeamBox ? _homePlayerBoxes : _awayPlayerBoxes);

            var boxesWithDuplicateSelections = teamBoxes.GroupBy(box => box.SelectedItem)
                .Where(groupings => groupings.Count() > 1 && groupings.Key != null)
                .Select(boxBySelectedItem => boxBySelectedItem.Key)
                .ToList();
            foreach (var dupePlayer in boxesWithDuplicateSelections)
            {
                if (dupePlayer != null)
                {
                    var boxes = teamBoxes.Select(box => box)
                        .Where(selectedBox => selectedBox.SelectedItem != null
                            && selectedBox.SelectedItem.Equals(dupePlayer));
                    foreach (var box in boxes)
                    {
                        box.BackColor = System.Drawing.Color.Red;
                    }
                }
            }

            var boxesWithoutDuplicateSelections = teamBoxes.GroupBy(box => box.SelectedItem)
                .Where(groupings => groupings.Count() <= 1 || groupings.Key == null)
                .Select(boxBySelectedItem => boxBySelectedItem.Key)
                .ToList();
            foreach (var nonDupePlayer in boxesWithoutDuplicateSelections)
            {
                if (nonDupePlayer != null)
                {
                    var boxes = teamBoxes.Select(box => box)
                        .Where(boxBySelectedItem => boxBySelectedItem.SelectedItem == null
                            || boxBySelectedItem.SelectedItem.Equals(nonDupePlayer));
                    foreach (var box in boxes)
                    {
                         box.BackColor = default;
                    }
                }
            }

            var selectedTeamStatsButton = isHomeTeamBox ? SendHomeStatsButton : SendAwayStatsButton;
            var selectedTeamBoxes = isHomeTeamBox ? _homePlayerBoxes : _awayPlayerBoxes;
            selectedTeamStatsButton.Enabled = boxesWithDuplicateSelections.Count() == 0
                && !selectedTeamBoxes.Any(box => box.Enabled.Equals(true) && box.SelectedIndex.Equals(-1));
        }

        private void DragDropPanel_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DragDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            var dropFiles = e.Data.GetData(DataFormats.FileDrop); // get all files dropped
            List<string> files = new List<string>();
            files.AddRange((dropFiles as string[]).ToList()); ;
            if (files != null && files.Any())
            {
                foreach (var file in files)
                {
                    if (!_loadedFiles.Contains(file))
                    {
                        _loadedFiles.Add(file);
                    }
                }
                LoadLogFiles(_loadedFiles);
            }
        }

        private void ClearLogsButton_Click(object sender, EventArgs e)
        {
            _loadedFiles.Clear();
            _lastLoadedFiles.Clear();
            ResetFormData();
        }
    }
}
