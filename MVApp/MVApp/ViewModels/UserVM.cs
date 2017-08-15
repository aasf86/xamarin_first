using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using System.Linq;
using System.ComponentModel;
using Xamarin.Forms;
using System.Threading;

namespace MVApp.ViewModels
{
    public class UserVM : INotifyPropertyChanged
    {
        public ICommand CarregarCommand { get; set; }

        private ObservableCollection<Model.User> _users;
        public ObservableCollection<Model.User> Users { get { return _users; } set { _users = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Users")); } }

        private bool _running;
        public bool Running { get { return _running; } set { _running = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Running")); } }

        private string _log;
        public string Log { get { return _log; } set { _log = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Log")); } }

        public UserVM()
        {
            Users = new ObservableCollection<Model.User>();

            CarregarCommand = new Xamarin.Forms.Command(async () => 
            {
                Running = true;
                Log = "Rodando...";

                var result = await RemoteApi.Api.GetUsersAsync("");

                Users = new ObservableCollection<Model.User>(result);                

                Running = false;
                Log = "#Concluído#";
                /*
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
                */
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
