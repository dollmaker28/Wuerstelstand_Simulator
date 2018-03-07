using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Wuerstelstand_Simulator.Database
{
    public class DBFactory
    {
        // Variable für die Datenbankverbindung
        private SQLiteAsyncConnection database;

        // Methode zur Erstellung der Datenbank und der Entitäten
        public void CreateDB()
        {
            string dbPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            database = new SQLiteAsyncConnection(System.IO.Path.Combine(dbPath, "Sausage.db3"));

            database.CreateTableAsync<StoredItems>();
            database.CreateTableAsync<ItemType>();
            database.CreateTableAsync<ItemSalesQuota>();
            database.CreateTableAsync<Finance>();
            database.CreateTableAsync<Weather>();
            database.CreateTableAsync<Seasons>();
            database.CreateTableAsync<SeasonTempRange>();
        }
    }
}
