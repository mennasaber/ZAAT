using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace ZAAT
{
    public partial class home_statue : UserControl
    {
        string color;
        int id;
        string sqlconnection;
        MySqlConnection con;
        public home_statue(string name, string date, string message, string color,int id)
        {
            InitializeComponent();
            sqlconnection = "server=127.0.0.1;UserID=root;database=dbzaat;CharSet=utf8";
            con = new MySqlConnection(sqlconnection);
            this.color = color;
            name_label.Text = name;
            date_label.Text = date;
            zaat_label.Text = message;
            set_color(color);
            this.id = id;

        }

        private void home_statue_Load(object sender, EventArgs e)
        {

        }
        private void set_color(string name)
        {
            color = name;
            if (name == "black")
            {
                BackColor = Color.Black;
                zaat_label.BackColor = Color.Black;
                button1.BackColor = MetroFramework.MetroColors.Black;
            }
            if (name == "blue")
            {
                BackColor = MetroFramework.MetroColors.Blue;
                zaat_label.BackColor = MetroFramework.MetroColors.Blue;
                button1.BackColor = MetroFramework.MetroColors.Blue;
            }
            if (name == "red")
            {
                BackColor = MetroFramework.MetroColors.Red;
                zaat_label.BackColor = MetroFramework.MetroColors.Red;
                button1.BackColor = MetroFramework.MetroColors.Red;
            }
            if (name == "green")
            {
                BackColor = MetroFramework.MetroColors.Green;
                zaat_label.BackColor = MetroFramework.MetroColors.Green;
                button1.BackColor = MetroFramework.MetroColors.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = MetroFramework.MetroColors.Silver;
            BackColor = MetroFramework.MetroColors.Silver;
            zaat_label.BackColor = MetroFramework.MetroColors.Silver;
            delete_statue();
        }

        private void delete_statue()
        {
            MySqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "DELETE FROM `statues` WHERE id_statue="+id;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
