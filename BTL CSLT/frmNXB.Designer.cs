namespace quan_ly_thu_vien
{
    partial class frmNXB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTenNXB5 = new System.Windows.Forms.TextBox();
            this.txtDiaChi5 = new System.Windows.Forms.TextBox();
            this.txtMail5 = new System.Windows.Forms.TextBox();
            this.nxbDong = new System.Windows.Forms.Button();
            this.nxbBoQua = new System.Windows.Forms.Button();
            this.nxbLuu = new System.Windows.Forms.Button();
            this.nxbSua = new System.Windows.Forms.Button();
            this.nxbXoa = new System.Windows.Forms.Button();
            this.nxbThem = new System.Windows.Forms.Button();
            this.nxbDataGrid = new System.Windows.Forms.DataGridView();
            this.txtMaNXB5 = new System.Windows.Forms.TextBox();
            this.txtEmail5 = new System.Windows.Forms.Label();
            this.nxbDienThoai = new System.Windows.Forms.Label();
            this.nxbDiaChi = new System.Windows.Forms.Label();
            this.nxbTenNXB = new System.Windows.Forms.Label();
            this.nxbMaNXB = new System.Windows.Forms.Label();
            this.maskedDienthoai = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nxbDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNXB5
            // 
            this.txtTenNXB5.Location = new System.Drawing.Point(174, 107);
            this.txtTenNXB5.Name = "txtTenNXB5";
            this.txtTenNXB5.Size = new System.Drawing.Size(175, 22);
            this.txtTenNXB5.TabIndex = 46;
            this.txtTenNXB5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenNXB5_KeyUp);
            // 
            // txtDiaChi5
            // 
            this.txtDiaChi5.Location = new System.Drawing.Point(174, 150);
            this.txtDiaChi5.Name = "txtDiaChi5";
            this.txtDiaChi5.Size = new System.Drawing.Size(175, 22);
            this.txtDiaChi5.TabIndex = 45;
            this.txtDiaChi5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiaChi5_KeyUp);
            // 
            // txtMail5
            // 
            this.txtMail5.Location = new System.Drawing.Point(174, 240);
            this.txtMail5.Name = "txtMail5";
            this.txtMail5.Size = new System.Drawing.Size(175, 22);
            this.txtMail5.TabIndex = 43;
            this.txtMail5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMail5_KeyUp);
            // 
            // nxbDong
            // 
            this.nxbDong.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbDong.Location = new System.Drawing.Point(674, 394);
            this.nxbDong.Name = "nxbDong";
            this.nxbDong.Size = new System.Drawing.Size(91, 44);
            this.nxbDong.TabIndex = 42;
            this.nxbDong.Text = "Đóng";
            this.nxbDong.UseVisualStyleBackColor = true;
            this.nxbDong.Click += new System.EventHandler(this.nxbDong_Click);
            // 
            // nxbBoQua
            // 
            this.nxbBoQua.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbBoQua.Location = new System.Drawing.Point(545, 394);
            this.nxbBoQua.Name = "nxbBoQua";
            this.nxbBoQua.Size = new System.Drawing.Size(91, 44);
            this.nxbBoQua.TabIndex = 41;
            this.nxbBoQua.Text = "Bỏ qua";
            this.nxbBoQua.UseVisualStyleBackColor = true;
            this.nxbBoQua.Click += new System.EventHandler(this.nxbBoQua_Click);
            // 
            // nxbLuu
            // 
            this.nxbLuu.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbLuu.Location = new System.Drawing.Point(408, 394);
            this.nxbLuu.Name = "nxbLuu";
            this.nxbLuu.Size = new System.Drawing.Size(91, 44);
            this.nxbLuu.TabIndex = 40;
            this.nxbLuu.Text = "Lưu";
            this.nxbLuu.UseVisualStyleBackColor = true;
            this.nxbLuu.Click += new System.EventHandler(this.nxbLuu_Click);
            // 
            // nxbSua
            // 
            this.nxbSua.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbSua.Location = new System.Drawing.Point(282, 394);
            this.nxbSua.Name = "nxbSua";
            this.nxbSua.Size = new System.Drawing.Size(91, 44);
            this.nxbSua.TabIndex = 39;
            this.nxbSua.Text = "Sửa";
            this.nxbSua.UseVisualStyleBackColor = true;
            this.nxbSua.Click += new System.EventHandler(this.nxbSua_Click);
            // 
            // nxbXoa
            // 
            this.nxbXoa.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbXoa.Location = new System.Drawing.Point(163, 394);
            this.nxbXoa.Name = "nxbXoa";
            this.nxbXoa.Size = new System.Drawing.Size(91, 44);
            this.nxbXoa.TabIndex = 38;
            this.nxbXoa.Text = "Xoá";
            this.nxbXoa.UseVisualStyleBackColor = true;
            this.nxbXoa.Click += new System.EventHandler(this.nxbXoa_Click);
            // 
            // nxbThem
            // 
            this.nxbThem.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbThem.Location = new System.Drawing.Point(40, 394);
            this.nxbThem.Name = "nxbThem";
            this.nxbThem.Size = new System.Drawing.Size(91, 44);
            this.nxbThem.TabIndex = 37;
            this.nxbThem.Text = "Thêm";
            this.nxbThem.UseVisualStyleBackColor = true;
            this.nxbThem.Click += new System.EventHandler(this.nxbThem_Click);
            // 
            // nxbDataGrid
            // 
            this.nxbDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nxbDataGrid.Location = new System.Drawing.Point(367, 12);
            this.nxbDataGrid.Name = "nxbDataGrid";
            this.nxbDataGrid.RowHeadersWidth = 51;
            this.nxbDataGrid.RowTemplate.Height = 24;
            this.nxbDataGrid.Size = new System.Drawing.Size(421, 376);
            this.nxbDataGrid.TabIndex = 36;
            this.nxbDataGrid.Click += new System.EventHandler(this.nxbDataGrid_Click);
            // 
            // txtMaNXB5
            // 
            this.txtMaNXB5.Location = new System.Drawing.Point(174, 57);
            this.txtMaNXB5.Name = "txtMaNXB5";
            this.txtMaNXB5.Size = new System.Drawing.Size(175, 22);
            this.txtMaNXB5.TabIndex = 35;
            this.txtMaNXB5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaNXB5_KeyUp);
            // 
            // txtEmail5
            // 
            this.txtEmail5.AutoSize = true;
            this.txtEmail5.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtEmail5.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail5.Location = new System.Drawing.Point(53, 236);
            this.txtEmail5.Name = "txtEmail5";
            this.txtEmail5.Size = new System.Drawing.Size(57, 30);
            this.txtEmail5.TabIndex = 34;
            this.txtEmail5.Text = "Email";
            // 
            // nxbDienThoai
            // 
            this.nxbDienThoai.AutoSize = true;
            this.nxbDienThoai.BackColor = System.Drawing.Color.PapayaWhip;
            this.nxbDienThoai.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbDienThoai.Location = new System.Drawing.Point(53, 188);
            this.nxbDienThoai.Name = "nxbDienThoai";
            this.nxbDienThoai.Size = new System.Drawing.Size(92, 30);
            this.nxbDienThoai.TabIndex = 33;
            this.nxbDienThoai.Text = "Điện thoại";
            // 
            // nxbDiaChi
            // 
            this.nxbDiaChi.AutoSize = true;
            this.nxbDiaChi.BackColor = System.Drawing.Color.PapayaWhip;
            this.nxbDiaChi.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbDiaChi.Location = new System.Drawing.Point(53, 146);
            this.nxbDiaChi.Name = "nxbDiaChi";
            this.nxbDiaChi.Size = new System.Drawing.Size(66, 30);
            this.nxbDiaChi.TabIndex = 32;
            this.nxbDiaChi.Text = "Địa chỉ";
            // 
            // nxbTenNXB
            // 
            this.nxbTenNXB.AutoSize = true;
            this.nxbTenNXB.BackColor = System.Drawing.Color.PapayaWhip;
            this.nxbTenNXB.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbTenNXB.Location = new System.Drawing.Point(53, 103);
            this.nxbTenNXB.Name = "nxbTenNXB";
            this.nxbTenNXB.Size = new System.Drawing.Size(78, 30);
            this.nxbTenNXB.TabIndex = 31;
            this.nxbTenNXB.Text = "Tên NXB";
            // 
            // nxbMaNXB
            // 
            this.nxbMaNXB.AutoSize = true;
            this.nxbMaNXB.BackColor = System.Drawing.Color.PapayaWhip;
            this.nxbMaNXB.Font = new System.Drawing.Font("iCiel Mijas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxbMaNXB.Location = new System.Drawing.Point(53, 57);
            this.nxbMaNXB.Name = "nxbMaNXB";
            this.nxbMaNXB.Size = new System.Drawing.Size(75, 30);
            this.nxbMaNXB.TabIndex = 30;
            this.nxbMaNXB.Text = "Mã NXB";
            // 
            // maskedDienthoai
            // 
            this.maskedDienthoai.Location = new System.Drawing.Point(174, 192);
            this.maskedDienthoai.Name = "maskedDienthoai";
            this.maskedDienthoai.Size = new System.Drawing.Size(175, 22);
            this.maskedDienthoai.TabIndex = 47;
            // 
            // frmNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedDienthoai);
            this.Controls.Add(this.txtTenNXB5);
            this.Controls.Add(this.txtDiaChi5);
            this.Controls.Add(this.txtMail5);
            this.Controls.Add(this.nxbDong);
            this.Controls.Add(this.nxbBoQua);
            this.Controls.Add(this.nxbLuu);
            this.Controls.Add(this.nxbSua);
            this.Controls.Add(this.nxbXoa);
            this.Controls.Add(this.nxbThem);
            this.Controls.Add(this.nxbDataGrid);
            this.Controls.Add(this.txtMaNXB5);
            this.Controls.Add(this.txtEmail5);
            this.Controls.Add(this.nxbDienThoai);
            this.Controls.Add(this.nxbDiaChi);
            this.Controls.Add(this.nxbTenNXB);
            this.Controls.Add(this.nxbMaNXB);
            this.Name = "frmNXB";
            this.Text = "Nhà xuất bản";
            this.Load += new System.EventHandler(this.frmNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nxbDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNXB5;
        private System.Windows.Forms.TextBox txtDiaChi5;
        private System.Windows.Forms.TextBox txtMail5;
        private System.Windows.Forms.Button nxbDong;
        private System.Windows.Forms.Button nxbBoQua;
        private System.Windows.Forms.Button nxbLuu;
        private System.Windows.Forms.Button nxbSua;
        private System.Windows.Forms.Button nxbXoa;
        private System.Windows.Forms.Button nxbThem;
        private System.Windows.Forms.DataGridView nxbDataGrid;
        private System.Windows.Forms.TextBox txtMaNXB5;
        private System.Windows.Forms.Label txtEmail5;
        private System.Windows.Forms.Label nxbDienThoai;
        private System.Windows.Forms.Label nxbDiaChi;
        private System.Windows.Forms.Label nxbTenNXB;
        private System.Windows.Forms.Label nxbMaNXB;
        private System.Windows.Forms.MaskedTextBox maskedDienthoai;
    }
}