namespace quan_ly_thu_vien
{
    partial class frmtimkiemsachtruyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtimkiemsachtruyen));
            this.cboNXB = new System.Windows.Forms.ComboBox();
            this.cboTheloai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.btndong = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNXB
            // 
            this.cboNXB.BackColor = System.Drawing.SystemColors.Info;
            this.cboNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(294, 484);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(190, 37);
            this.cboNXB.TabIndex = 28;
//            this.cboNXB.SelectedIndexChanged += new System.EventHandler(this.cboNXB_SelectedIndexChanged);
            // 
            // cboTheloai
            // 
            this.cboTheloai.BackColor = System.Drawing.SystemColors.Info;
            this.cboTheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTheloai.FormattingEnabled = true;
            this.cboTheloai.ItemHeight = 29;
            this.cboTheloai.Location = new System.Drawing.Point(294, 332);
            this.cboTheloai.MaxLength = 50;
            this.cboTheloai.Name = "cboTheloai";
            this.cboTheloai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboTheloai.Size = new System.Drawing.Size(190, 37);
            this.cboTheloai.TabIndex = 26;
            this.cboTheloai.UseWaitCursor = true;
//            this.cboTheloai.SelectedIndexChanged += new System.EventHandler(this.cboTheloai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(181, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 40);
            this.label5.TabIndex = 25;
            this.label5.Text = "NXB";
//            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(125, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 40);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên sách";
//            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txttensach
            // 
            this.txttensach.BackColor = System.Drawing.SystemColors.Info;
            this.txttensach.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttensach.Location = new System.Drawing.Point(294, 257);
            this.txttensach.Multiline = true;
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(190, 39);
            this.txttensach.TabIndex = 21;
//            this.txttensach.TextChanged += new System.EventHandler(this.txttensach_TextChanged);
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Image = ((System.Drawing.Image)(resources.GetObject("btndong.Image")));
            this.btndong.Location = new System.Drawing.Point(1124, 449);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(154, 58);
            this.btndong.TabIndex = 20;
            this.btndong.Text = "Cancel";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimlai.Image = ((System.Drawing.Image)(resources.GetObject("btntimlai.Image")));
            this.btntimlai.Location = new System.Drawing.Point(1124, 359);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(154, 58);
            this.btntimlai.TabIndex = 19;
            this.btntimlai.Text = "Refresh";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click_1);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(1124, 275);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(154, 58);
            this.btntimkiem.TabIndex = 18;
            this.btntimkiem.Text = "Search";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(333, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 88);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tìm kiếm sách truyện";
//            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(495, 229);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(623, 318);
            this.DataGridView.TabIndex = 16;
//            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Thể loại";
//            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmtimkiemsachtruyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 647);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboNXB);
            this.Controls.Add(this.cboTheloai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmtimkiemsachtruyen";
            this.Text = "Tìm kiếm sách truyện";
            this.Load += new System.EventHandler(this.frmtimkiemsachtruyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNXB;
        private System.Windows.Forms.ComboBox cboTheloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label6;
    }
}