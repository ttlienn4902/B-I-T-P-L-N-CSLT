using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quan_ly_thu_vien
{
    public partial class HoSoTra : Form
    {
        public HoSoTra()
        {
            InitializeComponent();
        }
        DataTable tbltrasach;


        private void dgridtrasach_Click(object sender, EventArgs e)
        {

            if (btntra.Enabled == false)
            {
                demngay();
                tinhtienthanhtoan();
                double dgt, tphat, thanhtien, songay;
                double sttt, tt, tu;
                dgt = Convert.ToDouble(txtdongiathue.Text);
                tphat = Convert.ToDouble(txttienphat.Text);
                songay = Convert.ToDouble(txtsongaythue.Text);
                
                tt= Convert.ToDouble(txttongtien.Text);
                tu= Convert.ToDouble(txtTAMUNG.Text);
                thanhtien = dgt * songay + tphat;
                sttt = tt - tu;
                txtthanhtien.Text = thanhtien.ToString();
                txtSoTienThanhToan.Text = sttt.ToString();
            }

        }
       
        private void cbomavipham_SelectedIndexChanged(object sender, EventArgs e)
        {
        txttienphat.Text = Functions.GetFieldValues("select Tienphat from Vipham where MaViPham=N'" + cbomavipham.SelectedValue + "'");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                txtTAMUNG.Text=Functions.GetFieldValues("select tamung from hosomuon where mahsm=N'" + cboMahsm.SelectedValue + "'");
        }
    

   

    private void demngay()
        {

            DateTime thue = new DateTime();
            thue = Convert.ToDateTime(txtngaythue.Text);
            DateTime tra = new DateTime();
            tra = Convert.ToDateTime(txtngaytra.Text);
            TimeSpan songay = tra - thue;
            int sn = songay.Days;
            txtsongaythue.Text = Convert.ToString(sn);
        }
        private void tinhtienthanhtoan()
        {
            double TONGTIEN = new double();
            TONGTIEN=Convert.ToDouble(txttongtien.Text);
            double TAMUNG = new double();
            TAMUNG= Convert.ToDouble(txtTAMUNG.Text);
            double Sotienthanhtoan = TONGTIEN - TAMUNG;
           txtSoTienThanhToan.Text = Convert.ToString(Sotienthanhtoan);
        }

        

       
        private void txtngaytra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                demngay();
            }
        }

    }
}
    

