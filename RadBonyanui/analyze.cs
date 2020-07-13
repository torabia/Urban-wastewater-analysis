using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadBonyanui
{
    public partial class analyze : Form
    {
        string n, b; 

     
        public analyze()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.play();
        }

        private void btnOpenvid_Click(object sender, EventArgs e)
        {

            step3 step3 = new step3();
            n = step3.videoPath;
            b = step3.videoTitle;
            wmp.URL = n; 

                //videoPath = openFileDialog.FileName;
                //videoTitle = openFileDialog.SafeFileName;
                //wmp.URL = videoPath; 



        }
    }
}
