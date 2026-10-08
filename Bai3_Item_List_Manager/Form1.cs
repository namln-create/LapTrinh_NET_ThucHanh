namespace Bai3_Item_List_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVT.Text) || string.IsNullOrWhiteSpace(txtTenVT.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in lsvVatTu.Items)
            {
                if (item.Text == txtMaVT.Text.Trim())
                {
                    MessageBox.Show("Mã vật tư đã tồn tại! Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaVT.Focus();
                    return;
                }
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số dương hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
                return;
            }

            ListViewItem newItem = new ListViewItem(txtMaVT.Text.Trim()); // Cột 0: Mã VT
            newItem.SubItems.Add(txtTenVT.Text.Trim());                   // Cột 1: Tên VT
            newItem.SubItems.Add(cboDVT.Text);                            // Cột 2: ĐVT
            newItem.SubItems.Add(donGia.ToString("N0"));                  // Cột 3: Đơn giá

            lsvVatTu.Items.Add(newItem);

            txtMaVT.Clear(); txtTenVT.Clear(); txtDonGia.Clear(); cboDVT.SelectedIndex = -1;
            txtMaVT.Focus();
        }

        private void lsvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvVatTu.SelectedItems[0];

                txtMaVT.Text = selectedItem.SubItems[0].Text;
                txtTenVT.Text = selectedItem.SubItems[1].Text;
                cboDVT.Text = selectedItem.SubItems[2].Text;

                txtDonGia.Text = selectedItem.SubItems[3].Text.Replace(",", "").Replace(".", "");

                txtMaVT.ReadOnly = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtTenVT.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem selectedItem = lsvVatTu.SelectedItems[0];

                selectedItem.SubItems[1].Text = txtTenVT.Text.Trim();
                selectedItem.SubItems[2].Text = cboDVT.Text;

                if (double.TryParse(txtDonGia.Text, out double donGia))
                {
                    selectedItem.SubItems[3].Text = donGia.ToString("N0");
                }

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMaVT.ReadOnly = false;
                txtMaVT.Clear(); txtTenVT.Clear(); txtDonGia.Clear(); cboDVT.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lsvVatTu.Items.Remove(lsvVatTu.SelectedItems[0]);

                    txtMaVT.ReadOnly = false;
                    txtMaVT.Clear(); txtTenVT.Clear(); txtDonGia.Clear(); cboDVT.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa TOÀN BỘ dữ liệu không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Clear();
                txtMaVT.ReadOnly = false;
                txtMaVT.Clear(); txtTenVT.Clear(); txtDonGia.Clear(); cboDVT.SelectedIndex = -1;
            }
        }
    }
}
