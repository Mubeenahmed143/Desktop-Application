using System.Data.SqlClient;

using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForm_2212F3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Email_lable_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(name.Text))
            //{

            //    MessageBox.Show("Please fill this fields");

            //}
            //else
            //{
            
            //    MessageBox.Show(name.Text + "\n" + email.Text + "\n" + age.Text + "\n" + course.Text + "\n" + gender.Text);

            //}
            

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=std_reg;User ID=sa;Password=aptech");
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into students(Name,Email,age,course,gender) values (@name,@email,@age,@course,@gender)", con);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@age", age.Text.ToString());
            cmd.Parameters.AddWithValue("@course", course.Text);
            cmd.Parameters.AddWithValue("@gender", gender.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("data inserted");

        }

        private void show_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            myform.Show();
        }
    }
}