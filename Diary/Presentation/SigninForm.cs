using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diary.DataAccess;

namespace Diary.Presentation
{
    public partial class SigninForm : Form
    {
        EventWorks ew;
        public SigninForm()
        {
            InitializeComponent();
        }

        private void SigninForm_Load(object sender, EventArgs e)
        {

        }

        private void SigninForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            if (Name.Text == "" || Passbox.Text == "" || Conbox.Text == "")
            {
                MessageBox.Show("Error!! Please fill all data");

            }
            else if (Passbox.Text != Conbox.Text)
            {
                MessageBox.Show("Error!! Password does not match");
            }
            else
            {
                ew = new EventWorks();
                int result = ew.Adduser(Name.Text, Passbox.Text);
                if (result == 1)
                {


                    MessageBox.Show("User Added!! Try login with your username and passward ");

                    LoginForm log = new LoginForm();
                    log.ShowDialog();
                    this.Hide();





                }
                else
                {

                    MessageBox.Show("Error!! Invalid user name and password");
                }

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
