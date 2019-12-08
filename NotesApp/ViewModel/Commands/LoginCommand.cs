using NotesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NotesApp.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {
        public LoginVM VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public LoginCommand(LoginVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            var user = parameter as User;

            //if (user == null)
            //    return false;
            //if (string.IsNullOrEmpty(user.Username))
            //    return false;
            //if (string.IsNullOrEmpty(user.Password))
            //    return false;
            return true;
        }

        public void Execute(object parameter)
        {
            VM.Login();
        }
    }
}
