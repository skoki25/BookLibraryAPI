using BookLibrary.WinformApp.Forms.UserControlFactory;
using WinformApp;
using WinformApp.Forms.UserControlComponents.UserComponentBuilder;

namespace BookLibrary.WinformApp.Forms.Menu
{
    public abstract class MenuComponentBase
    {
        public string Name { get; set; }
        public MenuComposite Parent { get; set; }
        public Button Button { get; set; }
        public Panel PanelContent { get; set; }
        public MainViewModel ViewModel { get; set; }
        public EnumControl EnumControl { get; set; }
        public bool IsActivated { get; set; }
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
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.Blue;
            button.FlatAppearance.BorderSize = 2;
            button.Click += ButtonClick;
            return button;
        }
        public void SetParent(MenuComposite parent)
        {
            Parent = parent;
        }
        void ButtonClick(object sender, EventArgs e)
        {
            SetActivate(true);
            if (this is MenuItem)
            {
                Parent.ResetActive(this);
            }
            else
            {
                if (this is MenuComposite menu)
                {
                    menu.ResetActive(this);
                }
            }

            PanelContent.Controls.Clear();
            GenerateMenu();
            UserControl userControl = UserControlFactory.CreateUserControl(EnumControl, ViewModel);
            PanelContent.Controls.Add(userControl);

            userControl.Dock = DockStyle.Fill;

        }

        public void SetActivate(bool activate)
        {
            IsActivated = activate;
            UpdateButtonStyle();
        }

        public void UpdateButtonStyle()
        {
            if (IsActivated)
            {
                Button.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                Button.FlatAppearance.BorderColor = Color.White;

            }
        }
    }
}
