﻿using ControlzEx.Theming;
using Core.Interfaces;
using Core.Services;
using Prism.Ioc;
using Prism.Modularity;
using Shell.DataAccess;
using Shell.ViewModels;
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

            containerRegistry.RegisterDialog<AboutDialog, AboutDialogViewModel>();

            containerRegistry.RegisterForNavigation<MakrosDb>("MakrosDb");
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Set the application theme to Dark.Green
            //ThemeManager.Current.ChangeTheme(this, "Dark.Green");
        }
    }
}
