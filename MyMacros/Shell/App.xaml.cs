﻿using ControlzEx.Theming;
using Core.Interfaces;
using Prism.Ioc;
using Prism.Modularity;
using Shell.DataAccess;
using Shell.Services;
using Shell.Views;
using System.Threading;
using System.Windows;

namespace Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            var lang = Shell.Properties.Settings.Default.AppLanguage;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // register in MainWindow with region
            containerRegistry.RegisterSingleton<ISettings, MainSettings>();
            containerRegistry.RegisterSingleton<IGlobalSettingService, GlobalSettingService>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Set the application theme to Dark.Green
            //ThemeManager.Current.ChangeTheme(this, "Dark.Green");
        }
    }
}
