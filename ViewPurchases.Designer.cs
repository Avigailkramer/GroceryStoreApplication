namespace SemesterProject
{
    partial class ViewPurchases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewPurchaseLbl = new System.Windows.Forms.Label();
            this.AllPurchaseButton = new System.Windows.Forms.Button();
            this.DateRangebutton = new System.Windows.Forms.Button();
            this.priceRangeButton = new System.Windows.Forms.Button();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewPurchaseLbl
            // 
            this.viewPurchaseLbl.AutoSize = true;
            this.viewPurchaseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPurchaseLbl.Location = new System.Drawing.Point(74, 47);
            this.viewPurchaseLbl.Name = "viewPurchaseLbl";
            this.viewPurchaseLbl.Size = new System.Drawing.Size(361, 20);
            this.viewPurchaseLbl.TabIndex = 0;
            this.viewPurchaseLbl.Text = "How Would you like to view your purchases?";
            // 
            // AllPurchaseButton
            // 
            this.AllPurchaseButton.Location = new System.Drawing.Point(200, 85);
            this.AllPurchaseButton.Name = "AllPurchaseButton";
            this.AllPurchaseButton.Size = new System.Drawing.Size(107, 35);
            this.AllPurchaseButton.TabIndex = 1;
            this.AllPurchaseButton.Text = "All Purchases";
            this.AllPurchaseButton.UseVisualStyleBackColor = true;
            this.AllPurchaseButton.Click += new System.EventHandler(this.AllPurchaseButton_Click);
            // 
            // DateRangebutton
            // 
            this.DateRangebutton.Location = new System.Drawing.Point(200, 139);
            this.DateRangebutton.Name = "DateRangebutton";
            this.DateRangebutton.Size = new System.Drawing.Size(107, 40);
            this.DateRangebutton.TabIndex = 2;
            this.DateRangebutton.Text = "Date Range";
            this.DateRangebutton.UseVisualStyleBackColor = true;
            this.DateRangebutton.Click += new System.EventHandler(this.DateRangebutton_Click);
            // 
            // priceRangeButton
            // 
            this.priceRangeButton.Location = new System.Drawing.Point(200, 201);
            this.priceRangeButton.Name = "priceRangeButton";
            this.priceRangeButton.Size = new System.Drawing.Size(107, 38);
            this.priceRangeButton.TabIndex = 3;
            this.priceRangeButton.Text = "Price Range";
            this.priceRangeButton.UseVisualStyleBackColor = true;
            this.priceRangeButton.Click += new System.EventHandler(this.priceRangeButton_Click);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.Location = new System.Drawing.Point(352, 275);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(119, 23);
            this.BackToMainMenuButton.TabIndex = 4;
            this.BackToMainMenuButton.Text = "Back to Main Menu";
            this.BackToMainMenuButton.UseVisualStyleBackColor = true;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // ViewPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.priceRangeButton);
            this.Controls.Add(this.DateRangebutton);
            this.Controls.Add(this.AllPurchaseButton);
            this.Controls.Add(this.viewPurchaseLbl);
            this.Name = "ViewPurchases";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewPurchaseLbl;
        private System.Windows.Forms.Button AllPurchaseButton;
        private System.Windows.Forms.Button DateRangebutton;
        private System.Windows.Forms.Button priceRangeButton;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.Label label1;
    }
}