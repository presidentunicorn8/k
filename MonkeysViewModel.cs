using KpopComebacks.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpopComebacks.Services; 

namespace KpopComebacks.ViewModel
{
    public partial class MonkeysViewModel : BaseViewModel
    {
        WebScraper webScraper; 
        public ObservableCollection<Monkey> Monkeys { get; } = new();
        public Command GetMonkeysCommand { get; }
        public MonkeysViewModel(WebScraper webScraper)
        {
            GetMonkeysCommand = new Command(async () => await GetMonkeysAsync());
            this.webScraper = webScraper; 
        }

        async Task GetMonkeysAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;

                var monkeyList = webScraper.GetItems();

                if (Monkeys.Count != 0)
                    Monkeys.Clear();

                foreach (var monkey in monkeyList)
                    Monkeys.Add(monkey);

            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
