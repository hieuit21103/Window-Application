using System;
using System.Windows.Forms;

namespace ex5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string positive = textBox1.Text;
                if (Int32.TryParse(positive, out int value))
                {
                    int a = Int32.Parse(positive);
                    if (a < 0)
                    {
                        textBox1.Clear();
                        MessageBox.Show("Không dương");
                    }
                }
                else
                {
                    textBox2.Clear();
                    MessageBox.Show("Không phải số");
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string adult = textBox2.Text;
                if (Int32.TryParse(adult, out int value))
                {
                    int a = Int32.Parse(adult);
                    if (a <= 18)
                    {
                        textBox2.Clear();
                        MessageBox.Show("Không > 18");
                    }
                }
                else
                {
                    textBox2.Clear();
                    MessageBox.Show("Không phải số");
                }
            }
        }
    }
}
