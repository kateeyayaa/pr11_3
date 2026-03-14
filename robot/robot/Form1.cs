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
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label11.Text = "Робот1: ";
            label12.Text = "Робот2: ";
            label13.Text = "Робот3: ";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            if (textBox4.Text == "")
            {
                MessageBox.Show("введите жизнь робота");
                return;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("введите жизнь робота");
                return;
            }

            if (textBox6.Text == "")
            {
                MessageBox.Show("введите жизнь робота");
                return;
            }
            Robot[] robots = new Robot[3];
            for (int i = 0; i < 3; i++)
                robots[i] = new Robot();

            // Чтение жизней из текстбоксов
            robots[0].SetLife(Convert.ToInt32(textBox4.Text));
            robots[1].SetLife(Convert.ToInt32(textBox5.Text));
            robots[2].SetLife(Convert.ToInt32(textBox6.Text));

            // Вывод начальных жизней
            label11.Text = "Робот1: " + robots[0].GetLife();
            label12.Text = "Робот2: " + robots[1].GetLife();
            label13.Text = "Робот3: " + robots[2].GetLife();

            // Уменьшаем жизнь первого робота
            int initialLife = robots[0].GetLife();
            robots[0].Min(initialLife);
            int lifeAfterMin = robots[0].GetLife();


            for (int i = 1; i < robots.Length; i++)
            {
                robots[i].Kol(initialLife, lifeAfterMin);
            }
           
            // Вывод жизней после игры
            label14.Text = "Робот1 после игры: " + robots[0].GetLife();
            label15.Text = "Робот2 после игры: " + robots[1].GetLife();
            label16.Text = "Робот3 после игры: " + robots[2].GetLife();
        }
    }
}
