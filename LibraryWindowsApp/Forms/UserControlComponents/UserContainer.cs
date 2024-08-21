using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.Forms.UserControlComponents
{
    public class UserContainer : ComponentAbstract
    {
        public UserContainer(string name, UserControl userControl, Panel panelContent)
        {
            Name = name;
            UserControl = userControl;
            PanelContent = panelContent;
            Button = CreateButton(Name);
        }

        public override void AddParent(ComponentAbstract parent)
        {
            Parent = parent;
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
