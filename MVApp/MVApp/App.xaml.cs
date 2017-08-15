using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MVApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();            

            //MainPage = new MVApp.MainPage();
            //MainPage = new MVApp.Views.Users(); //=>Sem navegação
            MainPage = new NavigationPage(new MVApp.Views.Users());//=>Com navegação
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
