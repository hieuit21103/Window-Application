using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initItem1();
            initItem2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string,int> p in people)
            {
                if(p.Key == comboBox1.SelectedItem)
                {
                    label1.Text = p.Value.ToString();
                }
            }
        }

        private void initItem1()
        {
            this.people = initListString();
            foreach (KeyValuePair<string, int> p in people)
            {
                comboBox1.Items.Add(p.Key);
            }
        }
        private List<KeyValuePair<string, int>> initListString()
        {
            var People = new List<KeyValuePair<string, int>>()
            {
               new KeyValuePair<string, int>("A", 1),
               new KeyValuePair<string, int>("B", 2),
               new KeyValuePair<string, int>("C", 3),
               new KeyValuePair<string, int>("D", 4),
               new KeyValuePair<string, int>("E", 5),
            };
            return People;
        }

        public List<KeyValuePair<string, int>> people;

        public void initItem2()
        {
            students.Add(new Student("hieu", 1));
            students.Add(new Student("hien", 2));
            students.Add(new Student("hiep", 3));
            foreach(Student st in students)
            {
                comboBox2.Items.Add(st.getName());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Student st in students)
            {
                if(st.getName() == comboBox2.SelectedItem)
                {
                    label2.Text = "Ten:" + st.getName() + "\n" + "MSV:" + st.getId().ToString();
                }
            }
        }

        List<Student> students = new List<Student>();
    }

    class Student
    {
        private int id;
        private string name;
        public Student(string name,int id) {
            this.name = name;
            this.id = id;  
        }

        public string getName()
        {
            return name;
        }
        public int getId()
        {
            return id;
        }
    }
}
