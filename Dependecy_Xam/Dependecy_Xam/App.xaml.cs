using Dependecy_Xam.ViewModels;
using Dependecy_Xam.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dependecy_Xam
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(Config.Navegation);
            containerRegistry.RegisterForNavigation<DevicePage, DeviceViewModel>(Config.Orientation);
            containerRegistry.RegisterForNavigation<MyEntryPage, MyEntryViewModel>(Config.Entry);
            containerRegistry.RegisterForNavigation<VisualElevationPage>(Config.Elevation);
            containerRegistry.RegisterForNavigation<CursorColorPage>(Config.Color);
        }
    }
}
