﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnections
    {
        void CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        void UpdateMatchup(MatchupModel model);

        void CompleteTournament(TournamentModel model);
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
		List<TournamentModel> GetTournaments_All();


	}
}
