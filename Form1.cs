using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_hw_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strcountry = comboBox1.SelectedItem.ToString();
            if(strcountry == "Франция")
            {
                comboBox2.Items.Add("Париж");
                comboBox2.Items.Add("Марсель");
                comboBox2.Items.Add("Лион");
                comboBox2.Items.Add("Тулуза");
            }
            else if (strcountry == "Италия")
            {
                comboBox2.Items.Add("Рим");
                comboBox2.Items.Add("Милан");
                comboBox2.Items.Add("Венеция");
                comboBox2.Items.Add("Палермо");
            }
            else if (strcountry == "Германия")
            {
                comboBox2.Items.Add("Берлин");
                comboBox2.Items.Add("Мюнхен");
                comboBox2.Items.Add("Гамбург");
                comboBox2.Items.Add("Кёльн");
            }
            else if (strcountry == "Россия")
            {
                comboBox2.Items.Add("Москва");
                comboBox2.Items.Add("Санкт_Петербург");
                comboBox2.Items.Add("Екатеринбург");
                comboBox2.Items.Add("Челябинск");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Анкета: \n";
            if (textBox_name.Text != string.Empty)
            {
                str += $"Имя: {textBox_name.Text}\n";

            }
            if (textBox_surname.Text != string.Empty)
            {
                str += $"Фамилия: {textBox_surname.Text}\n";

            }
            if (textBox_secname.Text != string.Empty)
            {
                str += $"Отчество: {textBox_secname.Text}\n";

            }
            if(comboBox1.Text!=string.Empty)
            {
                str += $"Страна: {comboBox1.SelectedItem} \n";
            }
            if (comboBox2.Text != string.Empty)
            {
                str += $"Город: {comboBox2.SelectedItem} \n";
            }
            if (maskedTextBox1.Text != string.Empty)
            {
                str += $"Телефон: {maskedTextBox1.Text} \n";
            }
            if(dateTimePicker1.Text!= string.Empty)
            {
                str += $"Дата рождения: {dateTimePicker1.Value.ToShortDateString()}\n";
            }
            if (radioButton_male.Checked == true)
            {
                str += $"Пол: {radioButton_male.Text}\n";
            }
            if (radioButton_female.Checked == true)
            {
                str += $"Пол: {radioButton_female.Text}\n";
            }

            MessageBox.Show(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
