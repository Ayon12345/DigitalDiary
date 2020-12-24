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
    public partial class EventHomeForm : Form
    {
        int id;
        EventWorks even;
        Events ev;
        string create;
        public EventHomeForm(int uid)
        {
            even = new EventWorks();
            id = uid;

            InitializeComponent();
            load();
        }

            void load()
            {
                AlldataGridView1.DataSource = even.GetAllEvent(id);
            }

        
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            int eventid = Int32.Parse(textBox1.Text);
            even = new EventWorks();
            ev = new Events();
            ev = even.Getthatevent(eventid);
            Enamebox.Text = ev.Name;
            Eeventdatebox.Value = DateTime.Parse(ev.Eventdate);
            Edescriptionbox.Text = ev.Description;
        
            Emportancebox.Text = ev.Importance;
            create = ev.Createdate;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           // OpenFileDialog fd = new OpenFileDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            even = new EventWorks();


            int result = even.UpdateEvent(Enamebox.Text, create, Emodifydatebox.Value.Date.ToString(), Eeventdatebox.Value.Date.ToString(),  Edescriptionbox.Text, id, Emportancebox.Text, Int32.Parse(textBox1.Text));
            if (result == 1)
            {


                MessageBox.Show("Event Updated");
                load();


            }
            else
            {

                MessageBox.Show("Error!!Try Again!!!");
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            even = new EventWorks();
            int result = even.AddEvent(Namebox.Text, Createdate.Value.Date.ToString(), Eventdate.Value.Date.ToString(), Descriptionbox.Text, id, Importancebox.Text);
            if (result == 1)
            {


                MessageBox.Show("Event Added");
                load();



            }
            else
            {

                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            even = new EventWorks();


            int result = even.DeleteEvent(Convert.ToInt32(Eventidbox.Text));
            if (result == 1)
            {

                MessageBox.Show("Event Deleted");
                load();

            }
            else
            {

                MessageBox.Show("Error");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
    