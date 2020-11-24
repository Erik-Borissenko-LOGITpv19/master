using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class masterdetailpage1Master : ContentPage
    {
        public ListView ListView;

        public masterdetailpage1Master()
        {
            InitializeComponent();

            BindingContext = new masterdetailpage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class masterdetailpage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<masterdetailpage1MasterMenuItem> MenuItems { get; set; }

            public masterdetailpage1MasterViewModel()
            {
                MenuItems = new ObservableCollection<masterdetailpage1MasterMenuItem>(new[]
                {
                    new masterdetailpage1MasterMenuItem { Id = 0, Title = "Понедельник" },
                    new masterdetailpage1MasterMenuItem { Id = 1, Title = "Вторник" },
                    new masterdetailpage1MasterMenuItem { Id = 2, Title = "Среда" },
                    new masterdetailpage1MasterMenuItem { Id = 3, Title = "Четверг" },
                    new masterdetailpage1MasterMenuItem { Id = 4, Title = "Пятница" },
                    new masterdetailpage1MasterMenuItem { Id = 4, Title = "Суббота" },
                    new masterdetailpage1MasterMenuItem { Id = 4, Title = "Воскресенье" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}