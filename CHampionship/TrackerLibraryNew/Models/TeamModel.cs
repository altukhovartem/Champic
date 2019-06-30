using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {

        public int Id { get; set; }
        /// <summary>
        /// Represents the name of the team
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Represents the list of people in the particular team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        
    }
}
