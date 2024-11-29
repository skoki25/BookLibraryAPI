using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformApp;

namespace BookLibrary.WinformApp.Forms.Context
{
    public class ComponentContext
    {
        public MainViewModel ViewModel { get; set; }
        public Panel ContentPanel { get; set; }
        public Panel NavigationPanel { get; set; }

        public ComponentContext(MainViewModel viewModel, Panel contentPanel, Panel navigationPanel)
        {
            ViewModel = viewModel;
            ContentPanel = contentPanel;
            NavigationPanel = navigationPanel;
        }
    }
}
