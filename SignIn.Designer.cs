namespace SemesterProject
{
    partial class SignIn
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
            this.UserName = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.passwordTag = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.FarmersMarketText = new System.Windows.Forms.TextBox();
            this.DescriptionTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(156, 152);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(67, 15);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // userNameInput
            // 
            this.userNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInput.Location = new System.Drawing.Point(284, 145);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(141, 21);
            this.userNameInput.TabIndex = 1;
            this.userNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTag
            // 
            this.passwordTag.AutoSize = true;
            this.passwordTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTag.Location = new System.Drawing.Point(161, 215);
            this.passwordTag.Name = "passwordTag";
            this.passwordTag.Size = new System.Drawing.Size(60, 15);
            this.passwordTag.TabIndex = 2;
            this.passwordTag.Text = "password";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(284, 208);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(142, 20);
            this.passwordInput.TabIndex = 3;
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(284, 289);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(132, 36);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Sign up or Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // FarmersMarketText
            // 
            this.FarmersMarketText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FarmersMarketText.Location = new System.Drawing.Point(193, 35);
            this.FarmersMarketText.Name = "FarmersMarketText";
            this.FarmersMarketText.Size = new System.Drawing.Size(266, 26);
            this.FarmersMarketText.TabIndex = 5;
            this.FarmersMarketText.Text = "Welcome to the Farmers Market";
            // 
            // DescriptionTag
            // 
            this.DescriptionTag.AutoSize = true;
            this.DescriptionTag.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTag.Location = new System.Drawing.Point(175, 82);
            this.DescriptionTag.Name = "DescriptionTag";
            this.DescriptionTag.Size = new System.Drawing.Size(284, 21);
            this.DescriptionTag.TabIndex = 6;
            this.DescriptionTag.Text = "Where you can get freshly picked fruits daily!";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 405);
            this.Controls.Add(this.DescriptionTag);
            this.Controls.Add(this.FarmersMarketText);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordTag);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.UserName);
            this.Name = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Label passwordTag;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox FarmersMarketText;
        private System.Windows.Forms.Label DescriptionTag;
    }
}

