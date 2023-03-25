using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || !char.IsLower(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!");
                textBox2.Focus();
            }
        }
    }
}
