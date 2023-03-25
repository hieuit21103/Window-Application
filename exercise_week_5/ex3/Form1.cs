using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            url = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label2.Text = openFileDialog1.FileName;
                    pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;               
                }
        }

        private string url;

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    label2.Text = openFileDialog1.FileName;
                    pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter) {
                try
                {
                    WebClient webClient = new WebClient();
                    byte[] imageBytes = webClient.DownloadData(url);
                    MemoryStream memoryStream = new MemoryStream(imageBytes);
                    Image image = Image.FromStream(memoryStream);
                    pictureBox1.Image = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
