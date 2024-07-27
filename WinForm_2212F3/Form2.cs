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

namespace WinForm_2212F3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=std_reg;User ID=sa;Password=aptech");
            con.Open();
            SqlCommand cm = new SqlCommand("select * from students", con);
            SqlDataReader read = cm.ExecuteReader();

            while (read.Read())
            {

                ListViewItem item = new ListViewItem(read["Id"].ToString());
                item.SubItems.Add(read["name"].ToString());
                item.SubItems.Add(read["email"].ToString());
                item.SubItems.Add(read["age"].ToString());
                item.SubItems.Add(read["course"].ToString());
                item.SubItems.Add(read["gender"].ToString());



                listView1.Items.Add(item);
            }




        }
    }
}
