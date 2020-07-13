using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadBonyanui
{
    public partial class step2 : Form
    {
        public step2()
        {
            InitializeComponent();
        }

        private void jMaterialTextbox9_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Road 
            string road = Road.TextName;
            //townOrVillage 
            string town_of_village = townOrVillage.TextName;
            //Standard 
            string standard = Standard.TextName;
            //Year_Comissioned
            string year_comissioned = Year_Comissioned.TextName;
            //Purpose 
            string purpose = Purpose.TextName;
            //US_MH GIS-ID
            string GIS_ID_US = US_MH.TextName;
            //DS_MH GIS-ID
            string GIS_ID_DS = DS_MH.TextName;
            //SIP Length
            string sip_length = SIP.TextName;
            //CCTV Length 
            string cctv_length = CCTV_Leng.TextName;

            //Pour the following output into the csv file 
            addRecord(road, town_of_village, standard, year_comissioned, purpose, GIS_ID_US, GIS_ID_DS, sip_length, cctv_length, "step2.txt");
            MessageBox.Show("Your data is saved");

            Process.Start(@"C:\Users\SEGAL\Documents\Visual Studio 2015\Projects\RadBonyanui\py\add_yolov3\detect.py");
        }
        public static void addRecord (string road, string town_of_village, string standard, string year_comissioned, string purpose, string GIS_ID_US, string GIS_ID_DS, string sip_length, string cctv_length , string filepath)
        {
            try
            {
                using (System.IO.StreamWriter FILE = new System.IO.StreamWriter(@filepath, true))
                {
                    FILE.WriteLine(road + "," + town_of_village + "," + standard + "," + year_comissioned + "," + purpose + "," + GIS_ID_US + "," + GIS_ID_DS + "," + sip_length + "," + cctv_length );

                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("this program did an oopsie : ", ex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            step3 step3res = new step3();
            step3res.Show(); 


        }
    }
}
