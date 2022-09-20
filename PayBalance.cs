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
    public partial class PayBalance : Form
    {
        public PayBalance(String userNameInput)
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

        private void PayBalanceButton_Click(object sender, EventArgs e)
        {
            decimal value = Convert.ToDecimal(AmountToPayInput.Text);
            DataClasses1DataContext data = new DataClasses1DataContext();
            
            PERSON pERSON = data.PERSONs.Where(p => p.USERNAME.Equals(label1.Text)).First();
            pERSON.BALANCE -= value;
            data.SubmitChanges();

        }

        

        
    }
}
