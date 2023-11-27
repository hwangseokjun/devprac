using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXApplication1.Views;

namespace DXApplication1.ViewModels
{
    [POCOViewModel]
    public class ChildViewModel : ViewModelBase
    {
        private static int _count = 0;
        public IMessageBoxService MessageBoxService => GetService<IMessageBoxService>();
        public IDocumentManagerService DocumentManagerService => GetService<IDocumentManagerService>();
        public virtual string Text { get; set; }

        public ChildViewModel()
        {

        }

        public static ChildViewModel Create() => ViewModelSource.Create<ChildViewModel>();

        public void AddDocument()
        {
            IDocument document = DocumentManagerService.FindDocumentById(_count);

            if (document == null)
            {
                document = DocumentManagerService.CreateDocument(nameof(DocumentTab), parameter: $"# {_count}", parentViewModel: this);
                document.Id = _count;
                document.Title = $"# {_count}";
                _count++;
            }

            document.Show();
        }

        public void ShowMessage() 
        {
            MessageBoxService.ShowMessage("Text");
        }
    }
}
