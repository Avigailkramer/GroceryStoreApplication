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
    public partial class ViewPurchases : Form
    {
        public ViewPurchases(String userNameInput)
        {
            InitializeComponent();
            label1.Text = userNameInput;
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu form2 = new MainMenu(label1.Text);
            this.Hide();
            form2.ShowDialog();
        }

        private void DateRangebutton_Click(object sender, EventArgs e)
        {
            PurchaseByDate purchaseByDate = new PurchaseByDate(label1.Text);
            this.Hide();
            purchaseByDate.ShowDialog();
        }

        private void AllPurchaseButton_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext data = new DataClasses1DataContext())
            {
                var per = data.PERSONs.Where(p => p.USERNAME.Equals(label1.Text)).Select(p => p.PERSON_ID).First();
                int person = Convert.ToInt32(per);
                Console.WriteLine(person);
                
                var personPurchases = data.ORDERs.Where(p => p.PERSON_ID.Equals(person)).ToList();
                
                foreach (var purchase in personPurchases)
                {
                    Console.WriteLine($"{purchase.ORDER_ID},{purchase.TOTAL},{purchase.DATE}");
                }
            }
        }

        private void priceRangeButton_Click(object sender, EventArgs e)
        {
            PurchaseByPrice pricepurchase = new PurchaseByPrice(label1.Text);
            this.Hide();
            pricepurchase.ShowDialog();
        }
    }
}
