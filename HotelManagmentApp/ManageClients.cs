using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentApp
{
    public partial class ManageClients : Form
    {
        public ManageClients()
        {
            InitializeComponent();
            DisplayData();
            buttonEditClient.Enabled = false;
            buttonRemoveClient.Enabled = false;
            
        }

        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        private void buttonResetClient_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }


        private void ClearAllData()
        {
            textClientsId.Text = "";
            textClientsFirstname.Text = "";
            textClientsLastName.Text = "";
            textClientsPhone.Text = "";
            textClientsCountry.Text = "";
        }

        private void buttonInsertClient_Click(object sender, EventArgs e)
        {
            string firstname = textClientsFirstname.Text;
            string lastname = textClientsLastName.Text;
            string phone = textClientsPhone.Text;
            string country = textClientsCountry.Text;

            if(textClientsFirstname.Text.Trim().Equals("") || textClientsLastName.Text.Trim().Equals("") || textClientsPhone.Text.Trim().Equals("") || textClientsCountry.Text.Trim().Equals("") )
            {
                MessageBox.Show("All Fields are required","Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(myconnection);
                try
                {
                    string sql = "INSERT INTO clients(firstname,lastname,phone,country) VALUES(@firstname,@lastname,@phone,@country)";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@firstname",firstname);
                    cmd.Parameters.AddWithValue("@lastname",lastname);
                    cmd.Parameters.AddWithValue("@phone",phone);
                    cmd.Parameters.AddWithValue("@country",country);

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if(rows > 0)
                    {
                        MessageBox.Show("New Client inserted.");
                        ClearAllData();
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Client insertion failed..");
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
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(myconnection);

            DataTable table = new DataTable();
            try
            {
                string sql = "SELECT id AS ClientID, firstname AS FirstName, lastname AS LastName, phone AS PhoneNumber, country AS Country FROM clients";
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);

                dataGridViewClients.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
            }
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            string id = textClientsId.Text;
            string firstname = textClientsFirstname.Text;
            string lastname = textClientsLastName.Text;
            string phone = textClientsPhone.Text;
            string country = textClientsCountry.Text;

            if (textClientsFirstname.Text.Trim().Equals("") || textClientsLastName.Text.Trim().Equals("") || textClientsPhone.Text.Trim().Equals("") || textClientsCountry.Text.Trim().Equals(""))
            {
                MessageBox.Show("All Fields are required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(myconnection);
                try
                {
                    string sql = "UPDATE clients SET firstname=@firstname,lastname=@lastname,phone=@phone,country=@country WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id",id);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@country", country);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Client Data Updated.");
                        DisplayData();
                        ClearAllData();
                        buttonEditClient.Enabled = false;
                        buttonRemoveClient.Enabled = false;
                        buttonInsertClient.Enabled = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("Client Updation failed.");
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
        }

        private void dataGridViewClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            textClientsId.Text = dataGridViewClients.Rows[rowIndex].Cells[0].Value.ToString();
            textClientsFirstname.Text = dataGridViewClients.Rows[rowIndex].Cells[1].Value.ToString();
            textClientsLastName.Text = dataGridViewClients.Rows[rowIndex].Cells[2].Value.ToString();
            textClientsPhone.Text = dataGridViewClients.Rows[rowIndex].Cells[3].Value.ToString();
            textClientsCountry.Text = dataGridViewClients.Rows[rowIndex].Cells[4].Value.ToString();

           buttonInsertClient.Enabled = false;
           buttonEditClient.Enabled = true;
           buttonRemoveClient.Enabled = true;

        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            string deleteID = textClientsId.Text;

            if(deleteID !="")
            {
                SqlConnection con = new SqlConnection(myconnection);

                try
                {
                    string sql = "DELETE FROM clients WHERE id=@deleteID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@deleteID", deleteID);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Client removed.");
                        DisplayData();
                        textClientsId.Text = "";
                        ClearAllData();
                        buttonEditClient.Enabled = false;
                        buttonRemoveClient.Enabled = false;
                        buttonInsertClient.Enabled = true;
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
            else
            {
                MessageBox.Show("Deletion failed.");
            }
        }

    }
}
