using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Matikkapeli
{
    public partial class Jakolasku : Form
    {
        private Form1 form1;
        public Jakolasku(Form1 form1)
        {
            InitializeComponent();
            pictureBox1.SendToBack();
          this.form1 = form1;
        }
        Random r = new Random();
        decimal arvo = 0;
        decimal arvo1 = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            arvo = r.Next(1, 101);
            arvo1 = r.Next(1, 101);

            label1.Text = arvo + " / " + arvo1;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            decimal sum = arvo / arvo1;
            form1.palkinto++;
            sum = Math.Floor(sum);
            if (sum == int.Parse(textBox1.Text))
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.Fireworks);
                sound.Play();
                pictureBox1.Image = Properties.Resources.tenor;
                label2.Text = "oikein";
                label2.BackColor = Color.LightGreen;
                textBox2.Text = "Oikea vastaus " + sum.ToString();
                label2.BackColor = Color.LightGreen;
                textBox1.Clear();
            }
            else
            {
                pictureBox1.Image = Properties.Resources.iconfinder;
                label2.Text = "viärin";
                label2.BackColor = Color.Red;
                textBox1.Clear();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
