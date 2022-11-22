using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSqlite.ViewModels;

namespace XamarinSqlite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPageView : ContentPage
    {
        public FirstPageView()
        {
            InitializeComponent();
            BindingContext = new FirstPageViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((FirstPageViewModel)BindingContext).OnAppering();
        }
    }
}