using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.Forms
{
    public abstract class ComponentAbstract
    {
        public string Name { get; set; }
        public UserControl UserControl { get; set; }
        public ComponentAbstract Parent { get; set; }
        public Button Button { get; set; }
        public Panel PanelContent { get; set; }
        public abstract void GenerateMenu();
        public abstract void AddParent(ComponentAbstract parent);

        public Button CreateButton(string name)
        {
            string nameWithoutSpace = name.Replace(" ", "_");
            Button button = new Button();
            button.Size = new Size(259, 35);
            button.TabIndex = 0;
            button.Text = name;
            button.Name = "bt" + nameWithoutSpace;
            button.UseVisualStyleBackColor = true;
            button.Click += ButtonClick;
            return button;
        }

        void ButtonClick(Object sender, EventArgs e)
        {
            PanelContent.Controls.Clear();
            GenerateMenu();
            PanelContent.Controls.Add(UserControl);
            UserControl.Dock = DockStyle.Fill;

        }
    }
}
