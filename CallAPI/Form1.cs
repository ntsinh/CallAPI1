using BLL;
using DTO;
using System.Data;
using System.Net;
using System.Runtime.Serialization.Json;

namespace CallAPI
{

    public partial class Form1 : Form
    {

        List<KhoHang>? listKho;
        public Form1()
        {
            InitializeComponent();
            dgvKho.AutoGenerateColumns = false;
        }
        int indexRow;
        private void Form1_Load(object sender, EventArgs e)
        {

            HienThi();
        }

        public void HienThi()
        {
            ApiBLL apiBll = new();
            var data = apiBll.getDataForGUI();
            //KhoHang[] danhsach = (KhoHang[])data;
            listKho = (List<KhoHang>)data;
            dgvKho.DataSource = listKho;
        }


        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvKho.Rows[e.RowIndex];
            string maKho = row.Cells[0].Value.ToString();
            string tenKho = row.Cells[1].Value.ToString();
            txtMaKho.Text = maKho;
            txtTenKho.Text = tenKho;
            if (row.Cells[2].Value != null)
            {
                string moTa = row.Cells[2].Value.ToString();
                txtMoTa.Text = moTa;
            }
            else { txtMoTa.Text = ""; }
        }


        public void resetDataGrid()
        {
            dgvKho.DataSource = null;
        }


        public void Clear()
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtMoTa.Text = "";

        }

        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            int j = 0;
            if (txtMaKho.Text != "")
            {
                for (int i = 0; i < listKho.Count; i++)
                {
                    DataGridViewRow row = dgvKho.Rows[i];
                    string maKho = row.Cells[0].Value.ToString();
                    if (maKho.Equals(txtMaKho.Text))
                    {
                        j++;
                        MessageBox.Show("Ma kho da ton tai");
                        break;
                    }
                }
                if (j == 0)
                {
                    KhoHang kh = new KhoHang();
                    kh.maKhoXuat = txtMaKho.Text;
                    kh.tenKhoXuat = txtTenKho.Text;
                    kh.moTa = txtMoTa.Text;
                    listKho.Add(kh);
                    resetDataGrid();
                    dgvKho.DataSource = listKho;
                    Clear();
                }
                {

                }
            }
            else { MessageBox.Show("Chua nhap ma kho xuat"); }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listKho.Count; i++)
            {
                DataGridViewRow newDataRow = dgvKho.Rows[i];
                string maKho = newDataRow.Cells[0].Value.ToString();
                if (maKho.Equals(txtMaKho.Text))
                {
                    newDataRow.Cells[0].Value = txtMaKho.Text;
                    newDataRow.Cells[1].Value = txtTenKho.Text;
                    newDataRow.Cells[2].Value = txtMoTa.Text;
                    Clear();
                }

            }
            /* indexRow = dgvKho.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dgvKho.Rows[indexRow];
            newDataRow.Cells[0].Value = txtMaKho.Text;
            newDataRow.Cells[1].Value = txtTenKho.Text;
            newDataRow.Cells[2].Value = txtMoTa.Text;
            Clear(); */
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            /* listKho.RemoveAt(indexRow);
             resetDataGrid();
             dgvKho.DataSource = listKho;
             Clear(); */
            for (int i = 0; i < listKho.Count; i++)
            {
                DataGridViewRow row = dgvKho.Rows[i];
                string maKho = row.Cells[0].Value.ToString();
                if (maKho.Equals(txtMaKho.Text))
                {
                    listKho.RemoveAt(i);
                    resetDataGrid();
                    dgvKho.DataSource = listKho;
                    Clear();
                }

            }
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}