using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZAAT
{
    public partial class home_container : UserControl
    {
        string sqlconnection;
        MySqlConnection con;
        string name;
        int id_user;
        string color;
        public home_container(string name,int id_user,string color)
        {
            InitializeComponent();
            sqlconnection = "server=127.0.0.1;UserID=root;database=dbzaat;CharSet=utf8";
            con = new MySqlConnection(sqlconnection);
            this.name = name;
            this.id_user = id_user;
            this.color = color;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void home_container_Load(object sender, EventArgs e)
        {
            load_statue();

        }

        private void load_statue()
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT * FROM `statues` WHERE id_user = "+ id_user;
             MySqlDataReader rd =  cmd.ExecuteReader();
            while (rd.Read())
            {
                home_statue h_s = new home_statue(name,rd["date"].ToString(),rd["message"].ToString(),color,int.Parse(rd["id_statue"].ToString()));
                flowLayoutPanel1.Controls.Add(h_s);
                h_s.Visible = true;
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_statue();
        }
    }
}
