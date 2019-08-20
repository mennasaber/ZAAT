using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAAT
{
    public partial class login : MetroFramework.Forms.MetroForm
    {
        string statue;
        string sqlconnection;
        MySqlConnection con;
        public login()
        {
            InitializeComponent();
            sqlconnection = "server=127.0.0.1;UserID=root;database=dbzaat;CharSet=utf8";
            con = new MySqlConnection(sqlconnection);
            statue = "SignIn";
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            statue = "SignIn";
            button3.Text = statue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statue = "SignUp";
            button3.Text = statue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (statue == "SignIn")
            {
                sign_in();
            }
            else
            {
                sign_up();
            }
        }

        private void sign_up()
        {
            if (name_textbox.Text != "" && pass_textbox.Text != "")
            {
                MySqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "INSERT INTO `data`(`name`, `password`) VALUES (@name,@password)";
                cmd.Parameters.AddWithValue("@name", name_textbox.Text);
                cmd.Parameters.AddWithValue("@password", pass_textbox.Text);
                cmd.ExecuteNonQuery();
                MySqlDataReader rd = cmd.ExecuteReader();
                con.Close();
                sign_in();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Name or Password not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Hand, 120);
            }
        }

        private void sign_in()
        {
            bool check=false;
            MySqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT * FROM `data` WHERE name = '"+name_textbox.Text+"' and password='"+pass_textbox.Text+"'";
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                check = true;
                load_home(rd["name"].ToString(),int.Parse(rd["id_user"].ToString()));
               
            }
            if (!check)
            {
                MetroFramework.MetroMessageBox.Show(this, "Name or Password not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Hand, 120);
            }
            con.Close();
        }

        private void load_home(string name,int id_user)
        {
            Home home = new Home(name,id_user);          
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
