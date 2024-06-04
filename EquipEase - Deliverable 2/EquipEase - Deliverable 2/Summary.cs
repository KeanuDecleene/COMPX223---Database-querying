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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void buttonUniqueCustomers_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT 
            hireFrom,
            COUNT(DISTINCT CustomerEmail)
            FROM 
            Rental
            WHERE 
            YEAR(startTime) = 2023
            GROUP BY 
            hireFrom
            ORDER BY 
            hireFrom";

            try
            {
                SQL.con.Open();
                // Execute the query
                using (SqlCommand cmd = new SqlCommand(query, SQL.con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxSummary.Items.Clear();
                        string header = "Branch Name:".PadRight(30) + "Unique Customers in 2023:";
                        listBoxSummary.Items.Add(header);

                        while (reader.Read())
                        {
                            string branchName = reader[0].ToString();
                            int uniqueCustomerCount = Convert.ToInt32(reader[1]);

                            string line = branchName.PadRight(30) + uniqueCustomerCount.ToString();
                            listBoxSummary.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the report: " + ex.Message);
            }
            finally
            {
                if (SQL.con.State == System.Data.ConnectionState.Open)
                {
                    SQL.con.Close();
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.ShowDialog();
            this.Close();
        }

        private void buttonAverageDuration_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT 
            e.TypeName,
            AVG(DATEDIFF(HOUR, r.startTime, re.returnTime))
            FROM 
            Rental r
            JOIN rentEquipment re ON r.RentalID = re.rRentalID
            JOIN Equipment e ON re.rEquipmentID = e.EquipmentID
            WHERE 
            YEAR(r.startTime) = 2023 AND re.returnTime IS NOT NULL
            GROUP BY 
            e.TypeName
            ORDER BY 
            e.TypeName";

            try
            {
                SQL.con.Open();
                // Execute the query
                using (SqlCommand cmd = new SqlCommand(query, SQL.con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxSummary.Items.Clear();
                        string header = "Equipment Type:".PadRight(30) + "Average Rental Duration (HOURS):";
                        listBoxSummary.Items.Add(header);

                        while (reader.Read())
                        {
                            string branchName = reader[0].ToString();
                            int uniqueCustomerCount = Convert.ToInt32(reader[1]);

                            string line = branchName.PadRight(30) + uniqueCustomerCount.ToString() + " Hours";
                            listBoxSummary.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the report: " + ex.Message);
            }
            finally
            {
                if (SQL.con.State == System.Data.ConnectionState.Open)
                {
                    SQL.con.Close();
                }
            }
        }

        private void buttonPopularEquipment_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT 
            BranchName,
            TypeName AS EquipmentType,
            RentalCount AS Count
            FROM (
            SELECT 
            r.hireFrom AS BranchName,
            e.TypeName,
            COUNT(*) AS RentalCount,
            ROW_NUMBER() OVER (PARTITION BY r.hireFrom ORDER BY COUNT(*) DESC) AS RowNum
            FROM 
            Rental r
            JOIN rentEquipment re ON r.RentalID = re.rRentalID
            JOIN Equipment e ON re.rEquipmentID = e.EquipmentID
            WHERE 
            YEAR(r.startTime) = 2023
            GROUP BY 
            r.hireFrom, e.TypeName
            ) AS t
            WHERE t.RowNum = 1;";

            try
            {
                SQL.con.Open();
                // Execute the query
                using (SqlCommand cmd = new SqlCommand(query, SQL.con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxSummary.Items.Clear();
                        string header = "MOST POPULAR EQUIPMENT IN EACH BRANCH IN 2023:";
                        listBoxSummary.Items.Add(header);
                        string head = "Branch Name:".PadRight(30) + "Equipment:".PadRight(30) + "Number of Rentals:";
                        listBoxSummary.Items.Add(head);

                        while (reader.Read())
                        {
                            string branchName = reader[0].ToString();
                            string Equipment = reader[1].ToString();
                            int numberOfRentals = Convert.ToInt32(reader[2]);

                            string line = branchName.PadRight(30) + Equipment.ToString().PadRight(30) + numberOfRentals;
                            listBoxSummary.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the report: " + ex.Message);
            }
            finally
            {
                if (SQL.con.State == System.Data.ConnectionState.Open)
                {
                    SQL.con.Close();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxSummary.Items.Clear();
        }

        private void buttonTotalRentals_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT 
            MONTH(r.startTime) AS Month,
            COUNT(*) AS TotalRentals
            FROM 
            Rental r
            JOIN 
            rentEquipment re ON r.RentalID = re.rRentalID
            WHERE 
            YEAR(r.startTime) = 2023
            GROUP BY 
            YEAR(r.startTime), MONTH(r.startTime)
            ORDER BY 
            YEAR(r.startTime), MONTH(r.startTime);
            ";
            try
            {
                SQL.con.Open();
                // Execute the query
                using (SqlCommand cmd = new SqlCommand(query, SQL.con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxSummary.Items.Clear();
                        string head = "Month:".PadRight(30) + "Total Rentals This Month:".PadRight(30);
                        listBoxSummary.Items.Add(head);

                        while (reader.Read())
                        {
                            string month = reader[0].ToString();
                            string totalRentals = reader[1].ToString();

                            string line = month.PadRight(30) + totalRentals.PadRight(30);
                            listBoxSummary.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the report: " + ex.Message);
            }
            finally
            {
                if (SQL.con.State == System.Data.ConnectionState.Open)
                {
                    SQL.con.Close();
                }
            }
        }

        private void buttonTotalGenerated_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT 
            et.TypeName,
            SUM(DATEDIFF(HOUR, r.startTime, re.returnTime) * et.ratePerHour) AS TotalIncome 
            FROM 
            Rental r
            JOIN 
            rentEquipment re ON r.RentalID = re.rRentalID
            JOIN 
            Equipment e ON re.rEquipmentID = e.EquipmentID
            JOIN 
            EquipmentType et ON e.TypeName = et.TypeName
            WHERE 
            YEAR(r.startTime) = 2023
            GROUP BY 
            et.TypeName;
            ";
            try
            {
                SQL.con.Open();
                // Execute the query
                using (SqlCommand cmd = new SqlCommand(query, SQL.con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxSummary.Items.Clear();
                        string head = "Equipment: ".PadRight(30) + "Income Generated:".PadRight(30);
                        listBoxSummary.Items.Add(head);

                        while (reader.Read())
                        {
                            string equipment = reader[0].ToString();
                            decimal income = Convert.ToDecimal(reader[1].ToString());

                            string line = equipment.PadRight(30) + income.ToString("C").PadRight(30);
                            listBoxSummary.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the report: " + ex.Message);
            }
            finally
            {
                if (SQL.con.State == System.Data.ConnectionState.Open)
                {
                    SQL.con.Close();
                }
            }
        }
    }
}
