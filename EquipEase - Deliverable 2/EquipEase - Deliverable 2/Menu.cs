using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipEase___Deliverable_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRentalRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental_Records form = new Rental_Records();
            form.ShowDialog();
            this.Close();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book form = new Book();
            form.ShowDialog();
            this.Close();
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReturnEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return form = new Return();
            form.ShowDialog();
            this.Close();
        }

        private void buttonSummaryReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Summary form = new Summary();
            form.ShowDialog();
            this.Close();
        }
    
    }
}
