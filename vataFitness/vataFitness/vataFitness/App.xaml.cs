using vataFitness.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace vataFitness
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

			SetMainPage();
		}

		public static void SetMainPage()
		{
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                      new NavigationPage(new TrainingsPage())
                    {
                        Title = "Trainings",
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                      new NavigationPage(new ComplexesPage())
                    {
                        Title = "Complexes",
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                      new NavigationPage(new ExcercisesPage())
                    {
                        Title = "Exercises",
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse",
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                    },
                }
            };
        }
	}
}
