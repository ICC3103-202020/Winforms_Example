using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms_Class_Example.CustomEventArgs;

namespace Winforms_Class_Example.Controllers
{
    public static class UserController
    {
        static List<User> users = new List<User>();
        static AppForm view;
        

        private static bool OnLoginButtonClicked(object sender, LoginEventArgs e)
        {
            User user = null;
            user = users.Where(
                u => u.Username.Equals(e.Username.ToUpper())
            ).FirstOrDefault();
            if (user is null)
            {
                return false;
            }
            else
            {
                return user.CheckCredentials(e.Username, e.Password);
            }
        }

        private static Dictionary<string,string> OnUserLogin(object sender, LoginEventArgs e)
        {
            User user = null;
            user = users.Where(
               u =>
               u.Username.Equals(e.Username.ToUpper())).FirstOrDefault();
            return new Dictionary<string, string>()
            {
                {"name", user.Name },
                {"age", user.Age.ToString()},
            };
        }


        public static void initialize(Form view)
        {
            UserController.view = view as AppForm;
            UserController.view.LoginButtonClicked += OnLoginButtonClicked;
            UserController.view.UserLoginChecked += OnUserLogin;
            users.Add(new User("cdiazarze", "Carlos Díaz", 28));
            users.Add(new User("ahowardm", "Andres Howard", 63));
            users.Add(new User("jperez", "Juan Perez", 31));
        }
    }
}
