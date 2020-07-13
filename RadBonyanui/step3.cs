using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadBonyanui
{
    public partial class step3 : Form
    {
        public string videoPath, videoTitle;
        public step3()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Defining a variable for primary data - 0.1 

            //Lining
            string lining = Lining.TextName;
            //Direction_of_Survey 
            string Direction_of_Survey = Direction.TextName;
            //Water_Kevel_(US)
            string water_kevel_us = Water_Kevel_US.TextName;
            //Water_Kevel_(DS)
            string water_kaval_ds = Water_Kevel_DS.TextName;
            //Width_(mm)
            string width_mm = Width.TextName;
            //Dia / Height (mm)
            string dia_mm = Dia.TextName;
            //Pipe Material 
            string pipe_material = Pipe.TextName;
            //Shape
            string shape = Shape.TextName;
            //Comment  
            string comment = Comment.TextName;

            addRecord(lining, Direction_of_Survey, water_kevel_us, water_kaval_ds, width_mm, dia_mm, pipe_material, shape, comment, "step3.txt");

            //run_cod();
            run_proc(); 


        }

        public static void addRecord
            (string lining, string Direction_of_Survey, string water_kevel_us, string water_kaval_ds, string width_mm, string dia_mm, string pipe_material, string shape, string comment , string filepath)
        {
            try
            {
                using (System.IO.StreamWriter FILE = new System.IO.StreamWriter(@filepath, true))
                {
                    FILE.WriteLine(lining + "," + Direction_of_Survey + "," + water_kevel_us + "," + water_kaval_ds + "," + width_mm + "," + dia_mm + "," + pipe_material + "," + shape + "," + comment);

                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("this program did an oopsie : ", ex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            analyze analyze1 = new analyze();
            analyze1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
       }

        private void btnOpenvid_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "MP4 File|*.mp4|ALL FILE|*.*" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoTitle = openFileDialog.SafeFileName;

            }
        }

        private void run_cod()
        {
            Console.WriteLine("Program processing began");
            // C:\Users\SEGAL\AppData\Local\Programs\Python\Python37\python.exe 
            // C:\Users\SEGAL\Documents\Visual Studio 2015\Projects\RadBonyanui\py\defect_detection\detect.py

            // 1) Create Process Info
            Console.WriteLine("Program processing Info");
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\SEGAL\AppData\Local\Programs\Python\Python37\python.exe ";

            Console.WriteLine("Program processing arguments");
            // 2) Provide script and arguments
            var script = @"C:\Users\SEGAL\Documents\Visual Studio 2015\Projects\RadBonyanui\py\defect_detection\intro.py";
            var start = "2019-1-1";
            var end = "2019-1-22";

            psi.Arguments = $"\"{script}\" \"{start}\" \"{end}\"";

            Console.WriteLine("Program processing configuration");
            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            Console.WriteLine("Program processing output");
            // 4) Execute process and get output
            var errors = "";
            var results = "";

            Console.WriteLine("Program processing psi");
            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }


            Console.WriteLine("Program processing output");
            // 5) Display output
            Console.WriteLine("ERRORS:");
            Console.WriteLine(errors);
            Console.WriteLine();
            Console.WriteLine("Results:");
            Console.WriteLine(results);



        }
        private void run_proc()
        {
  
        }
    }
}
