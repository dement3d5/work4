using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinSqlite.Models;
using XamarinSqlite.Services;

namespace XamarinSqlite.ViewModels
{
    public class FirstPageViewModel : BaseViewModel
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public string Text { get; set; }

        public CustomCommand Click { get; set; }

        public FirstPageViewModel()
        {
            Items = new List<Item>();
            Items = DBInstance.GetInstance().Item.ToList();
            SignalChanged(nameof(Items));

            Click = new CustomCommand(() =>
            {
                Text = "Нажата";
                SignalChanged(nameof(Text));
            });
        }

        public async void OnAppering()
        {
            await App.Current.MainPage.DisplayAlert("Сообщение", "Сработало", "Понятно");
        }
    }
}
