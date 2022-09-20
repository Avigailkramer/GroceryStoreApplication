using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject
{
    public partial class PurchaseByPrice : Form
    {
        public PurchaseByPrice(String userNameInput)
        {
            InitializeComponent();
            label1.Text = userNameInput;
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu form2 = new MainMenu(label1.Text);
            this.Hide();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            

            decimal start = Convert.ToDecimal(StartPriceInput.Text);
            decimal end = Convert.ToDecimal(EndPriceInput.Text);
            var person = data.PERSONs.Where(p => p.USERNAME.Equals(label1.Text)).Select(p => p.PERSON_ID).First();
            int per = Convert.ToInt32(person);
            var personPurchases = data.ORDERs.Where(p => p.PERSON_ID.Equals(per)).Where(p => p.TOTAL > start && p.TOTAL < end).ToList();
            foreach (var purchase in personPurchases)
            {
                Console.WriteLine($"{purchase.ORDER_ID},{purchase.TOTAL},{purchase.DATE}");
            }
            

        }
    }
}
