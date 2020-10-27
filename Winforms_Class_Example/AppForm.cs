using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms_Class_Example.CustomEventArgs;

namespace Winforms_Class_Example
{
    public partial class AppForm : Form
    {
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public delegate Dictionary<string,string> CheckedEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event CheckedEventHandler UserLoginChecked;

        //Organizacion
        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        public AppForm()
        {
            InitializeComponent();
            panels.Add("LoginView", LoginView);
            panels.Add("ProfileView", ProfileView);
            stackPanels.Add(panels["LoginView"]);
            ShowLastPanel();
        }

        private void LoginViewLoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginViewUserInput.Text;
            string pass = LoginViewPasswordInput.Text;
            OnLoginButtonClicked(username, pass);
        }


        //Metodos Internos
        private void OnLoginButtonClicked(string username, string pass)
        {
            if (LoginButtonClicked != null)
            {
                bool result = LoginButtonClicked(
                    this,
                    new LoginEventArgs() {Username=username, Password=pass}
                );

                if (result)
                {
                    LoginViewInvalidPasswordLabel.Hide();
                    OnUserLogin(username);
                    
                }
                else {
                    LoginViewInvalidPasswordLabel.Show();
                }
            }
        }

        private void OnUserLogin(string username)
        {
            if (UserLoginChecked != null)
            {
                Dictionary<string, string> userData = UserLoginChecked(
                    this,
                    new LoginEventArgs() { Username = username }
                );
                SetProfile(userData["name"], userData["age"]);
                LoginViewUserInput.Clear();
                LoginViewPasswordInput.Clear();
                stackPanels.Add(panels["ProfileView"]);
                ShowLastPanel();
            }
        }

        public void SetProfile(string name, string age)
        {
            ProfileViewUserNameInput.Text = name;
            ProfileViewUserAgeInput.Text = age;
        }

        private void ShowLastPanel()
        {
            foreach (Panel panel in panels.Values)
            {
                if (panel != stackPanels.Last())
                {
                    panel.Hide();
                }
                else
                {
                    panel.Show();
                }
            }
        }

        private void ProfileViewLogoutButton_Click(object sender, EventArgs e)
        {
            ProfileViewUserNameInput.ResetText();
            ProfileViewUserAgeInput.ResetText();
            stackPanels.RemoveAt(stackPanels.Count - 1);
            ShowLastPanel();
        }
    }
}
