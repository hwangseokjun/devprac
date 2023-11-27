using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DXApplication1.Models;
using DXApplication1.Views;

namespace DXApplication1.ViewModels
{
    [POCOViewModel]
    public class MainViewModel : ViewModelBase
    {
        
        public virtual Employee SelectedEmployee { get; set; }
        public virtual ObservableCollection<Employee> Employees { get; set; }
        

        public MainViewModel()
        {
            Employees = new ObservableCollection<Employee>();

        }
    }
}
