namespace EquipEase___Deliverable_2
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuLabel = new System.Windows.Forms.Label();
            this.buttonRentalRecords = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.buttonSummaryReport = new System.Windows.Forms.Button();
            this.buttonReturnEquipment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.Location = new System.Drawing.Point(11, 9);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(784, 76);
            this.MenuLabel.TabIndex = 0;
            this.MenuLabel.Text = "EQUIP EASE RENTALS";
            this.MenuLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRentalRecords
            // 
            this.buttonRentalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRentalRecords.Location = new System.Drawing.Point(439, 113);
            this.buttonRentalRecords.Name = "buttonRentalRecords";
            this.buttonRentalRecords.Size = new System.Drawing.Size(272, 99);
            this.buttonRentalRecords.TabIndex = 1;
            this.buttonRentalRecords.Text = "Rental Records";
            this.buttonRentalRecords.UseVisualStyleBackColor = true;
            this.buttonRentalRecords.Click += new System.EventHandler(this.buttonRentalRecords_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBook.Location = new System.Drawing.Point(439, 243);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(272, 99);
            this.buttonBook.TabIndex = 2;
            this.buttonBook.Text = "Book/Hire";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXIT.Location = new System.Drawing.Point(293, 383);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(188, 55);
            this.buttonEXIT.TabIndex = 3;
            this.buttonEXIT.Text = "EXIT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // buttonSummaryReport
            // 
            this.buttonSummaryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummaryReport.Location = new System.Drawing.Point(69, 113);
            this.buttonSummaryReport.Name = "buttonSummaryReport";
            this.buttonSummaryReport.Size = new System.Drawing.Size(272, 99);
            this.buttonSummaryReport.TabIndex = 4;
            this.buttonSummaryReport.Text = "Summary Report";
            this.buttonSummaryReport.UseVisualStyleBackColor = true;
            this.buttonSummaryReport.Click += new System.EventHandler(this.buttonSummaryReport_Click);
            // 
            // buttonReturnEquipment
            // 
            this.buttonReturnEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnEquipment.Location = new System.Drawing.Point(69, 243);
            this.buttonReturnEquipment.Name = "buttonReturnEquipment";
            this.buttonReturnEquipment.Size = new System.Drawing.Size(272, 99);
            this.buttonReturnEquipment.TabIndex = 5;
            this.buttonReturnEquipment.Text = "Return Equipment";
            this.buttonReturnEquipment.UseVisualStyleBackColor = true;
            this.buttonReturnEquipment.Click += new System.EventHandler(this.buttonReturnEquipment_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.buttonReturnEquipment);
            this.Controls.Add(this.buttonSummaryReport);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.buttonRentalRecords);
            this.Controls.Add(this.MenuLabel);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button buttonRentalRecords;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.Button buttonSummaryReport;
        private System.Windows.Forms.Button buttonReturnEquipment;
    }
}

