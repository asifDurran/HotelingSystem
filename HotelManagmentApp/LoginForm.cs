using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelManagmentApp
{
    public partial class LoginForm : Form
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconnection);

            DataTable table = new DataTable();

            try
            {
                string sql = "SELECT * FROM users WHERE username='"+textUsername.Text+"'AND password='"+textPassword.Text+"'";

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();

                adapter.Fill(table);

                if (table.Rows.Count >= 1)
                {
                    Main_Form mform = new Main_Form();
                    this.Hide();
                    mform.Show();
                    ClearAllData();
                }
                else
                {
                    if (textUsername.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Username to Login","Username empty",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textPassword.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Password to Login", "Password empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("This Username or Password doesn't exist","Username or Password doesn't match", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearAllData()
        {
            textUsername.Text = "";
            textPassword.Text = "";
        }

      
    }
}
