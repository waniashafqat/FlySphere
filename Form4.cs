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
    public partial class Form4 : Form
    {
        string connectionString = ("Data Source = DESKTOP - 5N3OP8P" + "\\" + "SQLEXPRESS;Initial Catalog = FlySphere; Integrated Security = True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select *from Package3 ", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }
    }
}
