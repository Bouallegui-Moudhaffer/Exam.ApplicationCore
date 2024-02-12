using Exam.Desktop.Commands;
using Exam.Desktop.Views;
using Record_Book_MVVM.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;

namespace Exam.Desktop.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }


        public ICommand ShowWindowCommand { get; set; }



        public MainViewModel()
        {
            Users = UserManager.GetUsers();

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);

        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUser addUserWin = new AddUser();
            addUserWin.Owner = mainWindow;
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();


        }
    }
}
