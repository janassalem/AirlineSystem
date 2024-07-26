namespace AirlineSystem
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.faretxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.sourcetxt = new System.Windows.Forms.TextBox();
            this.desttxt = new System.Windows.Forms.TextBox();
            this.arrtxt = new System.Windows.Forms.TextBox();
            this.deptxt = new System.Windows.Forms.TextBox();
            this.classtxt = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.seatstxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Details ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "flight name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arrival Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "flight class";
            // 
            // faretxt
            // 
            this.faretxt.AutoSize = true;
            this.faretxt.Location = new System.Drawing.Point(27, 323);
            this.faretxt.Name = "faretxt";
            this.faretxt.Size = new System.Drawing.Size(28, 13);
            this.faretxt.TabIndex = 7;
            this.faretxt.Text = "Fare";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Availlable seats ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(91, 63);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(256, 20);
            this.nametxt.TabIndex = 9;
            // 
            // sourcetxt
            // 
            this.sourcetxt.Location = new System.Drawing.Point(91, 114);
            this.sourcetxt.Name = "sourcetxt";
            this.sourcetxt.Size = new System.Drawing.Size(256, 20);
            this.sourcetxt.TabIndex = 10;
            // 
            // desttxt
            // 
            this.desttxt.Location = new System.Drawing.Point(93, 163);
            this.desttxt.Name = "desttxt";
            this.desttxt.Size = new System.Drawing.Size(256, 20);
            this.desttxt.TabIndex = 11;
            // 
            // arrtxt
            // 
            this.arrtxt.Location = new System.Drawing.Point(93, 202);
            this.arrtxt.Name = "arrtxt";
            this.arrtxt.Size = new System.Drawing.Size(256, 20);
            this.arrtxt.TabIndex = 12;
            // 
            // deptxt
            // 
            this.deptxt.Location = new System.Drawing.Point(93, 238);
            this.deptxt.Name = "deptxt";
            this.deptxt.Size = new System.Drawing.Size(256, 20);
            this.deptxt.TabIndex = 13;
            // 
            // classtxt
            // 
            this.classtxt.Location = new System.Drawing.Point(91, 278);
            this.classtxt.Name = "classtxt";
            this.classtxt.Size = new System.Drawing.Size(256, 20);
            this.classtxt.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(91, 320);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(256, 20);
            this.textBox7.TabIndex = 15;
            // 
            // seatstxt
            // 
            this.seatstxt.Location = new System.Drawing.Point(93, 356);
            this.seatstxt.Name = "seatstxt";
            this.seatstxt.Size = new System.Drawing.Size(256, 20);
            this.seatstxt.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Insert Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 255);
            this.dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seatstxt);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.classtxt);
            this.Controls.Add(this.deptxt);
            this.Controls.Add(this.arrtxt);
            this.Controls.Add(this.desttxt);
            this.Controls.Add(this.sourcetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.faretxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label faretxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox sourcetxt;
        private System.Windows.Forms.TextBox desttxt;
        private System.Windows.Forms.TextBox arrtxt;
        private System.Windows.Forms.TextBox deptxt;
        private System.Windows.Forms.TextBox classtxt;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox seatstxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}