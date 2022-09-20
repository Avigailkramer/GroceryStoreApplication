namespace SemesterProject
{
    partial class MainMenu
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
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.puchaseButton = new System.Windows.Forms.Button();
            this.PurchaseOption = new System.Windows.Forms.Label();
            this.payBalanceOption = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.pastPurchaseOption = new System.Windows.Forms.Label();
            this.viewPastPurchases = new System.Windows.Forms.Button();
            this.ItemListTag = new System.Windows.Forms.Label();
            this.ItemListButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(261, 49);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(96, 20);
            this.mainMenuLabel.TabIndex = 0;
            this.mainMenuLabel.Text = "Main Menu";
            this.mainMenuLabel.Click += new System.EventHandler(this.mainMenuLabel_Click);
            // 
            // puchaseButton
            // 
            this.puchaseButton.Location = new System.Drawing.Point(350, 143);
            this.puchaseButton.Name = "puchaseButton";
            this.puchaseButton.Size = new System.Drawing.Size(75, 23);
            this.puchaseButton.TabIndex = 1;
            this.puchaseButton.Text = "purchase";
            this.puchaseButton.UseVisualStyleBackColor = true;
            this.puchaseButton.Click += new System.EventHandler(this.puchaseButton_Click);
            // 
            // PurchaseOption
            // 
            this.PurchaseOption.AutoSize = true;
            this.PurchaseOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseOption.Location = new System.Drawing.Point(165, 146);
            this.PurchaseOption.Name = "PurchaseOption";
            this.PurchaseOption.Size = new System.Drawing.Size(103, 15);
            this.PurchaseOption.TabIndex = 2;
            this.PurchaseOption.Text = "Make a Purchase";
            // 
            // payBalanceOption
            // 
            this.payBalanceOption.AutoSize = true;
            this.payBalanceOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBalanceOption.Location = new System.Drawing.Point(165, 188);
            this.payBalanceOption.Name = "payBalanceOption";
            this.payBalanceOption.Size = new System.Drawing.Size(75, 15);
            this.payBalanceOption.TabIndex = 3;
            this.payBalanceOption.Text = "Pay Balance";
            this.payBalanceOption.Click += new System.EventHandler(this.payBalanceOption_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(350, 185);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 4;
            this.payButton.Text = "Balance";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // pastPurchaseOption
            // 
            this.pastPurchaseOption.AutoSize = true;
            this.pastPurchaseOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastPurchaseOption.Location = new System.Drawing.Point(165, 232);
            this.pastPurchaseOption.Name = "pastPurchaseOption";
            this.pastPurchaseOption.Size = new System.Drawing.Size(120, 15);
            this.pastPurchaseOption.TabIndex = 5;
            this.pastPurchaseOption.Text = "View past Purchases";
            // 
            // viewPastPurchases
            // 
            this.viewPastPurchases.Location = new System.Drawing.Point(350, 227);
            this.viewPastPurchases.Name = "viewPastPurchases";
            this.viewPastPurchases.Size = new System.Drawing.Size(75, 23);
            this.viewPastPurchases.TabIndex = 6;
            this.viewPastPurchases.Text = "list";
            this.viewPastPurchases.UseVisualStyleBackColor = true;
            this.viewPastPurchases.Click += new System.EventHandler(this.viewPastPurchases_Click);
            // 
            // ItemListTag
            // 
            this.ItemListTag.AutoSize = true;
            this.ItemListTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListTag.Location = new System.Drawing.Point(165, 107);
            this.ItemListTag.Name = "ItemListTag";
            this.ItemListTag.Size = new System.Drawing.Size(82, 15);
            this.ItemListTag.TabIndex = 7;
            this.ItemListTag.Text = "View Item List";
            // 
            // ItemListButton
            // 
            this.ItemListButton.Location = new System.Drawing.Point(350, 104);
            this.ItemListButton.Name = "ItemListButton";
            this.ItemListButton.Size = new System.Drawing.Size(75, 23);
            this.ItemListButton.TabIndex = 8;
            this.ItemListButton.Text = "Items";
            this.ItemListButton.UseVisualStyleBackColor = true;
            this.ItemListButton.Click += new System.EventHandler(this.ItemListButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemListButton);
            this.Controls.Add(this.ItemListTag);
            this.Controls.Add(this.viewPastPurchases);
            this.Controls.Add(this.pastPurchaseOption);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.payBalanceOption);
            this.Controls.Add(this.PurchaseOption);
            this.Controls.Add(this.puchaseButton);
            this.Controls.Add(this.mainMenuLabel);
            this.Name = "MainMenu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Button puchaseButton;
        private System.Windows.Forms.Label PurchaseOption;
        private System.Windows.Forms.Label payBalanceOption;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label pastPurchaseOption;
        private System.Windows.Forms.Button viewPastPurchases;
        private System.Windows.Forms.Label ItemListTag;
        private System.Windows.Forms.Button ItemListButton;
        private System.Windows.Forms.Label label1;
    }
}