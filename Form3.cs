using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace flysphere
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5N3OP8P" + "\\" + "SQLEXPRESS;Initial Catalog=FlySphere;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From login1 where email1= '" + textBox1.Text + "' and pass='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
            else
            {
                MessageBox.Show("Please Enter the correct User Email or Password");
            }
        }
    }
}
