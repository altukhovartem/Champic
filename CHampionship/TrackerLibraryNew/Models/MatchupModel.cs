using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// One team vs another team
    /// </summary>
    public class MatchupModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents the list of participants (player 1, player 2 and etc)
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The ID from the db that will be used to identify the winner
        /// </summary>
        public int WinnerID { get; set; }

        /// <summary>
        /// Specifies witch team is the winner
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Specifies the number of the round
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = ""; 
                foreach (MatchupEntryModel matchupEntry in Entries)
                {
                    if (matchupEntry.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = matchupEntry.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {matchupEntry.TeamCompeting.TeamName}";
                        } 
                    }
                    else
                    {
                        output = "Matchup Not Yet Determind";
                        break;
                    }
                }
                return output;
            }
        }
    }
}