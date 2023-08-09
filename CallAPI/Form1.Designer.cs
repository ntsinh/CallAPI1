namespace CallAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvKho = new DataGridView();
            maKhoXuat = new DataGridViewTextBoxColumn();
            tenKhoXuat = new DataGridViewTextBoxColumn();
            moTa = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbMaKhoLog = new Label();
            lbTenKhoLog = new Label();
            btnThem = new GUI.CustomButton();
            btnSua = new GUI.CustomButton();
            btnXoa = new GUI.CustomButton();
            txtMaKho = new UserControl2.UserControl1();
            txtTenKho = new UserControl2.UserControl1();
            txtMoTa = new UserControl2.UserControl1();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            SuspendLayout();
            // 
            // dgvKho
            // 
            dgvKho.BackgroundColor = Color.Gainsboro;
            dgvKho.BorderStyle = BorderStyle.None;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { maKhoXuat, tenKhoXuat, moTa });
            dgvKho.Location = new Point(234, 12);
            dgvKho.Name = "dgvKho";
            dgvKho.ReadOnly = true;
            dgvKho.RowTemplate.Height = 25;
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.Size = new Size(460, 416);
            dgvKho.TabIndex = 0;
            dgvKho.CellClick += dgvKho_CellClick;
            dgvKho.CellContentClick += dgvKho_CellContentClick;
            // 
            // maKhoXuat
            // 
            maKhoXuat.DataPropertyName = "maKhoXuat";
            maKhoXuat.HeaderText = "Mã Kho Xuất";
            maKhoXuat.Name = "maKhoXuat";
            maKhoXuat.ReadOnly = true;
            maKhoXuat.Width = 120;
            // 
            // tenKhoXuat
            // 
            tenKhoXuat.DataPropertyName = "tenKhoXuat";
            tenKhoXuat.HeaderText = "Tên Kho Xuất";
            tenKhoXuat.Name = "tenKhoXuat";
            tenKhoXuat.ReadOnly = true;
            tenKhoXuat.Width = 150;
            // 
            // moTa
            // 
            moTa.DataPropertyName = "moTa";
            moTa.HeaderText = "Mô Tả";
            moTa.Name = "moTa";
            moTa.ReadOnly = true;
            moTa.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã Kho Xuất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Kho Xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(14, 160);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 1;
            label3.Text = "Mô Tả";
            // 
            // lbMaKhoLog
            // 
            lbMaKhoLog.AutoSize = true;
            lbMaKhoLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMaKhoLog.ForeColor = Color.Red;
            lbMaKhoLog.Location = new Point(17, 63);
            lbMaKhoLog.Name = "lbMaKhoLog";
            lbMaKhoLog.Size = new Size(0, 21);
            lbMaKhoLog.TabIndex = 4;
            // 
            // lbTenKhoLog
            // 
            lbTenKhoLog.AutoSize = true;
            lbTenKhoLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTenKhoLog.ForeColor = Color.Red;
            lbTenKhoLog.Location = new Point(18, 151);
            lbTenKhoLog.Name = "lbTenKhoLog";
            lbTenKhoLog.Size = new Size(0, 21);
            lbTenKhoLog.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.Orange;
            btnThem.BackgroundColor = Color.Orange;
            btnThem.BackgroundImageLayout = ImageLayout.None;
            btnThem.BorderColor = Color.Orange;
            btnThem.BorderRadius = 5;
            btnThem.BorderSize = 0;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(12, 289);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(207, 40);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.BackgroundColor = Color.White;
            btnSua.BorderColor = Color.Orange;
            btnSua.BorderRadius = 5;
            btnSua.BorderSize = 3;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.FromArgb(255, 128, 0);
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(12, 335);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(5, 0, 0, 0);
            btnSua.Size = new Size(208, 40);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.TextColor = Color.FromArgb(255, 128, 0);
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.BackgroundColor = Color.White;
            btnXoa.BorderColor = Color.Red;
            btnXoa.BorderRadius = 5;
            btnXoa.BorderSize = 3;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(12, 381);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(5, 0, 0, 0);
            btnXoa.Size = new Size(207, 40);
            btnXoa.TabIndex = 7;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.TextColor = Color.Red;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // txtMaKho
            // 
            txtMaKho.BackColor = SystemColors.Window;
            txtMaKho.BorderColor = SystemColors.ButtonShadow;
            txtMaKho.BorderFocusColor = SystemColors.ControlDark;
            txtMaKho.BorderRadius = 5;
            txtMaKho.BorderSize = 1;
            txtMaKho.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKho.ForeColor = Color.DimGray;
            txtMaKho.Location = new Point(12, 36);
            txtMaKho.Margin = new Padding(4);
            txtMaKho.Multiline = false;
            txtMaKho.Name = "txtMaKho";
            txtMaKho.Padding = new Padding(7);
            txtMaKho.PasswordChar = false;
            txtMaKho.Size = new Size(207, 31);
            txtMaKho.TabIndex = 8;
            txtMaKho.Texts = "";
            txtMaKho.UnderlinedStyle = false;
            txtMaKho._TextChanged += txtMaKho__TextChanged;
            // 
            // txtTenKho
            // 
            txtTenKho.BackColor = SystemColors.Window;
            txtTenKho.BorderColor = SystemColors.ButtonShadow;
            txtTenKho.BorderFocusColor = SystemColors.ControlDark;
            txtTenKho.BorderRadius = 5;
            txtTenKho.BorderSize = 1;
            txtTenKho.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKho.ForeColor = Color.DimGray;
            txtTenKho.Location = new Point(12, 113);
            txtTenKho.Margin = new Padding(4);
            txtTenKho.Multiline = false;
            txtTenKho.Name = "txtTenKho";
            txtTenKho.Padding = new Padding(7);
            txtTenKho.PasswordChar = false;
            txtTenKho.Size = new Size(207, 31);
            txtTenKho.TabIndex = 8;
            txtTenKho.Texts = "";
            txtTenKho.UnderlinedStyle = false;
            txtTenKho._TextChanged += txtTenKho__TextChanged;
            // 
            // txtMoTa
            // 
            txtMoTa.BackColor = SystemColors.Window;
            txtMoTa.BorderColor = SystemColors.ButtonShadow;
            txtMoTa.BorderFocusColor = SystemColors.ControlDark;
            txtMoTa.BorderRadius = 5;
            txtMoTa.BorderSize = 1;
            txtMoTa.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoTa.ForeColor = Color.DimGray;
            txtMoTa.Location = new Point(14, 191);
            txtMoTa.Margin = new Padding(4);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Padding = new Padding(7);
            txtMoTa.PasswordChar = false;
            txtMoTa.Size = new Size(207, 91);
            txtMoTa.TabIndex = 8;
            txtMoTa.Texts = "";
            txtMoTa.UnderlinedStyle = false;
            txtMoTa._TextChanged += txtMoTa__TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(706, 440);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenKho);
            Controls.Add(txtMaKho);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lbTenKhoLog);
            Controls.Add(lbMaKhoLog);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvKho);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKho;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbMaKhoLog;
        private Label lbTenKhoLog;
        private GUI.CustomButton btnThem;
        private GUI.CustomButton btnSua;
        private GUI.CustomButton btnXoa;
        private DataGridViewTextBoxColumn maKhoXuat;
        private DataGridViewTextBoxColumn tenKhoXuat;
        private DataGridViewTextBoxColumn moTa;
        private UserControl2.UserControl1 txtMaKho;
        private UserControl2.UserControl1 txtTenKho;
        private UserControl2.UserControl1 txtMoTa;
    }
}