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
    public partial class Pluslasku : Form
    {
       
        private Form1 form1;
        public Pluslasku(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            pictureBox1.SendToBack();//Laitetaan pictureboksi taka-alalle jotta nappulat näkyy
        }
        Random r = new Random();
        int arvo = 0;
        int arvo1 = 0;



        private void Button1_Click(object sender, EventArgs e)
        {
            arvo = r.Next(1, 101);
            arvo1 = r.Next(1, 101);

            label1.Text= arvo+" + "+arvo1;
            textBox2.Clear();
            

        }
        

        private void Label1_Click(object sender, EventArgs e)
        {
           

           
          

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }
        //private void playaudio() // defining the function
        //{
        //    SoundPlayer audio = new SoundPlayer(Properties.Resources.Fireworks); 
        //    audio.Play();
        //}

        private void Button2_Click(object sender, EventArgs e)
        {
            int sum = arvo + arvo1;
            if (sum == int.Parse(textBox1.Text))
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.Fireworks);
                sound.Play();
                
                //playaudio();
                pictureBox1.Image = Properties.Resources.tenor;
                //Image kuva = new Bitmap(Properties.Resources.tenor);
                //this.BackgroundImage = kuva;
                //BackgroundImageLayout = ImageLayout.Stretch;
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label2.Text = "oikein";
                label2.BackColor = Color.LightGreen;
                textBox2.Text ="Oikea vastaus "+ sum.ToString();
                form1.palkinto++;
                textBox1.Clear();
            }
            else
            {

                pictureBox1.Image = Properties.Resources.iconfinder;
               
                //BackgroundImageLayout = ImageLayout.Stretch;
                label2.Text = "viärin";
                label2.BackColor = Color.Red;
                textBox2.Text = "Oikea vastaus "+ sum.ToString();
                textBox1.Clear();
               
                
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pluslasku_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
