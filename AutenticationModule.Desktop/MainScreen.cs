using AutenticationModule.Classes;
using System;
using System.Windows.Forms;

namespace AutenticationModule.Desktop
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            if (user.Login.Equals("") || user.Password.Equals(" "))
            {
                MessageBox.Show("Login and password required");
            }
            else if (user.Login.Equals("senai") && user.Password.Equals("123"))
            {
                RegisterScreen registerScreen = new RegisterScreen();
                registerScreen.Show();
            }
            else
            {
                MessageBox.Show("Invalid login or password");
            }
        }
    }
}
