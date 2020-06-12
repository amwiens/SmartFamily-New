using Prism.DryIoc;
using Prism.Ioc;

using SmartFamily.Views;

namespace SmartFamily
{
    public partial class App
    {
        public App() { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}