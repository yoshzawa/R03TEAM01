﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TEAM01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            page.Top tabbedPage = new page.Top();
            MainPage = tabbedPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
