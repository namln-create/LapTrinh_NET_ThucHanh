namespace Bai3_Item_List_Manager
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
            txtMaVT = new TextBox();
            txtTenVT = new TextBox();
            cboDVT = new ComboBox();
            txtDonGia = new TextBox();
            groupBox1 = new GroupBox();
            btnXoaAll = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lsvVatTu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(103, 25);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(223, 27);
            txtMaVT.TabIndex = 0;
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(103, 68);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(223, 27);
            txtTenVT.TabIndex = 1;
            // 
            // cboDVT
            // 
            cboDVT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDVT.FormattingEnabled = true;
            cboDVT.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDVT.Location = new Point(103, 113);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new Size(223, 28);
            cboDVT.TabIndex = 2;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(103, 153);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(223, 27);
            txtDonGia.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaAll);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboDVT);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtMaVT);
            groupBox1.Controls.Add(txtTenVT);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 304);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập liệu";
            // 
            // btnXoaAll
            // 
            btnXoaAll.Location = new Point(232, 267);
            btnXoaAll.Name = "btnXoaAll";
            btnXoaAll.Size = new Size(94, 29);
            btnXoaAll.TabIndex = 10;
            btnXoaAll.Text = "Xóa hết";
            btnXoaAll.UseVisualStyleBackColor = true;
            btnXoaAll.Click += btnXoaAll_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(60, 267);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(232, 215);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 8;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(60, 215);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 160);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 121);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "ĐVT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 75);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên VT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã VT:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvVatTu);
            groupBox2.Location = new Point(370, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 304);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // lsvVatTu
            // 
            lsvVatTu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvVatTu.Dock = DockStyle.Fill;
            lsvVatTu.FullRowSelect = true;
            lsvVatTu.GridLines = true;
            lsvVatTu.Location = new Point(3, 23);
            lsvVatTu.Name = "lsvVatTu";
            lsvVatTu.Size = new Size(452, 278);
            lsvVatTu.TabIndex = 0;
            lsvVatTu.UseCompatibleStateImageBehavior = false;
            lsvVatTu.View = View.Details;
            lsvVatTu.SelectedIndexChanged += lsvVatTu_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã VT";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên VT";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ĐVT";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Đơn giá";
            columnHeader4.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 326);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản lý danh mục Vật tư / Linh kiện";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMaVT;
        private TextBox txtTenVT;
        private ComboBox cboDVT;
        private TextBox txtDonGia;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnXoaAll;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private ListView lsvVatTu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
