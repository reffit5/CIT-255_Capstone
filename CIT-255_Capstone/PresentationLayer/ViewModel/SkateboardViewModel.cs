using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIT_255_Capstone.BusinessLayer;
using CIT_255_Capstone.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace CIT_255_Capstone.PresentationLayer.ViewModel
{
    public class SkateboardViewModel : ObservableObject
    {
        #region COMMANDS


        #endregion

        #region ENUMS

        #endregion

        #region FIELDS

        private ObservableCollection<Skateboard> _skateboard;
        private Skateboard _selectedSkateboard;
        private SkateboardBusiness _sbBusiness;


        #endregion

        #region PROPERTIES

        public ObservableCollection<Skateboard> Skateboard
        {
            get { return _skateboard; }
            set { _skateboard = value; }
        }

        public Skateboard SelectedSkateboard
        {
            get { return _selectedSkateboard; }
            set {
                if (_selectedSkateboard == value)
                {
                    return;
                }
                _selectedSkateboard = value;
                OnPropertyChanged("SelectedCaracter");
            }
        }

        #endregion

        #region CONSTRUCTORS
        public SkateboardViewModel(SkateboardBusiness sbBusiness)
        {
            _sbBusiness = sbBusiness;
           // _skateboard = new ObservableCollection<Skateboard>(sbBusiness.AllSkateboards());


            #endregion

            #region METHODS

             //void OnDeleteSkateboard()
           // {
           //     MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show($"Are you sure you want to delete {_selectedSkateboard.CompanyName}", "from favorites", System.Windows.MessageBoxButton.OKCancel);

           //     if (messageBoxResult == MessageBoxResult.OK)
           //     {
           //         _skateboard.Remove(_selectedSkateboard);
          //      }
         //   }

         //   void OnSortListByRating()
        //    {
        //        _skateboard = new ObservableCollection<Skateboard>(_skateboard.OrderBy(c => c.Rating));
        //    }

            #endregion

            #region Events

            #endregion
        }
    } }


