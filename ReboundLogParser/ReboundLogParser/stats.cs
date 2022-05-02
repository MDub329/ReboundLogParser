using System.Collections.Generic;

namespace ReboundLogParser
{
    class stats
    {
        public stats(dynamic statsObject)
        {
            PlayerName = statsObject.username;
            Team = statsObject.team;

            try
            {
                Goals = statsObject.stats.goals.Value;
            }
            catch
            {
                Goals = 0;
            }

            try
            {
                Primary_assists = statsObject.stats.primary_assists.Value;
            }
            catch
            {
                Primary_assists = 0;
            }

            try
            {
                Sec_assists = statsObject.stats.secondary_assists.Value;
            }
            catch
            {
                Sec_assists = 0;
            }

            try
            {
                Shots = statsObject.stats.shots.Value;
            }
            catch
            {
                Shots = 0;
            }

            try
            {
                Saves = statsObject.stats.saves.Value;
            }
            catch
            {
                Saves = 0;
            }

            try
            {
                Faceoffs_won = statsObject.stats.faceoffs_won.Value;
            }
            catch
            {
                Faceoffs_won = 0;
            }

            try
            {
                Faceoffs_lost = statsObject.stats.faceoffs_lost.Value;
            }
            catch
            {
                Faceoffs_lost = 0;
            }

            try
            {
                Takeaways = statsObject.stats.takeaways.Value;
            }
            catch
            {
                Takeaways = 0;
            }

            try
            {
                Turnovers = statsObject.stats.turnovers.Value;
            }
            catch
            {
                Turnovers = 0;
            }

            try
            {
                Post_hits = statsObject.stats.post_hits.Value;
            }
            catch
            {
                Post_hits = 0;
            }

            try
            {
                Passes = statsObject.stats.passes.Value;
            }
            catch
            {
                Passes = 0;
            }

            try
            {
                Blocks = statsObject.stats.blocks.Value;
            }
            catch
            {
                Blocks = 0;
            }

            try
            {
                GW_Goals = statsObject.stats.game_winning_goals.Value;
            }
            catch
            {
                GW_Goals = 0;
            }

            try
            {
                Possession_Time = statsObject.stats.possession_time_sec.Value;
            }
            catch
            {
                Possession_Time = 0;
            }
        }

        public void addValues(dynamic statsObject) {
            try
            {
                Goals += statsObject.stats.goals.Value;
            }
            catch
            {
                Goals += 0;
            }

            try
            {
                Primary_assists += statsObject.stats.primary_assists.Value;
            }
            catch 
            {
                Primary_assists += 0;
            }

            try
            {
                Sec_assists += statsObject.stats.secondary_assists.Value;
            }
            catch
            {
                Sec_assists += 0;
            }

            try
            {
                Shots += statsObject.stats.shots.Value;
            }
            catch
            {
                Shots += 0;
            }

            try
            {
                Saves += statsObject.stats.saves.Value;
            }
            catch
            {
                Saves += 0;
            }

            try
            {
                Faceoffs_won += statsObject.stats.faceoffs_won.Value;
            }
            catch
            {
                Faceoffs_won += 0;
            }

            try
            {
                Faceoffs_lost += statsObject.stats.faceoffs_lost.Value;
            }
            catch
            {
                Faceoffs_lost += 0;
            }

            try
            {
                Takeaways += statsObject.stats.takeaways.Value;
            }
            catch
            {
                Takeaways += 0;
            }

            try
            {
                Turnovers += statsObject.stats.turnovers.Value;
            }
            catch
            {
                Turnovers += 0;
            }

            try
            {
                Post_hits += statsObject.stats.post_hits.Value;
            }
            catch
            {
                Post_hits += 0;
            }

            try
            {
                Passes += statsObject.stats.passes.Value;
            }
            catch
            {
                Passes += 0;
            }

            try
            {
                Blocks += statsObject.stats.blocks.Value;
            }
            catch
            {
                Blocks += 0;
            }

            try
            {
                GW_Goals += statsObject.stats.game_winning_goals.Value;
            }
            catch
            {
                GW_Goals += 0;
            }

            try
            {
                Possession_Time += statsObject.stats.possession_time_sec.Value;
            }
            catch
            {
                Possession_Time += 0;
            }
        }

        public double GetPropertyValueByEnum(StatsEnum enumValue)
        {
            Dictionary<StatsEnum, object> kvp = new Dictionary<StatsEnum, object>()
            {
                { StatsEnum.Goals, Goals },
                { StatsEnum.PrimaryAssists, Primary_assists },
                { StatsEnum.SecondaryAssists, Sec_assists },
                { StatsEnum.Shots, Shots },
                { StatsEnum.Saves, Saves },
                { StatsEnum.FaceoffsWon, Faceoffs_won },
                { StatsEnum.FaceoffsLost, Faceoffs_lost },
                { StatsEnum.TakeAways, Takeaways },
                { StatsEnum.TurnOvers, Turnovers },
                { StatsEnum.PostHits, Post_hits },
                { StatsEnum.Passes, Passes },
                { StatsEnum.Blocks, Blocks },
                { StatsEnum.GameWinningGoals, GW_Goals },
                { StatsEnum.PossessionTime, Possession_Time }
            };

            return (double)kvp[enumValue];
        }

        public string PlayerName { get; set; }
        public string Team { get; private set; }
        public double Goals { get; set; }
        public double Primary_assists { get; set; }
        public double Sec_assists { get; set; }
        public double Shots { get; set; }
        public double Saves { get; set; }
        public double Faceoffs_won { get; set; }
        public double Faceoffs_lost { get; set; }
        public double Takeaways { get; set; }
        public double Turnovers { get; set; }
        public double Post_hits { get; set; }
        public double Passes { get; set; }
        public double Blocks { get; set; }
        public double GW_Goals { get; set; }
        public double Possession_Time { get; set; }
    }
}
