using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diary.Logic;
using Diary.DataAccess;

namespace Diary.Presentation
{
    public partial class LoginForm : Form
    {
        User user;
        int id;
        EventWorks ev;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            SigninForm signin = new SigninForm();
            signin.ShowDialog();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            user = new User();
            string username = userbox.Text;
            string pass = passbox.Text;
            ev = new EventWorks();

            user = ev.GetUser(username);
            if (user.Password == pass)
            {

                id = user.Id;
                EventHomeForm home = new EventHomeForm(id);
                home.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("User name or Password is not valid");

            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
