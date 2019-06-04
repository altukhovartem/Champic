﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnections Connection { get; private set; }



        public static void InitializeConnections(DatabaseType db)
        {
            if(db == DatabaseType.Sql)
            {
                // TODO - Set up SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else if(db == DatabaseType.TextFile)
            {
                // TODO - create the text connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
