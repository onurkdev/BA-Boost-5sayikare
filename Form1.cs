using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA_Boost_5sayikare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter;
        string input;
        int number;
        int sum;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToInt32(input);
            }
            catch (Exception ex )
            {

                
                MessageBox.Show($"Lütfen sayı giriniz \n Hata:{ex.ToString()}");
                textBox1.Clear();
                input = "";
                number = 0;
                return;
            }
            sum = sum + (number*number);
            enterednumbers.Items.Add(number);
            textBox1.Clear();
            number = 0;
            input = "";
            counter++;
            if (counter == 5) {
                addbutton.Enabled = false;
                MessageBox.Show($"İşlem tamamlandı sonuç : {sum}");
            
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            addbutton.Enabled = true;
            enterednumbers.Items.Clear();
            textBox1.Clear();
            number = 0;
            input = "";
            counter=0;
            sum = 0;
        }
    }
}
