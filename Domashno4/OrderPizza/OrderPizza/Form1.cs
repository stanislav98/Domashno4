using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("D:\\za universiteta\\TSP\\Domashno4\\OrderPizza\\OrderPizza\\checked.txt");
            foreach (string str in lines)
            {
                checkedListBox1.Items.Add(str);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstChoise = "";
            String secondChoise = "";
            String extra = "без екстра кашкавал";
            String toppings = "";
            double total = 0;
            int count = 0;
            var first = new[] { groupBox1 }
                    .SelectMany(g => g.Controls.OfType<RadioButton>()
                                            .Where(r => r.Checked));
           
           foreach (var c in first)
                {
                   firstChoise = c.Name;
                if (c.Name == "Small") { total += 9.25; }
                else if (c.Name == "Medium") { total += 11.50; }
                else total += 13.75;
                }

            var second = new[] { groupBox2 }
                    .SelectMany(g => g.Controls.OfType<RadioButton>()
                                            .Where(r => r.Checked));
            if (second == null || !(second.GetEnumerator().MoveNext()))
            {
                MessageBox.Show("Моля изберете си Crust");
            }
            else
            {
                foreach (var s in second)
                {
                    secondChoise = s.Name;
                }
            }
            if (checkBox1.Checked)
            {
                extra = "със екстра кашкавал";
                total += 1.50;
            }

            foreach (object Item in checkedListBox1.CheckedItems)
            {
                toppings += Item.ToString() + " ";
                count += 1;
                total += 1;
            }
            if (toppings == "")
            {
                MessageBox.Show("Моля изберете си Toppings");
            }

            textBox1.Text =
            "Вие си избрахте " + firstChoise + " " + secondChoise +
            " crust пица " + extra + " и " + count.ToString() +
            " добавки : " + "\r\n" + toppings + "\r\n" + "Общата ви сума е : " + total;
        }
    }
}
