using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic
{
    public partial class Form1 : Form
    {

        Button button1 = new Button();
        TextBox textBox1 = new TextBox();
        TextBox textBox2 = new TextBox();
        int firstNum,secondNum;

        protected void CreateButton() {
            button1.Size = new System.Drawing.Size(200, 50);
            button1.Location = new System.Drawing.Point(350, 50);
            button1.Text = "Calculate";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(this.button1_Click);
        }
        protected void CreateTextBox()
        {
            textBox1.Size = new System.Drawing.Size(150, 25);
            textBox1.Location = new System.Drawing.Point(100, 50);
            this.Controls.Add(textBox1);
            textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);

            textBox2.Size = new System.Drawing.Size(150, 25);
            textBox2.Location = new System.Drawing.Point(100, 120);
            this.Controls.Add(textBox2);
            textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            CreateTextBox();
        }

        protected void textBox1_TextChanged(object sender,EventArgs e)
        {

            try
            {
              
                firstNum = Int32.Parse(textBox1.Text);
                if (firstNum >= -360 && firstNum <= 360)
                {

                    MessageBox.Show("Тригонометрични функции : " + "\n" +
                         "cos " + firstNum + " = " + Math.Round(Math.Cos(firstNum), 2) + "\n" +
                         "sin " + firstNum + " = " + Math.Round(Math.Sin(firstNum), 2) + "\n" +
                         "tang " + firstNum + " = " + Math.Round(Math.Tan(firstNum), 2) + "\n" 
                         );
                }
                else
                {
                    MessageBox.Show("Моля въведете число в диапазона от -360 до 360");
                }
            }
            catch
            {
                MessageBox.Show("Моля въведете число");
            }
        }

        protected void textBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {

                secondNum = Int32.Parse(textBox2.Text);
                if (secondNum >= 1 && secondNum <= 10)
                {

                    MessageBox.Show("S и P на окръжността : " + "\n" +
                         "S = " + Math.Round(Math.PI * secondNum * secondNum,2) + "\n" +
                         "P = "  + Math.Round(2 * Math.PI * secondNum,2) + "\n"
                         );
                }
                else
                {
                    MessageBox.Show("Моля въведете число в диапазона от 1 до 10");
                }
            }
            catch
            {
                MessageBox.Show("Моля въведете число");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

            
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButton();
          
        }
    }
}
