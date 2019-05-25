using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// One team vs another team
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of participants (player 1, player 2 and etc)
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Specifies witch team is the winner
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Specifies the number of the round
        /// </summary>
        public int MatchupRound { get; set; }
    }
}