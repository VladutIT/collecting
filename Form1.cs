using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collecting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///this.WindowState = FormWindowState.Maximized;
            sound();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 but1 = new Form2();
            but1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 fri = new Form3();
            fri.Show();
            this.Hide();
        }
        private void sound()
        {
            System.Media.SoundPlayer core = new System.Media.SoundPlayer(@"musica.wav");
            core.Play();
        }
       
    }
}
