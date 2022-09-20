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
    public partial class PurchaseByDate : Form
    {
        public PurchaseByDate(String userNameInput)
        {
            InitializeComponent();
            label1.Text = userNameInput;
        }

        private void ButtonForDateRange_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            DataClasses1DataContext data = new DataClasses1DataContext();

            var person = data.PERSONs.Where(p => p.USERNAME.Equals(label1.Text)).Select(p => p.PERSON_ID).First();
            var personPurchases = data.ORDERs.Where(p => p.PERSON_ID.Equals(person)).Where(p => p.DATE > start && p.DATE < end);
            foreach (var purchase in personPurchases)
            {
                Console.WriteLine($"{purchase.ORDER_ID},{purchase.TOTAL},{purchase.DATE}");
            }
            Console.ReadKey();
            data.Dispose();
            
        }

        
    }
}
