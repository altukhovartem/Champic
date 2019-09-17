using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnections
    {
		public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentID = 1;
            if(people.Count > 0)
            {
                currentID = people.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentID;
            people.Add(model);
            people.SaveToPeopleFile();
        }

        // TODO - Wire up the CreatePrize for text files
        public void CreatePrize(PrizeModel model)
        {
            // load the test file and convert the file to List<PrizeModel>            
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            // find max id
            int currentID = 1;
            if(prizes.Count > 0)
            {
                currentID = prizes.OrderByDescending(x => x.id).First().id+1;
            }
            model.id = currentID;
            // add a new record with a new ID (max + 1)
            prizes.Add(model);



            // convert the prizes to a List<strings>
            // save list to the text file
            prizes.SaveToPrizeFile();
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            int currentID = 1;
            if (teams.Count > 0)
            {
                currentID = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentID;
            // add a new record with a new ID (max + 1)
            teams.Add(model);

            // convert the prizes to a List<strings>
            // save list to the text file
            teams.SaveToTeamFile();
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath()
                                                             .LoadFile()
                                                             .ConvertToTournamentModels();
            int currentID = 1;
            if (tournaments.Count > 0)
            {
                currentID = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentID;

			model.SaveRoundsToFile();

            tournaments.Add(model);
            tournaments.SaveToTournamentFile();
            TournamentLogic.UpdateTournamentResults(model);
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public List<TournamentModel> GetTournaments_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
    }
}
