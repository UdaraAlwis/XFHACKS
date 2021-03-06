﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFHacks
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

		    // Initialize Live Reload.
#if DEBUG
		    LiveReload.Init();
#endif

            MainPage = new NavigationPage( new XFHacks.MainPage());
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
