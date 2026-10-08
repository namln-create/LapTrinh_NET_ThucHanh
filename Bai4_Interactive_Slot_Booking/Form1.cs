namespace Bai4_Interactive_Slot_Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhungGio.SelectedIndex = 0;

            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();
                btn.Text = "" + i;
                btn.Width = 80;
                btn.Height = 50;
                btn.BackColor = Color.LightGray;
                btn.Cursor = Cursors.Hand;

                btn.Click += ChonViTri_Click;

                flpSoDo.Controls.Add(btn);
            }
        }

        private void ChonViTri_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Vị trí này đã được đặt, vui lòng chọn vị trí khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btn.BackColor == Color.LightGray)
            {
                btn.BackColor = Color.LightGreen;
            }
            else if (btn.BackColor == Color.LightGreen)
            {
                btn.BackColor = Color.LightGray;
            }

            CapNhatTinhTien();
        }

        private void CapNhatTinhTien()
        {
            int soLuong = 0;
            int donGia = cboKhungGio.SelectedIndex == 0 ? 100000 : 150000;

            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button btn && btn.BackColor == Color.LightGreen)
                {
                    soLuong++;
                }
            }

            double tongTien = soLuong * donGia;

            lblSoLuong.Text = $"Số vị trí đang chọn: {soLuong}";
            lblTamTinh.Text = $"Tạm tính tiền: {tongTien:N0} VNĐ";

        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTinhTien();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button btn && btn.BackColor == Color.LightGreen)
                {
                    btn.BackColor = Color.Red;
                    count++;
                }
            }

            if (count > 0)
            {
                MessageBox.Show($"Đặt thành công {count} vị trí!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhatTinhTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 vị trí để đặt!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyAll_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button btn && btn.BackColor == Color.LightGreen)
                {
                    btn.BackColor = Color.LightGray;
                }
            }
            CapNhatTinhTien();
        }
    }
}