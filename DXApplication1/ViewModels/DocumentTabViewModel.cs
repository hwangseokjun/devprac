using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.ViewModels
{
    public class DocumentTabViewModel : ISupportParameter
    {
        public object Parameter { get => Title; set => Title = value as string; }
        public virtual string Title { get; protected set; }
    }
}
