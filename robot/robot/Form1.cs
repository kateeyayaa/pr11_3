using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            robot robot1 = new robot();
            robot robot2 = new robot();
            robot robot3 = new robot();
            if (textBox1.Text=="")
            {
                MessageBox.Show("Введите жизнь робота!");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите жизнь робота!");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Введите жизнь робота!");
                return;
            }
            label6.Visible = true;
            label4.Visible = true;
            label10.Visible = true;
            label8.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            robot1.kollife = Convert.ToInt32(textBox1.Text);
            label6.Text = "Количество жизней робота1 в начале игры " + robot1.kollife;

            robot2.kollife = Convert.ToInt32(textBox2.Text);
            label4.Text = "Количество жизней робота2 в начале игры " + robot2.kollife;

            robot3.kollife = Convert.ToInt32(textBox3.Text);
            label10.Text = "Количество жизней робота3 в начале игры " + robot3.kollife;

            int a = robot1.kollife;

            robot1.Min(robot1.kollife);

            label8.Text = "Количество жизней робота1 в конце игры " +
                          robot1.getlife();

            robot2.Kol(a, robot1.kollife);
            label5.Text = "Количество жизней робота2 в конце игры " +
                          robot2.getlife();

            robot3.Kol(a, robot1.kollife);
            label9.Text = "Количество жизней робота3 в конце игры " +
                          robot3.getlife();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            label4.Visible = false;
            label10.Visible = false;
            label8.Visible = false;
            label5.Visible = false;
            label9.Visible=false;
        }
    }
}
