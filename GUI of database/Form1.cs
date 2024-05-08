using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//include new lib

using System.Data.SqlClient;

namespace GUI_of_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-8OQ8UTE\\SQLEXPRESS;Initial Catalog=MAR;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cnic = tbcnic.Text;
            string name = tbname.Text;
            string fname = tbfname.Text;
            string dob = tbdob.Text;

            string query = "INSERT INTO person (CNIC, Name, Father, DOB) VALUES ('" + cnic + "','" + name + "','" + fname + "','" + dob + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Record Inserted");

            tbcnic.Text = "";
            tbname.Text = "";
            tbfname.Text = "";
            tbdob.Text = "";
        }

        private void Cnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dob_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Tbview_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=DESKTOP-8OQ8UTE\\SQLEXPRESS;Initial Catalog=MAR;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "SELECT * FROM person";
            SqlCommand cmd = new SqlCommand(query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            tbgrid.DataSource = table;

            con.Close();
        }
       

        private void Button3_Click_1(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-8OQ8UTE\\SQLEXPRESS;Initial Catalog=MAR;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cnic = tbcnic.Text;
            string name = tbname.Text;
            string fname = tbfname.Text;
            string dob = tbdob.Text;

            string query = "UPDATE person SET Name = '" + name + "', Father = '" + fname + "', DOB = '" + dob + "' WHERE CNIC = '" + cnic + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");

            tbcnic.Text = "";
            tbname.Text = "";
            tbfname.Text = "";
            tbdob.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-8OQ8UTE\\SQLEXPRESS;Initial Catalog=MAR;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cnic = tbcnic.Text;
        

            string query = "DELETE FROM person WHERE CNIC = '"+cnic+"'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");

            tbcnic.Text = "";
         
        }
    }
}
