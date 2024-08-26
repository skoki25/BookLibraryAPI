using LibraryWindowsApp.Forms.UserControlComponents.UserComponentBuilder;
using LibraryWindowsApp.Forms.UserControlComponents.UserControlFactory;

namespace LibraryWindowsApp.Forms
{
    public abstract class ComponentAbstract
    {
        public string Name { get; set; }
        public ComponentAbstract Parent { get; set; }
        public Button Button { get; set; }
        public Panel PanelContent { get; set; }
        public MainViewModel ViewModel { get; set; }
        public EnumControl EnumControl { get; set; }
        public abstract void GenerateMenu();
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
        public void AddParent(ComponentAbstract parent)
        {
            Parent = parent;
        }
        void ButtonClick(Object sender, EventArgs e)
        {
            PanelContent.Controls.Clear();
            GenerateMenu();
            UserControl userControl = UserControlFactory.CreateUserControl(EnumControl,ViewModel);
            PanelContent.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;

        }
    }
}
