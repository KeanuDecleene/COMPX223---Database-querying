using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EquipEase___Deliverable_2
{
    public partial class Rental_Records : Form
    {
        public Rental_Records()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays all of the rental records 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string query = "";
            // query uses @" at the front to keep formatting from qorking sql query
            query = @" 
                    SELECT 
                        E.TypeName, 
                        R.startTime, 
                        RE.returnTime, 
                        R.hireFrom, 
                        RE.returnTo, 
                        C.Email 
                    FROM 
                        Rental R 
                        INNER JOIN rentEquipment RE ON R.RentalID = RE.rRentalID 
                        INNER JOIN Equipment E ON RE.rEquipmentID = E.EquipmentID 
                        INNER JOIN EquipmentType ET ON E.TypeName = ET.TypeName 
                        INNER JOIN Customer C ON R.CustomerEmail = C.Email";

            SQL.selectQuery(query);
            try
            {
                if (SQL.read.HasRows)
                {
                    //loop through each table row from the database
                    displayRows();
                }
                else 
                {
                    listBoxRecords.Items.Add("No Rows found.");
                }
            }
            catch
            {
                //If an error happens here, it means error in locating data
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }
            finally
            {
                if (SQL.con.State == System.Data.ConnectionState.Open)
                {
                    SQL.con.Close(); // close connection
                }
            }
        }

        /// <summary>
        /// Displays all the rows into the listbox 
        /// </summary>
        public void displayRows()
        {
            listBoxRecords.Items.Clear();
            string header = "Equipment Type:".PadRight(20) +
                            "Start Time".PadRight(25) +
                            "Return Time:".PadRight(25) +
                            "Hired From:".PadRight(30) +
                            "Returned To:".PadRight(30) +
                            "Email Address:".PadRight(20);
            listBoxRecords.Items.Add(header);
            string equipmentType = "", branchNameHiredFrom = "", branchNameReturnedTo = "",
                emailAddress = "", startTime = "", returnTime = "";
            while (SQL.read.Read())
            {
                //get the data values and store them in variables
                equipmentType = SQL.read["TypeName"].ToString();
                startTime = SQL.read["startTime"].ToString();
                returnTime = SQL.read["returnTime"].ToString();
                branchNameHiredFrom = SQL.read["hireFrom"].ToString();
                branchNameReturnedTo = SQL.read["returnTo"].ToString();
                emailAddress = SQL.read["Email"].ToString();
                //display each of the rows in a nice way
                listBoxRecords.Items.Add(equipmentType.PadRight(20) +
                     startTime.PadRight(25) +
                     returnTime.PadRight(25) +
                     branchNameHiredFrom.PadRight(30) +
                     branchNameReturnedTo.PadRight(30) +
                     emailAddress.PadRight(20));
            }
        }


        /// <summary>
        /// Button that handles the filter box's input and uses a switch case to determine what filter WHERE clause should be added 
        /// to the SELECT AND FROM to FILTER for desired result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string filter = "";
            string selectedFilter = "";
            try 
            {
                if (comboBoxFilter.SelectedIndex == -1)
                {
                    MessageBox.Show("FILTER IS EMPTY");
                    return;
                }
                selectedFilter = comboBoxFilter.SelectedItem.ToString(); 
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("use a preset filter" + ex.ToString()); ;
            }

            switch (selectedFilter)
            {
                case "Upcoming rentals":
                    filter = @"WHERE 
                             R.startTime > GETDATE()";
                    break;
                case "Ongoing rentals":
                    filter = @"WHERE 
                             R.startTime <= GETDATE() AND (RE.returnTime IS NULL OR RE.returnTime >= GETDATE())"; 
                    break;
                case "Past rentals":
                    filter = @"WHERE 
                             RE.returnTime < GETDATE()";
                    break;
                default: //nothing in filter
                    filter = ""; 
                    break;
            }

            string query = @" 
                    SELECT 
                        E.TypeName, 
                        R.startTime, 
                        RE.returnTime, 
                        R.hireFrom, 
                        RE.returnTo, 
                        C.Email 
                    FROM 
                        Rental R 
                        INNER JOIN rentEquipment RE ON R.RentalID = RE.rRentalID 
                        INNER JOIN Equipment E ON RE.rEquipmentID = E.EquipmentID 
                        INNER JOIN EquipmentType ET ON E.TypeName = ET.TypeName 
                        INNER JOIN Customer C ON R.CustomerEmail = C.Email "
                        + filter;

            SQL.selectQuery(query);
            try
            {
                if (SQL.read.HasRows)
                {
                    //loop through each table row from the database
                    displayRows();
                }
                else
                {
                    listBoxRecords.Items.Add("No Rows found.");
                }
            }
            catch
            {
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }
            finally
            {
                if (SQL.con.State == System.Data.ConnectionState.Open)
                {
                    SQL.con.Close(); // close connection
                }
            }

        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.ShowDialog();
            this.Close();
        }
    }
}
