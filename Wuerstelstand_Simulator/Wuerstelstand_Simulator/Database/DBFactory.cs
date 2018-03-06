using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Wuerstelstand_Simulator.Database
{
    static class DBFactory
    {
        public static void CreateSeasons(Seasons season)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var conn = new SQLiteAsyncConnection(System.IO.Path.Combine(folder, "Wurst.db"));
            SQLiteCommand insertSQL = new SQLiteCommand();
        }
    }
}
