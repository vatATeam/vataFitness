using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vataFitness.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vataFitness.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExcercisesPage : ContentPage
	{
	    private ExcercisesViewModel _viewModel;

	    public ExcercisesPage ()
		{
			InitializeComponent ();
            BindingContext = _viewModel = new ExcercisesViewModel();
        }

	    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        
	    }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel.Items.Count == 0)
                _viewModel.LoadItemsCommand.Execute(null);
        }
    }

}
