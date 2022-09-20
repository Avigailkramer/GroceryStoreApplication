namespace SemesterProject
{
    partial class PayBalance
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
            this.payBalanceLbl = new System.Windows.Forms.Label();
            this.HowMuchPaylbl = new System.Windows.Forms.Label();
            this.AmountToPayInput = new System.Windows.Forms.TextBox();
            this.PayBalanceButton = new System.Windows.Forms.Button();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // payBalanceLbl
            // 
            this.payBalanceLbl.AutoSize = true;
            this.payBalanceLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBalanceLbl.Location = new System.Drawing.Point(236, 73);
            this.payBalanceLbl.Name = "payBalanceLbl";
            this.payBalanceLbl.Size = new System.Drawing.Size(105, 22);
            this.payBalanceLbl.TabIndex = 0;
            this.payBalanceLbl.Text = "Pay Balance";
            // 
            // HowMuchPaylbl
            // 
            this.HowMuchPaylbl.AutoSize = true;
            this.HowMuchPaylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowMuchPaylbl.Location = new System.Drawing.Point(84, 137);
            this.HowMuchPaylbl.Name = "HowMuchPaylbl";
            this.HowMuchPaylbl.Size = new System.Drawing.Size(203, 16);
            this.HowMuchPaylbl.TabIndex = 1;
            this.HowMuchPaylbl.Text = "How much would you like to pay?";
            // 
            // AmountToPayInput
            // 
            this.AmountToPayInput.Location = new System.Drawing.Point(323, 136);
            this.AmountToPayInput.Name = "AmountToPayInput";
            this.AmountToPayInput.Size = new System.Drawing.Size(100, 20);
            this.AmountToPayInput.TabIndex = 2;
            this.AmountToPayInput.Text = "0";
            
            // 
            // PayBalanceButton
            // 
            this.PayBalanceButton.Location = new System.Drawing.Point(249, 199);
            this.PayBalanceButton.Name = "PayBalanceButton";
            this.PayBalanceButton.Size = new System.Drawing.Size(75, 23);
            this.PayBalanceButton.TabIndex = 3;
            this.PayBalanceButton.Text = "Pay Balance";
            this.PayBalanceButton.UseVisualStyleBackColor = true;
            this.PayBalanceButton.Click += new System.EventHandler(this.PayBalanceButton_Click);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.Location = new System.Drawing.Point(407, 282);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(114, 23);
            this.BackToMainMenuButton.TabIndex = 4;
            this.BackToMainMenuButton.Text = "Back to Main Menu";
            this.BackToMainMenuButton.UseVisualStyleBackColor = true;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // PayBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.PayBalanceButton);
            this.Controls.Add(this.AmountToPayInput);
            this.Controls.Add(this.HowMuchPaylbl);
            this.Controls.Add(this.payBalanceLbl);
            this.Name = "PayBalance";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label payBalanceLbl;
        private System.Windows.Forms.Label HowMuchPaylbl;
        private System.Windows.Forms.TextBox AmountToPayInput;
        private System.Windows.Forms.Button PayBalanceButton;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.Label label1;
    }
}