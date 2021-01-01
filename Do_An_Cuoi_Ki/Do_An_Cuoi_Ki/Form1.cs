using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Cuoi_Ki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hideOnPanelForm()
        {
            panelTitle.Visible = false;
            picTongQuan.Visible = false;
        }
        private void showOnPanelForm()
        {
            panelTitle.Visible = true;
            picTongQuan.Visible = true;
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            if(panelAccount.Visible == true)
                panelAccount.Visible = false;
            else
                panelAccount.Visible = true;
        }
        private Form activeForm = null;
        private void openChildForm(Form chidlForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = chidlForm;
            chidlForm.TopLevel = false;
            chidlForm.FormBorderStyle = FormBorderStyle.None;
            chidlForm.Dock = DockStyle.Fill;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(chidlForm);
            panelChildForm.Tag = chidlForm;
            chidlForm.BringToFront();
            chidlForm.Show();   
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            openChildForm(new fbanHang());
            panelMenu.Visible = false;
            hideOnPanelForm();
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            showOnPanelForm();
            panelMenu.Visible = true;
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            openChildForm(new fDonHang());
            panelMenu.Visible = true;
            hideOnPanelForm();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new fKhachHang());
            panelMenu.Visible = true;
            hideOnPanelForm();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new fSanPham());
            panelMenu.Visible = true;
            hideOnPanelForm();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            openChildForm(new fBaoCao());
            panelMenu.Visible = true;
            hideOnPanelForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            fHoSo fHS = new fHoSo();
            fHS.Show();
        }
    }
}
