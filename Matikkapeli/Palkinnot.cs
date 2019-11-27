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
    public partial class Palkinnot : Form
    {
        private Form1 form1;
        public Palkinnot(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            label2.Text = form1.palkinto.ToString();
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Palkinnot_Load(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
       
        }
    }
}
