using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModernDesign.Core
{
    internal class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManger.RequerySuggested += value; }
            remove { CommandManger.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, )
    }
}
