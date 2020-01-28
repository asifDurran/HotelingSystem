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
    public partial class ManageReservations : Form
    {
        public ManageReservations()
        {
            InitializeComponent();
        }
        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            string clientid = textClientID.Text;
            string reservationid = textReseveID.Text;
            string roomtype = comboRoomTypeClient.SelectedValue.ToString();
            string roomnumber = comboRoomNoClient.Text;
            string datein = dateTimePickerIN.Text;
            string dateout = dateTimePickerOUT.Text;
          
            if(textClientID.Text.Trim().Equals("") || textReseveID.Text.Trim().Equals("") || comboRoomTypeClient.Text.Trim().Equals("") || comboRoomNoClient.Text.Trim().Equals("") ||  dateTimePickerIN.Text.Trim().Equals("") || dateTimePickerOUT.Text.Trim().Equals(""))
            {
                MessageBox.Show("All fields are required","Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(myconnection);

                try
                {
                    string sql = "INSERT INTO reservations(clientid,reservationid,roomtype,roomnumber,datein,dateout)VALUES(@clientid,@reservationid,@roomtype,@roomnumber,@datein,@dateout)";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@clientid", clientid);
                    cmd.Parameters.AddWithValue("@reservationid", reservationid);
                    cmd.Parameters.AddWithValue("@roomtype", roomtype);
                    cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                    cmd.Parameters.AddWithValue("@datein", datein);
                    cmd.Parameters.AddWithValue("@dateout", dateout);

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Data inserted.");
                    }
                    else
                    {
                        MessageBox.Show("Failed insetion!!!!");
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

        private void ManageReservations_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconnection);

            DataTable table = new DataTable();
            try
            {
                string sql = "SELECT category_id, label FROM rooms_category";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);
                comboRoomTypeClient.DataSource = table;
                comboRoomTypeClient.DisplayMember = "label";
                comboRoomTypeClient.ValueMember = "category_id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void comboRoomNoClient_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboRoomTypeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roomID = comboRoomTypeClient.SelectedValue.ToString();

            SqlConnection con = new SqlConnection(myconnection);

            DataTable dt = new DataTable();

            try
            {
                con.Open();

                string sql = "SELECT * FROM room WHERE roomType=" +roomID;
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
                adapter.Fill(dt);
                comboRoomNoClient.DataSource = dt;
                comboRoomNoClient.DisplayMember = "roomNumber";
                comboRoomNoClient.ValueMember = "roomNumber";
                cmd.ExecuteNonQuery();

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
}
