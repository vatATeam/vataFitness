using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using vataFitness.Helpers;
using vataFitness.Models;
using vataFitness.Services;
using vataFitness.Views;
using Xamarin.Forms;

namespace vataFitness.ViewModels
{
    class ExcercisesViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Exercise> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        /// <summary>
        /// Get the azure service instance
        /// </summary>
        public IDataStore<Exercise> DataStore => DependencyService.Get<IDataStore<Exercise>>();
        public ExcercisesViewModel()
        {
            Title = "Browse";
            Items = new ObservableRangeCollection<Exercise>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Exercise>(this, "AddItem", async (obj, item) =>
            {
                var _item = item;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = new ObservableCollection<Exercise>(new []{new Exercise("Бёрпи") { Description = "Тут написано как его делать"}, new Exercise("Отжимание") {Description = "Тут написано как делать оотжимания" },  });//await DataStore.GetItemsAsync(true);
                Items.ReplaceRange(items);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessagingCenter.Send(new MessagingCenterAlert
                {
                    Title = "Error",
                    Message = "Unable to load items.",
                    Cancel = "OK"
                }, "message");
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
