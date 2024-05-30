namespace EquipEase___Deliverable_2
{
    partial class Summary
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
            this.listBoxSummary = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUniqueCustomers = new System.Windows.Forms.Button();
            this.buttonAverageDuration = new System.Windows.Forms.Button();
            this.buttonPopularEquipment = new System.Windows.Forms.Button();
            this.buttonTotalRentals = new System.Windows.Forms.Button();
            this.buttonTotalGenerated = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSummary
            // 
            this.listBoxSummary.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSummary.FormattingEnabled = true;
            this.listBoxSummary.HorizontalScrollbar = true;
            this.listBoxSummary.ItemHeight = 16;
            this.listBoxSummary.Location = new System.Drawing.Point(459, 107);
            this.listBoxSummary.Name = "listBoxSummary";
            this.listBoxSummary.Size = new System.Drawing.Size(820, 468);
            this.listBoxSummary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Summary Report";
            // 
            // buttonUniqueCustomers
            // 
            this.buttonUniqueCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUniqueCustomers.Location = new System.Drawing.Point(12, 12);
            this.buttonUniqueCustomers.Name = "buttonUniqueCustomers";
            this.buttonUniqueCustomers.Size = new System.Drawing.Size(430, 104);
            this.buttonUniqueCustomers.TabIndex = 4;
            this.buttonUniqueCustomers.Text = "Number of unique customers who rented equipment in each branch in 2023";
            this.buttonUniqueCustomers.UseVisualStyleBackColor = true;
            this.buttonUniqueCustomers.Click += new System.EventHandler(this.buttonUniqueCustomers_Click);
            // 
            // buttonAverageDuration
            // 
            this.buttonAverageDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAverageDuration.Location = new System.Drawing.Point(12, 122);
            this.buttonAverageDuration.Name = "buttonAverageDuration";
            this.buttonAverageDuration.Size = new System.Drawing.Size(430, 104);
            this.buttonAverageDuration.TabIndex = 5;
            this.buttonAverageDuration.Text = "Average rental duration per equipment type in 2023\r\n";
            this.buttonAverageDuration.UseVisualStyleBackColor = true;
            this.buttonAverageDuration.Click += new System.EventHandler(this.buttonAverageDuration_Click);
            // 
            // buttonPopularEquipment
            // 
            this.buttonPopularEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPopularEquipment.Location = new System.Drawing.Point(12, 232);
            this.buttonPopularEquipment.Name = "buttonPopularEquipment";
            this.buttonPopularEquipment.Size = new System.Drawing.Size(430, 104);
            this.buttonPopularEquipment.TabIndex = 6;
            this.buttonPopularEquipment.Text = "Most popular equipment type rented in each branch in 2023\r\n\r\n";
            this.buttonPopularEquipment.UseVisualStyleBackColor = true;
            this.buttonPopularEquipment.Click += new System.EventHandler(this.buttonPopularEquipment_Click);
            // 
            // buttonTotalRentals
            // 
            this.buttonTotalRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotalRentals.Location = new System.Drawing.Point(12, 342);
            this.buttonTotalRentals.Name = "buttonTotalRentals";
            this.buttonTotalRentals.Size = new System.Drawing.Size(430, 104);
            this.buttonTotalRentals.TabIndex = 7;
            this.buttonTotalRentals.Text = "Total number of rentals per month in 2023";
            this.buttonTotalRentals.UseVisualStyleBackColor = true;
            this.buttonTotalRentals.Click += new System.EventHandler(this.buttonTotalRentals_Click);
            // 
            // buttonTotalGenerated
            // 
            this.buttonTotalGenerated.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotalGenerated.Location = new System.Drawing.Point(12, 452);
            this.buttonTotalGenerated.Name = "buttonTotalGenerated";
            this.buttonTotalGenerated.Size = new System.Drawing.Size(430, 104);
            this.buttonTotalGenerated.TabIndex = 8;
            this.buttonTotalGenerated.Text = "Total income generated by each equipment type in 2023\r\n";
            this.buttonTotalGenerated.UseVisualStyleBackColor = true;
            this.buttonTotalGenerated.Click += new System.EventHandler(this.buttonTotalGenerated_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 566);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(152, 46);
            this.buttonMenu.TabIndex = 9;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(199, 562);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(215, 60);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 624);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonTotalGenerated);
            this.Controls.Add(this.buttonTotalRentals);
            this.Controls.Add(this.buttonPopularEquipment);
            this.Controls.Add(this.buttonAverageDuration);
            this.Controls.Add(this.buttonUniqueCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSummary);
            this.Name = "Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUniqueCustomers;
        private System.Windows.Forms.Button buttonAverageDuration;
        private System.Windows.Forms.Button buttonPopularEquipment;
        private System.Windows.Forms.Button buttonTotalRentals;
        private System.Windows.Forms.Button buttonTotalGenerated;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonClear;
    }
}