namespace Bai5_Delivery_Order_Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TinhTong()
        {
            double tongSoLuong = 0, tongTrongLuong = 0, tongTien = 0;

            foreach (DataGridViewRow row in dgvHangHoa.Rows)
            {
                if (!row.IsNewRow)
                {
                    tongSoLuong += Convert.ToDouble(row.Cells["SoLuong"].Value ?? 0);
                    tongTrongLuong += Convert.ToDouble(row.Cells["TrongLuong"].Value ?? 0);
                    tongTien += Convert.ToDouble(row.Cells["ThanhTien"].Value ?? 0);
                }
            }

            lblTongSoLuong.Text = $"Tổng SL: {tongSoLuong}";
            lblTongTrongLuong.Text = $"Tổng TL: {tongTrongLuong} kg";
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void dgvHangHoa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvHangHoa.Columns[e.ColumnIndex].Name;

            if (colName == "SoLuong" || colName == "DonGia")
            {
                double soLuong = Convert.ToDouble(dgvHangHoa.Rows[e.RowIndex].Cells["SoLuong"].Value ?? 0);
                double donGia = Convert.ToDouble(dgvHangHoa.Rows[e.RowIndex].Cells["DonGia"].Value ?? 0);

                dgvHangHoa.Rows[e.RowIndex].Cells["ThanhTien"].Value = soLuong * donGia;
            }

            TinhTong();
        }

        private void dgvHangHoa_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvHangHoa.Columns[e.ColumnIndex].Name;
            if (colName == "SoLuong" || colName == "TrongLuong")
            {
                if (!double.TryParse(e.FormattedValue.ToString(), out double val) || val <= 0)
                {
                    dgvHangHoa.Rows[e.RowIndex].ErrorText = $"{colName} phải là số > 0!";
                    e.Cancel = true;
                }
                else
                {
                    dgvHangHoa.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                dgvHangHoa.Rows.Add("", 0, 0, 0, 0);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (dgvHangHoa.SelectedRows.Count > 0)
                {
                    DialogResult rs = MessageBox.Show("Xóa dòng đang chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        if (!dgvHangHoa.SelectedRows[0].IsNewRow)
                        {
                            dgvHangHoa.Rows.RemoveAt(dgvHangHoa.SelectedRows[0].Index);
                            TinhTong();
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboLoaiVC.Items.Add("Giao hàng tiêu chuẩn");
            cboLoaiVC.Items.Add("Giao hàng nhanh (Express)");
            cboLoaiVC.Items.Add("Giao hàng hỏa tốc");

            if (cboLoaiVC.Items.Count > 0)
            {
                cboLoaiVC.SelectedIndex = 0;
            }
        }
    }
}