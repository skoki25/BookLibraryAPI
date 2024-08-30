using LibraryWindowsApp.Forms.UserControlComponents.UserControlFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.Forms.UserControlComponents
{
    public class MenuItem : MenuComponentBase
    {
        public MenuItem(string name, EnumControl enumControl, ComponentContext context)
        {
            Name = name;
            PanelContent = context.ContentPanel;
            ViewModel = context.ViewModel;
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
