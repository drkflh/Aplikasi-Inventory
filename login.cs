using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Aplikasi_Inventory
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buat koneksi dengan database
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Tugas Stematel XI\Tugas Proyek\inventory\Bngkl.accdb");
            //Membuat Oled adapter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from login where username='" + textBox1.Text + "' and password ='" + textBox2.Text + "'", con);
            //Membuat tabel data
            DataTable dt = new DataTable();
            //fill datatable
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Form1 f2 = new Form1();
                f2.Show();
            }
            else
            {
                //jika salah akan muncul
                MessageBox.Show(" kesalahan username/password ");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
