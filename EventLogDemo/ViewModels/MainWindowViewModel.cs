using EventLogDemo.Infrastructure.Commands;
using EventLogDemo.ViewModels.Base;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EventLogDemo.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            #region Commands
            AddMessageCommand = new RelayCommand(OnAddMessageCommandExecuted, CanAddMessageCommandExecute);
            #endregion

            
        }

        #region Commands

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion

        #region AddMessageCommand
        public ICommand AddMessageCommand { get; }

        private void OnAddMessageCommandExecuted(object p)
        {
            //if (p is null) return;
            //SelectedPageIndex = Convert.ToInt32(p);
            //switch (SelectedPageIndex)
            //{
            //    case 1: SlowOpacity(_Clients); break;
            //    case 2: SlowOpacity(_Welcome1); break;
            //    case 3: SlowOpacity(_Welcome2); break;
            //    case 4: SlowOpacity(_AppSettings); break;
            //    default: SlowOpacity(_Welcome1); break;
            //};
        }

        private bool CanAddMessageCommandExecute(object p) => true;
        #endregion



        #endregion

        #region Window title
        private string _Title = "Демо. Запись событий в EventLog Windows";
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

    

       

    }
}
