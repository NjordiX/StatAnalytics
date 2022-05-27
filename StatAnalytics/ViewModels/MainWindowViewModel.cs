using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using StatAnalytics.Infrastructure.Commands;
using StatAnalytics.ViewModels.Base;

namespace StatAnalytics.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        //One more test for Git 

        #region Заголовок окна
        private string _Title = "StatAnalytics";
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Статус программы
        private string _Status = "Ready";
        /// <summary>
        /// Статус программы
        /// </summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion

        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; set; }
        private bool CanCloseApplicationCommandExecute(object obj) => true;
        private void OnCloseApplicationCommandExecuted(object obj)
        {
            Application.Current.Shutdown();
        } 
        #endregion

        #endregion


        public MainWindowViewModel()
        {
            #region Команды
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute); 
            #endregion

        }





    }
}
