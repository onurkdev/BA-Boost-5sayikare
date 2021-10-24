
namespace BA_Boost_5sayikare
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enterednumbers = new System.Windows.Forms.ListBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sumlabel = new System.Windows.Forms.Label();
            this.resetbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "5 Sayı Karesi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lütfen 5 sayı giriniz.";
            // 
            // enterednumbers
            // 
            this.enterednumbers.FormattingEnabled = true;
            this.enterednumbers.ItemHeight = 20;
            this.enterednumbers.Location = new System.Drawing.Point(331, 184);
            this.enterednumbers.Name = "enterednumbers";
            this.enterednumbers.Size = new System.Drawing.Size(120, 124);
            this.enterednumbers.TabIndex = 3;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(352, 135);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 43);
            this.addbutton.TabIndex = 4;
            this.addbutton.Text = "Ekle";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam:";
            // 
            // sumlabel
            // 
            this.sumlabel.AutoSize = true;
            this.sumlabel.Location = new System.Drawing.Point(377, 329);
            this.sumlabel.Name = "sumlabel";
            this.sumlabel.Size = new System.Drawing.Size(18, 20);
            this.sumlabel.TabIndex = 6;
            this.sumlabel.Text = "0";
            this.sumlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(352, 368);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 43);
            this.resetbutton.TabIndex = 7;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.sumlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.enterednumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox enterednumbers;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sumlabel;
        private System.Windows.Forms.Button resetbutton;
    }
}

