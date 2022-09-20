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
    public partial class MainMenu : Form
    {
        public MainMenu(String userNameInput)
        {
            InitializeComponent();
            label1.Text= userNameInput;

        }
        private void mainMenuLabel_Click(object sender, EventArgs e)
        {

        }

        private void payBalanceOption_Click(object sender, EventArgs e)
        {
            PayBalance payBalance = new PayBalance(label1.Text);
            this.Hide();
            payBalance.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ItemListButton_Click(object sender, EventArgs e)
        {
            ProductList form3 = new ProductList(label1.Text);
            this.Hide();
            form3.ShowDialog();
        }

        private void puchaseButton_Click(object sender, EventArgs e)
        {
            MakePurchase form4 = new MakePurchase(label1.Text);
            this.Hide();
            form4.ShowDialog();
        }

        private void viewPastPurchases_Click(object sender, EventArgs e)
        {
            ViewPurchases viewPurchases = new ViewPurchases(label1.Text);
            this.Hide();
            viewPurchases.ShowDialog();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            PayBalance paybalance = new PayBalance(label1.Text);
            this.Hide();
            paybalance.ShowDialog();
        }
    }
}
