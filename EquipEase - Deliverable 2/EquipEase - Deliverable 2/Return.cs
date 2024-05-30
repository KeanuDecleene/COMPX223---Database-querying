using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipEase___Deliverable_2
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.ShowDialog();
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            int equipmentID = Convert.ToInt32(numericUpDownEquipmentID.Value);
            int rentalID = Convert.ToInt32(numericUpDownRentalID.Value);
            DateTime returnTime = dateTimePickerReturnTime.Value;
            string returnToBranch = comboBoxBranchReturnTo.Text;
            string query = "";

            if (equipmentID <= 0 || returnTime == DateTime.MinValue || string.IsNullOrEmpty(returnToBranch))
            {
                MessageBox.Show("Please fill all of the inputs");
                return;
            }

            try
            {
                query = "INSERT INTO rentEquipment (rEquipmentID, rRentalID, returnTime, returnTo) VALUES (@equipmentID, @rentalID, @returnTime, @returnToBranch)";
                using (SqlCommand cmd = new SqlCommand(query, SQL.con))
                {
                    cmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                    cmd.Parameters.AddWithValue("@rentalID", rentalID);
                    cmd.Parameters.AddWithValue("@returnTime", returnTime);
                    cmd.Parameters.AddWithValue("@returnToBranch", returnToBranch);

                    SQL.con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Equipment return success.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"An error occured while returning equipment:" + "\n" + " Check if the EquipmentID and rentalID are valid ID's" + "\n" + " Check if Duplicated");
                MessageBox.Show(ex.Message);
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
