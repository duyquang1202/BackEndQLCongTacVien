using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCongTacVienClient
{
    public partial class FormDangNhap : Form
    {
        Process objPro;
        public static tblUser objUser=null;
        public FormDangNhap()
        {
            InitializeComponent();
            objPro = new Process();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {                
                var result = objPro.checkDangNhap(txtusername.Text, txtpassword.Text);
                if (result == null)
                {
                    MessageBox.Show("Username hoặc mật khẩu không đúng. Vui long thử lại!");
                    return;
                }
                objUser = result;
                MessageBox.Show("Bạn đã đăng nhập thành công!");
                FormMain frm = new FormMain();
                frm.Show();
                this.Hide();
                return;
            }
            catch (Exception objEx)
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng thử lại!");
                return;
            }
        }
    }
}
