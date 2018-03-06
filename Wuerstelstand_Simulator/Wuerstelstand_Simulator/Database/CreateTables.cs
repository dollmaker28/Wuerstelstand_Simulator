using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wuerstelstand_Simulator.Database
{
    class CreateTables
    {
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        public void CreateDB()
        {
        var conn = new SQLiteAsyncConnection(System.IO.Path.Combine(folder, "Wurst.db"));
            conn.CreateTableAsync<StoredItems>();
            conn.CreateTableAsync<ItemType>();
            conn.CreateTableAsync<ItemSalesQuota>();
            conn.CreateTableAsync<Finance>();
            conn.CreateTableAsync<Weather>();
            conn.CreateTableAsync<Seasons>();
            conn.CreateTableAsync<SeasonTempRange>();
        }
    }
}
