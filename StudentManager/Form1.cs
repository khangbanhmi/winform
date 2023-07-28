using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Modify modify;
        Student student;

        private void Form1_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllStudent();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string name = this.textBox2.Text;
            string sex = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            DateTime date = this.dateTimePicker1.Value;
            string address = this.textBox4.Text;
            string phonenumber = this.textBox5.Text;
            student = new Student(id, name, sex, date, address, phonenumber);
            if (modify.insert(student))
            {
                dataGridView1.DataSource = modify.getAllStudent();
            }
            else
            {
                MessageBox.Show("ERROR:" + "không thêm vào được ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(id))
            {
                dataGridView1.DataSource = modify.getAllStudent();
            }
            else
            {
                MessageBox.Show("ERROR:" + "không thể xóa ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string name = this.textBox2.Text;
            string sex = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            DateTime date = this.dateTimePicker1.Value;
            string address = this.textBox4.Text;
            string phonenumber = this.textBox5.Text;
            student = new Student(id, name, sex, date, address, phonenumber);
            if (modify.update(student))
            {
                dataGridView1.DataSource = modify.getAllStudent();
            }
            else
            {
                MessageBox.Show("ERROR:" + "không thể sửa ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
