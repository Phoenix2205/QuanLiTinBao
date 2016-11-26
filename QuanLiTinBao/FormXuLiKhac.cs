using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLiTinBao
{
    public partial class FormXuLiKhac : Form
    {
       
        
        public string SoQuyetDinh
        {
            get
            {
                return textBox_sqd.Text; 
            }
            set
            {
                textBox_sqd.Text = value;
            }
        }
        public string SoTinBao
        {
            get
            {
                return textBox_stb.Text;
            }
            set
            {
                textBox_stb.Text = value;
            }
        }
        public string CanBo
        {
            get
            {
                return textBox_canbo.Text;
            }
            set
            {
                textBox_canbo.Text = value;
            }
        }
        public string MaCanBo
        {
            get
            {
                return textBox_macb.Text;
            }
            set
            {
                textBox_macb.Text = value;
            }
        }
        public string NgayXL
        {
            get
            {
                return textBox_ngayxl.Text;
            }
            set
            {
                textBox_ngayxl.Text = value;
            }
        }
        public string NoiDung
        {
            get
            {
                return richTextBox_noidung.Text;
            }
            set
            {
                richTextBox_noidung.Text = value;
            }
        }
        private string connectionString= "Data Source=DESKTOP-7SQ7FOL;Initial Catalog=QLTB;Integrated Security=True";


        public FormXuLiKhac()
        {

            InitializeComponent();
           
            textBox_ngayxl.Enabled = false;
            textBox_canbo.Enabled = false;
            textBox_stb.Enabled = false;
            textBox_sqd.Enabled = false;
            textBox_macb.Enabled = false;
            textBox_macb.Text = "2132350";
            textBox_ngayxl.Text = DateTime.Now.ToString();
            
        }

        private void button_taoform_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO XuLyKhac (SoQuyetDinh, CanBo, NgayXuLy, SoTinBao, NoiDung) VALUES (@sqd, @mcb, @ngay, @tb, @noidung)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@sqd", SoQuyetDinh);
                    cmd.Parameters.AddWithValue("@mcb", MaCanBo);
                    cmd.Parameters.AddWithValue("@ngay", NgayXL);
                    cmd.Parameters.AddWithValue("@tb", SoTinBao);
                    cmd.Parameters.AddWithValue("@noidung", NoiDung);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    this.DialogResult = DialogResult.OK;

                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
