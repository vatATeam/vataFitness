using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace vataFitness.ViewModels
{
	public class AboutViewModel : BaseViewModel
	{
	    
	    public string AboutPageText { get; set; }

	    public AboutViewModel()
		{
			Title = "About";
		    AppTitle = "vataFitness";
		    AboutPageText = "This app is written by vataTeam";
			OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/vatATeam/vataFitness")));
		}

		/// <summary>
		/// Command to open browser to xamarin.com
		/// </summary>
		public ICommand OpenWebCommand { get; }
	}
}
