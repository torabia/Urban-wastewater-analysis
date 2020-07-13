using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf; 


namespace RadBonyanui
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Client 
            string client = ClientTextbox.TextName;
            //operating 
            string operatoring = Operatoring.TextName;
            //Sewer_gis_id
            string Sewer_gis_id = Sewer_GIS_ID.TextName;
            //year_Comissioned 
            string year_Comissioned = Year_Comissioned.TextName;
            //division_district
            string division_district = Division_District.TextName;
            //type_of_survey
            string type_of_survey = Type_of_survey.TextName;
            //weather
            string weather = Weather.TextName;
            //survey_Date
            string survey_Date = Survey_Date.TextName;
            //start_Time
            string start_Time = Start_Time.TextName;
            //full_segment_CCTV
            string full_segment_CCTV = Full_segment_CCTV.TextName;


            addRecord(client, operatoring, Sewer_gis_id, year_Comissioned, division_district, type_of_survey, weather, survey_Date, start_Time, full_segment_CCTV, "step.txt");
            MessageBox.Show("Your data is saved");

        }
        public static void addRecord
            (string Client  , string Operator , string Sewer_GIS_ID , string Year_Comissioned , string Division_District , string Type_of_survey , string Weather , string Survey_Date ,string Start_Time , string Full_segment_CCTV, string filepath)
        {
            try
            {
                using(System.IO.StreamWriter FILE = new System.IO.StreamWriter(@filepath , true))
                {
                    FILE.WriteLine(Client + "," + Operator + "," + Sewer_GIS_ID + "," + Year_Comissioned + "," + Type_of_survey + "," + Division_District + "," + Weather + "," + Survey_Date + "," + Start_Time + "," + Full_segment_CCTV); 

                }

            }
            catch(Exception ex)
            {
                throw new ApplicationException("this program did an oopsie : ", ex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            step2 step2res = new step2();
            step2res.Show(); 
        }

        private void buttonCreat_Click(object sender, EventArgs e)
        {
            Document pdoc = new Document(PageSize.A4, 20f, 20f, 30f, 40f);
            PdfWriter pWriter = PdfWriter.GetInstance(pdoc, new FileStream("C:\\pdf.pdf", FileMode.Create));
            pdoc.Open();
            Paragraph praghraph = new Paragraph("Hello this is my pdf sdd");
            pdoc.Add(praghraph);
            pdoc.Close();

        }
    }
}
