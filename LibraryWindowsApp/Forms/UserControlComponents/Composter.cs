using LibraryWindowsApp.Forms.UserControlComponents.UserControlFactory;

namespace LibraryWindowsApp.Forms
{
    public class Composter: ComponentAbstract
    {
        private List<ComponentAbstract> components = new List<ComponentAbstract>();
        public Panel PanelNavigation { get; set; }
        public ComponentAbstract parent { get; set; }

        public Composter(string name,MainViewModel viewModel, EnumControl enumControl, Panel panelContent,Panel panelNavigation)
        {
            Name = name;
            ViewModel = viewModel;
            EnumControl = enumControl;
            PanelContent = panelContent;
            PanelNavigation = panelNavigation;
            Button = CreateButton(Name);
        }

        public void Add(ComponentAbstract component)
        {
            component.AddParent(this);
            components.Add(component);
        }

        public override void GenerateMenu()
        {
            PanelNavigation.Controls.Clear();
            for(int i =0;i < components.Count();i++)
            {
                ComponentAbstract component = components[i];
                component.Button.Location = new Point(0, i * 34);
                PanelNavigation.Controls.Add(component.Button);
            }
        }
    }
}
