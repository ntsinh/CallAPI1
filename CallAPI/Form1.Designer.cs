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
            dgvKho = new DataGridView();
            maKhoXuat = new DataGridViewTextBoxColumn();
            tenKhoXuat = new DataGridViewTextBoxColumn();
            moTa = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtMaKho = new TextBox();
            label2 = new Label();
            txtTenKho = new TextBox();
            label3 = new Label();
            txtMoTa = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            SuspendLayout();
            // 
            // dgvKho
            // 
            dgvKho.BackgroundColor = SystemColors.ButtonHighlight;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { maKhoXuat, tenKhoXuat, moTa });
            dgvKho.Location = new Point(303, 25);
            dgvKho.Name = "dgvKho";
            dgvKho.ReadOnly = true;
            dgvKho.RowTemplate.Height = 25;
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.Size = new Size(399, 329);
            dgvKho.TabIndex = 0;
            dgvKho.CellClick += dgvKho_CellClick;
            // 
            // maKhoXuat
            // 
            maKhoXuat.DataPropertyName = "maKhoXuat";
            maKhoXuat.HeaderText = "Mã Kho Xuất";
            maKhoXuat.Name = "maKhoXuat";
            maKhoXuat.ReadOnly = true;
            maKhoXuat.Width = 110;
            // 
            // tenKhoXuat
            // 
            tenKhoXuat.DataPropertyName = "tenKhoXuat";
            tenKhoXuat.HeaderText = "Tên Kho Xuất";
            tenKhoXuat.Name = "tenKhoXuat";
            tenKhoXuat.ReadOnly = true;
            tenKhoXuat.Width = 120;
            // 
            // moTa
            // 
            moTa.DataPropertyName = "moTa";
            moTa.HeaderText = "Mô Tả";
            moTa.Name = "moTa";
            moTa.ReadOnly = true;
            moTa.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Kho Xuất";
            // 
            // txtMaKho
            // 
            txtMaKho.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaKho.Location = new Point(126, 29);
            txtMaKho.Name = "txtMaKho";
            txtMaKho.Size = new Size(171, 27);
            txtMaKho.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 92);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Kho Xuất";
            // 
            // txtTenKho
            // 
            txtTenKho.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenKho.Location = new Point(126, 92);
            txtTenKho.Name = "txtTenKho";
            txtTenKho.Size = new Size(171, 27);
            txtTenKho.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 155);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "Mô Tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMoTa.Location = new Point(126, 155);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(171, 27);
            txtMoTa.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 192, 0);
            btnThem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(14, 208);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(87, 44);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 128, 0);
            btnSua.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.ButtonHighlight;
            btnSua.Location = new Point(112, 208);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(87, 44);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoa.Location = new Point(210, 208);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(87, 44);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 362);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtMoTa);
            Controls.Add(label3);
            Controls.Add(txtTenKho);
            Controls.Add(label2);
            Controls.Add(txtMaKho);
            Controls.Add(label1);
            Controls.Add(dgvKho);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKho;
        private Label label1;
        private TextBox txtMaKho;
        private Label label2;
        private TextBox txtTenKho;
        private Label label3;
        private TextBox txtMoTa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridViewTextBoxColumn maKhoXuat;
        private DataGridViewTextBoxColumn tenKhoXuat;
        private DataGridViewTextBoxColumn moTa;
    }
}