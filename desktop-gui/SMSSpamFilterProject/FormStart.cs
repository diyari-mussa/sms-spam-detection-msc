using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSSpamFilterProject
{
    public partial class FormStart : Form
    {
        // required python .exe variables
        string pythonExePath;
        public static string SetValueForPythonExe = "";

        // required Preprocessing.py variables
        public static string SetValueForPrePy = "";

        // required Feature selection python variables
        public static string SetValueForFeatSelPy = "";

        // required prediction python file
        public static string SetValueForPredictPy = "";

        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            lblProjDesc.Text = "SMS spam detection Proj. for testing boosting algorithms," + Environment.NewLine + "feature extraction and selection." 
                + Environment.NewLine + "Created and Designed by: Diyari Jalal Mussa" + Environment.NewLine + "Supervised by: Dr. Noor Ghazi" + Environment.NewLine + "Sulaimani Polytechnic University" + Environment.NewLine + "Sulaymaniyah, iraq" + Environment.NewLine + "Thesis version";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SetValueForPythonExe = pythonExePath;

            if (SetValueForPythonExe != "" && SetValueForPrePy != "" && SetValueForFeatSelPy != "" && SetValueForPredictPy != "")
            {
                Form1 formCandidates = new Form1();
                this.Hide();
                formCandidates.ShowDialog();
                this.Close();
            }
            else {
                MessageBox.Show("Please Select all required files in order for this Project to work properly!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnPythonFile_Click(object sender, EventArgs e)
        {
            string pc_username = getComputerUsername();

            //pythonExePath = @"C:\Users\" + pc_username + @"\AppData\Local\Programs\Python\Python310\python.exe";
            pythonExePath = @"C:\Users\" + pc_username + @"\source\repos\SMSSpamFilterProject\SMSSpamFilterProject\Needed_Resources\Requirements_venv\venvpy37\Scripts\python.exe";

            try
            {
                if (!File.Exists(pythonExePath))
                {
                    MessageBox.Show("Python.exe not found!");
                }
                else
                {
                    MessageBox.Show("Your Python.exe successfully found in directory : " + pythonExePath); ;
                }
            }
            catch (Exception)
            {

            }
        }

        private string getComputerUsername()
        {
            string pc_username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            string[] parts1 = pc_username.Split(new string[] { @"\\" }, StringSplitOptions.None);
            string[] parts2 = Regex.Split(pc_username, @"\\");
            String finalText = parts2[1];

            return finalText;
        }

        private void btnPreporcessPyFile_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\MSI GP66\source\repos\SMSSpamFilterProject\SMSSpamFilterProject\Needed_Resources\Requirements_venv\Preprocessing.py";
            if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), path)))
            {
                SetValueForPrePy = path;
                MessageBox.Show(path + " Successfuly Loaded");
            }
            else
            { MessageBox.Show("No Preprocessing python file Found!"); }
        }

        private void btnFeatureSelPyFile_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\MSI GP66\source\repos\SMSSpamFilterProject\SMSSpamFilterProject\Needed_Resources\Requirements_venv\FeatureSelection.py";
            if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), path)))
            {
                SetValueForFeatSelPy = path;
                MessageBox.Show(path + " Successfuly Loaded");
            }
            else
            { MessageBox.Show("No Feature Selection python file Found!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\MSI GP66\source\repos\SMSSpamFilterProject\SMSSpamFilterProject\Needed_Resources\Requirements_venv\TestNewDataset.py";
            if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), path)))
            {
                SetValueForPredictPy = path;
                MessageBox.Show(path + " Successfuly Loaded");
            }
            else
            { MessageBox.Show("No Feature Selection python file Found!"); }
        }
    }
}
