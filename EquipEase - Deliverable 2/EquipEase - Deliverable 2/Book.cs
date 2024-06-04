using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace EquipEase___Deliverable_2
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            InitialiseListBox();
        }

        public void InitialiseListBox()
        {
            string query = "";
            query = @" 
                    SELECT TypeName, purchaseDate
                    FROM Equipment
                    ORDER BY purchaseDate DESC";
            SQL.selectQuery(query);
            listBoxRecentlyPurchased.Items.Clear();
            string header = "Equipment Type:".PadRight(20) +
                            "Purchase Date Descending:".PadRight(25);
            listBoxRecentlyPurchased.Items.Add(header);
            string equipmentType = "";
            DateTime purchaseDate;
            SQL.selectQuery(query);
            try
            {
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        //get the data values and store them in variables
                        equipmentType = SQL.read["TypeName"].ToString();
                        purchaseDate = Convert.ToDateTime(SQL.read["purchaseDate"]);
                        //display each of the rows in a nice way
                        listBoxRecentlyPurchased.Items.Add(equipmentType.PadRight(20) +
                        purchaseDate.ToShortDateString().PadRight(25));
                    }
                }
                else
                {
                    listBoxRecentlyPurchased.Items.Add("No Rows found.");
                }
            }
            catch
            {
                //If an error happens here, it means error in locating data
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }
            finally
            {
                SQL.con.Close();
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxRecentlyPurchased_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedEquipment = listBoxRecentlyPurchased.SelectedItem.ToString();
            selectedEquipment = selectedEquipment.TrimEnd(); // Remove trailing spaces

            for (int i = 0; i < 2; i++)
            {
                int lastIndex = selectedEquipment.LastIndexOf(" ");
                if (lastIndex != -1)
                {
                    selectedEquipment = selectedEquipment.Substring(0, lastIndex); // Remove the last space
                }
            }
            selectedEquipment = selectedEquipment.TrimEnd(); 
            comboBoxEquipment.Text = selectedEquipment;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// gets the values from the Various inputs provided and then Inserts into the rental table, and RentEquipment table keeping foreign key structure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRent_Click(object sender, EventArgs e)
        {
            // Get user inputs
            string equipment = comboBoxEquipment.Text;
            DateTime startTime = dateTimePickerStart.Value;
            string branch = comboBoxBranchHireFrom.Text;
            string email = textBoxUserEmail.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(equipment) || string.IsNullOrEmpty(branch) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill all of the inputs");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            int rentalID = 0;
            try
            {
                SQL.con.Open();
                string checkEmail = "SELECT COUNT(*) FROM Customer WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(checkEmail, SQL.con))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Email does not exist in the database.");
                        return;
                    }
                }


                // Insert into Rental table
                string insertRentalQuery = "INSERT INTO Rental (startTime, hireFrom, CustomerEmail) VALUES (@startTime, @branch, @customerEmail)";
                using (SqlCommand command = new SqlCommand(insertRentalQuery, SQL.con))
                {
                    command.Parameters.AddWithValue("@startTime", startTime);
                    command.Parameters.AddWithValue("@branch", branch);
                    command.Parameters.AddWithValue("@customerEmail", email);
                    command.ExecuteNonQuery();
                }

                // Get the last inserted RentalID
                string getRentalIDQuery = "SELECT MAX(RentalID) AS RentalID FROM Rental"; //most recent rentalID
                using (SqlCommand command = new SqlCommand(getRentalIDQuery, SQL.con))
                {
                    command.Parameters.Clear();  //clear params
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rentalID = Convert.ToInt32(reader["RentalID"]); //finding the rentalID of equipment
                        }
                    }
                }

                // Get the EquipmentID of the selected equipment
                int equipmentID = 0; 
                //this query gets the equipment ID where the typename branchname and availabilty all equals 1
                string equipmentIDQuery = "SELECT EquipmentID FROM Equipment WHERE TypeName = @equipment AND BranchName = @branch AND available = 1 ORDER BY purchaseDate DESC";
                using (SqlCommand command = new SqlCommand(equipmentIDQuery, SQL.con))
                {
                    command.Parameters.AddWithValue("@equipment", equipment);
                    command.Parameters.AddWithValue("@branch", branch);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            equipmentID = Convert.ToInt32(reader["EquipmentID"]);
                        }
                        else
                        {
                            MessageBox.Show("Equipment is not available at the branch you chose.");
                            return;
                        }
                    }
                }

                //inserts into rentequipment only have to do not null variables
                string rentEquipmentQuery = "INSERT INTO rentEquipment (rEquipmentID, rRentalID) VALUES (@equipmentID, @rentalID)";
                using (SqlCommand command = new SqlCommand(rentEquipmentQuery, SQL.con))
                {
                    command.Parameters.AddWithValue("@equipmentID", equipmentID);
                    command.Parameters.AddWithValue("@rentalID", rentalID);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Equipment booked and hired successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the rental: " + ex.Message);
            }
            finally
            {
                if (SQL.con.State == System.Data.ConnectionState.Open)
                {
                    SQL.con.Close(); // close connection
                }
            }
        }
    }
}