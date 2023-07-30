using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubwayPOS
{
    public partial class CashReturn : Form
    {
        public string userName;

        public CashReturn(string uName, string cash)
        {
            InitializeComponent();
            userName = uName;
            txtCash.Text = cash;
            txtUserName.Text = uName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PunchingScreenMain punchScreenMain = new PunchingScreenMain(userName);
            punchScreenMain.Show();
            Hide();
        }
    }
}
