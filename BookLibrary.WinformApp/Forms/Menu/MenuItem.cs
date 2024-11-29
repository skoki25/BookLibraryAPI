using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.WinformApp.Forms.Context;
using WinformApp.Forms;

namespace BookLibrary.WinformApp.Forms.Menu
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
