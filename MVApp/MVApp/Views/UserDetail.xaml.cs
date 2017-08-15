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
	public partial class UserDetail : ContentPage
	{
		public UserDetail(Model.User user)
		{
			InitializeComponent();
            lblId.Text = user.Id.ToString();
            lblName.Text = user.Name;
		}
	}
}