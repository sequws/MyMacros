using Core.Interfaces;
using NLog;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Shell.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private string _title = "MyMacros";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IRegionManager _regionManager;
        private readonly IGlobalSettingService _settingService;

        public MainWindowViewModel(
            IRegionManager regionManager,
            IGlobalSettingService settingService)
        {
            _regionManager = regionManager;
            _settingService = settingService;

            NavigateCommand = new DelegateCommand<string>(Navigate);

            var test =_settingService.Get("AppLanguage");

            //logger.Info("MainWindow Start!");
            //_settingService.Update("AppLanguage", "en-EN");
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("ContentRegion", uri);
        }

        #region commands
        public DelegateCommand<string> NavigateCommand { get; set; }

        private DelegateCommand _closeCommand;
        public DelegateCommand CloseCommand =>
            _closeCommand ?? (_closeCommand = new DelegateCommand(ExecuteCloseCommand, CanExecuteCloseCommand));

        void ExecuteCloseCommand()
        {
            App.Current.Shutdown();
        }

        bool CanExecuteCloseCommand()
        {
            return true;
        }
        #endregion
    }
}
