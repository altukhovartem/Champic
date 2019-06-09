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
        private const string PrizesFile = "PrizeModels.csv";


        // TODO - Wire up the CreatePrize for text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // load the test file and convert the file to List<PrizeModel>            
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
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
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }
    }
}
