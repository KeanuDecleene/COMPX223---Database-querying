namespace EquipEase___Deliverable_2
{
    partial class Return
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
            this.numericUpDownEquipmentID = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerReturnTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBranchReturnTo = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownRentalID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEquipmentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalID)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownEquipmentID
            // 
            this.numericUpDownEquipmentID.Location = new System.Drawing.Point(314, 73);
            this.numericUpDownEquipmentID.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownEquipmentID.Name = "numericUpDownEquipmentID";
            this.numericUpDownEquipmentID.Size = new System.Drawing.Size(167, 20);
            this.numericUpDownEquipmentID.TabIndex = 0;
            // 
            // dateTimePickerReturnTime
            // 
            this.dateTimePickerReturnTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePickerReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReturnTime.Location = new System.Drawing.Point(314, 192);
            this.dateTimePickerReturnTime.Name = "dateTimePickerReturnTime";
            this.dateTimePickerReturnTime.Size = new System.Drawing.Size(167, 20);
            this.dateTimePickerReturnTime.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Return Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Equipment ID:";
            // 
            // comboBoxBranchReturnTo
            // 
            this.comboBoxBranchReturnTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranchReturnTo.FormattingEnabled = true;
            this.comboBoxBranchReturnTo.Items.AddRange(new object[] {
            "Tauranga Downtown Branch",
            "Hamilton East Branch",
            "Christchurch Central Branch",
            "Wellington CBD Branch",
            "Auckland Central Branch"});
            this.comboBoxBranchReturnTo.Location = new System.Drawing.Point(314, 268);
            this.comboBoxBranchReturnTo.Name = "comboBoxBranchReturnTo";
            this.comboBoxBranchReturnTo.Size = new System.Drawing.Size(168, 21);
            this.comboBoxBranchReturnTo.TabIndex = 18;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(309, 240);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(176, 25);
            this.label.TabIndex = 19;
            this.label.Text = "Branch To Return :";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(250, 316);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(278, 92);
            this.buttonReturn.TabIndex = 20;
            this.buttonReturn.Text = "Return Equipment";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 392);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(152, 46);
            this.buttonMenu.TabIndex = 21;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Rental ID:";
            // 
            // numericUpDownRentalID
            // 
            this.numericUpDownRentalID.Location = new System.Drawing.Point(314, 135);
            this.numericUpDownRentalID.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numericUpDownRentalID.Name = "numericUpDownRentalID";
            this.numericUpDownRentalID.Size = new System.Drawing.Size(167, 20);
            this.numericUpDownRentalID.TabIndex = 22;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownRentalID);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBoxBranchReturnTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerReturnTime);
            this.Controls.Add(this.numericUpDownEquipmentID);
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEquipmentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownEquipmentID;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBranchReturnTo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownRentalID;
    }
}