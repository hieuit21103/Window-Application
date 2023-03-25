using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            format();
            this.selectedDate = getValue();
            this.selectedDateString = getText();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            format();
        }

        private void format()
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        DateTime selectedDate;
        string selectedDateString;

    }
}
