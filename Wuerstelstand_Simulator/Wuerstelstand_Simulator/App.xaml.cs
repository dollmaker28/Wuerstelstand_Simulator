using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Wuerstelstand_Simulator.Database;

using Xamarin.Forms;

namespace Wuerstelstand_Simulator
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new Wuerstelstand_Simulator.MainPage();

            // Instanzieren der UserDatabaseController-Klasse (Tabellen werden im Konstruktor gleich mit erstellt.
            //UserDatabaseController db = new UserDatabaseController();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
