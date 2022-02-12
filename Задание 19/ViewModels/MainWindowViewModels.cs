using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Задание_19.Models;

namespace Задание_19.ViewModels
{
    class MainWindowViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       
        void OnPropertyChanged([CallerMemberName]string PropertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }

        private double lenght;
        public double Lenght
        {
            get => lenght;
            set
            {
                lenght = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute (object p)
        {
            Lenght = Calc.Add(Radius);
        }
        //private bool CanAddCommandExecuted(object p)
        //{
        //    if (Radius != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public MainWindowViewModels()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute/*, CanAddCommandExecuted*/);
        }
    }
}
