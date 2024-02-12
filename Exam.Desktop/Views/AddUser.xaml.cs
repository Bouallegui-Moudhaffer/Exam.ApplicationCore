using Exam.Desktop.ViewModel;
using System.Windows;

namespace Exam.Desktop.Views
{
    /// <summary>
    /// Logique d'interaction pour AddUser.xaml
    /// </summary>

    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            this.DataContext = addUserViewModel;

        }
    }
}
