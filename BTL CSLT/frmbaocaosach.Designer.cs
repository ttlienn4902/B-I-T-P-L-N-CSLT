namespace quan_ly_thu_vien
{
    partial class frmbaocaosachchuatra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnthoát = new System.Windows.Forms.Button();
            this.btninbaocao = new System.Windows.Forms.Button();
            this.dataGridViewbcsach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbcsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "năm";
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(158, 18);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(100, 22);
            this.txtthang.TabIndex = 2;
            this.txtthang.TextChanged += new System.EventHandler(this.txtthang_TextChanged);
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(158, 67);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 22);
            this.txtnam.TabIndex = 3;
            // 
            // btnbaocao
            // 
            this.btnbaocao.Location = new System.Drawing.Point(81, 392);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(75, 23);
            this.btnbaocao.TabIndex = 4;
            this.btnbaocao.Text = "Báo cáo";
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(674, 392);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 5;
            this.btnboqua.Text = "bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnthoát
            // 
            this.btnthoát.Location = new System.Drawing.Point(449, 392);
            this.btnthoát.Name = "btnthoát";
            this.btnthoát.Size = new System.Drawing.Size(75, 23);
            this.btnthoát.TabIndex = 6;
            this.btnthoát.Text = "đóng";
            this.btnthoát.UseVisualStyleBackColor = true;
            this.btnthoát.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btninbaocao
            // 
            this.btninbaocao.Location = new System.Drawing.Point(247, 392);
            this.btninbaocao.Name = "btninbaocao";
            this.btninbaocao.Size = new System.Drawing.Size(108, 23);
            this.btninbaocao.TabIndex = 7;
            this.btninbaocao.Text = "in báo cáo";
            this.btninbaocao.UseVisualStyleBackColor = true;
            this.btninbaocao.Click += new System.EventHandler(this.btninbaocao_Click);
            // 
            // dataGridViewbcsach
            // 
            this.dataGridViewbcsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbcsach.Location = new System.Drawing.Point(12, 95);
            this.dataGridViewbcsach.Name = "dataGridViewbcsach";
            this.dataGridViewbcsach.RowHeadersWidth = 51;
            this.dataGridViewbcsach.RowTemplate.Height = 24;
            this.dataGridViewbcsach.Size = new System.Drawing.Size(776, 291);
            this.dataGridViewbcsach.TabIndex = 8;
            // 
            // frmbaocaosachchuatra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewbcsach);
            this.Controls.Add(this.btninbaocao);
            this.Controls.Add(this.btnthoát);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmbaocaosachchuatra";
            this.Text = "Báo cáo sách chưa trả";
            this.Load += new System.EventHandler(this.frmbaocaosach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbcsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Button btnbaocao;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnthoát;
        private System.Windows.Forms.Button btninbaocao;
        private System.Windows.Forms.DataGridView dataGridViewbcsach;
    }
}