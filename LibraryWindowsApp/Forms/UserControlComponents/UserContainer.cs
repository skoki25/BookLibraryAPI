using LibraryWindowsApp.Forms.UserControlComponents.UserControlFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.Forms.UserControlComponents
{
    public class UserContainer : ComponentAbstract
    {
        public UserContainer(string name, MainViewModel viewModel, EnumControl enumControl, Panel panelContent)
        {
            Name = name;
            PanelContent = panelContent;
            ViewModel = viewModel;
            EnumControl = enumControl;
            Button = CreateButton(Name);
        }

        public override void GenerateMenu()
        {
            if (Parent != null)
            {
                Parent.GenerateMenu();
            }
        }
    }
}
