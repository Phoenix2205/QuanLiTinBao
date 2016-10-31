using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTinBao
{
    public partial class FormQuanLi : MetroForm
    {
       // panelMain panel_main = null;
        Boolean isClosed=true;
        public FormQuanLi()
        {
            InitializeComponent();
            // panel_main = new panelMain(this);
            // panel_main.swipe();
            navframe_content_managment.SelectedPage = navigationPage1;
            
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (isClosed == true)
            {
                //panel_menu.Visible = true;
                icon_managment.Visible = false;
                isClosed = false;
            }
            else
            {
               // panel_menu.Visible = false;
                icon_managment.Visible = true;
                isClosed = true;
                
            }
        }

        private void icon_trangchu_Click(object sender, EventArgs e)
        {

        }

        private void icon_tinbao_Click(object sender, EventArgs e)
        {
            navframe_content_managment.SelectedPage = page_tinbao ;
        }

        private void icon_kt_Click(object sender, EventArgs e)
        {

        }

        private void icon_kkt_Click(object sender, EventArgs e)
        {

        }

        private void icon_hc_Click(object sender, EventArgs e)
        {

        }

        private void icon_ccq_Click(object sender, EventArgs e)
        {

        }

        private void icon_khac_Click(object sender, EventArgs e)
        {

        }

        private void icon_dangxuat_Click(object sender, EventArgs e)
        {

        }

        private void menu_tinbao_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {

        }

        private void btn_nghiepvu_Click(object sender, EventArgs e)
        {

        }

        private void dropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void FormQuanLi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTBDataSet2.TinBao' table. You can move, or remove it, as needed.
            this.tinBaoTableAdapter.Fill(this.qLTBDataSet2.TinBao);

        }
    }
}
