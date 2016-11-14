using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTinBao
{
    public partial class Chuye : UserControl
    {
        public event EventHandler Save;
        public event EventHandler Add;

        public Chuye()
        {
            InitializeComponent();
        }

        private void barButtonItem_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EventHandler handler = Save;
            if (handler != null) handler(this, e);
        }
    }
}
