using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Users : ContentPage
	{
		public Users()
		{
			InitializeComponent();

            this.BindingContext = new ViewModels.UserVM();

            ListUsers.ItemTapped += async (sender, e) => 
            {
                var itemUser = e.Item as Model.User;
                await App.Current.MainPage.Navigation.PushAsync(new Views.UserDetail(itemUser));
            };
		}
    }
}