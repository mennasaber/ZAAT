namespace ZAAT
{
    partial class home_statue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.zaat_label = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(299, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(193, 23);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_label
            // 
            this.date_label.ForeColor = System.Drawing.Color.White;
            this.date_label.Location = new System.Drawing.Point(316, 23);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(150, 20);
            this.date_label.TabIndex = 1;
            this.date_label.Text = "Date";
            this.date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zaat_label
            // 
            this.zaat_label.BackColor = System.Drawing.Color.Black;
            this.zaat_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zaat_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaat_label.ForeColor = System.Drawing.Color.White;
            this.zaat_label.Location = new System.Drawing.Point(10, 54);
            this.zaat_label.Multiline = true;
            this.zaat_label.Name = "zaat_label";
            this.zaat_label.ReadOnly = true;
            this.zaat_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.zaat_label.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.zaat_label.Size = new System.Drawing.Size(743, 72);
            this.zaat_label.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ZAAT.Properties.Resources.delete_button__;
            this.button1.Location = new System.Drawing.Point(714, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 32);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home_statue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zaat_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.name_label);
            this.Name = "home_statue";
            this.Size = new System.Drawing.Size(766, 130);
            this.Load += new System.EventHandler(this.home_statue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox zaat_label;
        private System.Windows.Forms.Button button1;
    }
}
