using chimbay.Properties;
using System.Resources;
using System.Runtime.CompilerServices;

namespace chimbay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random= new Random();
            int a = random.Next(0, 500);
            int b = random.Next(0, 350);
        if (_img == 1)
        {
                pictureBox1.Image = Resources.bfopen;
                pictureBox1.Location = new Point(i+a,j+b);
                _img = 2;
        }
        else
        {
                pictureBox1.Image = Resources.bfclose;
                pictureBox1.Location = new Point(i+a,j+b);
                _img = 1;
        }
        }
        private int _img = 1;
        private int i = 12;
        private int j = 12;
    }

    
}