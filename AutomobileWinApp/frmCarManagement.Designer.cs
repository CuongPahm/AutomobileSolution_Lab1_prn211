namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lblCarID = new Label();
            lblCarName = new Label();
            lblManufacturer = new Label();
            lblPrice = new Label();
            lblReleasedYear = new Label();
            txtCarID = new TextBox();
            txtReleasedYear = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtCarName = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(67, 76);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(50, 20);
            lblCarID.TabIndex = 0;
            lblCarID.Text = "Car ID";
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Location = new Point(67, 133);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(75, 20);
            lblCarName.TabIndex = 1;
            lblCarName.Text = "Car Name";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(67, 191);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(97, 20);
            lblManufacturer.TabIndex = 2;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(445, 76);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // lblReleasedYear
            // 
            lblReleasedYear.AutoSize = true;
            lblReleasedYear.Location = new Point(445, 133);
            lblReleasedYear.Name = "lblReleasedYear";
            lblReleasedYear.Size = new Size(101, 20);
            lblReleasedYear.TabIndex = 4;
            lblReleasedYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(180, 69);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(228, 27);
            txtCarID.TabIndex = 5;
            // 
            // txtReleasedYear
            // 
            txtReleasedYear.Location = new Point(552, 130);
            txtReleasedYear.Name = "txtReleasedYear";
            txtReleasedYear.Size = new Size(228, 27);
            txtReleasedYear.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(180, 188);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(228, 27);
            txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(552, 69);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(228, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(180, 130);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(228, 27);
            txtCarName.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(180, 252);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(397, 252);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(595, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(19, 304);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(829, 180);
            dgvCarList.TabIndex = 13;
            dgvCarList.CellDoubleClick += dgvCarManagement_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(392, 502);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 543);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtCarName);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtReleasedYear);
            Controls.Add(txtCarID);
            Controls.Add(lblReleasedYear);
            Controls.Add(lblPrice);
            Controls.Add(lblManufacturer);
            Controls.Add(lblCarName);
            Controls.Add(lblCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarID;
        private Label lblCarName;
        private Label lblManufacturer;
        private Label lblPrice;
        private Label lblReleasedYear;
        private TextBox txtCarID;
        private TextBox txtReleasedYear;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtCarName;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}