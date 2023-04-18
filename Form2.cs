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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        List<Tovars> tovars = new List<Tovars>();
        public class Tovars
        {
            public Tovars (string n, string c, string p)
            {
                name = n;
                country = c;
                price = p;
            }
            public string country { get; set; }
            public string name { get; set; }
            public string price { get; set; }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_name.Text))
            {
                if (!Tovar.Items.Contains(textBox_name))
                {
                    tovars.Add(new Tovars(textBox_name.Text, textBox_country.Text, textBox_price.Text));
                    Tovar.Items.Add(textBox_name.Text + " " + textBox_country.Text + " " + textBox_price.Text + "\n");
                    textBox_name.Clear();
                    textBox_country.Clear();
                    textBox_price.Clear();
                }
                else MessageBox.Show("String must be unique");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_country.Clear();
            textBox_price.Clear();
            panel1.Visible = false;
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            string str = Tovar.SelectedItems.ToString();
            string[] strarr = str.Split(' ');
            if(Tovar.SelectedItems!= null)
            {
                MessageBox.Show("1 if");
                for (int i = 0; i < tovars.Count; i++)
                {
                   
                    MessageBox.Show("3 if");
                    textBox_name.Text = tovars[i].name;
                    textBox_country.Text = tovars[i].country;
                    textBox_price.Text = tovars[i].price;
                    Tovar.SelectedItems.Clear();
                    break;
                    
                }

            }
        

        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (Tovar.SelectedItems.Count != 0)
            {
                if (Tovar.SelectedItem != null)
                {
                    while (Tovar.SelectedItems.Count > 0)
                    {
                        Tovar.Items.Remove(Tovar.SelectedItems[0]);
                    }
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Tovar.Items.Clear();
        }

        
    }
}
