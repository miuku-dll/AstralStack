using Kill_yourself_1.Core;
using Kill_yourself_1.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kill_yourself_1.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand SecondaryViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }

        public SecondaryViewModel SecondaryVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }

            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            SecondaryVM = new SecondaryViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            SecondaryViewCommand = new RelayCommand(o =>
            {
                CurrentView = SecondaryVM;
            });

        }
    }
}
