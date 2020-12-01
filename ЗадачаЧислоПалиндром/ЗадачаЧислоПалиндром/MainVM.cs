using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace ЗадачаЧислоПалиндром
{
    public class MainVM : INotifyPropertyChanged
    {
       
        private string var01;
        
        public string Var1
        {
            get { return var01; }
            set
            {
                var01 = value;
                OnPropertyChanged("Var2");
                OnPropertyChanged("Var3");
            }
        }
         
        public string Var2
        {
            get { return MainModel.ReverseStr(Var1); }
        }

        public string Var3
        {
            get { return MainModel.CheckOK(Var1, Var2); }
        }
  
       
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
