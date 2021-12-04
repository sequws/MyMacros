using Core.Interfaces;
using NLog;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;

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
        private readonly IDialogService _dialogService;

        public MainWindowViewModel(
            IRegionManager regionManager,
            IGlobalSettingService settingService,
            IDialogService dialogService)
        {
            _regionManager = regionManager;
            _settingService = settingService;
            _dialogService = dialogService;

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

        private DelegateCommand _showAboutDialogCommand;
        public DelegateCommand ShowAboutDialogCommand =>
            _showAboutDialogCommand ?? (_showAboutDialogCommand = new DelegateCommand(ExecuteShowAboutCommand));

        void ExecuteShowAboutCommand()
        {
            _dialogService.ShowDialog("AboutDialog", new DialogParameters(), (res) =>
            {

            });
        }
        #endregion
    }
}
