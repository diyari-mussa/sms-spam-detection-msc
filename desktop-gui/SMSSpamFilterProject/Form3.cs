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

namespace SMSSpamFilterProject
{
    public partial class Form3 : Form
    {
        // python files (exe, preprocessing.py)
        string pythonExePath;
        string pythonPredictPath;

        // Preprocessing variables
        string datasetPath; // dataset string
        // display outputs from preporcessing
        int getDatasetContent; // get dataset content only variable
        int checkMissingValue; // missing value checking state
        int getRenamedDsCols; // get dataset with renamed collumns
        int getClassDist; // get class distribution how many spam or ham
        int classEncoding; // class encoding to binary 
        int showUsefulInfo; // show usful information about the dataset
        string featureNamesVar;

        // classification
        int showGBMEvaluation;
        int showXGBEvaluation;
        int showLGBEvaluation;

        public Form3()
        {
            InitializeComponent();
        }

        public string Python_ExecProcess()
        {
            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            //psi.FileName = @"C:\Users\OMEN\AppData\Local\Programs\Python\Python37\python.exe";
            psi.FileName = pythonExePath;

            // 2) Provide script and arguments
            //var script = @"C:\Users\OMEN\Desktop\SMSSpamFilterPythonProject\Preprocessing.py";
            var script = pythonPredictPath;

            var datasetPath_arg = datasetPath;
            var datasetContnt_arg = getDatasetContent;
            var missingValue_arg = checkMissingValue;
            var renamedDsCols_arg = getRenamedDsCols;
            var columnClass_arg = tbColumnV1.Text;
            var columnMessage_arg = tbColumnV2.Text;
            var columnPurpose_arg = tbColumnV3.Text;
            var showClassDist_arg = getClassDist;
            var classEncoding_arg = classEncoding;
            var showUsefulInfo_arg = showUsefulInfo;

            var featureNamesVar_arg = featureNamesVar;

            var showGBMEvaluation_arg = showGBMEvaluation;
            var showXGBEvaluation_arg = showXGBEvaluation;
            var showLGBEvaluation_arg = showLGBEvaluation;

            psi.Arguments = $"\"{script}\" \"{datasetPath_arg}\" \"{datasetContnt_arg}\" \"{missingValue_arg}\" " +
                $" \"{renamedDsCols_arg}\" \"{columnClass_arg}\" \"{columnMessage_arg}\" \"{columnPurpose_arg}\" " +
                $" \"{showClassDist_arg}\" \"{classEncoding_arg}\" \"{showUsefulInfo_arg}\" " +
                $" \"{featureNamesVar_arg}\" \"{showGBMEvaluation_arg}\" \"{showXGBEvaluation_arg}\" \"{showLGBEvaluation_arg}\" ";

            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output
            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }

            // 5) Display output
            Console.WriteLine("ERRORS:");
            Console.WriteLine(errors);
            Console.WriteLine();
            Console.WriteLine("Results:");
            return results;

        }

        /* ------------------------------------------------------------------- */

        /* Section One :
        * --------------
        * Preprocessing Methods and buttons, checkboxes.. 
        */

        private void btnBrowsDataset_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Comma-Seprated vector|*.csv";
            openFileDialog1.Title = "Select SMS Messages Dataset file";

            // default directory
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            // Show the Dialog.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                datasetPath = openFileDialog1.FileName;

                tbDataset.Text = datasetPath;
                getDatasetContent = 1;
                tbPreLogs.Text = Python_ExecProcess();

            }
        }

        List<string> listofFeatures;
        private void Form3_Load(object sender, EventArgs e)
        {
            pythonExePath = FormStart.SetValueForPythonExe;
            lblPythonExe.Text = pythonExePath;

            pythonPredictPath = FormStart.SetValueForPredictPy;

            // get the selected feature names
            featureNamesVar = Form2.SetSelectedFeatureNames;

            //listofFeatures = new List<string>();

            listofFeatures = featureNamesVar.Split(',').ToList();

            lboxSelectedFeatures.DataSource = listofFeatures;

            // label texts
            lblNotes.Text = "- Selected features has extraced" + Environment.NewLine + "Fit the model (training the model)"
                + Environment.NewLine + "- (dataset column values are seprated into training and testing)" + Environment.NewLine + "Classification will be done using Training/Testing Split";
            
        }

        private void chbCheckMissingValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCheckMissingValue.Checked == true)
            {
                checkMissingValue = 1;
                tbPreLogs.Text = Python_ExecProcess();
            }
            else
            {
                checkMissingValue = 0;
                tbPreLogs.Text = Python_ExecProcess();
            }
        }

        private void btnShowNamedCol_Click(object sender, EventArgs e)
        {
            getRenamedDsCols = 1;
            tbPreLogs.Text = Python_ExecProcess();
        }

        private void chbShowClassDist_CheckedChanged(object sender, EventArgs e)
        {
            getClassDist = 1;
            tbPreLogs.Text = Python_ExecProcess();
        }

        private void chbrbEncodeClass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbrbEncodeClass.Checked == true)
            {
                classEncoding = 1;
                tbPreLogs.Text = Python_ExecProcess();
            }
            else
            {
                classEncoding = 0;
                tbPreLogs.Text = Python_ExecProcess();
            }
        }

        private void chbShowUsefulInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowUsefulInfo.Checked == true)
            {
                showUsefulInfo = 1;
                tbPreLogs.Text = Python_ExecProcess();
            }
            else
            {
                showUsefulInfo = 0;
                tbPreLogs.Text = Python_ExecProcess();
            }
        }
        

        private void btnGBMClassifier_Click(object sender, EventArgs e)
        {
            getDatasetContent = 0; 
            checkMissingValue = 0; 
            getRenamedDsCols = 0; 
            getClassDist = 0;
            classEncoding = 0;
            showUsefulInfo = 0;

            showGBMEvaluation = 1;
            tbClassifLogs.Text = Python_ExecProcess();
        }

        private void btnXGBClassifier_Click(object sender, EventArgs e)
        {
            getDatasetContent = 0;
            checkMissingValue = 0;
            getRenamedDsCols = 0;
            getClassDist = 0;
            classEncoding = 0;
            showUsefulInfo = 0;

            showXGBEvaluation = 1;
            tbClassifLogs.Text = Python_ExecProcess();
        }

        private void btnLGBClassifier_Click(object sender, EventArgs e)
        {
            getDatasetContent = 0;
            checkMissingValue = 0;
            getRenamedDsCols = 0;
            getClassDist = 0;
            classEncoding = 0;
            showUsefulInfo = 0;

            showLGBEvaluation = 1;
            tbClassifLogs.Text = Python_ExecProcess();
        }

        private void btnBackToForm2_Click(object sender, EventArgs e)
        {
            Form2 formTwo = new Form2();
            this.Hide();
            formTwo.ShowDialog();
            this.Close();
        }
    }
}
