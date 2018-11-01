using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Superheroes
{
    public class RelayCommand : ICommand
    {
        //private Action execute;

        public event EventHandler CanExecuteChanged;

        private Informer execute;

        public RelayCommand(Informer inf)   //ctor 
        {
            execute = inf;
        }

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            execute();
        }
    }
}
