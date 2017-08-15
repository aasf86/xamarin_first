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
	public partial class Usuarios : ContentPage
	{
		public Usuarios ()
		{
			InitializeComponent();

            this.BindingContext = new ViewModels.UserVM();
		}
	}
}