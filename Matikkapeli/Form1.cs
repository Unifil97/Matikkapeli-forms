using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;


namespace Matikkapeli
{
    public partial class Form1 : Form
    {
       

        public int palkinto { get; set; }
        public Form1() 
        {
            InitializeComponent();
            

        }
   
        
      
        private void Button1_Click(object sender, EventArgs e)
        {
            using (var plus = new Pluslasku(this))
           
            {
               
                plus.ShowDialog();
                
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (var plus = new Vahennyslasku(this))
            {
                plus.ShowDialog();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (var plus = new Kertolasku(this))
            {
                plus.ShowDialog();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            using (var plus = new Jakolasku(this))
            {
                plus.ShowDialog();
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            using (var plus = new Palkinnot(this))
            {
               
                plus.ShowDialog();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
