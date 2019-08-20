using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// All data surrounds the actual tournament
    /// </summary>
    public class TournamentModel
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the amount of money which is paid by the team to have an ability to participate 
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the list of teams entered the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the list of prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// We have a list of "on team vs another" (like round 1, round 2 and etc.) that represents one round.
        /// This particular property represents the list of list of rounds of the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
