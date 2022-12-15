namespace Fuzzy_Logic
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.acoutput = new System.Windows.Forms.Label();
            this.roomtemp = new System.Windows.Forms.Label();
            this.desiredtemp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desired Temperature";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.desiredtemp);
            this.panel1.Controls.Add(this.roomtemp);
            this.panel1.Controls.Add(this.acoutput);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(64, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 174);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Desired Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current Room Temperature";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "AC Output ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Click for 1 step process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(64, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 142);
            this.panel2.TabIndex = 8;
            // 
            // acoutput
            // 
            this.acoutput.AutoSize = true;
            this.acoutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.acoutput.Location = new System.Drawing.Point(213, 93);
            this.acoutput.Name = "acoutput";
            this.acoutput.Size = new System.Drawing.Size(2, 18);
            this.acoutput.TabIndex = 11;
            // 
            // roomtemp
            // 
            this.roomtemp.AutoSize = true;
            this.roomtemp.BackColor = System.Drawing.SystemColors.Control;
            this.roomtemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomtemp.Location = new System.Drawing.Point(213, 58);
            this.roomtemp.Name = "roomtemp";
            this.roomtemp.Size = new System.Drawing.Size(2, 18);
            this.roomtemp.TabIndex = 12;
            // 
            // desiredtemp
            // 
            this.desiredtemp.AutoSize = true;
            this.desiredtemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.desiredtemp.Location = new System.Drawing.Point(213, 20);
            this.desiredtemp.Name = "desiredtemp";
            this.desiredtemp.Size = new System.Drawing.Size(2, 18);
            this.desiredtemp.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Fuzzy Logic: Airconditioner Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label acoutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label desiredtemp;
        private System.Windows.Forms.Label roomtemp;
    }
}

