using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnections> Connections { get; private set; } = new List<IDataConnections>();
        public static void InitializeConnections(bool database, bool textfile)
        {
            if(database == true)
            {
                // TODO - Set up SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if(textfile)
            {
                // TODO - create the text connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
