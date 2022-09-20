using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SemesterProject
{
    public partial class SignIn : Form
    {

        SqlCommand sqlCommand = new SqlCommand();
        public SignIn()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            var userName = db.PERSONs.Where(p => p.USERNAME.Equals(userNameInput.Text)).Select(p => p.PERSON_ID);
            if(userName.Any())
            {
                MainMenu form2 = new MainMenu(userNameInput.Text);
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                decimal d = 0.00m;
                PERSON person = new PERSON();
                person.USERNAME = userNameInput.Text;
                person.PASSWORD = passwordInput.Text;
                person.BALANCE = d;
                

                db.PERSONs.InsertOnSubmit(person);
                db.SubmitChanges();

                MainMenu form2 = new MainMenu(userNameInput.Text);
                this.Hide();
                form2.ShowDialog();
            }
                

            }
            
        }
    }


