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

namespace pr4
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-B9NL3QIJ\SQLEXPRESS;Initial Catalog=bretta;Integrated Security=True");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string check = "select position from yser where login = '"+textBox1.Text+"' and password = '"+textBox2.Text+"'";
            cmd  = new SqlCommand(check, con);
            con.Open();
            var res = cmd.ExecuteScalar().ToString();
            con.Close();
            MessageBox.Show(res);*/
            Form2 f = new Form2();
            f.Show();
            Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string check = "INSERT INTO [dbo].[yser]([position],[login],[password])VALUES('"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')";
            cmd = new SqlCommand(check, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Добавлено!");
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
