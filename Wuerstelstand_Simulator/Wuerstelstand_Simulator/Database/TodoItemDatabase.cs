using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Wuerstelstand_Simulator.Database
{
    public class TodoItemDatabase
    {
        // Variable für die DB-Verbindung
        static TodoItemDatabase database;

        //DB erstellen
        //public static TodoItemDatabase Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new TodoItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
        //        }
        //        return database;
        //    }
        //}

        //Konstruktor
    //    public TodoItemDatabase(string dbPath)
    //    {
    //        database = new SQLiteAsyncConnection(dbPath);
    //        database.CreateTableAsync<TodoItem>().Wait();
    //    }
    }
}
