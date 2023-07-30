
namespace SubwayPOS
{
    partial class UserRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistration));
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbl_psword = new System.Windows.Forms.Label();
            this.lbl_userId = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegister.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegister.Location = new System.Drawing.Point(320, 345);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(192, 68);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbl_psword
            // 
            this.lbl_psword.AutoSize = true;
            this.lbl_psword.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_psword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_psword.Location = new System.Drawing.Point(147, 159);
            this.lbl_psword.Name = "lbl_psword";
            this.lbl_psword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_psword.Size = new System.Drawing.Size(169, 44);
            this.lbl_psword.TabIndex = 4;
            this.lbl_psword.Text = "Password:";
            // 
            // lbl_userId
            // 
            this.lbl_userId.AutoSize = true;
            this.lbl_userId.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_userId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_userId.Location = new System.Drawing.Point(183, 66);
            this.lbl_userId.Name = "lbl_userId";
            this.lbl_userId.Size = new System.Drawing.Size(133, 44);
            this.lbl_userId.TabIndex = 5;
            this.lbl_userId.Text = "User Id:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(375, 153);
            this.txt_password.MaxLength = 10;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(280, 51);
            this.txt_password.TabIndex = 7;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_userId
            // 
            this.txt_userId.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_userId.Location = new System.Drawing.Point(375, 60);
            this.txt_userId.MaxLength = 10;
            this.txt_userId.Name = "txt_userId";
            this.txt_userId.Size = new System.Drawing.Size(280, 51);
            this.txt_userId.TabIndex = 6;
            this.txt_userId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(147, 248);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFullName.Location = new System.Drawing.Point(375, 242);
            this.txtFullName.MaxLength = 10;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(280, 51);
            this.txtFullName.TabIndex = 10;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(37, 9);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(0, 25);
            this.txtUserName.TabIndex = 11;
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbl_psword);
            this.Controls.Add(this.lbl_userId);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserRegistration";
            this.Text = "UserRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbl_psword;
        private System.Windows.Forms.Label lbl_userId;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label txtUserName;
    }
}