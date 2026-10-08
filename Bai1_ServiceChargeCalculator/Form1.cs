namespace Bai1_ServiceChargeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia < 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá hợp lệ (số dương).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng khách hợp lệ (số nguyên dương).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (!double.TryParse(txtGiamGia.Text, out double giamGia) || giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm giá hợp lệ (từ 0 đến 100).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamGia.Focus();
                return;
            }


            double tongTien = (donGia * soLuong) * ((100 - giamGia) / 100.0);

            lblTongTien.Text = $"Tổng tiền: {tongTien:N2} VNĐ";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            txtDonGia.Focus();
        }
    }
}
