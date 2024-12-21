
namespace School_Mark_Calculation
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
            this.label1 = new System.Windows.Forms.Label();
            this.assBox1 = new System.Windows.Forms.TextBox();
            this.assBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dpBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DPbutton = new System.Windows.Forms.Button();
            this.markBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FinaLbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aegroBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuppBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assesment 1";
            // 
            // assBox1
            // 
            this.assBox1.Location = new System.Drawing.Point(366, 50);
            this.assBox1.Name = "assBox1";
            this.assBox1.Size = new System.Drawing.Size(100, 20);
            this.assBox1.TabIndex = 1;
            // 
            // assBox2
            // 
            this.assBox2.Location = new System.Drawing.Point(366, 81);
            this.assBox2.Name = "assBox2";
            this.assBox2.Size = new System.Drawing.Size(100, 20);
            this.assBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assesment 2";
            // 
            // dpBox
            // 
            this.dpBox.Location = new System.Drawing.Point(366, 148);
            this.dpBox.Name = "dpBox";
            this.dpBox.ReadOnly = true;
            this.dpBox.Size = new System.Drawing.Size(100, 20);
            this.dpBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DP";
            // 
            // DPbutton
            // 
            this.DPbutton.Location = new System.Drawing.Point(96, 148);
            this.DPbutton.Name = "DPbutton";
            this.DPbutton.Size = new System.Drawing.Size(103, 23);
            this.DPbutton.TabIndex = 6;
            this.DPbutton.Text = "Calculate DP";
            this.DPbutton.UseVisualStyleBackColor = true;
            this.DPbutton.Click += new System.EventHandler(this.DPbutton_Click);
            // 
            // markBox
            // 
            this.markBox.Enabled = false;
            this.markBox.Location = new System.Drawing.Point(366, 194);
            this.markBox.Name = "markBox";
            this.markBox.Size = new System.Drawing.Size(100, 20);
            this.markBox.TabIndex = 8;
            this.markBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exam Mark";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FinaLbutton
            // 
            this.FinaLbutton.Enabled = false;
            this.FinaLbutton.Location = new System.Drawing.Point(96, 240);
            this.FinaLbutton.Name = "FinaLbutton";
            this.FinaLbutton.Size = new System.Drawing.Size(103, 45);
            this.FinaLbutton.TabIndex = 9;
            this.FinaLbutton.Text = "Calculate Final Mark";
            this.FinaLbutton.UseVisualStyleBackColor = true;
            this.FinaLbutton.Click += new System.EventHandler(this.FinaLbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Final Mark";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 11;
            // 
            // aegroBox
            // 
            this.aegroBox.Location = new System.Drawing.Point(366, 107);
            this.aegroBox.Name = "aegroBox";
            this.aegroBox.Size = new System.Drawing.Size(100, 20);
            this.aegroBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aegrotat";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(223, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Assesment 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(223, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Assesment 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(223, 110);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Aegro";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // SuppBox
            // 
            this.SuppBox.Enabled = false;
            this.SuppBox.Location = new System.Drawing.Point(286, 357);
            this.SuppBox.Name = "SuppBox";
            this.SuppBox.Size = new System.Drawing.Size(100, 20);
            this.SuppBox.TabIndex = 18;
            this.SuppBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Supplementary Mark";
            this.label7.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 487);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(370, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Final Mark After Supp";
            this.label8.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(239, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calculate Final Mark After Supp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SuppBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.aegroBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FinaLbutton);
            this.Controls.Add(this.markBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DPbutton);
            this.Controls.Add(this.dpBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.assBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "School Mark Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox assBox1;
        private System.Windows.Forms.TextBox assBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DPbutton;
        private System.Windows.Forms.TextBox markBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FinaLbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox aegroBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox SuppBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

