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
    public partial class purchaseByDateDisplay : Form
    {
        public purchaseByDateDisplay(String userNameInput, DateTime start, DateTime end)
        {
            InitializeComponent();
            label1.Text = userNameInput;
            DateTime Start = start;
            DateTime End = end;
            fillTable(Start, End);
        }

        private void fillTable (DateTime start, DateTime end)
        {
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
        
        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu form2 = new MainMenu(label1.Text);
            this.Hide();
            form2.ShowDialog();
        }
    }
}
