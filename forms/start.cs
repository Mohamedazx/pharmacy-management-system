using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy.forms
{
   
    public partial class start : Form
    {
        int startpoint = 0;
        public start()
        {
            InitializeComponent();
           // this.Opacity += startpoint; 


        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            // Opacity = startpoint;
            bunifuProgressBar1.Value = startpoint;

            if (bunifuProgressBar1.Value == 100)
            {
                bunifuProgressBar1.Value =100;
               // Opacity = 100;
                timer1.Stop();
                login n = new login();
                n.Show();
                this.Hide();
               
            }
        }

        private void start_Load(object sender, EventArgs e)
        {
            
            this.timer1.Start();
         
        }
    }
}
