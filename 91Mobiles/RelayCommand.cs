﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _91Mobiles
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action cmd;

        public RelayCommand(Action cmd)
        {
            this.cmd = cmd;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            cmd?.Invoke();
        }
    }
}
