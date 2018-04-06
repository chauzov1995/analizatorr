using SQLiteApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App12
{
	public partial class App : Application
	{
        public const string DATABASE_NAME = "AR.db";
        public static FriendRepository database;
       
        public App ()
		{
			InitializeComponent();

			MainPage = new App12.MasterDetailPage1();
		}

        public static FriendRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new FriendRepository(DATABASE_NAME);
                }
                return database;
            }
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
