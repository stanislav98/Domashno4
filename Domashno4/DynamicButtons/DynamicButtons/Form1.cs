using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListBox listBox1 = new ListBox();
        ListBox listBox2 = new ListBox();
        Button button1 = new Button();
        Button button2 = new Button();

        private void CreateButton()
        {
            //button1
            button1.Size = new System.Drawing.Size(150, 30);
            button1.Location = new System.Drawing.Point(150, 150);
            button1.Text = "Create ListBox";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(this.button1_Click);

            //button2
            button2.Size = new System.Drawing.Size(150, 30);
            button2.Location = new System.Drawing.Point(350, 150);
            button2.Text = "InputBox";
            this.Controls.Add(button2);
            button2.Click += new EventHandler(this.button2_Click);
        }

        private void CreateListBoxFirst()
        {
            listBox1.Size = new System.Drawing.Size(200,116);
            listBox1.Location = new System.Drawing.Point(100, 14);
            this.Controls.Add(listBox1);
            listBox1.MultiColumn = true;
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }
        private void CreateListBoxSecond()
        {
            listBox2.Size = new System.Drawing.Size(200, 116);
            listBox2.Location = new System.Drawing.Point(350, 14);
            this.Controls.Add(listBox2);
            listBox2.MultiColumn = true;
            listBox2.SelectionMode = SelectionMode.MultiExtended;
        }

        //метод button1_Click(), който ще обработва събитието Click за button1
        protected void button1_Click(object sender, EventArgs e)
        {
            CreateListBoxFirst(); 
            string[] lines = System.IO.File.ReadAllLines("D:\\za universiteta\\TSP\\Domashno4\\DynamicButtons\\DynamicButtons\\names.txt");
            foreach (string str in lines)
            {
                listBox1.Items.Add(str);
            }
        }
        protected void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CreateListBoxSecond();
                double salary = Double.Parse(Interaction.InputBox("Въведете заплата: "));
                listBox2.Items.Add(salary);
            }
            catch
            {
                MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ ЧИСЛО!");
            }
        }


        //при стартиране на формата се извиква функция CreateButton();       
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButton();
        }
    }
}
