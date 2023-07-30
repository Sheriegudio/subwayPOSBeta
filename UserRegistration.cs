using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SubwayPOS
{
    public partial class UserRegistration : Form
    {
       
        public UserRegistration()
        {
            InitializeComponent();
                
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                Model model = new Model();
                int userId;
                userId = int.TryParse(txt_userId.Text, out userId) ? int.Parse(txt_userId.Text) : throw new FormatException("userId");
                int passWord;
                passWord = int.TryParse(txt_password.Text, out passWord) ? int.Parse(txt_password.Text) : throw new FormatException("passWord");

                var userName = txtFullName.Text;

                //QUERY TO AUTHENTICATE USER
                /*                string authenticationQurery = "insert into USERS (USERID,PASSWORD,USERNAME) " +
                                    "VALUES(@ID,@PASSWORD,@USERNAME)";

                                SqlConnection con = new SqlConnection(connectionString);
                                con.Open();

                                SqlCommand cmd = new SqlCommand(authenticationQurery, con);
                                cmd.Parameters.AddWithValue("ID", userId);
                                cmd.Parameters.AddWithValue("PASSWORD", passWord);
                                cmd.Parameters.AddWithValue("USERNAME", userName);*/
                SqlDataReader returnNum = Model.insertUser(userId,passWord,userName);

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                String title = "User Registration";
                /*if (returnNum == 0)
                {
                    MessageBox.Show("Record not Inserted",title, buttons);
                }
                else {
                    MessageBox.Show("Record Successfully Inserted", title, buttons);
                }*/
                //con.Close();

            }
            catch (System.FormatException ex)
            {
                if (ex.Message.Equals("userId"))
                {
                    txt_userId.Text = "";
                    txt_userId.Focus();
                    MessageBox.Show("Please enter valid numeric value for User ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (ex.Message.Equals("passWord"))
                {
                    txt_password.Text = "";
                    txt_userId.Focus();
                    MessageBox.Show("Please enter valid numeric value for Password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
    }
}
