using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnections
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
