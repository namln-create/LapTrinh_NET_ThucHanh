namespace Bai4_Interactive_Slot_Booking
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
            flpSoDo = new FlowLayoutPanel();
            cboKhungGio = new ComboBox();
            lblSoLuong = new Label();
            lblTamTinh = new Label();
            btnXacNhan = new Button();
            btnHuyAll = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // flpSoDo
            // 
            flpSoDo.BorderStyle = BorderStyle.FixedSingle;
            flpSoDo.Location = new Point(12, 12);
            flpSoDo.Name = "flpSoDo";
            flpSoDo.Size = new Size(439, 275);
            flpSoDo.TabIndex = 0;
            // 
            // cboKhungGio
            // 
            cboKhungGio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhungGio.FormattingEnabled = true;
            cboKhungGio.Items.AddRange(new object[] { "Sáng (100.000đ)", "Tối (150.000đ)" });
            cboKhungGio.Location = new Point(98, 312);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(151, 28);
            cboKhungGio.TabIndex = 1;
            cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(275, 320);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(148, 20);
            lblSoLuong.TabIndex = 0;
            lblSoLuong.Text = "Số vị trí đang chọn: 0";
            // 
            // lblTamTinh
            // 
            lblTamTinh.AutoSize = true;
            lblTamTinh.Location = new Point(277, 352);
            lblTamTinh.Name = "lblTamTinh";
            lblTamTinh.Size = new Size(146, 20);
            lblTamTinh.TabIndex = 2;
            lblTamTinh.Text = "Tạm tính tiền: 0 VNĐ";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(82, 388);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "Xác nhận đặt";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuyAll
            // 
            btnHuyAll.Location = new Point(291, 388);
            btnHuyAll.Name = "btnHuyAll";
            btnHuyAll.Size = new Size(94, 29);
            btnHuyAll.TabIndex = 4;
            btnHuyAll.Text = "Hủy chọn tất cả";
            btnHuyAll.UseVisualStyleBackColor = true;
            btnHuyAll.Click += btnHuyAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 315);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 5;
            label1.Text = "Khung giờ:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 450);
            Controls.Add(label1);
            Controls.Add(btnHuyAll);
            Controls.Add(btnXacNhan);
            Controls.Add(lblTamTinh);
            Controls.Add(lblSoLuong);
            Controls.Add(cboKhungGio);
            Controls.Add(flpSoDo);
            Name = "Form1";
            Text = "Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn hẹn giờ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpSoDo;
        private ComboBox cboKhungGio;
        private Label lblSoLuong;
        private Label lblTamTinh;
        private Button btnXacNhan;
        private Button btnHuyAll;
        private Label label1;
    }
}
