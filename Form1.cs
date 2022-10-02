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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5N3OP8P" + "\\" + "SQLEXPRESS;Initial Catalog=FlySphere;Integrated Security=True");
            conn.Open();
            MessageBox.Show("Data Inserted");
            SqlCommand cm;
            string id = textBox1.Text;
            string or = textBox2.Text;
            
            string query = "Insert into login (userID, password) values ('" + id + "','" + or + "'  )";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.userid = textBox1.Text;
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}