using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;

namespace Playfair_cipher
{
    public class UserList : List<User>
    {

        public bool SingIn(string login, string password)
        {

            if (this.Any(u => u.Login == login))
                return false;

            Add(new User(login, password));
            return true;
        }

        public bool LogIn(string login, string password)
        {
            var user = this.FirstOrDefault(u => u.Login == login);
            if (user == null) return false;
            if (user.Password != password) return false;
            return true;
        }
    }

    public class User
    {
        string _login;
        string _password;

        public string Login { get { return _login; } }
        public string Password { get { return _password; } }

        public User(string Login, string Password)
        {
            _login = Login;
            _password = Password;
        }
    }
}
