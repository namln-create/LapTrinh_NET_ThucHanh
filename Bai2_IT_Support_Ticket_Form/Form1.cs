namespace Bai2_IT_Support_Ticket_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                ofd.Title = "Chọn ảnh chụp lỗi";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAnhLoi.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) || string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu và Người yêu cầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mucDo = "Thấp";
            if (radTrungBinh.Checked) mucDo = "Trung bình";
            if (radKhanCap.Checked) mucDo = "Khẩn cấp";

            string loaiSuCo = cboLoaiSuCo.SelectedItem?.ToString() ?? "Chưa xác định";

            List<string> thietBi = new List<string>();
            if (chkPC.Checked) thietBi.Add("Máy tính bàn");
            if (chkLaptop.Checked) thietBi.Add("Laptop");
            if (chkMayIn.Checked) thietBi.Add("Máy in");
            if (chkDienThoai.Checked) thietBi.Add("Điện thoại");
            string dsThietBi = thietBi.Count > 0 ? string.Join(", ", thietBi) : "Không có";

            string tomTat = $"--- THÔNG TIN PHIẾU HỖ TRỢ ---\n" +
                            $"- Mã phiếu: {txtMaPhieu.Text.Trim()}\n" +
                            $"- Người yêu cầu: {txtNguoiYeuCau.Text.Trim()}\n" +
                            $"- Ngày ghi nhận: {dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy")}\n" +
                            $"- Mức độ ưu tiên: {mucDo}\n" +
                            $"- Loại sự cố: {loaiSuCo}\n" +
                            $"- Thiết bị ảnh hưởng: {dsThietBi}\n" +
                            $"- Đính kèm ảnh: {(picAnhLoi.Image != null ? "Đã tải lên" : "Không có")}";

            MessageBox.Show(tomTat, "Xác nhận yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;

            // Reset RadioButton
            radThap.Checked = true;

            // Reset ComboBox
            cboLoaiSuCo.SelectedIndex = -1;

            // Reset CheckBox
            chkPC.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            // Xóa ảnh
            picAnhLoi.Image = null;

            txtMaPhieu.Focus();
        }
    }
}
