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
    public partial class ManageRooms : Form
    {
        public ManageRooms()
        {
            InitializeComponent();
            GetAllRoom();
            buttonEditRoom.Enabled = false;
            buttonRemoveRoom.Enabled = false;
        }

        static string myconnection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        private void GetAllRoom()
        {
            SqlConnection con = new SqlConnection(myconnection);

            DataTable table = new DataTable();
            try
            {
                string sql = "SELECT roomNumber AS RoomNumber, roomType AS RoomType, phone AS PhoneNumber, free AS Free FROM room";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);

                dataGridViewRooms.DataSource = table;
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void buttonInsertRoom_Click(object sender, EventArgs e)
        {
            string roomNumber = textRoomNumber.Text;
            string roomType = comboRoomType.SelectedValue.ToString();
            string phone = textRoomPhone.Text;
            string free = "";

            if (radioButtonYes.Checked)
            {
                free = "Yes";
            }
            else if (radioButtonNo.Checked)
            {
                free = "No";
            }
          

            if(textRoomNumber.Text.Trim().Equals("") || textRoomPhone.Text.Trim().Equals("") || comboRoomType.Text.Trim().Equals(""))
            {
                MessageBox.Show("All Fields are required", "Empty fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(myconnection);

                try
                {
                    string sql = "INSERT INTO room(roomNumber, roomType, phone, free) VALUES(@roomNumber, @roomType, @phone, @free)";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                    cmd.Parameters.AddWithValue("@roomType",roomType);
                    cmd.Parameters.AddWithValue("@phone",phone);
                    cmd.Parameters.AddWithValue("@free",free);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("New Room added.");
                        GetAllRoom();
                        ClearAllData();
                    }
                    else
                    {
                        MessageBox.Show("New Room Adition failed.");

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

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconnection);

            DataTable table = new DataTable();
            try
            {
                string sql = "SELECT category_id, label , price  FROM rooms_category";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);
                comboRoomType.DataSource = table;
                comboRoomType.DisplayMember = "label";
                comboRoomType.ValueMember = "category_id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void ClearAllData()
        {
            textRoomNumber.Text = "";
            textRoomNumber.Text = "";
            textRoomPhone.Text = "";
            comboRoomType.SelectedItem = 0;
            radioButtonYes.Checked = true;
        }

        private void buttonResetClient_Click(object sender, EventArgs e)
        {
            ClearAllData();
            buttonEditRoom.Enabled = false;
            buttonRemoveRoom.Enabled = false;
            buttonInsertRoom.Enabled = true;
        }

        private void dataGridViewRooms_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int roomIdex = e.RowIndex;
            textRoomNumber.Text = dataGridViewRooms.Rows[roomIdex].Cells[0].Value.ToString();
            comboRoomType.Text = dataGridViewRooms.Rows[roomIdex].Cells[1].Value.ToString();
            textRoomPhone.Text = dataGridViewRooms.Rows[roomIdex].Cells[2].Value.ToString();
            string free = dataGridViewRooms.Rows[roomIdex].Cells[3].Value.ToString();

            if (free.Equals("Yes"))
            { 
                radioButtonYes.Checked = true;
            }
            else if(free.Equals("No"))
            {
                radioButtonNo.Checked = true;
            }


            buttonInsertRoom.Enabled = false;
            buttonEditRoom.Enabled = true;
            buttonRemoveRoom.Enabled = true;

        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {

            string roomNumber = textRoomNumber.Text;
            string roomType = comboRoomType.Text;
            string phone = textRoomPhone.Text;
            string free = "";

            if (radioButtonYes.Checked)
            {
                free = "Yes";
            }
            else if (radioButtonNo.Checked)
            {
                free = "No";
            }

            if (textRoomNumber.Text.Trim().Equals("") || textRoomPhone.Text.Trim().Equals("") || comboRoomType.Text.Trim().Equals(""))
            {
                MessageBox.Show("All Fields are required", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(myconnection);

                try
                {
                    
                    string sql = "UPDATE room SET roomType=@roomType,phone=@phone,free=@free WHERE roomNumber=@roomNumber";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                    cmd.Parameters.AddWithValue("@roomType", roomType);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@free", free);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Room Updated.");
                        GetAllRoom();
                        buttonRemoveRoom.Enabled = false;
                        buttonEditRoom.Enabled = false;
                        buttonInsertRoom.Enabled = true;
                        ClearAllData();
                    }
                    else
                    {
                        MessageBox.Show("Room updation failed.");

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

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            string deleteID = textRoomNumber.Text;

            if(deleteID !="")
            {
                SqlConnection con = new SqlConnection(myconnection);

                try
                {
                    string sql = "DELETE FROM room WHERE roomNumber=@deleteID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@deleteID",deleteID);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Room deleted!");
                        GetAllRoom();
                        ClearAllData();
                        buttonEditRoom.Enabled =false;
                        buttonRemoveRoom.Enabled = false;
                        buttonInsertRoom.Enabled =true;
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
                MessageBox.Show("Nothing to delete..");
            }
        }

    }
}
