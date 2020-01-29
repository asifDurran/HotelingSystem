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
            int clientid = Convert.ToInt32(textClientID.Text);
            //int reservationid = Convert.ToInt32(textReseveID.Text);
            string roomtype = comboRoomTypeClient.SelectedValue.ToString();
            int roomnumber = Convert.ToInt32(comboRoomNoClient.Text);
            DateTime datein = dateTimePickerIN.Value;
            DateTime dateout = dateTimePickerOUT.Value;

            if (textClientID.Text.Trim().Equals("") || comboRoomTypeClient.Text.Trim().Equals("") || comboRoomNoClient.Text.Trim().Equals("") || dateTimePickerIN.Text.Trim().Equals("") || dateTimePickerOUT.Text.Trim().Equals(""))
            {
                MessageBox.Show("All fields are required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(myconnection);

                try
                {
                    string sql = "INSERT INTO reservations(clientid,roomtype,roomnumber,datein,dateout)VALUES(@clientid,@roomtype,@roomnumber,@datein,@dateout)";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@clientid", clientid);
                    //cmd.Parameters.AddWithValue("@reservationid", reservationid);
                    cmd.Parameters.AddWithValue("@roomtype", roomtype);
                    cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                    cmd.Parameters.AddWithValue("@datein", datein);
                    cmd.Parameters.AddWithValue("@dateout", dateout);

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("New Reservation inserted.");
                    }
                    else
                    {
                        MessageBox.Show("Reservation Failed!!!!");
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

        private void comboRoomTypeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roomID = comboRoomTypeClient.SelectedValue.ToString();

            SqlConnection con = new SqlConnection(myconnection);

            DataTable dt = new DataTable();

            try
            {
                con.Open();

                string sql = "SELECT * FROM room WHERE roomType=" + roomID;
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
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