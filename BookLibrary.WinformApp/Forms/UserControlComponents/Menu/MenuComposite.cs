using WinformApp.Forms.UserControlComponents;
using WinformApp.Forms.UserControlComponents.UserControlFactory;

namespace WinformApp.Forms
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
            components.Add(this);
        }

        public void Add(MenuComponentBase component, int? position = null)
        {
            if(position is not null)
            {
                components.Insert(position.GetValueOrDefault(), component);
            }
            else
            {
                components.Add(component);
            }
            component.SetParent(this);
        }

        public override void GenerateMenu()
        {
            PanelNavigation.Controls.Clear();
            for(int i =0;i < components.Count();i++)
            {
                MenuComponentBase component = components[i];
                component.Button.Location = new Point(0, i * 38);
                PanelNavigation.Controls.Add(component.Button);
            }
        }

        public void ResetActive(MenuComponentBase activated)
        {
            foreach(MenuComponentBase component in components)
            {
                if(component != activated)
                {
                    component.SetActivate(false);
                }
            }
        }
    }
}
