using System;

namespace ReboundLogParser
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoadLogsButton = new System.Windows.Forms.Button();
            this.LogFileName = new System.Windows.Forms.TextBox();
            this.homeDataGrid = new System.Windows.Forms.DataGridView();
            this.HomeTeam = new System.Windows.Forms.Label();
            this.awayDataGrid = new System.Windows.Forms.DataGridView();
            this.AwayTeam = new System.Windows.Forms.Label();
            this.HomeOT = new System.Windows.Forms.Label();
            this.AwayOT = new System.Windows.Forms.Label();
            this.MultipleFiles = new System.Windows.Forms.Label();
            this.periodTextLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.cefPanel1 = new System.Windows.Forms.Panel();
            this.loadHomePlayersButton = new System.Windows.Forms.Button();
            this.homePlayerBox1 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox2 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox3 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox4 = new System.Windows.Forms.ComboBox();
            this.homePlayerBox5 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox1 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox2 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox3 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox4 = new System.Windows.Forms.ComboBox();
            this.awayPlayerBox5 = new System.Windows.Forms.ComboBox();
            this.loadAwayPlayersButton = new System.Windows.Forms.Button();
            this.SendHomeStatsButton = new System.Windows.Forms.Button();
            this.SendAwayStatsButton = new System.Windows.Forms.Button();
            this.DragDropPanel = new System.Windows.Forms.Panel();
            this.ClearLogsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayDataGrid)).BeginInit();
            this.DragDropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadLogsButton
            // 
            this.LoadLogsButton.Location = new System.Drawing.Point(78, 3);
            this.LoadLogsButton.Name = "LoadLogsButton";
            this.LoadLogsButton.Size = new System.Drawing.Size(70, 31);
            this.LoadLogsButton.TabIndex = 0;
            this.LoadLogsButton.Text = "Open Logs";
            this.LoadLogsButton.UseVisualStyleBackColor = true;
            this.LoadLogsButton.Click += new System.EventHandler(this.LoadLogsButton_Click);
            // 
            // LogFileName
            // 
            this.LogFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right))
            );
            this.LogFileName.Location = new System.Drawing.Point(26, 6);
            this.LogFileName.Name = "LogFileName";
            this.LogFileName.ReadOnly = true;
            this.LogFileName.Size = new System.Drawing.Size(489, 20);
            this.LogFileName.TabIndex = 1;
            // 
            // homeDataGrid
            // 
            this.homeDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right))
            );
            this.homeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.homeDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.homeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeDataGrid.Location = new System.Drawing.Point(1, 93);
            this.homeDataGrid.Name = "homeDataGrid";
            this.homeDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.homeDataGrid.Size = new System.Drawing.Size(806, 164);
            this.homeDataGrid.TabIndex = 2;
            // 
            // HomeTeam
            // 
            this.HomeTeam.AutoSize = true;
            this.HomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTeam.Location = new System.Drawing.Point(1, 48);
            this.HomeTeam.Name = "HomeTeam";
            this.HomeTeam.Size = new System.Drawing.Size(222, 42);
            this.HomeTeam.TabIndex = 5;
            this.HomeTeam.Text = "Home Team";
            // 
            // awayDataGrid
            // 
            this.awayDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right))
            );
            this.awayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.awayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awayDataGrid.Location = new System.Drawing.Point(1, 322);
            this.awayDataGrid.Name = "awayDataGrid";
            this.awayDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.awayDataGrid.Size = new System.Drawing.Size(807, 164);
            this.awayDataGrid.TabIndex = 7;
            // 
            // AwayTeam
            // 
            this.AwayTeam.AutoSize = true;
            this.AwayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayTeam.Location = new System.Drawing.Point(1, 276);
            this.AwayTeam.Name = "AwayTeam";
            this.AwayTeam.Size = new System.Drawing.Size(215, 42);
            this.AwayTeam.TabIndex = 8;
            this.AwayTeam.Text = "Away Team";
            // 
            // HomeOT
            // 
            this.HomeOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeOT.AutoSize = true;
            this.HomeOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeOT.ForeColor = System.Drawing.Color.Red;
            this.HomeOT.Location = new System.Drawing.Point(358, 48);
            this.HomeOT.Name = "HomeOT";
            this.HomeOT.Size = new System.Drawing.Size(293, 42);
            this.HomeOT.TabIndex = 9;
            this.HomeOT.Text = "OVERTIME WIN";
            this.HomeOT.Visible = false;
            // 
            // AwayOT
            // 
            this.AwayOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AwayOT.AutoSize = true;
            this.AwayOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayOT.ForeColor = System.Drawing.Color.Red;
            this.AwayOT.Location = new System.Drawing.Point(358, 276);
            this.AwayOT.Name = "AwayOT";
            this.AwayOT.Size = new System.Drawing.Size(293, 42);
            this.AwayOT.TabIndex = 10;
            this.AwayOT.Text = "OVERTIME WIN";
            this.AwayOT.Visible = false;
            // 
            // MultipleFiles
            // 
            this.MultipleFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MultipleFiles.AutoSize = true;
            this.MultipleFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleFiles.ForeColor = System.Drawing.Color.Red;
            this.MultipleFiles.Location = new System.Drawing.Point(521, 6);
            this.MultipleFiles.Name = "MultipleFiles";
            this.MultipleFiles.Size = new System.Drawing.Size(285, 25);
            this.MultipleFiles.TabIndex = 11;
            this.MultipleFiles.Text = "Multiple log files in log folder";
            this.MultipleFiles.Visible = false;
            // 
            // periodTextLabel
            // 
            this.periodTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodTextLabel.AutoSize = true;
            this.periodTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.periodTextLabel.Location = new System.Drawing.Point(703, 48);
            this.periodTextLabel.Name = "periodTextLabel";
            this.periodTextLabel.Size = new System.Drawing.Size(74, 25);
            this.periodTextLabel.TabIndex = 12;
            this.periodTextLabel.Text = "Period:";
            // 
            // periodLabel
            // 
            this.periodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.periodLabel.Location = new System.Drawing.Point(783, 48);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(23, 25);
            this.periodLabel.TabIndex = 13;
            this.periodLabel.Text = "0";
            // 
            // cefPanel1
            // 
            this.cefPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right))
            );
            this.cefPanel1.Location = new System.Drawing.Point(4, 501);
            this.cefPanel1.Name = "cefPanel1";
            this.cefPanel1.Size = new System.Drawing.Size(933, 151);
            this.cefPanel1.TabIndex = 14;
            // 
            // loadHomePlayersButton
            // 
            this.loadHomePlayersButton.Location = new System.Drawing.Point(4, 51);
            this.loadHomePlayersButton.Name = "loadHomePlayersButton";
            this.loadHomePlayersButton.Size = new System.Drawing.Size(119, 34);
            this.loadHomePlayersButton.TabIndex = 15;
            this.loadHomePlayersButton.Text = "Load Home Players";
            this.loadHomePlayersButton.UseVisualStyleBackColor = true;
            this.loadHomePlayersButton.Click += new System.EventHandler(this.TeamPlayersLoadButton_Click);
            // 
            // homePlayerBox1
            // 
            this.homePlayerBox1.FormattingEnabled = true;
            this.homePlayerBox1.Location = new System.Drawing.Point(4, 91);
            this.homePlayerBox1.Name = "homePlayerBox1";
            this.homePlayerBox1.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox1.TabIndex = 16;
            this.homePlayerBox1.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox1.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox2
            // 
            this.homePlayerBox2.FormattingEnabled = true;
            this.homePlayerBox2.Location = new System.Drawing.Point(4, 118);
            this.homePlayerBox2.Name = "homePlayerBox2";
            this.homePlayerBox2.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox2.TabIndex = 16;
            this.homePlayerBox2.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox2.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox3
            // 
            this.homePlayerBox3.FormattingEnabled = true;
            this.homePlayerBox3.Location = new System.Drawing.Point(4, 145);
            this.homePlayerBox3.Name = "homePlayerBox3";
            this.homePlayerBox3.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox3.TabIndex = 16;
            this.homePlayerBox3.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox3.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox4
            // 
            this.homePlayerBox4.FormattingEnabled = true;
            this.homePlayerBox4.Location = new System.Drawing.Point(4, 172);
            this.homePlayerBox4.Name = "homePlayerBox4";
            this.homePlayerBox4.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox4.TabIndex = 16;
            this.homePlayerBox4.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox4.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // homePlayerBox5
            // 
            this.homePlayerBox5.FormattingEnabled = true;
            this.homePlayerBox5.Location = new System.Drawing.Point(4, 199);
            this.homePlayerBox5.Name = "homePlayerBox5";
            this.homePlayerBox5.Size = new System.Drawing.Size(119, 21);
            this.homePlayerBox5.TabIndex = 16;
            this.homePlayerBox5.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.homePlayerBox5.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox1
            // 
            this.awayPlayerBox1.FormattingEnabled = true;
            this.awayPlayerBox1.Location = new System.Drawing.Point(4, 319);
            this.awayPlayerBox1.Name = "awayPlayerBox1";
            this.awayPlayerBox1.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox1.TabIndex = 16;
            this.awayPlayerBox1.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox1.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox2
            // 
            this.awayPlayerBox2.FormattingEnabled = true;
            this.awayPlayerBox2.Location = new System.Drawing.Point(4, 346);
            this.awayPlayerBox2.Name = "awayPlayerBox2";
            this.awayPlayerBox2.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox2.TabIndex = 16;
            this.awayPlayerBox2.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox2.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox3
            // 
            this.awayPlayerBox3.FormattingEnabled = true;
            this.awayPlayerBox3.Location = new System.Drawing.Point(4, 373);
            this.awayPlayerBox3.Name = "awayPlayerBox3";
            this.awayPlayerBox3.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox3.TabIndex = 16;
            this.awayPlayerBox3.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox3.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox4
            // 
            this.awayPlayerBox4.FormattingEnabled = true;
            this.awayPlayerBox4.Location = new System.Drawing.Point(3, 400);
            this.awayPlayerBox4.Name = "awayPlayerBox4";
            this.awayPlayerBox4.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox4.TabIndex = 16;
            this.awayPlayerBox4.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox4.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // awayPlayerBox5
            // 
            this.awayPlayerBox5.FormattingEnabled = true;
            this.awayPlayerBox5.Location = new System.Drawing.Point(3, 427);
            this.awayPlayerBox5.Name = "awayPlayerBox5";
            this.awayPlayerBox5.Size = new System.Drawing.Size(119, 21);
            this.awayPlayerBox5.TabIndex = 16;
            this.awayPlayerBox5.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.awayPlayerBox5.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // loadAwayPlayersButton
            // 
            this.loadAwayPlayersButton.Location = new System.Drawing.Point(4, 279);
            this.loadAwayPlayersButton.Name = "loadAwayPlayersButton";
            this.loadAwayPlayersButton.Size = new System.Drawing.Size(119, 34);
            this.loadAwayPlayersButton.TabIndex = 15;
            this.loadAwayPlayersButton.Text = "Load Away Players";
            this.loadAwayPlayersButton.UseVisualStyleBackColor = true;
            this.loadAwayPlayersButton.Click += new System.EventHandler(this.TeamPlayersLoadButton_Click);
            // 
            // SendHomeStatsButton
            // 
            this.SendHomeStatsButton.Location = new System.Drawing.Point(4, 226);
            this.SendHomeStatsButton.Name = "SendHomeStatsButton";
            this.SendHomeStatsButton.Size = new System.Drawing.Size(119, 35);
            this.SendHomeStatsButton.TabIndex = 17;
            this.SendHomeStatsButton.Text = "Send Home Stats";
            this.SendHomeStatsButton.UseVisualStyleBackColor = true;
            this.SendHomeStatsButton.Click += new System.EventHandler(this.SendStatsButton_Click);
            // 
            // SendAwayStatsButton
            // 
            this.SendAwayStatsButton.Location = new System.Drawing.Point(4, 454);
            this.SendAwayStatsButton.Name = "SendAwayStatsButton";
            this.SendAwayStatsButton.Size = new System.Drawing.Size(119, 35);
            this.SendAwayStatsButton.TabIndex = 17;
            this.SendAwayStatsButton.Text = "Send Away Stats";
            this.SendAwayStatsButton.UseVisualStyleBackColor = true;
            this.SendAwayStatsButton.Click += new System.EventHandler(this.SendStatsButton_Click);
            // 
            // DragDropPanel
            // 
            this.DragDropPanel.AllowDrop = true;
            this.DragDropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right))
            );
            this.DragDropPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DragDropPanel.Controls.Add(this.periodTextLabel);
            this.DragDropPanel.Controls.Add(this.periodLabel);
            this.DragDropPanel.Controls.Add(this.MultipleFiles);
            this.DragDropPanel.Controls.Add(this.LogFileName);
            this.DragDropPanel.Controls.Add(this.AwayTeam);
            this.DragDropPanel.Controls.Add(this.HomeTeam);
            this.DragDropPanel.Controls.Add(this.HomeOT);
            this.DragDropPanel.Controls.Add(this.AwayOT);
            this.DragDropPanel.Controls.Add(this.homeDataGrid);
            this.DragDropPanel.Controls.Add(this.awayDataGrid);
            this.DragDropPanel.Location = new System.Drawing.Point(128, 3);
            this.DragDropPanel.Name = "DragDropPanel";
            this.DragDropPanel.Size = new System.Drawing.Size(809, 492);
            this.DragDropPanel.TabIndex = 18;
            this.DragDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropPanel_DragDrop);
            this.DragDropPanel.DragOver += new System.Windows.Forms.DragEventHandler(this.DragDropPanel_DragOver);
            // 
            // ClearLogsButton
            // 
            this.ClearLogsButton.Location = new System.Drawing.Point(4, 3);
            this.ClearLogsButton.Name = "ClearLogsButton";
            this.ClearLogsButton.Size = new System.Drawing.Size(68, 31);
            this.ClearLogsButton.TabIndex = 19;
            this.ClearLogsButton.Text = "Clear Logs";
            this.ClearLogsButton.UseVisualStyleBackColor = true;
            this.ClearLogsButton.Click += new System.EventHandler(this.ClearLogsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 656);
            this.Controls.Add(this.LoadLogsButton);
            this.Controls.Add(this.ClearLogsButton);
            this.Controls.Add(this.SendAwayStatsButton);
            this.Controls.Add(this.SendHomeStatsButton);
            this.Controls.Add(this.awayPlayerBox5);
            this.Controls.Add(this.awayPlayerBox4);
            this.Controls.Add(this.awayPlayerBox3);
            this.Controls.Add(this.awayPlayerBox2);
            this.Controls.Add(this.awayPlayerBox1);
            this.Controls.Add(this.homePlayerBox5);
            this.Controls.Add(this.homePlayerBox4);
            this.Controls.Add(this.homePlayerBox3);
            this.Controls.Add(this.homePlayerBox2);
            this.Controls.Add(this.homePlayerBox1);
            this.Controls.Add(this.loadAwayPlayersButton);
            this.Controls.Add(this.loadHomePlayersButton);
            this.Controls.Add(this.cefPanel1);
            this.Controls.Add(this.DragDropPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 695);
            this.Name = "MainForm";
            this.Text = "Rebound Log Parser 6.0";
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayDataGrid)).EndInit();
            this.DragDropPanel.ResumeLayout(false);
            this.DragDropPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button LoadLogsButton;
        private System.Windows.Forms.TextBox LogFileName;
        private System.Windows.Forms.DataGridView homeDataGrid;
        private System.Windows.Forms.Label HomeTeam;
        private System.Windows.Forms.DataGridView awayDataGrid;
        private System.Windows.Forms.Label AwayTeam;
        private System.Windows.Forms.Label HomeOT;
        private System.Windows.Forms.Label AwayOT;
        private System.Windows.Forms.Label MultipleFiles;
        private System.Windows.Forms.Label periodTextLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Panel cefPanel1;
        private System.Windows.Forms.Button loadHomePlayersButton;
        private System.Windows.Forms.ComboBox homePlayerBox1;
        private System.Windows.Forms.ComboBox homePlayerBox2;
        private System.Windows.Forms.ComboBox homePlayerBox3;
        private System.Windows.Forms.ComboBox homePlayerBox4;
        private System.Windows.Forms.ComboBox homePlayerBox5;
        private System.Windows.Forms.ComboBox awayPlayerBox1;
        private System.Windows.Forms.ComboBox awayPlayerBox2;
        private System.Windows.Forms.ComboBox awayPlayerBox3;
        private System.Windows.Forms.ComboBox awayPlayerBox4;
        private System.Windows.Forms.ComboBox awayPlayerBox5;
        private System.Windows.Forms.Button loadAwayPlayersButton;
        private System.Windows.Forms.Button SendHomeStatsButton;
        private System.Windows.Forms.Button SendAwayStatsButton;
        private System.Windows.Forms.Panel DragDropPanel;
        private System.Windows.Forms.Button ClearLogsButton;
    }
}

