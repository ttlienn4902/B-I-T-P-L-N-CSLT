namespace quan_ly_thu_vien
{
    partial class frmtimkiemthuthu
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
            this.dataGridViewthuthu = new System.Windows.Forms.DataGridView();
            this.txttenthuthu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntimkiem1 = new System.Windows.Forms.Button();
            this.btnthoat1 = new System.Windows.Forms.Button();
            this.btnTimlai1 = new System.Windows.Forms.Button();
            this.ckbhsma = new System.Windows.Forms.CheckBox();
            this.ckbhsme = new System.Windows.Forms.CheckBox();
            this.ckbhsmd = new System.Windows.Forms.CheckBox();
            this.ckbhsmc = new System.Windows.Forms.CheckBox();
            this.ckbhsmb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthuthu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewthuthu
            // 
            this.dataGridViewthuthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewthuthu.Location = new System.Drawing.Point(385, 40);
            this.dataGridViewthuthu.Name = "dataGridViewthuthu";
            this.dataGridViewthuthu.RowHeadersWidth = 51;
            this.dataGridViewthuthu.RowTemplate.Height = 24;
            this.dataGridViewthuthu.Size = new System.Drawing.Size(403, 398);
            this.dataGridViewthuthu.TabIndex = 0;
            this.dataGridViewthuthu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewthuthu_CellContentClick);
            this.dataGridViewthuthu.Click += new System.EventHandler(this.dataGridViewthuthu_Click);
            // 
            // txttenthuthu
            // 
            this.txttenthuthu.Location = new System.Drawing.Point(154, 40);
            this.txttenthuthu.Name = "txttenthuthu";
            this.txttenthuthu.Size = new System.Drawing.Size(100, 22);
            this.txttenthuthu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên thủ thư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "hồ sơ cho mượn sách";
            // 
            // btntimkiem1
            // 
            this.btntimkiem1.Location = new System.Drawing.Point(39, 401);
            this.btntimkiem1.Name = "btntimkiem1";
            this.btntimkiem1.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem1.TabIndex = 5;
            this.btntimkiem1.Text = "Tìm kiếm";
            this.btntimkiem1.UseVisualStyleBackColor = true;
            this.btntimkiem1.Click += new System.EventHandler(this.btntimkiem1_Click);
            // 
            // btnthoat1
            // 
            this.btnthoat1.Location = new System.Drawing.Point(281, 401);
            this.btnthoat1.Name = "btnthoat1";
            this.btnthoat1.Size = new System.Drawing.Size(75, 23);
            this.btnthoat1.TabIndex = 10;
            this.btnthoat1.Text = "Đóng";
            this.btnthoat1.UseVisualStyleBackColor = true;
            this.btnthoat1.Click += new System.EventHandler(this.btnthoat1_Click);
            // 
            // btnTimlai1
            // 
            this.btnTimlai1.Location = new System.Drawing.Point(154, 401);
            this.btnTimlai1.Name = "btnTimlai1";
            this.btnTimlai1.Size = new System.Drawing.Size(75, 23);
            this.btnTimlai1.TabIndex = 11;
            this.btnTimlai1.Text = "Tìm lại";
            this.btnTimlai1.UseVisualStyleBackColor = true;
            this.btnTimlai1.Click += new System.EventHandler(this.btnTimlai1_Click);
            // 
            // ckbhsma
            // 
            this.ckbhsma.AutoSize = true;
            this.ckbhsma.Location = new System.Drawing.Point(225, 96);
            this.ckbhsma.Name = "ckbhsma";
            this.ckbhsma.Size = new System.Drawing.Size(68, 20);
            this.ckbhsma.TabIndex = 12;
            this.ckbhsma.Text = "HSMA";
            this.ckbhsma.UseVisualStyleBackColor = true;
            this.ckbhsma.CheckedChanged += new System.EventHandler(this.ckbhsma_CheckedChanged);
            // 
            // ckbhsme
            // 
            this.ckbhsme.AutoSize = true;
            this.ckbhsme.Location = new System.Drawing.Point(226, 260);
            this.ckbhsme.Name = "ckbhsme";
            this.ckbhsme.Size = new System.Drawing.Size(68, 20);
            this.ckbhsme.TabIndex = 13;
            this.ckbhsme.Text = "HSME";
            this.ckbhsme.UseVisualStyleBackColor = true;
            // 
            // ckbhsmd
            // 
            this.ckbhsmd.AutoSize = true;
            this.ckbhsmd.Location = new System.Drawing.Point(225, 215);
            this.ckbhsmd.Name = "ckbhsmd";
            this.ckbhsmd.Size = new System.Drawing.Size(69, 20);
            this.ckbhsmd.TabIndex = 14;
            this.ckbhsmd.Text = "HSMD";
            this.ckbhsmd.UseVisualStyleBackColor = true;
            // 
            // ckbhsmc
            // 
            this.ckbhsmc.AutoSize = true;
            this.ckbhsmc.Location = new System.Drawing.Point(225, 174);
            this.ckbhsmc.Name = "ckbhsmc";
            this.ckbhsmc.Size = new System.Drawing.Size(68, 20);
            this.ckbhsmc.TabIndex = 15;
            this.ckbhsmc.Text = "HSMC";
            this.ckbhsmc.UseVisualStyleBackColor = true;
            // 
            // ckbhsmb
            // 
            this.ckbhsmb.AutoSize = true;
            this.ckbhsmb.Location = new System.Drawing.Point(225, 133);
            this.ckbhsmb.Name = "ckbhsmb";
            this.ckbhsmb.Size = new System.Drawing.Size(68, 20);
            this.ckbhsmb.TabIndex = 16;
            this.ckbhsmb.Text = "HSMB";
            this.ckbhsmb.UseVisualStyleBackColor = true;
            // 
            // frmtimkiemthuthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbhsmb);
            this.Controls.Add(this.ckbhsmc);
            this.Controls.Add(this.ckbhsmd);
            this.Controls.Add(this.ckbhsme);
            this.Controls.Add(this.ckbhsma);
            this.Controls.Add(this.btnTimlai1);
            this.Controls.Add(this.btnthoat1);
            this.Controls.Add(this.btntimkiem1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenthuthu);
            this.Controls.Add(this.dataGridViewthuthu);
            this.Name = "frmtimkiemthuthu";
            this.Text = "frmtimkiemthuthu";
            this.Load += new System.EventHandler(this.frmtimkiemthuthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthuthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewthuthu;
        private System.Windows.Forms.TextBox txttenthuthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntimkiem1;
        private System.Windows.Forms.Button btnthoat1;
        private System.Windows.Forms.Button btnTimlai1;
        private System.Windows.Forms.CheckBox ckbhsma;
        private System.Windows.Forms.CheckBox ckbhsme;
        private System.Windows.Forms.CheckBox ckbhsmd;
        private System.Windows.Forms.CheckBox ckbhsmc;
        private System.Windows.Forms.CheckBox ckbhsmb;
    }
}