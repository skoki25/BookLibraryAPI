using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.Installation
{
    public static class UserControlExtension
    {
        public static void FillDock(this UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
        }
    }
}
