using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

namespace BirthdayParadox

{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)

        {

            double totalNum, calcNum, ans, fact1 = 1.0000, fact2 = 1.0000;

            double a = Convert.ToDouble(textBox1.Text);

            double b = Convert.ToDouble(textBox2.Text);

            calcNum = Convert.ToDouble(a);

            totalNum = Convert.ToDouble(b);

            while (a > 0)

            {

                fact2 = Convert.ToDouble((b - a + 1) / b);

                fact1 = fact1 * fact2;

                a--;

            }

            ans = (1- fact1)*100;

            textBox3.Text = Convert.ToString(ans);

        }

    }

}

birthdayParadoxForm.cs

namespace BirthdayParadox

{

    partial class Form1

    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

            {

                components.Dispose();

            }

            base.Dispose(disposing);

        }

        #region Windows Form Designer generated code

        private void InitializeComponent()

        {

            this.label1 = new System.Windows.Forms.Label();

            this.label2 = new System.Windows.Forms.Label();

            this.label3 = new System.Windows.Forms.Label();

            this.textBox1 = new System.Windows.Forms.TextBox();

            this.textBox2 = new System.Windows.Forms.TextBox();

            this.textBox3 = new System.Windows.Forms.TextBox();

            this.button1 = new System.Windows.Forms.Button();

            this.label4 = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 

            // label1

            // 

            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(32, 93);

            this.label1.Name = "label1";

            this.label1.Size = new System.Drawing.Size(143, 13);

            this.label1.TabIndex = 0;

            this.label1.Text = "Numbers Randomly choosen";

            // 

            // label2

            // 

            this.label2.AutoSize = true;

            this.label2.Location = new System.Drawing.Point(32, 137);

            this.label2.Name = "label2";

            this.label2.Size = new System.Drawing.Size(121, 13);

            this.label2.TabIndex = 1;

            this.label2.Text = "Numbers of Possibalities";

            // 

            // label3

            // 

            this.label3.AutoSize = true;

            this.label3.Location = new System.Drawing.Point(32, 186);

            this.label3.Name = "label3";

            this.label3.Size = new System.Drawing.Size(184, 13);

            this.label3.TabIndex = 2;

            this.label3.Text = "Probabality that two of them are same";

            // 

            // textBox1

            // 

            this.textBox1.Location = new System.Drawing.Point(338, 85);

            this.textBox1.Name = "textBox1";

            this.textBox1.Size = new System.Drawing.Size(150, 20);

            this.textBox1.TabIndex = 3;

            // 

            // textBox2

            // 

            this.textBox2.Location = new System.Drawing.Point(338, 130);

            this.textBox2.Name = "textBox2";

            this.textBox2.Size = new System.Drawing.Size(150, 20);

            this.textBox2.TabIndex = 4;

            // 

            // textBox3

            // 

            this.textBox3.Location = new System.Drawing.Point(338, 179);

            this.textBox3.Name = "textBox3";

            this.textBox3.ReadOnly = true;

            this.textBox3.Size = new System.Drawing.Size(150, 20);

            this.textBox3.TabIndex = 5;

            // 

            // button1

            // 

            this.button1.Location = new System.Drawing.Point(566, 107);

            this.button1.Name = "button1";

            this.button1.Size = new System.Drawing.Size(75, 23);

            this.button1.TabIndex = 6;

            this.button1.Text = "Calculate";

            this.button1.UseVisualStyleBackColor = true;

            this.button1.Click += new           

System.EventHandler(this.button1_Click);

            // 

            // label4

            // 

            this.label4.AutoSize = true;

            this.label4.Location = new System.Drawing.Point(494, 186);

            this.label4.Name = "label4";

            this.label4.Size = new System.Drawing.Size(15, 13);

            this.label4.TabIndex = 7;

            this.label4.Text = "%";

            // 

            // Form1

            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(937, 464);

            this.Controls.Add(this.label4);

            this.Controls.Add(this.button1);

            this.Controls.Add(this.textBox3);

            this.Controls.Add(this.textBox2);

            this.Controls.Add(this.textBox1);

            this.Controls.Add(this.label3);

            this.Controls.Add(this.label2);

            this.Controls.Add(this.label1);

            this.Name = "Form1";

            this.Text = "Form1";

            this.ResumeLayout(false);

            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label4;

    }

}