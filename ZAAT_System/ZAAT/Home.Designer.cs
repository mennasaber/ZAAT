namespace ZAAT
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.red = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.talk_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logout_button);
            this.panel1.Controls.Add(this.talk_button);
            this.panel1.Controls.Add(this.home_button);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.red);
            this.panel2.Controls.Add(this.blue);
            this.panel2.Controls.Add(this.green);
            this.panel2.Controls.Add(this.black);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // main_panel
            // 
            resources.ApplyResources(this.main_panel, "main_panel");
            this.main_panel.Name = "main_panel";
            // 
            // red
            // 
            this.red.Image = global::ZAAT.Properties.Resources.rounded_black_square_shape_r;
            resources.ApplyResources(this.red, "red");
            this.red.Name = "red";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // blue
            // 
            this.blue.Image = global::ZAAT.Properties.Resources.rounded_black_square_shape_b;
            resources.ApplyResources(this.blue, "blue");
            this.blue.Name = "blue";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // green
            // 
            this.green.Image = global::ZAAT.Properties.Resources.rounded_black_square_shape_g;
            resources.ApplyResources(this.green, "green");
            this.green.Name = "green";
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // black
            // 
            this.black.Image = global::ZAAT.Properties.Resources.rounded_black_square_shape;
            resources.ApplyResources(this.black, "black");
            this.black.Name = "black";
            this.black.UseVisualStyleBackColor = true;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.logout_button, "logout_button");
            this.logout_button.ForeColor = System.Drawing.Color.Black;
            this.logout_button.Image = global::ZAAT.Properties.Resources.icons8_logout_rounded_left_24px;
            this.logout_button.Name = "logout_button";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // talk_button
            // 
            this.talk_button.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.talk_button, "talk_button");
            this.talk_button.ForeColor = System.Drawing.Color.Black;
            this.talk_button.Image = global::ZAAT.Properties.Resources.icons8_talk_male_24px;
            this.talk_button.Name = "talk_button";
            this.talk_button.UseVisualStyleBackColor = false;
            this.talk_button.Click += new System.EventHandler(this.talk_button_Click);
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.home_button, "home_button");
            this.home_button.ForeColor = System.Drawing.Color.Black;
            this.home_button.Image = global::ZAAT.Properties.Resources.icons8_home_26px_11;
            this.home_button.Name = "home_button";
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button talk_button;
        private System.Windows.Forms.FlowLayoutPanel main_panel;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button green;
    }
}