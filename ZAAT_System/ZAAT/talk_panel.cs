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
    public partial class talk_panel : UserControl
    {
        string sqlconnection;
        MySqlConnection con;
        int id_user;
        public talk_panel(int id_user)
        {
            InitializeComponent();
            sqlconnection = "server=127.0.0.1;UserID=root;database=dbzaat;CharSet=utf8";
            con = new MySqlConnection(sqlconnection);
            this.id_user = id_user;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (message_textbox.Text != "")
            {
                DateTime dt = DateTime.Now;
                string date = dt.Day.ToString();
                date += "/";
                date += dt.Month.ToString();
                date += "/";
                date += dt.Year.ToString();

                MySqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "INSERT INTO `statues`(`id_user`, `date`, `message`) VALUES (@id_user,@date,@message)";
                cmd.Parameters.AddWithValue("@id_user", id_user);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@message", message_textbox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MetroFramework.MetroMessageBox.Show(this, "Your words Saved In ZAAT Memory \nSmile, Everything will be good soon :) ", "", MessageBoxButtons.OK, MessageBoxIcon.Hand, 120);
                message_textbox.Text = "";
            }

        }

        private void talk_panel_Load(object sender, EventArgs e)
        {

        }
    }
}
