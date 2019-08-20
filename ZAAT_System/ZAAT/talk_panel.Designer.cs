namespace ZAAT
{
    partial class talk_panel
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
            this.message_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_textbox
            // 
            this.message_textbox.BackColor = System.Drawing.Color.White;
            this.message_textbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_textbox.Location = new System.Drawing.Point(53, 142);
            this.message_textbox.Multiline = true;
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.Size = new System.Drawing.Size(675, 327);
            this.message_textbox.TabIndex = 0;
            this.message_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello My Friend";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 74);
            this.label2.TabIndex = 2;
            this.label2.Text = "I Am here to you, share with me bad and good memories .\r\nSure that i will be here" +
    " everytime you need me not like others let you alone,\r\nSo don\'t let anything ins" +
    "ide you without tell me it :)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Image = global::ZAAT.Properties.Resources.favorite_heart_button;
            this.label3.Location = new System.Drawing.Point(204, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(299, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // talk_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message_textbox);
            this.Name = "talk_panel";
            this.Size = new System.Drawing.Size(790, 529);
            this.Load += new System.EventHandler(this.talk_panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
