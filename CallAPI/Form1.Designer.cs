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
            lbMaKhoLog = new Label();
            lbTenKhoLog = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            btnXoa = new GUI.CustomButton();
            btnThem = new GUI.CustomButton();
            btnSua = new GUI.CustomButton();
            label3 = new Label();
            label2 = new Label();
            txtMaKho = new UserControl2.UserControl1();
            label1 = new Label();
            txtTenKho = new UserControl2.UserControl1();
            txtMoTa = new UserControl2.UserControl1();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKho
            // 
            dgvKho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKho.BackgroundColor = Color.Gainsboro;
            dgvKho.BorderStyle = BorderStyle.None;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { maKhoXuat, tenKhoXuat, moTa });
            dgvKho.Location = new Point(13, 13);
            dgvKho.Name = "dgvKho";
            dgvKho.ReadOnly = true;
            dgvKho.RowTemplate.Height = 25;
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.Size = new Size(764, 355);
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
            // 
            // tenKhoXuat
            // 
            tenKhoXuat.DataPropertyName = "tenKhoXuat";
            tenKhoXuat.HeaderText = "Tên Kho Xuất";
            tenKhoXuat.Name = "tenKhoXuat";
            tenKhoXuat.ReadOnly = true;
            // 
            // moTa
            // 
            moTa.DataPropertyName = "moTa";
            moTa.HeaderText = "Mô Tả";
            moTa.Name = "moTa";
            moTa.ReadOnly = true;
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvKho);
            panel3.Location = new Point(12, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(790, 382);
            panel3.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnSua);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(814, 60);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(11, 14);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 8;
            label4.Text = "Kho hàng xuất";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.Red;
            btnXoa.BackgroundColor = Color.Red;
            btnXoa.BorderColor = Color.Red;
            btnXoa.BorderRadius = 5;
            btnXoa.BorderSize = 0;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(651, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 7;
            btnXoa.TabStop = false;
            btnXoa.Text = "Xóa";
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnThem.Location = new Point(342, 6);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 40);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.FromArgb(0, 192, 0);
            btnSua.BackgroundColor = Color.FromArgb(0, 192, 0);
            btnSua.BorderColor = Color.Orange;
            btnSua.BorderRadius = 5;
            btnSua.BorderSize = 0;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(495, 6);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 40);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(429, 5);
            label3.Margin = new Padding(3, 5, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 1;
            label3.Text = "Mô Tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(3, 5);
            label2.Margin = new Padding(3, 5, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên Kho Xuất";
            // 
            // txtMaKho
            // 
            txtMaKho.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaKho.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtMaKho.BackColor = Color.WhiteSmoke;
            txtMaKho.BorderColor = Color.WhiteSmoke;
            txtMaKho.BorderFocusColor = SystemColors.ControlDark;
            txtMaKho.BorderRadius = 0;
            txtMaKho.BorderSize = 0;
            txtMaKho.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKho.ForeColor = Color.DimGray;
            txtMaKho.Location = new Point(12, 39);
            txtMaKho.Margin = new Padding(12, 4, 4, 4);
            txtMaKho.Multiline = false;
            txtMaKho.Name = "txtMaKho";
            txtMaKho.Padding = new Padding(7);
            txtMaKho.PasswordChar = false;
            txtMaKho.Size = new Size(197, 31);
            txtMaKho.TabIndex = 8;
            txtMaKho.textBox1_Text = "";
            txtMaKho.Texts = "";
            txtMaKho.UnderlinedStyle = false;
            txtMaKho._TextChanged += txtMaKho__TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(216, 5);
            label1.Margin = new Padding(3, 5, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 1;
            label1.Text = "Mã Kho Xuất";
            // 
            // txtTenKho
            // 
            txtTenKho.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenKho.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtTenKho.BackColor = Color.WhiteSmoke;
            txtTenKho.BorderColor = Color.WhiteSmoke;
            txtTenKho.BorderFocusColor = SystemColors.ControlDark;
            txtTenKho.BorderRadius = 0;
            txtTenKho.BorderSize = 0;
            txtTenKho.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKho.ForeColor = Color.DimGray;
            txtTenKho.Location = new Point(217, 39);
            txtTenKho.Margin = new Padding(4, 4, 15, 4);
            txtTenKho.Multiline = false;
            txtTenKho.Name = "txtTenKho";
            txtTenKho.Padding = new Padding(7);
            txtTenKho.PasswordChar = false;
            txtTenKho.Size = new Size(194, 31);
            txtTenKho.TabIndex = 8;
            txtTenKho.textBox1_Text = "";
            txtTenKho.Texts = "";
            txtTenKho.UnderlinedStyle = false;
            txtTenKho._TextChanged += txtTenKho__TextChanged;
            // 
            // txtMoTa
            // 
            txtMoTa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMoTa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtMoTa.BackColor = Color.WhiteSmoke;
            txtMoTa.BorderColor = Color.WhiteSmoke;
            txtMoTa.BorderFocusColor = SystemColors.ControlDark;
            txtMoTa.BorderRadius = 0;
            txtMoTa.BorderSize = 0;
            txtMoTa.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoTa.ForeColor = Color.DimGray;
            txtMoTa.Location = new Point(426, 39);
            txtMoTa.Margin = new Padding(0, 4, 15, 4);
            txtMoTa.Multiline = false;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Padding = new Padding(7);
            txtMoTa.PasswordChar = false;
            txtMoTa.Size = new Size(349, 31);
            txtMoTa.TabIndex = 8;
            txtMoTa.textBox1_Text = "";
            txtMoTa.Texts = "";
            txtMoTa.UnderlinedStyle = false;
            txtMoTa._TextChanged += txtMoTa__TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tableLayoutPanel1.Controls.Add(txtMoTa, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTenKho, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(txtMaKho, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(790, 75);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightGray;
            ClientSize = new Size(814, 545);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(lbTenKhoLog);
            Controls.Add(lbMaKhoLog);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKho;
        private Label lbMaKhoLog;
        private Label lbTenKhoLog;
        private Panel panel3;
        private DataGridViewTextBoxColumn maKhoXuat;
        private DataGridViewTextBoxColumn tenKhoXuat;
        private DataGridViewTextBoxColumn moTa;
        private Panel panel2;
        private Label label4;
        private GUI.CustomButton btnXoa;
        private GUI.CustomButton btnThem;
        private GUI.CustomButton btnSua;
        private Label label3;
        private Label label2;
        private UserControl2.UserControl1 txtMaKho;
        private Label label1;
        private UserControl2.UserControl1 txtTenKho;
        private UserControl2.UserControl1 txtMoTa;
        private TableLayoutPanel tableLayoutPanel1;
    }
}