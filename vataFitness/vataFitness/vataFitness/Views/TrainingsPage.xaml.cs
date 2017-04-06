using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vataFitness.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrainingsPage : ContentPage
	{
		public TrainingsPage ()
		{
		    Label header = new Label() {Text = "vataFitness"};
            Content = header;
			InitializeComponent ();
		}
	}
}
