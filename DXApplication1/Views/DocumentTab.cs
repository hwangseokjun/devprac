using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DXApplication1.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Views
{
    public partial class DocumentTab : DevExpress.XtraEditors.XtraUserControl
    {
        private MVVMContext _mvvmContext = new MVVMContext();

        public DocumentTab()
        {
            InitializeComponent();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            if (_mvvmContext.IsDesignMode) 
            {
                return;
            }

            _mvvmContext.ContainerControl = this;
            _mvvmContext.ViewModelType = typeof(DocumentTabViewModel);

            var fluent = _mvvmContext.OfType<DocumentTabViewModel>();
            fluent.SetBinding(labelControl1, x => x.Text, x => x.Title);
        }
    }
}
