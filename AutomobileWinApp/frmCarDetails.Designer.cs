namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            txtYear = new MaskedTextBox();
            txtPrice = new MaskedTextBox();
            btnCancel = new Button();
            btnSave = new Button();
            cbManufacturer = new ComboBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label5 = new Label();
            lblPrice = new Label();
            Manufacturer = new Label();
            lblCarName = new Label();
            lblCarID = new Label();
            SuspendLayout();
            // 
            // txtYear
            // 
            txtYear.Location = new Point(361, 273);
            txtYear.Mask = "0000";
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(248, 27);
            txtYear.TabIndex = 26;
            txtYear.Text = "0";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(361, 215);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(248, 27);
            txtPrice.TabIndex = 25;
            txtPrice.Text = "0";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(461, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(292, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbManufacturer
            // 
            cbManufacturer.FormattingEnabled = true;
            cbManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cbManufacturer.Location = new Point(361, 161);
            cbManufacturer.Name = "cbManufacturer";
            cbManufacturer.Size = new Size(248, 28);
            cbManufacturer.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(361, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 27);
            txtName.TabIndex = 21;
            // 
            // txtID
            // 
            txtID.Location = new Point(361, 61);
            txtID.Name = "txtID";
            txtID.Size = new Size(248, 27);
            txtID.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 276);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 19;
            label5.Text = "Released Year";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(191, 218);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Price";
            // 
            // Manufacturer
            // 
            Manufacturer.AutoSize = true;
            Manufacturer.Location = new Point(191, 169);
            Manufacturer.Name = "Manufacturer";
            Manufacturer.Size = new Size(97, 20);
            Manufacturer.TabIndex = 17;
            Manufacturer.Text = "Manufacturer";
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Location = new Point(191, 113);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(75, 20);
            lblCarName.TabIndex = 16;
            lblCarName.Text = "Car Name";
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(191, 64);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(50, 20);
            lblCarID.TabIndex = 15;
            lblCarID.Text = "Car ID";
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtYear);
            Controls.Add(txtPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbManufacturer);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(lblPrice);
            Controls.Add(Manufacturer);
            Controls.Add(lblCarName);
            Controls.Add(lblCarID);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtYear;
        private MaskedTextBox txtPrice;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cbManufacturer;
        private TextBox txtName;
        private TextBox txtID;
        private Label label5;
        private Label lblPrice;
        private Label Manufacturer;
        private Label lblCarName;
        private Label lblCarID;
    }
}