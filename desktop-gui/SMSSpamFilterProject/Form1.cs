using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSSpamFilterProject
{
    public partial class Form1 : Form
    {
        // python files (exe, preprocessing.py)
        // string pythonFileName;
        string pythonExePath;
        string pythonPrePath;

        // Preprocessing variables
        string datasetPath; // dataset string
        // display outputs from preporcessing
        int getDatasetContent; // get dataset content only variable
        int checkMissingValue; // missing value checking state
        int getRenamedDsCols; // get dataset with renamed collumns
        int getClassDist; // get class distribution how many spam or ham
        int classEncoding; // class encoding to binary 
        int showUsefulInfo; // show usful information about the dataset

        // feature extraction variables
        // first we will convert dataset into a list
        int datasetToList;

        // if message row checked or not of the dataset
        int msgRowCheckState;
        int msgRowID; // it will be converted to int

        // checking between feature extraction types
        int checkAllFeature;
        int checknshowAllFeatures;
        int checkBinaryFeature;
        int checknshowBinaryFeatures;
        int checkNumericFeature;
        int checknshowNumericFeatures;
        // export all export features
        int exportAllFeatures;
        string exportCSVPath;

        // checking boosting algorithm types and showing thier evaluation parameters
        int checkGBMModel;
        int gbmBinaryEvaluation;
        int gbmNumericEvaluation;
        int gbmAllEvaluation;

        int checkXGBoostModel;
        int xgbBinaryEvaluation;
        int xgbNumericEvaluation;
        int xgbAllEvaluation;

        int checkLightGBModel;
        int lgbBinaryEvaluation;
        int lgbNumericEvaluation;
        int lgbAllEvaluation;

        public Form1()
        {
            InitializeComponent();
        }

        /* ------------------------------------------------------------------- */

        /* Section Fundamentals :
        * --------------
        * here we identify python file and its requirements
        */
        /*
        private void btnPythonBrows_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "python files|*.py";
            openFileDialog1.Title = "Select a Python File";

            // default directory
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                //this.Cursor = new Cursor(openFileDialog1.OpenFile())
                pythonFileName = openFileDialog1.FileName;


                //tbPythonFileDir.Text = pythonFileName;

            }
        }
        */

        private string getComputerUsername()
        {
            string pc_username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            string[] parts1 = pc_username.Split(new string[] { @"\\" }, StringSplitOptions.None);
            string[] parts2 = Regex.Split(pc_username, @"\\");
            String finalText = parts2[1];

            return finalText;
        }

        private void btnPythonExe_Click(object sender, EventArgs e)
        {
            string pc_username = getComputerUsername();

            pythonExePath = @"C:\Users\" + pc_username + @"\AppData\Local\Programs\Python\Python37\python.exe";

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

        /*
        private void run_cmd()
        {

            //string fileName = @"C:\Users\OMEN\Desktop\SMSSpamFilterPythonProject\Preprocessing.py";

            var datasetPath_arg = datasetPath;

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\OMEN\AppData\Local\Programs\Python\Python37\python.exe", pythonFileName)
            //p.StartInfo = new ProcessStartInfo(pythonExePath, pythonFileName)
            {
                //Arguments = string.Format("{0}", args[0])
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true

            };
            p.Start();


            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            //Console.WriteLine(output);
            tbPreLogs.Text = output;
            //Console.ReadLine();

        }
        */

        public string Python_ExecProcess()
        {
            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            //psi.FileName = @"C:\Users\OMEN\AppData\Local\Programs\Python\Python37\python.exe";
            psi.FileName = pythonExePath;

            // 2) Provide script and arguments
            //var script = @"C:\Users\OMEN\Desktop\SMSSpamFilterPythonProject\Preprocessing.py";
            var script = pythonPrePath;

            var datasetPath_arg = datasetPath;
            var datasetContnt_arg = getDatasetContent;
            var missingValue_arg = checkMissingValue;
            var renamedDsCols_arg = getRenamedDsCols;
            var columnClass_arg = tbColumnV1.Text;
            var columnMessage_arg = tbColumnV2.Text;
            var showClassDist_arg = getClassDist;
            var classEncoding_arg = classEncoding;
            var showUsefulInfo_arg = showUsefulInfo;

            var datasetToList_arg = datasetToList;
            var msgRowCheckState_arg = msgRowCheckState;
            var msgRowID_arg = msgRowID;

            var allFeatureExtr_arg = checkAllFeature;
            var allFeatureExtrShow_arg = checknshowAllFeatures;
            var binaryFeatureExtr_arg = checkBinaryFeature;
            var binaryFeatureExtrShow_arg = checknshowBinaryFeatures;
            var numericFeatureExtr_arg = checkNumericFeature;
            var numericFeatureExtrShow_arg = checknshowNumericFeatures;

            var allFeatureExport_arg = exportAllFeatures;
            var exportCSVPath_arg = exportCSVPath;

            var gbmModelChecked_arg = checkGBMModel;
            var gbmBinEvaluationShow_arg = gbmBinaryEvaluation;
            var gbmNumEvaluationShow_arg = gbmNumericEvaluation;
            var gbmAllEvaluationShow_arg = gbmAllEvaluation;

            var xgbModelChecked_arg = checkXGBoostModel;
            var xgbBinEvaluationShow_arg = xgbBinaryEvaluation;
            var xgbNumEvaluationShow_arg = xgbNumericEvaluation;
            var xgbAllEvaluationShow_arg = xgbAllEvaluation;

            var lgbModelChecked_arg = checkLightGBModel;
            var lgbBinEvaluationShow_arg = lgbBinaryEvaluation;
            var lgbNumEvaluationShow_arg = lgbNumericEvaluation;
            var lgbAllEvaluationShow_arg = lgbAllEvaluation;

            psi.Arguments = $"\"{script}\" \"{datasetPath_arg}\" \"{datasetContnt_arg}\" \"{missingValue_arg}\" \"{renamedDsCols_arg}\"" +
                $" \"{columnClass_arg}\" \"{columnMessage_arg}\" \"{showClassDist_arg}\" \"{classEncoding_arg}\" \"{showUsefulInfo_arg}\" " +
                $" \"{datasetToList_arg}\" \"{msgRowCheckState_arg}\" \"{msgRowID_arg}\" " +
                $" \"{allFeatureExtr_arg}\" \"{allFeatureExtrShow_arg}\" \"{binaryFeatureExtr_arg}\" \"{binaryFeatureExtrShow_arg}\" \"{numericFeatureExtr_arg}\" \"{numericFeatureExtrShow_arg}\" " +
                $" \"{allFeatureExport_arg}\" \"{exportCSVPath_arg}\" " +
                $" \"{gbmModelChecked_arg}\" \"{gbmBinEvaluationShow_arg}\" \"{gbmNumEvaluationShow_arg}\" \"{gbmAllEvaluationShow_arg}\" " +
                $" \"{xgbModelChecked_arg}\" \"{xgbBinEvaluationShow_arg}\" \"{xgbNumEvaluationShow_arg}\" \"{xgbAllEvaluationShow_arg}\" " +
                $" \"{lgbModelChecked_arg}\" \"{lgbBinEvaluationShow_arg}\" \"{lgbNumEvaluationShow_arg}\" \"{lgbAllEvaluationShow_arg}\"" +
                $"  ";

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
        
        /*
        private void button2_Click_1(object sender, EventArgs e)
        {
            
             getDatasetContent = 0;
             checkMissingValue = 0;
             getRenamedDsCols = 0;
             getClassDist = 0;
             classEncoding = 0;
            showUsefulInfo = 0;
            datasetToList = 1;

            // assign the list of the dataset messages to multiline string variable
            string deviceListStr = Python_ExecProcess();

            // convert multiline string to array string
            string[] splitted = deviceListStr.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // adding message to the list
            foreach (string message in splitted)
            {
                checkedListBox1.Items.Add(message);   
            }
        }*/

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

        private void chbCheckMissingValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCheckMissingValue.Checked == true)
            {
                checkMissingValue = 1;
                tbPreLogs.Text = Python_ExecProcess();
            }
            else {
                checkMissingValue = 0;
                tbPreLogs.Text = Python_ExecProcess();
            }
        }

        private void chbrbEncodeClass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbrbEncodeClass.Checked == true)
            {
                classEncoding = 1;
                tbPreLogs.Text = Python_ExecProcess();
            }
            else {
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

        //  this methode is responsible to not to show preprocessing outputs
        public void preprocessingOutputsInvisible()
        {

            getDatasetContent = 0;
            checkMissingValue = 0;
            getRenamedDsCols = 0;
            getClassDist = 0;
            classEncoding = 0;
            showUsefulInfo = 0;
        }

        /* ------------------------------------------------------------------- */

        /* Section Two :
        * --------------
        * Feature Extraction, selecting each feature and extract them
        */

        string getSelectedMsg;
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // hide export 
            exportAllFeatures = 0;

            int iSelectedIndex = checkedListBox1.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < checkedListBox1.Items.Count; iIndex++)
                checkedListBox1.SetItemCheckState(iIndex, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(iSelectedIndex, CheckState.Checked);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    if (checkAllFeature == 1)
                    {
                        string str = (string)checkedListBox1.Items[i];
                        getSelectedMsg = str;
                        //MessageBox.Show(getOnlyMessageID(str));

                        msgRowCheckState = 1;

                        msgRowID = int.Parse(getOnlyMessageID(str)); ;

                        preprocessingOutputsInvisible();
                        datasetToList = 0;
                        //tbFEMessage.Text = Python_ExecProcess();

                        // 
                        // assign extracted messages and feature values to string
                        string extractedFeatureStr = Python_ExecProcess();

                        // convert multiline string to array string
                        string[] splitted = extractedFeatureStr.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                        tbFEMessage.Text = splitted[0];
                        tbFeature1.Text = splitted[1];
                        tbFeature2.Text = splitted[2];
                        tbFeature3.Text = splitted[3];
                        tbFeature4.Text = splitted[4];
                        tbFeature5.Text = splitted[5];
                        tbFeature6.Text = splitted[6];
                        tbFeature7.Text = splitted[7];
                        tbFeature8.Text = splitted[8];
                        tbFeature9.Text = splitted[9];
                        tbFeature10.Text = splitted[10];
                        tbFeature11.Text = splitted[11];
                        tbFeature12.Text = splitted[12];
                        tbFeature13.Text = splitted[13];
                        tbFeature14.Text = splitted[14];
                        tbFeature15.Text = splitted[15];
                        tbFeature16.Text = splitted[16];
                        tbFeature17.Text = splitted[17];
                        tbFeature18.Text = splitted[18];
                        tbFeature19.Text = splitted[19];
                        tbFeature20.Text = splitted[20];
                        tbFeature21.Text = splitted[21];
                        tbFeature22.Text = splitted[22];
                        tbFeature23.Text = splitted[23];
                        tbFeature24.Text = splitted[24];
                        tbFeature25.Text = splitted[25];
                        tbFeature26.Text = splitted[26];

                        //tbFeature10.Text = splitted[10];

                        //tbFeature1.Text = splitted[1];
                    }

                    if (checkBinaryFeature == 1)
                    {

                        string str = (string)checkedListBox1.Items[i];
                        getSelectedMsg = str;
                        //MessageBox.Show(getOnlyMessageID(str));

                        msgRowCheckState = 1;

                        msgRowID = int.Parse(getOnlyMessageID(str)); ;

                        preprocessingOutputsInvisible();
                        datasetToList = 0;
                        //tbFEMessage.Text = Python_ExecProcess();

                        // 
                        // assign extracted messages and feature values to string
                        string extractedFeatureStr = Python_ExecProcess();

                        // convert multiline string to array string
                        string[] splitted = extractedFeatureStr.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                        tbFEMessage.Text = splitted[0];
                        tbFeature1.Text = splitted[1];
                        tbFeature2.Text = splitted[2];
                        tbFeature3.Text = splitted[3];
                        tbFeature4.Text = splitted[4];
                        tbFeature5.Text = splitted[5];
                        tbFeature6.Text = splitted[6];
                        tbFeature7.Text = splitted[7];
                        tbFeature8.Text = splitted[8];
                        tbFeature9.Text = splitted[9];
                        tbFeature10.Text = splitted[10];
                        tbFeature11.Text = splitted[11];
                        tbFeature12.Text = splitted[12];
                        tbFeature13.Text = splitted[13];
                        tbFeature14.Text = splitted[14];
                        tbFeature15.Text = splitted[15];
                        tbFeature16.Text = splitted[16];
                        tbFeature17.Text = splitted[17];
                        tbFeature18.Text = splitted[18];
                    }

                    if (checkNumericFeature == 1)
                    {
                        string str = (string)checkedListBox1.Items[i];
                        getSelectedMsg = str;
                        //MessageBox.Show(getOnlyMessageID(str));

                        msgRowCheckState = 1;

                        msgRowID = int.Parse(getOnlyMessageID(str)); ;

                        preprocessingOutputsInvisible();
                        datasetToList = 0;
                        //tbFEMessage.Text = Python_ExecProcess();

                        // 
                        // assign extracted messages and feature values to string
                        string extractedFeatureStr = Python_ExecProcess();

                        // convert multiline string to array string
                        string[] splitted = extractedFeatureStr.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                        tbFEMessage.Text = splitted[0];
                        tbFeature1.Text = splitted[1];
                        tbFeature2.Text = splitted[2];
                        tbFeature3.Text = splitted[3];
                        tbFeature4.Text = splitted[4];
                        tbFeature5.Text = splitted[5];
                        tbFeature6.Text = splitted[6];
                        tbFeature7.Text = splitted[7];
                        tbFeature8.Text = splitted[8];
                    }
                }
            }
        }

        private string getOnlyMessageID(string msg) {

            string[] parts1 = msg.Split(new string[] { " " }, StringSplitOptions.None);
            string[] parts2 = Regex.Split(msg, " ");
            String finalText = parts2[0];
            string[] parts3 = finalText.Split(new string[] { "}" }, StringSplitOptions.None);
            string[] parts4 = Regex.Split(finalText, "}");
            String finalTextAll = parts4[0];

            return finalText;
        }

        

        private void btnFeature8_Click(object sender, EventArgs e)
        {
            // feature8 is math symbol here
            if (rbAllFeatures.Checked == true)
            {
                featureMathSymbolExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featurePhoneNumberWExsist();
            }

            if (rbNumericFeatures.Checked == true)
            {
                featureSpamKeyWords();
            }
        }

        private void featureMessageLength()
        {
            string str = tbFEMessage.Text;
            MessageBox.Show("Message Length is : " + str.Length);
        }

        
        private void featureSlashCount() {

            string str = tbFEMessage.Text;
            int slashCount = 0;

            if (Regex.IsMatch(str, @"/"))
            {
                foreach (Match match in Regex.Matches(str, @"/"))
                {
                    if (match.Success)
                    {
                        slashCount++;
                    }
                }

                MessageBox.Show("Count of Slash : " + slashCount);
            }
            else
            {
                // false;
            }
        }
        
        private void featurePunctuationsCount()
        {
            List<string> listPunctuationsCount = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"[^a-zA-Z0-9 ]"))
            {
                foreach (Match match in Regex.Matches(str, @"[^a-zA-Z0-9 ]"))
                {
                    if (match.Success)
                    {
                        listPunctuationsCount.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, listPunctuationsCount);
                MessageBox.Show("punctuations found in the message: \n" + message);
                
            }
            else
            {
                // false;
            }
        }

        private void featurealphanumericWCount()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"(?:[0-9][^ ]*[A-Za-z][^ ]*)|(?:[A-Za-z][^ ]*[0-9][^ ]*)"))
            {
                foreach (Match match in Regex.Matches(str, @"(?:[0-9][^ ]*[A-Za-z][^ ]*)|(?:[A-Za-z][^ ]*[0-9][^ ]*)"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("alphanumeric words found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }
        
        private void featureNumericWCount()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"\d+(\.\d+)?"))
            {
                foreach (Match match in Regex.Matches(str, @"\d+(\.\d+)?"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("numeric words found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        
        private void featureUpperCaseLetterCount()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            int countUpper = 0;
            if (Regex.IsMatch(str, @"\p{Lu}"))
            {
                foreach (Match match in Regex.Matches(str, @"\p{Lu}"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                        countUpper++;
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("uppercase letter found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureNumWordsCount()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"([^\s][a-zA-Z]+)"))
            {
                foreach (Match match in Regex.Matches(str, @"([^\s][a-zA-Z]+)"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Number of words found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureMathSymbolExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"\+|\-|<|>|/|\^"))
            {
                foreach (Match match in Regex.Matches(str, @"\+|\-|<|>|/|\^"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Math Symbol found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureURLExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"(?i)\bhttp[s]?[:]?[//]?[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|www\.[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|http[\s]|.co.uk"))
            {
                foreach (Match match in Regex.Matches(str, @"(?i)\bhttp[s]?[:]?[//]?[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|www\.[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|http[\s]|.co.uk"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("URL found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureDotExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"\."))
            {
                foreach (Match match in Regex.Matches(str, @"\."))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Dots found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureSpecialSymbolExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"£|\$|!|\*|&|#|~"))
            {
                foreach (Match match in Regex.Matches(str, @"£|\$|!|\*|&|#|~"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Special symbol found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureEmotionssExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @":\)|:-\)|:\(|:-\(|;\);-\)|:-O|:P|:D|:\||:\$|:@|8o\||\+o\(|\(H\)|\(C\)|\(\?\)|;\)|-_-|:\*|:o|:\'\(|:V|:3|\*\^\*|xD|<3|-\.-|,-\)|\(:-\(|\(:-\)|\'-\)|:-#|:-\/|:->|:-@|:-d|:-V|:-X|:-]|;-\(|;\^\)|8:-\)|8:-\)"))
            {
                foreach (Match match in Regex.Matches(str, @":\)|:-\)|:\(|:-\(|;\);-\)|:-O|:P|:D|:\||:\$|:@|8o\||\+o\(|\(H\)|\(C\)|\(\?\)|;\)|-_-|:\*|:o|:\'\(|:V|:3|\*\^\*|xD|<3|-\.-|,-\)|\(:-\(|\(:-\)|\'-\)|:-#|:-\/|:->|:-@|:-d|:-V|:-X|:-]|;-\(|;\^\)|8:-\)|8:-\)"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Emotions found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureLowercaseWExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            int countLowerW = 0;
            if (Regex.IsMatch(str, @"\b[a-z]+\b"))
            {
                foreach (Match match in Regex.Matches(str, @"\b[a-z]+\b"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                        countLowerW++;
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Lowercase word found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureUppercaseWExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            int countUpperW = 0;

            if (Regex.IsMatch(str, @"\b[A-Z]{2,20}\b"))
            {
                foreach (Match match in Regex.Matches(str, @"\b[A-Z]{2,20}\b"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                        countUpperW++;
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("uppercase word found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featurePhoneNumberWExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"[+]?\(?[\d]{3,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{4,7}|[+]?\(?[\d]{1,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{3,4}[\s-][\d]{3,4}\b"))
            {
                foreach (Match match in Regex.Matches(str, @"[+]?\(?[\d]{3,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{4,7}|[+]?\(?[\d]{1,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{3,4}[\s-][\d]{3,4}\b"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Phone Number found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureCurrencyPNumExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"[£|\$|\€|\¥][\s]?\d+[\.]?\d+"))
            {
                foreach (Match match in Regex.Matches(str, @"[£|\$|\€|\¥][\s]?\d+[\.]?\d+"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Currency + number found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureNumberPPercentExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"(?i)\d+[\.]?\d+[\s]?%|\d+[\.]?\d+[\s]?percent|%[\s]?\d+[\.]?\d+"))
            {
                foreach (Match match in Regex.Matches(str, @"(?i)\d+[\.]?\d+[\s]?%|\d+[\.]?\d+[\s]?percent|%[\s]?\d+[\.]?\d+"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Number + % percent found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureRingTelPNumExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"(?i)ring[\s]?\d+|call[\s]?\d+|cal[\s]?\d+|tel[\s]?\d+"))
            {
                foreach (Match match in Regex.Matches(str, @"(?i)ring[\s]?\d+|call[\s]?\d+|cal[\s]?\d+|tel[\s]?\d+"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Reing,tel,call+number  Words found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureDateTimeExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"(?i)Jan[\s]?\d+|January[\s]?\d+|Feb[\s]?\d+|February[\s]?\d+|Mar[\s]?\d+|March[\s]?\d+|Apr[\s]?\d+|April[\s]?\d+|May[\s]?\d+|Jun[\s]?\d+|June[\s]?\d+|Jul[\s]?\d+|July[\s]?\d+|August[\s]?\d+|Sep[\s]?\d+|September[\s]?\d+|Oct[\s]?\d+|October[\s]?\d+|Nov[\s]?\d+|November[\s]?\d+|Dec[\s]?\d+|December[\s]?\d+"))
            {
                foreach (Match match in Regex.Matches(str, @"(?i)Jan[\s]?\d+|January[\s]?\d+|Feb[\s]?\d+|February[\s]?\d+|Mar[\s]?\d+|March[\s]?\d+|Apr[\s]?\d+|April[\s]?\d+|May[\s]?\d+|Jun[\s]?\d+|June[\s]?\d+|Jul[\s]?\d+|July[\s]?\d+|August[\s]?\d+|Sep[\s]?\d+|September[\s]?\d+|Oct[\s]?\d+|October[\s]?\d+|Nov[\s]?\d+|November[\s]?\d+|Dec[\s]?\d+|December[\s]?\d+"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Date Time found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureLongStrNumExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"\d{13,35}"))
            {
                foreach (Match match in Regex.Matches(str, @"\d{13,35}"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("long string number found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureEmailExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"[a-zA-Z0-9.!#$%&\'*+=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*"))
            {
                foreach (Match match in Regex.Matches(str, @"[a-zA-Z0-9.!#$%&\'*+=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("email found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureCurrencySymbExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"£|\$|\€|\¥"))
            {
                foreach (Match match in Regex.Matches(str, @"£|\$|\€|\¥"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Currency symbol found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureServiceNumExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"\b\d{5}\b|\b\d{4}\b|\b\d{6}\b"))
            {
                foreach (Match match in Regex.Matches(str, @"\b\d{5}\b|\b\d{4}\b|\b\d{6}\b"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Service Number found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureCurrencyWExsist()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text;

            if (Regex.IsMatch(str, @"(?i)\d+[\s]?pound|\d+[\s]?p\b|\d+[\s]?pence\b|gbp|\d+[\s]?USD\b|\d+[\s]?dollar\b"))
            {
                foreach (Match match in Regex.Matches(str, @"(?i)\d+[\s]?pound|\d+[\s]?p\b|\d+[\s]?pence\b|gbp|\d+[\s]?USD\b|\d+[\s]?dollar\b"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Currency Word found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }

        private void featureSpamKeyWords()
        {
            List<string> list = new List<string>();
            string str = tbFEMessage.Text.ToLower();

            if (Regex.IsMatch(str, @"free|ringtone|claim|txt |text|reply|nokia|win |video|mobile|award|dating|won |lottery|entitled"))
            {
                foreach (Match match in Regex.Matches(str, @"free|ringtone|claim|txt |text|reply|nokia|win |video|mobile|award|dating|won |lottery|entitled"))
                {
                    if (match.Success)
                    {
                        list.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, list);
                MessageBox.Show("Spam keywords found in this message: \n" + message);

            }
            else
            {
                // false;
            }
        }



        private void btnShowDatasetMessages_Click(object sender, EventArgs e)
        {
            // Hide all preprocessing Results
            preprocessingOutputsInvisible();
            // Hide Export All Features
            exportAllFeatures = 0;
            // Hide All Learning Results
            gbmEvaluationHide();
            xgbEvaluationHide();
            lgbEvaluationHide();

            datasetToList = 1;

            // assign the list of the dataset messages to multiline string variable
            string deviceListStr = Python_ExecProcess();

            // convert multiline string to array string
            string[] splitted = deviceListStr.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // adding message to the list
            foreach (string message in splitted)
            {
                checkedListBox1.Items.Add(message);
            }
        }
        
        private void rbBinaryFeatures_CheckedChanged(object sender, EventArgs e)
        {
            checkBinaryFeature = 1;
            checknshowBinaryFeatures = 1;

            rbNumericFeatures.Checked = false;
            rbAllFeatures.Checked = false;
            checkNumericFeature = 0;
            checkAllFeature = 0;

            ShowOnlyBinaryFeatures();
            ClearFeatureTBoxes();

            renameLabelsBinary();

            lblVarSelectedFG.Text = "Binary features";
        }

        private void rbNumericFeatures_CheckedChanged(object sender, EventArgs e)
        {
            checkNumericFeature = 1;
            checknshowNumericFeatures = 1;

            rbBinaryFeatures.Checked = false;
            rbAllFeatures.Checked = false;
            checkBinaryFeature = 0;
            checkAllFeature = 0;

            ShowOnlyNumericFeatures();
            ClearFeatureTBoxes();

            renameLabelsNumeric();

            lblVarSelectedFG.Text = "Numeric features";
        }

        private void rbAllFeatures_CheckedChanged(object sender, EventArgs e)
        {
            checkAllFeature = 1;
            checknshowAllFeatures = 1;

            rbBinaryFeatures.Checked = false;
            rbNumericFeatures.Checked = false;
            checkBinaryFeature = 0;
            checkNumericFeature = 0;

            ShowAllFeatures();
            ClearFeatureTBoxes();

            renameLabelsAll();

            lblVarSelectedFG.Text = "All features (binary and numeric)";
        }
        
        public void ShowOnlyBinaryFeatures() {

            lblFeature9.Visible = true;
            lblFeature10.Visible = true;
            lblFeature11.Visible = true;
            lblFeature12.Visible = true;
            lblFeature13.Visible = true;
            lblFeature14.Visible = true;
            lblFeature15.Visible = true;
            lblFeature16.Visible = true;
            lblFeature17.Visible = true;
            lblFeature18.Visible = true;
            lblFeature19.Visible = false;
            lblFeature20.Visible = false;
            lblFeature21.Visible = false;
            lblFeature22.Visible = false;
            lblFeature23.Visible = false;
            lblFeature24.Visible = false;
            lblFeature25.Visible = false;
            lblFeature26.Visible = false;

            tbFeature9.Visible = true;
            tbFeature10.Visible = true;
            tbFeature11.Visible = true;
            tbFeature12.Visible = true;
            tbFeature13.Visible = true;
            tbFeature14.Visible = true;
            tbFeature15.Visible = true;
            tbFeature16.Visible = true;
            tbFeature17.Visible = true;
            tbFeature18.Visible = true;
            tbFeature19.Visible = false;
            tbFeature20.Visible = false;
            tbFeature21.Visible = false;
            tbFeature22.Visible = false;
            tbFeature23.Visible = false;
            tbFeature24.Visible = false;
            tbFeature25.Visible = false;
            tbFeature26.Visible = false;

            

            btnFeature9.Visible = true;
            btnFeature10.Visible = true;
            btnFeature11.Visible = true;
            btnFeature12.Visible = true;
            btnFeature13.Visible = true;
            btnFeature14.Visible = true;
            btnFeature15.Visible = true;
            btnFeature16.Visible = true;
            btnFeature17.Visible = true;
            btnFeature18.Visible = true;
            btnFeature19.Visible = false;
            btnFeature20.Visible = false;
            btnFeature21.Visible = false;
            btnFeature22.Visible = false;
            btnFeature23.Visible = false;
            btnFeature24.Visible = false;
            btnFeature25.Visible = false;
            btnFeature26.Visible = false;
        }

        public void ShowOnlyNumericFeatures()
        {
            lblFeature9.Visible = false;
            lblFeature10.Visible = false;
            lblFeature11.Visible = false;
            lblFeature12.Visible = false;
            lblFeature13.Visible = false;
            lblFeature14.Visible = false;
            lblFeature15.Visible = false;
            lblFeature16.Visible = false;
            lblFeature17.Visible = false;
            lblFeature18.Visible = false;
            lblFeature19.Visible = false;
            lblFeature20.Visible = false;
            lblFeature21.Visible = false;
            lblFeature22.Visible = false;
            lblFeature23.Visible = false;
            lblFeature24.Visible = false;
            lblFeature25.Visible = false;
            lblFeature26.Visible = false;

            tbFeature9.Visible = false;
            tbFeature10.Visible = false;
            tbFeature11.Visible = false;
            tbFeature12.Visible = false;
            tbFeature13.Visible = false;
            tbFeature14.Visible = false;
            tbFeature15.Visible = false;
            tbFeature16.Visible = false;
            tbFeature17.Visible = false;
            tbFeature18.Visible = false;
            tbFeature19.Visible = false;
            tbFeature20.Visible = false;
            tbFeature21.Visible = false;
            tbFeature22.Visible = false;
            tbFeature23.Visible = false;
            tbFeature24.Visible = false;
            tbFeature25.Visible = false;
            tbFeature26.Visible = false;

            btnFeature9.Visible = false;
            btnFeature10.Visible = false;
            btnFeature11.Visible = false;
            btnFeature12.Visible = false;
            btnFeature13.Visible = false;
            btnFeature14.Visible = false;
            btnFeature15.Visible = false;
            btnFeature16.Visible = false;
            btnFeature17.Visible = false;
            btnFeature18.Visible = false;
            btnFeature19.Visible = false;
            btnFeature20.Visible = false;
            btnFeature21.Visible = false;
            btnFeature22.Visible = false;
            btnFeature23.Visible = false;
            btnFeature24.Visible = false;
            btnFeature25.Visible = false;
            btnFeature26.Visible = false;
        }

        public void ShowAllFeatures()
        {
            lblFeature9.Visible = true;
            lblFeature10.Visible = true;
            lblFeature11.Visible = true;
            lblFeature12.Visible = true;
            lblFeature13.Visible = true;
            lblFeature14.Visible = true;
            lblFeature15.Visible = true;
            lblFeature16.Visible = true;
            lblFeature17.Visible = true;
            lblFeature18.Visible = true;
            lblFeature19.Visible = true;
            lblFeature20.Visible = true;
            lblFeature21.Visible = true;
            lblFeature22.Visible = true;
            lblFeature23.Visible = true;
            lblFeature24.Visible = true;
            lblFeature25.Visible = true;
            lblFeature26.Visible = true;

            tbFeature9.Visible = true;
            tbFeature10.Visible = true;
            tbFeature11.Visible = true;
            tbFeature12.Visible = true;
            tbFeature13.Visible = true;
            tbFeature14.Visible = true;
            tbFeature15.Visible = true;
            tbFeature16.Visible = true;
            tbFeature17.Visible = true;
            tbFeature18.Visible = true;
            tbFeature19.Visible = true;
            tbFeature20.Visible = true;
            tbFeature21.Visible = true;
            tbFeature22.Visible = true;
            tbFeature23.Visible = true;
            tbFeature24.Visible = true;
            tbFeature25.Visible = true;
            tbFeature26.Visible = true;

            btnFeature9.Visible = true;
            btnFeature10.Visible = true;
            btnFeature11.Visible = true;
            btnFeature12.Visible = true;
            btnFeature13.Visible = true;
            btnFeature14.Visible = true;
            btnFeature15.Visible = true;
            btnFeature16.Visible = true;
            btnFeature17.Visible = true;
            btnFeature18.Visible = true;
            btnFeature19.Visible = true;
            btnFeature20.Visible = true;
            btnFeature21.Visible = true;
            btnFeature22.Visible = true;
            btnFeature23.Visible = true;
            btnFeature24.Visible = true;
            btnFeature25.Visible = true;
            btnFeature26.Visible = true;
        }

        public void ClearFeatureTBoxes() {

            tbFEMessage.Text = "";

            tbFeature1.Text = "";
            tbFeature2.Text = "";
            tbFeature3.Text = "";
            tbFeature4.Text = "";
            tbFeature5.Text = "";
            tbFeature6.Text = "";
            tbFeature7.Text = "";
            tbFeature8.Text = "";
            tbFeature9.Text = "";
            tbFeature10.Text = "";
            tbFeature11.Text = "";
            tbFeature12.Text = "";
            tbFeature13.Text = "";
            tbFeature14.Text = "";
            tbFeature15.Text = "";
            tbFeature16.Text = "";
            tbFeature17.Text = "";
            tbFeature18.Text = "";
            tbFeature19.Text = "";
            tbFeature20.Text = "";
            tbFeature21.Text = "";
            tbFeature22.Text = "";
            tbFeature23.Text = "";
            tbFeature24.Text = "";
            tbFeature25.Text = "";
            tbFeature26.Text = "";
        }

        public void featureExtractionInvisible() {

            datasetToList = 0;

            // empty the listbox
            checkedListBox1.Items.Clear();

            ClearFeatureTBoxes();
        }


        public void renameLabelsBinary()
        {

            lblFeature1.Text = "feature1 (math symbols)";
            lblFeature2.Text = "feature2 (URL)";
            lblFeature3.Text = "feature3 (dots)";
            lblFeature4.Text = "feature4 (special symbol)";
            lblFeature5.Text = "feature5 (emotionss)";
            lblFeature6.Text = "feature6 (lowercase words)";
            lblFeature7.Text = "feature7 (uppercase words)";
            lblFeature8.Text = "feature8 (phone number)";
            lblFeature9.Text = "feature9 (currency+number)";
            lblFeature10.Text = "feature10 (number+% or number+percent)";
            lblFeature11.Text = "feature11 (Ring, tel, call+number)";
            lblFeature12.Text = "feature12 (Time, date)";
            lblFeature13.Text = "feature13 (Long string number)";
            lblFeature14.Text = "feature14 (email)";
            lblFeature15.Text = "feature15 (Currency (£, $, €, ¥))";
            lblFeature16.Text = "feature16 (service numbers)";
            lblFeature17.Text = "feature17 (currency as word)";
            lblFeature18.Text = "feature18 (spam keywords)";
        }

        public void renameLabelsNumeric()
        {

            lblFeature1.Text = "feature1 (message length)";
            lblFeature2.Text = "feature2 (Count of slash)";
            lblFeature3.Text = "feature3 (non-alphanumeric char)";
            lblFeature4.Text = "feature4 (alphanumeric words)";
            lblFeature5.Text = "feature5 (numeric words)";
            lblFeature6.Text = "feature6 (uppercase letter)";
            lblFeature7.Text = "feature7 (number of words)";
            lblFeature8.Text = "feature8 (spam keyword)";
        }

        public void renameLabelsAll()
        {
            lblFeature1.Text = "feature1 (message length)";
            lblFeature2.Text = "feature2 (Count of slash)";
            lblFeature3.Text = "feature3 (non-alphanumeric char)";
            lblFeature4.Text = "feature4 (alphanumeric words)";
            lblFeature5.Text = "feature5 (numeric words)";
            lblFeature6.Text = "feature6 (uppercase letter)";
            lblFeature7.Text = "feature7 (number of words)";

            lblFeature8.Text = "feature8 (math symbols)";
            lblFeature9.Text = "feature9 (URL)";
            lblFeature10.Text = "feature10 (dots)";
            lblFeature11.Text = "feature11 (special symbol)";
            lblFeature12.Text = "feature12 (emotionss)";
            lblFeature13.Text = "feature13 (lowercase words)";
            lblFeature14.Text = "feature14 (uppercase words)";
            lblFeature15.Text = "feature15 (phone number)";
            lblFeature16.Text = "feature16 (currency+number)";
            lblFeature17.Text = "feature17 (number+% or number+percent)";
            lblFeature18.Text = "feature18 (Ring, tel, call+number)";
            lblFeature19.Text = "feature19 (Time, date)";
            lblFeature20.Text = "feature20 (Long string number)";
            lblFeature21.Text = "feature21 (email)";
            lblFeature22.Text = "feature22 (Currency (£, $, €, ¥))";
            lblFeature23.Text = "feature23 (service numbers)";
            lblFeature24.Text = "feature24 (currency as word)";
            lblFeature25.Text = "feature25 (count of spam keywords)";

            lblFeature26.Text = "feature26 (presence of spam keyword)";
        }

        
        /* ------------------------------------------------------------------- */

        /* Section Three :
        * --------------
        * Model evaluation and performance metrics.. 
        */

        private void chbGBM_CheckedChanged(object sender, EventArgs e)
        {
            if(chbGBM.Checked == true)
                checkGBMModel = 1;
            else
                checkGBMModel = 0;
        }

        private void btnEvaluateModel_Click(object sender, EventArgs e)
        {
            preprocessingOutputsInvisible();
            featureExtractionInvisible();

            if (rbAllFeatures.Checked == true)
            {
                if (chbGBM.Checked == true)
                {
                    checknshowAllFeatures = 0;
                    gbmAllEvaluation = 1;
                    tbModelEvalLogs.Text = Python_ExecProcess();
                }
            }

            if (rbBinaryFeatures.Checked == true)
            {
                if (chbGBM.Checked == true)
                {
                    checknshowBinaryFeatures = 0;
                    gbmBinaryEvaluation = 1;
                    tbModelEvalLogs.Text = Python_ExecProcess();
                }
            }

            if (rbNumericFeatures.Checked == true)
            {
                if (chbGBM.Checked == true)
                {
                    checknshowNumericFeatures = 0;
                    gbmNumericEvaluation = 1;
                    tbModelEvalLogs.Text = Python_ExecProcess();
                }
            }
        }

        public void gbmEvaluationHide() {

            chbGBM.Checked = false;

            checkGBMModel = 0;

            gbmAllEvaluation = 0;
            gbmBinaryEvaluation = 0;
            gbmNumericEvaluation = 0;
        }

        public void xgbEvaluationHide()
        {

            chbXGBoost.Checked = false;

            checkXGBoostModel = 0;

            xgbAllEvaluation = 0;
            xgbBinaryEvaluation = 0;
            xgbNumericEvaluation = 0;
        }

        public void lgbEvaluationHide()
        {

            chbLGB.Checked = false;

            checkLightGBModel = 0;

            lgbAllEvaluation = 0;
            lgbBinaryEvaluation = 0;
            lgbNumericEvaluation = 0;
        }


        private void chbXGBoost_CheckedChanged(object sender, EventArgs e)
        {
            if(chbXGBoost.Checked == true)
                checkXGBoostModel = 1;
            else
                checkXGBoostModel = 0;
        }

        private void btnXGBEvaluateModel_Click(object sender, EventArgs e)
        {
            preprocessingOutputsInvisible();
            featureExtractionInvisible();

            if (rbAllFeatures.Checked == true)
            {
                if (chbXGBoost.Checked == true)
                {
                    checknshowAllFeatures = 0;
                    xgbAllEvaluation = 1;
                    tbModelEvalLogs.Text = Python_ExecProcess();
                }
            }

            if (rbBinaryFeatures.Checked == true)
            {
                if (chbXGBoost.Checked == true)
                {
                    checknshowBinaryFeatures = 0;
                    xgbBinaryEvaluation = 1;
                    tbModelEvalLogs.Text = Python_ExecProcess();
                }
            }

            if (rbNumericFeatures.Checked == true)
            {
                if (chbXGBoost.Checked == true)
                {
                    checknshowNumericFeatures = 0;
                    xgbNumericEvaluation = 1;
                    tbModelEvalLogs.Text = Python_ExecProcess();
                }
            }
        }

        private void chbLGB_CheckedChanged(object sender, EventArgs e)
        {
            if(chbLGB.Checked == true)
                checkLightGBModel = 1;
            else
                checkLightGBModel = 0;
        }

        private void btnLGBEvaluateModel_Click(object sender, EventArgs e)
        {
            preprocessingOutputsInvisible();
            featureExtractionInvisible();

            if (rbAllFeatures.Checked == true)
            {
                if (chbLGB.Checked == true)
                {
                    checknshowAllFeatures = 0;
                    lgbAllEvaluation = 1;
                    tbModelEvalLogs.Text = Python_ExecProcess();
                }
            }

            if (rbBinaryFeatures.Checked == true)
            {
                if (chbLGB.Checked == true)
                {
                    checknshowBinaryFeatures = 0;
                    lgbBinaryEvaluation = 1;
                    tbModelEvalLogs.Text = Python_ExecProcess();
                }
            }

            if (rbNumericFeatures.Checked == true)
            {
                if (chbLGB.Checked == true)
                {
                    checknshowNumericFeatures = 0;
                    lgbNumericEvaluation = 1;
                    tbModelEvalLogs.Text = Python_ExecProcess();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pythonExePath = FormStart.SetValueForPythonExe;
            pythonPrePath = FormStart.SetValueForPrePy;
        }

        private void btnFeature1_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true) {

                featureMessageLength();
            }

            if (rbBinaryFeatures.Checked == true) {

                featureMathSymbolExsist();
            }

            if (rbNumericFeatures.Checked == true)
            {
                featureMessageLength();
            }
        }

        private void btnFeature2_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureSlashCount();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureURLExsist();
            }

            if (rbNumericFeatures.Checked == true)
            {
                featureSlashCount();
            }
        }

        private void btnFeature3_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featurePunctuationsCount();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureDotExsist();
            }

            if (rbNumericFeatures.Checked == true)
            {
                featurePunctuationsCount();
            }

        }

        private void btnFeature4_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featurealphanumericWCount();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureSpecialSymbolExsist();
            }

            if (rbNumericFeatures.Checked == true)
            {
                featurealphanumericWCount();
            }
        }

        private void btnFeature5_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureNumericWCount();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureEmotionssExsist();
            }

            if (rbNumericFeatures.Checked == true)
            {
                featureNumericWCount();
            }
        }

        private void btnFeature6_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureUpperCaseLetterCount();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureLowercaseWExsist();
            }

            if (rbNumericFeatures.Checked == true)
            {
                featureUpperCaseLetterCount();
            }
        }

        private void btnFeature7_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true) {
                featureNumWordsCount();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureUppercaseWExsist();
            }

            if (rbNumericFeatures.Checked == true)
            {
                featureNumWordsCount();
            }
        }

        private void btnFeature9_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureURLExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureCurrencyPNumExsist();
            }
        }

        private void btnFeature10_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureDotExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureNumberPPercentExsist();
            }
        }

        private void btnFeature11_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureSpecialSymbolExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureRingTelPNumExsist();
            }
        }

        private void btnFeature12_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureEmotionssExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureDateTimeExsist();
            }
        }

        private void btnFeature13_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureLowercaseWExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureLongStrNumExsist();
            }
        }

        private void btnFeature14_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureUppercaseWExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureEmailExsist();
            }
        }

        private void btnFeature15_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featurePhoneNumberWExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureCurrencySymbExsist();
            }
        }

        private void btnFeature16_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureCurrencyPNumExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureServiceNumExsist();
            }
        }

        private void btnFeature17_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureNumberPPercentExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureCurrencyWExsist();
            }
        }

        private void btnFeature18_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureRingTelPNumExsist();
            }

            if (rbBinaryFeatures.Checked == true)
            {
                featureSpamKeyWords();
            }
        }

        private void btnFeature19_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureDateTimeExsist();
            }
        }

        private void btnFeature20_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureLongStrNumExsist();
            }
        }

        private void btnFeature21_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureEmailExsist();
            }
        }

        private void btnFeature22_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureCurrencySymbExsist();
            }
        }

        private void btnFeature23_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureServiceNumExsist();
            }
        }

        private void btnFeature24_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureCurrencyWExsist();
            }
        }
        
        public static string SetValueForPythonEXE = "";
        public static string SetValueForDataset = "";
        public static string SetValueForClass = "";
        public static string SetValueForMessage = "";
        private void btnSecondPhase_Click(object sender, EventArgs e)
        {
            SetValueForPythonEXE = pythonExePath;
            SetValueForDataset = datasetPath;
            SetValueForClass = tbColumnV1.Text;
            SetValueForMessage = tbColumnV2.Text;

            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        /*
        int counterFET;
        double tempValue;
        private void btnFETime_Click(object sender, EventArgs e)
        {
            checknshowAllFeatures = 0;
            checknshowBinaryFeatures = 0;
            checknshowNumericFeatures = 0;

            featureExTimeCal = 1;

            string featExtrTime = Python_ExecProcess();

            counterFET++;

            tbModelEvalLogs.AppendText(counterFET + " : " + featExtrTime);

            
            lblCountNumFET.Text = "Count Number of Feature Extraction Time ("+ counterFET + ")";

            tempValue = tempValue + double.Parse(featExtrTime);
            lblFETValue.Text = tempValue.ToString();
        }

        private void btnFETAverage_Click(object sender, EventArgs e)
        {
            double avg = tempValue / counterFET;
            tbModelEvalLogs.AppendText("Average is : " +avg.ToString() +"\n");
        }

        private void btnRestCounterFET_Click(object sender, EventArgs e)
        {
            lblCountNumFET.Text = "Count Number of Feature Extraction Time";
            lblFETValue.Text = "";

            counterFET = 0;
            tempValue = 0.0;
        }
        */

        private void btnFeature25_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureSpamKeyWords();
            }
        }

        private void btnFeature26_Click(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                featureSpamKeyWords();
            }
        }

        private void btnBackToStart_Click(object sender, EventArgs e)
        {
            FormStart formStart = new FormStart();
            this.Hide();
            formStart.ShowDialog();
            this.Close();
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.Title = "Save Tabular Files";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "Comma-Separated Values|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (rbAllFeatures.Checked == true)
                {
                    exportCSVPath = saveFileDialog1.FileName;
                    exportAllFeatures = 1;

                    Python_ExecProcess();
                }

                if (rbBinaryFeatures.Checked == true)
                {
                    exportCSVPath = saveFileDialog1.FileName;
                    exportAllFeatures = 2;

                    Python_ExecProcess();
                }

                if (rbNumericFeatures.Checked == true)
                {
                    exportCSVPath = saveFileDialog1.FileName;
                    exportAllFeatures = 3;

                    Python_ExecProcess();
                }
            }
        }

        bool graghCreated = true;
        private void chbClassGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowClassDist.Checked == true)
            {
                // calling get the stats only in order to fill the list 
                getStatsOnly();

                if (chbClassGraph.Checked == true)
                {
                    chart1.Visible = true;

                    if (graghCreated.Equals(true))
                    {
                        double spamRatio = (Convert.ToDouble(listStatsHamSpam[1]) / 5574.0) * 100;
                        double hamRatio = (Convert.ToDouble(listStatsHamSpam[0]) / 5574.0) * 100;
                        spamRatio = Math.Round(spamRatio, 2);
                        hamRatio = Math.Round(hamRatio, 2);

                        this.chart1.Series["Text Messages"].Points.AddXY("Ham \n" + hamRatio, int.Parse(listStatsHamSpam[0]));
                        this.chart1.Series["Text Messages"].Points.AddXY("Spam \n" + spamRatio, int.Parse(listStatsHamSpam[1]));
                    }
                }

                else
                {
                    chart1.Visible = false;
                    graghCreated = false;
                }
            }
            else {

            }
        }

        List<string> listStatsHamSpam = new List<string>();
        private void getStatsOnly() {
            
            string str = tbPreLogs.Text;

            if (Regex.IsMatch(str, @"am\s\s\s\s\s\d+(\.\d+)?"))
            {
                foreach (Match match in Regex.Matches(str, @"am\s\s\s\s\s\d+(\.\d+)?"))
                {
                    if (match.Success)
                    {
                        listStatsHamSpam.Add(match.Value.Substring(2));
                    }
                }
                var message = string.Join(Environment.NewLine, listStatsHamSpam);
                //MessageBox.Show("Date Time found in the message: \n" + message);

            }
            else
            {
                // false;
            }
        }
        
    }
}


