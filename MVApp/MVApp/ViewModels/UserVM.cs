using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using System.Linq;

namespace MVApp.ViewModels
{
    public class UserVM
    {
        public ICommand CarregarCommand { get; set; }

        public ObservableCollection<Model.User> Users { get; set; }

        public UserVM()
        {
            Users = new ObservableCollection<Model.User>();


            CarregarCommand = new Xamarin.Forms.Command(() => 
            {
                Users.Add(new Model.User
                {
                    Id=Users.Count(),
                    Name=$"Anderson {Users.Count()} - {Guid.NewGuid().ToString().Replace("-","")}"
                });

                Users.Add(new Model.User
                {
                    Id = Users.Count(),
                    Name = $"Edneia {Users.Count()} - {Guid.NewGuid().ToString().Replace("-","")}"
                });
            });
        }
    }
}
