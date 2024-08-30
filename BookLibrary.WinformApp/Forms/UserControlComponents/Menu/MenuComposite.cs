using LibraryWindowsApp.Forms.UserControlComponents;
using LibraryWindowsApp.Forms.UserControlComponents.UserControlFactory;

namespace LibraryWindowsApp.Forms
{
    public class MenuComposite: MenuComponentBase
    {
        private List<MenuComponentBase> components = new List<MenuComponentBase>();
        public Panel PanelNavigation { get; set; }
        public MenuComponentBase parent { get; set; }

        public MenuComposite(string name, EnumControl enumControl, ComponentContext context)
        {
            Name = name;
            ViewModel = context.ViewModel;
            EnumControl = enumControl;
            PanelContent = context.ContentPanel;
            PanelNavigation = context.NavigationPanel;
            Button = CreateButton(Name);
        }

        public void Add(MenuComponentBase component)
        {
            component.SetParent(this);
            components.Add(component);
        }

        public override void GenerateMenu()
        {
            PanelNavigation.Controls.Clear();
            for(int i =0;i < components.Count();i++)
            {
                MenuComponentBase component = components[i];
                component.Button.Location = new Point(0, i * 34);
                PanelNavigation.Controls.Add(component.Button);
            }
        }
    }
}
