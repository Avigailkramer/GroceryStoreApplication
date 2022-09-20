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
    public partial class ViewAllPurchases : Form
    {
        public ViewAllPurchases(String userNameInput)
        {
            InitializeComponent();
            label1.Text= userNameInput;
            fillTable();
        }

        private void fillTable()
        {

            using (DataClasses1DataContext data = new DataClasses1DataContext())
            {
                var person = data.PERSONs.Where(p => p.USERNAME.Equals(label1.Text)).Select(p => p.PERSON_ID).First();
                int per = Convert.ToInt32(person);
                var personPurchases = data.ORDERs.Where(p => p.PERSON_ID.Equals(per)).Select(p => p);
                foreach (var purchase in personPurchases)
                {
                    Console.WriteLine($"{purchase.ORDER_ID},{purchase.TOTAL},{purchase.DATE}");
                }
            }
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu form2 = new MainMenu(label1.Text);
            this.Hide();
            form2.ShowDialog();
        }
    }
}
