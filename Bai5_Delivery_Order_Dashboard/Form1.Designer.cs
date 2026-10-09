namespace Bai5_Delivery_Order_Dashboard
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblThoiGian = new ToolStripStatusLabel();
            lblTongSoLuong = new ToolStripStatusLabel();
            lblTongTrongLuong = new ToolStripStatusLabel();
            lblTongTien = new ToolStripStatusLabel();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            cboLoaiVC = new ComboBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvHangHoa = new DataGridView();
            TenHang = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            TrongLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            statusStrip1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThoiGian, lblTongSoLuong, lblTongTrongLuong, lblTongTien });
            statusStrip1.Location = new Point(0, 286);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1108, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(72, 20);
            lblThoiGian.Text = "Thời Gian";
            // 
            // lblTongSoLuong
            // 
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Size = new Size(110, 20);
            lblTongSoLuong.Text = "Tổng Số Lượng";
            // 
            // lblTongTrongLuong
            // 
            lblTongTrongLuong.Name = "lblTongTrongLuong";
            lblTongTrongLuong.Size = new Size(131, 20);
            lblTongTrongLuong.Text = "Tổng Trọng Lượng";
            // 
            // lblTongTien
            // 
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(75, 20);
            lblTongTien.Text = "Tổng Tiền";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1100, 279);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Đơn hàng mới";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(cboLoaiVC);
            splitContainer1.Panel1.Controls.Add(txtSDT);
            splitContainer1.Panel1.Controls.Add(txtTenKH);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvHangHoa);
            splitContainer1.Size = new Size(1094, 273);
            splitContainer1.SplitterDistance = 548;
            splitContainer1.TabIndex = 0;
            // 
            // cboLoaiVC
            // 
            cboLoaiVC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiVC.FormattingEnabled = true;
            cboLoaiVC.Location = new Point(97, 162);
            cboLoaiVC.Name = "cboLoaiVC";
            cboLoaiVC.Size = new Size(295, 28);
            cboLoaiVC.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(97, 102);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(295, 27);
            txtSDT.TabIndex = 5;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(97, 39);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(295, 27);
            txtTenKH.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 170);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Loại VC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 105);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "SDT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 46);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên KH:";
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { TenHang, SoLuong, TrongLuong, DonGia, ThanhTien });
            dgvHangHoa.Dock = DockStyle.Fill;
            dgvHangHoa.Location = new Point(0, 0);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHangHoa.Size = new Size(542, 273);
            dgvHangHoa.TabIndex = 0;
            dgvHangHoa.CellValidating += dgvHangHoa_CellValidating;
            dgvHangHoa.CellValueChanged += dgvHangHoa_CellValueChanged;
            // 
            // TenHang
            // 
            TenHang.HeaderText = "Tên Hàng";
            TenHang.MinimumWidth = 6;
            TenHang.Name = "TenHang";
            TenHang.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 125;
            // 
            // TrongLuong
            // 
            TrongLuong.HeaderText = "Trọng Lượng";
            TrongLuong.MinimumWidth = 6;
            TrongLuong.Name = "TrongLuong";
            TrongLuong.Width = 125;
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.Width = 125;
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            ThanhTien.Width = 125;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1108, 312);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 312);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Quản lý Đơn giao hàng";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThoiGian;
        private ToolStripStatusLabel lblTongSoLuong;
        private ToolStripStatusLabel lblTongTrongLuong;
        private ToolStripStatusLabel lblTongTien;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private ComboBox cboLoaiVC;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvHangHoa;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn TrongLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private TabControl tabControl1;
    }
}
