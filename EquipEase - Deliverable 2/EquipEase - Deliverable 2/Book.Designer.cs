namespace EquipEase___Deliverable_2
{
    partial class Book
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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBranchHireFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.listBoxRecentlyPurchased = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 392);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(152, 46);
            this.buttonMenu.TabIndex = 7;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(23, 196);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(167, 20);
            this.dateTimePickerStart.TabIndex = 9;
            // 
            // comboBoxBranchHireFrom
            // 
            this.comboBoxBranchHireFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranchHireFrom.FormattingEnabled = true;
            this.comboBoxBranchHireFrom.Items.AddRange(new object[] {
            "Tauranga Downtown Branch",
            "Hamilton East Branch",
            "Christchurch Central Branch",
            "Wellington CBD Branch",
            "Auckland Central Branch"});
            this.comboBoxBranchHireFrom.Location = new System.Drawing.Point(22, 123);
            this.comboBoxBranchHireFrom.Name = "comboBoxBranchHireFrom";
            this.comboBoxBranchHireFrom.Size = new System.Drawing.Size(168, 21);
            this.comboBoxBranchHireFrom.TabIndex = 10;
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Items.AddRange(new object[] {
            "Air Compressor",
            "Angle Grinder",
            "Belt Sander",
            "Brick Saw",
            "Circular Saw",
            "Concrete Mixer",
            "Concrete Vibrator",
            "Demolition Hammer",
            "Drill",
            "Drywall Screwgun",
            "Floor Sander",
            "Hammer Drill",
            "Impact Driver",
            "Jackhammer",
            "Jigsaw",
            "Ladder",
            "Masonry Saw",
            "Mitre Saw",
            "Nail Gun",
            "Paint Sprayer",
            "Planer",
            "Plaster Mixer",
            "Rotary Hammer",
            "Router",
            "Sander",
            "Staple Gun",
            "Table Saw",
            "Tile Cutter",
            "Wallpaper Steamer"});
            this.comboBoxEquipment.Location = new System.Drawing.Point(23, 52);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(167, 21);
            this.comboBoxEquipment.TabIndex = 11;
            this.comboBoxEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxRecentlyPurchased
            // 
            this.listBoxRecentlyPurchased.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecentlyPurchased.FormattingEnabled = true;
            this.listBoxRecentlyPurchased.HorizontalScrollbar = true;
            this.listBoxRecentlyPurchased.ItemHeight = 16;
            this.listBoxRecentlyPurchased.Location = new System.Drawing.Point(245, 130);
            this.listBoxRecentlyPurchased.Name = "listBoxRecentlyPurchased";
            this.listBoxRecentlyPurchased.Size = new System.Drawing.Size(540, 292);
            this.listBoxRecentlyPurchased.TabIndex = 12;
            this.listBoxRecentlyPurchased.SelectedIndexChanged += new System.EventHandler(this.listBoxRecentlyPurchased_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Equipment:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(23, 86);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 25);
            this.label.TabIndex = 14;
            this.label.Text = "Branch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Start Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 61);
            this.label4.TabIndex = 16;
            this.label4.Text = "Book/Hire:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.Location = new System.Drawing.Point(23, 263);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.Size = new System.Drawing.Size(167, 20);
            this.textBoxUserEmail.TabIndex = 17;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(23, 235);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(66, 25);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "Email:";
            // 
            // buttonRent
            // 
            this.buttonRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRent.Location = new System.Drawing.Point(22, 300);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(168, 55);
            this.buttonRent.TabIndex = 19;
            this.buttonRent.Text = "Book/Hire";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxUserEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRecentlyPurchased);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.comboBoxBranchHireFrom);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonMenu);
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.ComboBox comboBoxBranchHireFrom;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.ListBox listBoxRecentlyPurchased;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUserEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonRent;
    }
}