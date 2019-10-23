using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
            //This portion of the program allows the user to open a file that has either a .mp3, .wmv, or any extension and play it in a Windows Media Player like window within the parent form.       
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Media Player closing.....");
            Application.Exit();
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
          
        }
    }
}
