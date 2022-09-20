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
using System.Globalization;



namespace SemesterProject
{
    public partial class MakePurchase : Form
    {
        public MakePurchase(String userNameInput)
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

        private void PurchaseButton_Click_1(object sender, EventArgs e)
        {
            double totalPrice = 0.0;
            DataClasses1DataContext db = new DataClasses1DataContext();
            int value = Convert.ToInt32(AppleInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Apple")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }

            //checking bananas
            value = Convert.ToInt32(BananaInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Banana")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }
            //checking Oranges
            value = Convert.ToInt32(OrangeInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Orange")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }
            //checking Strawberries
            value = Convert.ToInt32(StrawberryInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Strawberry")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }
            //checking BlueBerries
            value = Convert.ToInt32(BlueberryInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Blueberry")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }
            //checking Peach
            value = Convert.ToInt32(PeachInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Peach")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }
            //checking Plum
            value = Convert.ToInt32(PlumInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Plum")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }
            //checking Lemon
            value = Convert.ToInt32(LemonInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Lemon")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }
            //checking Lime
            value = Convert.ToInt32(LimeInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Lime")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }

            //checking Grape
            value = Convert.ToInt32(GrapeInput.Text);
            if (value >= 1)
            {
                decimal? priceForFruit = db.ITEMs.Where(p => p.NAME.Equals("Grapes")).Select(p => p.PRICE).First();
                totalPrice += Convert.ToDouble(priceForFruit) * Convert.ToDouble(value);
            }



            int person = db.PERSONs.Where(p => p.USERNAME.Equals(label1.Text)).Select(p => p.PERSON_ID).First();

            decimal ? userBalance = db.PERSONs.Where(p => p.USERNAME.Equals(label1.Text)).Select(p => p.BALANCE).First();

            //checking is balance is over a certain amount and if yes then they cant make another purchase 
            if (userBalance > 100)
            {
                label2.Text = "Could Not make a purchase, Balance too big";
            }
            else
            {

               int personID = Convert.ToInt32(person);
               decimal total = Convert.ToDecimal(totalPrice);
                DateTime dateTime = DateTime.Now;
                

                ORDER order = new ORDER();
                order.PERSON_ID = personID;
                order.TOTAL = total;
                order.DATE = dateTime;
                
                db.ORDERs.InsertOnSubmit(order);
                db.SubmitChanges();

                decimal decPrice = Convert.ToDecimal(total);

                PERSON pERSON = db.PERSONs.Where(p => p.USERNAME.Equals(label1.Text)).First();
                pERSON.BALANCE += decPrice;

                
                db.SubmitChanges();
            }
            MainMenu form2 = new MainMenu(label1.Text);
            this.Hide();
            form2.ShowDialog();





        }
    }
}
