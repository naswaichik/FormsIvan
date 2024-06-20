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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Тест
{
    public partial class Form1 : Form
    {
        int b = 0;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label4.Text = "Правильно";
                b = b + 1;

            }
            else label4.Text = "Неправильно";
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                label6.Text = "Правильно";
                b = b + 1;
            }
            else label6.Text = "Неправильно";
            button2.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                label8.Text = "Правильно";
                b = b + 1;
            }
            else label8.Text = "Неправильно";
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Неограниченное количество")
            {
                label10.Text = "Правильно";
                b = b + 1;
            }
            else label10.Text = "Неправильно";
            
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                label12.Text = "Правильно";
                b = b + 1;
            }
            else label12.Text = "Неправильно";
            button5.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Устанавливает задний фон объекта")
            {
                label14.Text = "Правильно";
                b = b + 1;
            }
            else label14.Text = "Неправильно";

            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "База данных - это структурированное хранилище информации, организованное для эффективного доступа и управления данными.")
            {
                label17.Text = "Правильно";
                b = b + 1;
            }
            else label17.Text = "Неправильно";

            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Используя Intent, Bundle или SharedPreferences.")
            {
                label19.Text = "Правильно";
                b = b + 1;
            }
            else label19.Text = "Неправильно";

            button8.Visible = false;
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "База данных - это структурированное хранилище информации, организованное для эффективного доступа и управления данными")
            {
                label23.Text = "Правильно";
                b = b + 1;
            }
            else label23.Text = "Неправильно";

            button10.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                label25.Text = "Правильно";
                b = b + 1;
            }
            else label25.Text = "Неправильно";
            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true)
            {
                label27.Text = "Правильно";
                b = b + 1;
            }
            else label27.Text = "Неправильно";
            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton26.Checked == true)
            {
                label29.Text = "Правильно";
                b = b + 1;
            }
            else label29.Text = "Неправильно";
            button13.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton28.Checked == true)
            {
                label31.Text = "Правильно";
                b = b + 1;
            }
            else label31.Text = "Неправильно";
            button14.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton31.Checked == true)
            {
                label33.Text = "Правильно";
                b = b + 1;
            }
            else label33.Text = "Неправильно";
            button15.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton34.Checked == true)
            {
                label35.Text = "Правильно";
                b = b + 1;
            }
            else label35.Text = "Неправильно";
            button16.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton37.Checked == true)
            {
                label37.Text = "Правильно";
                b = b + 1;
            }
            else label37.Text = "Неправильно";
            button17.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton41.Checked == true)
            {
                label39.Text = "Правильно";
                b = b + 1;
            }
            else label39.Text = "Неправильно";
            button18.Visible = false;
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (radioButton44.Checked == true)
            {
                label41.Text = "Правильно";
                b = b + 1;
            }
            else label41.Text = "Неправильно";
            button19.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (radioButton47.Checked == true)
            {
                label52.Text = "Правильно";
                b = b + 1;
            }
            else label52.Text = "Неправильно";
            button20.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (radioButton49.Checked == true)
            {
                label54.Text = "Правильно";
                b = b + 1;
            }
            else label54.Text = "Неправильно";
            button21.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (radioButton53.Checked == true)
            {
                label56.Text = "Правильно";
                b = b + 1;
            }
            else label56.Text = "Неправильно";
            button22.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (radioButton56.Checked == true)
            {
                label58.Text = "Правильно";
                b = b + 1;
            }
            else label58.Text = "Неправильно";
            button23.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "набор инструментов и библиотек для разработки приложений под операционную систему Android.")
            {
                label62.Text = "Правильно";
                b = b + 1;
            }
            else label62.Text = "Неправильно";

            button25.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "Файлы макетов пользовательского интерфейса в Android хранятся в файлах XML")
            {
                label64.Text = "Правильно";
                b = b + 1;
            }
            else label64.Text = "Неправильно";

            button26.Visible = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "Для передачи данных между Activity в Android можно использовать объект Intent с помощью метода putExtra().")
            {
                label66.Text = "Правильно";
                b = b + 1;
            }
            else label66.Text = "Неправильно";

            button27.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "встроенная база данных, которая используется для хранения данных в мобильных приложениях Android.")
            {
                label68.Text = "Правильно";
                b = b + 1;
            }
            else label68.Text = "Неправильно";

            button28.Visible = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "компонент приложения Android, который работает в фоновом режиме и выполняет длительные операции без привязки к пользовательскому интерфейсу.")
            {
                label70.Text = "Правильно";
                b = b + 1;
            }
            else label70.Text = "Неправильно";

            button29.Visible = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "Для оптимизации производительности приложения Android можно использовать асинхронные операции, избегать выполнения длительных операций на главном потоке и использовать инструменты профилирования и оптимизации.")
            {
                label72.Text = "Правильно";
                b = b + 1;
            }
            else label72.Text = "Неправильно";

            button30.Visible = false;
        }

       

        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (radioButton58.Checked == true)
            {
                label60.Text = "Правильно";
                b = b + 1;
            }
            else label60.Text = "Неправильно";
            button24.Visible = false;
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            if (textBox13.Text == "Информационные технологии (ИТ) - это область знаний, связанная с использованием компьютеров и программного обеспечения для обработки и передачи информации.\r\n")
            {
                label74.Text = "Правильно";
                b = b + 1;
            }
            else label74.Text = "Неправильно";

            button31.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            label75.Text = "Набрано баллов= " + Convert.ToString(b); ;
            if (b == 30 || b == 29 || b == 28 || b == 27 || b == 26 || b == 25 || b == 24 || b == 23 || b == 22 || b == 21 || b == 20) label20.Text = "Оценка 5 (отлично)";
            if (b == 19 || b == 18 || b == 17 || b == 16 || b == 15 || b == 14 || b == 13 || b == 12 || b == 11 || b == 10) label20.Text = "Оценка 4 (хорошо)";
            if (b == 9 || b == 8 || b == 7 || b == 6 || b == 5) label20.Text = "Оценка 3 (удовлетворительно)";
            if (b == 4 || b == 3 || b == 2 || b == 1) label20.Text = "Оценка 2 (плохо)";

            

        }

        private void button32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;
            button31.Visible = true;

            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            label10.Text = "";
            label12.Text = "";
            label14.Text = "";
            label17.Text = "";
            label19.Text = "";
            label23.Text = "";
            label25.Text = "";
            label27.Text = "";
            label29.Text = "";
            label31.Text = "";
            label33.Text = "";
            label35.Text = "";
            label37.Text = "";
            label39.Text = "";
            label41.Text = "";
            label52.Text = "";
            label54.Text = "";
            label56.Text = "";
            label58.Text = "";
            label60.Text = "";
            label62.Text = "";
            label64.Text = "";
            label66.Text = "";
            label68.Text = "";
            label70.Text = "";
            label72.Text = "";
            label74.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;
            radioButton25.Checked = false;
            radioButton26.Checked = false;
            radioButton27.Checked = false;
            radioButton28.Checked = false;
            radioButton29.Checked = false;
            radioButton30.Checked = false;
            radioButton31.Checked = false;
            radioButton32.Checked = false;
            radioButton33.Checked = false;
            radioButton34.Checked = false;
            radioButton35.Checked = false;
            radioButton36.Checked = false;
            radioButton37.Checked = false;
            radioButton38.Checked = false;
            radioButton39.Checked = false;
            radioButton40.Checked = false;
            radioButton41.Checked = false;
            radioButton42.Checked = false;
            radioButton43.Checked = false;
            radioButton44.Checked = false;
            radioButton45.Checked = false;
            radioButton46.Checked = false;
            radioButton47.Checked = false;
            radioButton48.Checked = false;
            radioButton49.Checked = false;
            radioButton50.Checked = false;
            radioButton51.Checked = false;
            radioButton52.Checked = false;
            radioButton53.Checked = false;
            radioButton54.Checked = false;
            radioButton55.Checked = false;
            radioButton56.Checked = false;
            radioButton57.Checked = false;
            radioButton58.Checked = false;
            radioButton59.Checked = false;
            radioButton60.Checked = false;


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";

            b = 0;
            label75.Text = "Набрано баллов= ";
            label20.Text = "";
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
