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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        string name;
        int id_user;
        string color;
        string current;
        public Home(string name, int id_user)
        {
            InitializeComponent();
            this.name = name;
            this.id_user = id_user;
            color = "black";
            current = "Home";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            load_home();

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            load_home();
        }

        private void load_home()
        {
            main_panel.Controls.Clear();
            home_container h_c = new home_container(name, id_user, color);
            main_panel.Controls.Add(h_c);
            h_c.Visible = true;
            current = "Home";
        }

        private void talk_button_Click(object sender, EventArgs e)
        {
            load_talk();
        }

        private void load_talk()
        {
            main_panel.Controls.Clear();
            talk_panel t_p = new talk_panel(id_user);
            main_panel.Controls.Add(t_p);
            t_p.Visible = true;
            current = "Talk";
        }

        private void black_Click(object sender, EventArgs e)
        {
            set_color(black.Name);
            Refresh();
        }

        private void set_color(string name)
        {
            color = name;
            if (name == "black")
            {
                Style = MetroFramework.MetroColorStyle.Black;
                panel1.BackColor = Color.Black;
                label1.BackColor = Color.Black;
            }
            if (name == "blue")
            {
                Style = MetroFramework.MetroColorStyle.Blue;
                panel1.BackColor = MetroFramework.MetroColors.Blue;
                label1.BackColor = MetroFramework.MetroColors.Blue;
            }
            if (name == "red")
            {
                Style = MetroFramework.MetroColorStyle.Red;
                panel1.BackColor = MetroFramework.MetroColors.Red;
                label1.BackColor = MetroFramework.MetroColors.Red;
            }
            if (name == "green")
            {
                Style = MetroFramework.MetroColorStyle.Green;
                panel1.BackColor = MetroFramework.MetroColors.Green;
                label1.BackColor = MetroFramework.MetroColors.Green;
            }
            if (current == "Home")
                load_home();
        }

        private void green_Click(object sender, EventArgs e)
        {
            set_color(green.Name);
            Refresh();
        }

        private void blue_Click(object sender, EventArgs e)
        {
            set_color(blue.Name);
            Refresh();
        }

        private void red_Click(object sender, EventArgs e)
        {
            set_color(red.Name);
            Refresh();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {            
           Close();
        }
    }
}
