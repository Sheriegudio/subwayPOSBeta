using System.Windows.Forms;

namespace SubwayPOS
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_userId = new TextBox();
            txt_password = new TextBox();
            lbl_userId = new Label();
            lbl_psword = new Label();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // txt_userId
            // 
            resources.ApplyResources(txt_userId, "txt_userId");
            txt_userId.Name = "txt_userId";
            // 
            // txt_password
            // 
            resources.ApplyResources(txt_password, "txt_password");
            txt_password.Name = "txt_password";
            // 
            // lbl_userId
            // 
            resources.ApplyResources(lbl_userId, "lbl_userId");
            lbl_userId.Name = "lbl_userId";
            // 
            // lbl_psword
            // 
            resources.ApplyResources(lbl_psword, "lbl_psword");
            lbl_psword.Name = "lbl_psword";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(btn_Login, "btn_Login");
            btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btn_Login.Name = "btn_Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Login);
            Controls.Add(lbl_psword);
            Controls.Add(lbl_userId);
            Controls.Add(txt_password);
            Controls.Add(txt_userId);
            Name = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_userId;
        private TextBox txt_password;
        private Label lbl_userId;
        private Label lbl_psword;
        private Button btn_Login;
    }
}
