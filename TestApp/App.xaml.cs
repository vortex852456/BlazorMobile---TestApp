using BlazorMobile.Common;
using BlazorMobile.Components;
using TestApp.Helpers;
using BlazorMobile.Services;

namespace TestApp
{
	public partial class App : BlazorApplication
    {
        public App()
        {
            InitializeComponent();

            ServiceRegistrationHelper.RegisterServices();

            WebApplicationFactory.SetHttpPort(8888);

            MainPage = new MainPage();
        }
    }
}
