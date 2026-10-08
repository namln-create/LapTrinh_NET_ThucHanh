namespace Bai2_IT_Support_Ticket_Form
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
            txtMaPhieu = new TextBox();
            txtNguoiYeuCau = new TextBox();
            dtpNgayGhiNhan = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radKhanCap = new RadioButton();
            radTrungBinh = new RadioButton();
            radThap = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnTaiAnh = new Button();
            picAnhLoi = new PictureBox();
            groupBox4 = new GroupBox();
            chkDienThoai = new CheckBox();
            chkLaptop = new CheckBox();
            chkMayIn = new CheckBox();
            chkPC = new CheckBox();
            label4 = new Label();
            cboLoaiSuCo = new ComboBox();
            btnGuiYeuCau = new Button();
            btnNhapLai = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(120, 66);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(250, 27);
            txtMaPhieu.TabIndex = 0;
            // 
            // txtNguoiYeuCau
            // 
            txtNguoiYeuCau.Location = new Point(120, 28);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(250, 27);
            txtNguoiYeuCau.TabIndex = 1;
            // 
            // dtpNgayGhiNhan
            // 
            dtpNgayGhiNhan.Format = DateTimePickerFormat.Short;
            dtpNgayGhiNhan.Location = new Point(120, 107);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(250, 27);
            dtpNgayGhiNhan.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Controls.Add(txtNguoiYeuCau);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpNgayGhiNhan);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 164);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radKhanCap);
            groupBox2.Controls.Add(radTrungBinh);
            groupBox2.Controls.Add(radThap);
            groupBox2.Location = new Point(468, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 122);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mức độ ưu tiên";
            // 
            // radKhanCap
            // 
            radKhanCap.AutoSize = true;
            radKhanCap.Location = new Point(6, 87);
            radKhanCap.Name = "radKhanCap";
            radKhanCap.Size = new Size(91, 24);
            radKhanCap.TabIndex = 2;
            radKhanCap.TabStop = true;
            radKhanCap.Text = "Khẩn cấp";
            radKhanCap.UseVisualStyleBackColor = true;
            // 
            // radTrungBinh
            // 
            radTrungBinh.AutoSize = true;
            radTrungBinh.Location = new Point(6, 57);
            radTrungBinh.Name = "radTrungBinh";
            radTrungBinh.Size = new Size(100, 24);
            radTrungBinh.TabIndex = 1;
            radTrungBinh.TabStop = true;
            radTrungBinh.Text = "Trung bình";
            radTrungBinh.UseVisualStyleBackColor = true;
            // 
            // radThap
            // 
            radThap.AutoSize = true;
            radThap.Location = new Point(6, 26);
            radThap.Name = "radThap";
            radThap.Size = new Size(63, 24);
            radThap.TabIndex = 0;
            radThap.TabStop = true;
            radThap.Text = "Thấp";
            radThap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 5;
            label2.Text = "Người yêu cầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 6;
            label3.Text = "Ngày ghi nhận:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 69);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã phiếu:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTaiAnh);
            groupBox3.Controls.Add(picAnhLoi);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cboLoaiSuCo);
            groupBox3.Location = new Point(6, 170);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(791, 224);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Phân loại sự cố";
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(575, 177);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(94, 29);
            btnTaiAnh.TabIndex = 4;
            btnTaiAnh.Text = "Tải ảnh lỗi";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            // 
            // picAnhLoi
            // 
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
            picAnhLoi.Location = new Point(468, 34);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(303, 137);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 3;
            picAnhLoi.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(chkDienThoai);
            groupBox4.Controls.Add(chkLaptop);
            groupBox4.Controls.Add(chkMayIn);
            groupBox4.Controls.Add(chkPC);
            groupBox4.Location = new Point(6, 65);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(358, 106);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thiết bị ảnh hưởng";
            // 
            // chkDienThoai
            // 
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(208, 60);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(100, 24);
            chkDienThoai.TabIndex = 3;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(42, 60);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 2;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(208, 30);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(75, 24);
            chkMayIn.TabIndex = 1;
            chkMayIn.Text = "Máy In";
            chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkPC
            // 
            chkPC.AutoSize = true;
            chkPC.BackColor = SystemColors.Control;
            chkPC.Location = new Point(42, 30);
            chkPC.Name = "chkPC";
            chkPC.Size = new Size(48, 24);
            chkPC.TabIndex = 0;
            chkPC.Text = "PC";
            chkPC.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 34);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 1;
            label4.Text = "Loại sự cố:";
            // 
            // cboLoaiSuCo
            // 
            cboLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSuCo.FormattingEnabled = true;
            cboLoaiSuCo.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cboLoaiSuCo.Location = new Point(114, 31);
            cboLoaiSuCo.Name = "cboLoaiSuCo";
            cboLoaiSuCo.Size = new Size(250, 28);
            cboLoaiSuCo.TabIndex = 0;
            // 
            // btnGuiYeuCau
            // 
            btnGuiYeuCau.BackColor = SystemColors.Window;
            btnGuiYeuCau.Location = new Point(226, 400);
            btnGuiYeuCau.Name = "btnGuiYeuCau";
            btnGuiYeuCau.Size = new Size(94, 29);
            btnGuiYeuCau.TabIndex = 5;
            btnGuiYeuCau.Text = "Gửi yêu cầu";
            btnGuiYeuCau.UseVisualStyleBackColor = false;
            btnGuiYeuCau.Click += btnGuiYeuCau_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(443, 400);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(94, 29);
            btnNhapLai.TabIndex = 6;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNhapLai);
            Controls.Add(btnGuiYeuCau);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân loại sự cố IT";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMaPhieu;
        private TextBox txtNguoiYeuCau;
        private DateTimePicker dtpNgayGhiNhan;
        private GroupBox groupBox1;
        private RadioButton radKhanCap;
        private RadioButton radTrungBinh;
        private RadioButton radThap;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckBox chkDienThoai;
        private CheckBox chkLaptop;
        private CheckBox chkMayIn;
        private CheckBox chkPC;
        private Label label4;
        private ComboBox cboLoaiSuCo;
        private Button btnTaiAnh;
        private PictureBox picAnhLoi;
        private Button btnGuiYeuCau;
        private Button btnNhapLai;
    }
}
