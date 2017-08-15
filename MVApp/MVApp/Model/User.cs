using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVApp.Model
{
    public class User : INotifyPropertyChanged
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id")); } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); } }

        private string _userName;
        public string UserName { get { return _userName; } set { _userName = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserName")); } }

        private string _email;
        public string Email { get { return _email; } set { _email = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email")); } }

        private string _phone;
        public string Phone { get { return _phone; } set { _phone = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Phone")); } }

        private string _webSite;
        public string WebSite { get { return _webSite; } set { _webSite = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WebSite")); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
