using NUnit.Framework;
using DXApplication1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.ViewModels.Tests
{
    [TestFixture()]
    public class ChildViewModelTests
    {
        [Test()]
        public void ShowMessageTest()
        {
            // Arrange
            var viewModel = ChildViewModel.Create();

            // Act
            viewModel.ShowMessage();

            // Assert
        }
    }
}