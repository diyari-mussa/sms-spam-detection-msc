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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSSpamFilterProject
{
    public partial class Form2 : Form
    {
        // python file
        //string pythonFileName;
        string pythonExePath;
        string pythonFeatSelPath;

        string datasetPath; // dataset string

        int fchMessageLength; //f1
        string fnameMessageLength; //f1
        int fchCountSlashes; //f2
        string fnameCountSlashes; //f2
        int fchCountPunct; //f3
        string fnameCountPunct; //f3
        int fchCountAlphaNum; //f4
        string fnameCountAlphaNum; //f4
        int fchCountNumTerms; //f5
        string fnameCountNumTerms; //f5
        int fchCountUpperCaseLetter; //f6
        string fnameCountUpperCaseLetter; //f6
        int fchCountWordsNum; //f7
        string fnameCountWordsNum; //f7

        int fchMathSymbol; //f8
        string fnameMathSymbol; //f8
        int fchURL; //f9
        string fnameURL; //f9
        int fchDots; //f10
        string fnameDots; //f10
        int fchSpecialSymbol; //f11
        string fnameSpecialSymbol; //f11
        int fchEmotions; //f12
        string fnameEmotions; //f12
        int fchLowercase; //f13
        string fnameLowercase; //f13
        int fchUppercase; //f14
        string fnameUppercase; //f14
        int fchPhoneNumber; //f15
        string fnamePhoneNumber; //f15
        int fchCurrencyPNum; //f16
        string fnameCurrencyPNum; //f16
        int fchNumPpercent; //f17
        string fnameNumPpercent; //f17
        int fchRingtelPNum; //f18
        string fnamefchRingtelPNum; //f18
        int fchDateTime; //f19
        string fnameDateTime; //f19
        int fchLongStrNum; //f20
        string fnameLongStrNum; //f20
        int fchEmail; //f21
        string fnameEmail; //f21
        int fchCurrencySymb; //f22
        string fnameCurrencySymb; //f22
        int fchServiceNum; //f23
        string fnameServiceNum; //f23
        int fchCurrencyWord; //f24
        string fnameCurrencyWord; //f24

        int fchCountSpamKeywords; //f25
        string fnameCountSpamKeywords; //f25
        int fchPreSpamKeywords; //f26
        string fnamePreSpamKeywords; //f26

        // Feature selection
        int parMLBoostingAlg;
        string parK_features;
        string parFeatSelecType;
        string parScore;

        int featureSelectState;
        string reportFileName;

        // model evaluation and time
        int showGBMAccuracyTime;
        int showGBMEvaluation;
        int showXGBAccuracyTime;
        int showXGBEvaluation;
        int showLGBMAccuracyTime;
        int showLGBMEvaluation;

        // 
        string reportPath;

        // features names selected for Form3
        public static string SetSelectedFeatureNames = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pythonExePath = Form1.SetValueForPythonEXE;
            lblPythonExe.Text = pythonExePath;

            datasetPath = Form1.SetValueForDataset;
            tbDataset.Text = datasetPath;

            tbColumnV1.Text = Form1.SetValueForClass;
            tbColumnV2.Text = Form1.SetValueForMessage;

            // get feature slection path from starting page
            pythonFeatSelPath = FormStart.SetValueForFeatSelPy;

            // when form loads check radio button of All features
            rbAllFeatures.Checked = true;
        }

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

        public string Python_ExecProcess()
        {
            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            //psi.FileName = @"C:\Users\OMEN\AppData\Local\Programs\Python\Python37\python.exe";
            psi.FileName = pythonExePath;
            

            // 2) Provide script and arguments
            //var script = @"C:\Users\OMEN\Desktop\SMSSpamFilterPythonProject\FeatureSelection.py";
            var script = pythonFeatSelPath;

            var datasetPath_arg = datasetPath;
            var columnClass_arg = tbColumnV1.Text;
            var columnMessage_arg = tbColumnV2.Text;

            var fchMessageLenght_arg = fchMessageLength; // f1
            var fnameMessageLength_arg = fnameMessageLength; // f1
            var fchCountSlashes_arg = fchCountSlashes; // f2
            var fnameCountSlashes_arg = fnameCountSlashes; // f2
            var fchCountPunct_arg = fchCountPunct; // f3
            var fnameCountPunct_arg = fnameCountPunct; // f3
            var fchCountAlphaNum_arg = fchCountAlphaNum; // f4
            var fnameCountAlphaNum_arg = fnameCountAlphaNum; // f4
            var fchCountNumTerms_arg = fchCountNumTerms; // f5
            var fnameCountNumTerms_arg = fnameCountNumTerms; // f5
            var fchCountUpperCaseLetter_arg = fchCountUpperCaseLetter; // f6
            var fnameCountUpperCaseLetter_arg = fnameCountUpperCaseLetter; // f6
            var fchCountWordsNum_arg = fchCountWordsNum; // f7
            var fnameCountWordsNum_arg = fnameCountWordsNum; // f7
            var fchMathSymbol_arg = fchMathSymbol; // f8
            var fnameMathSymbol_arg = fnameMathSymbol; // f8
            var fchURL_arg = fchURL; // f9
            var fnameURL_arg = fnameURL; // f9
            var fchDots_arg = fchDots; // f10
            var fnameDots_arg = fnameDots; // f10 
            var fchSpecialSymbol_arg = fchSpecialSymbol; // f11
            var fnameSpecialSymbol_arg = fnameSpecialSymbol; // f11
            var fchEmotions_arg = fchEmotions; // f12
            var fnameEmotions_arg = fnameEmotions; // f12
            var fchLowercase_arg = fchLowercase; // f13
            var fnameLowercase_arg = fnameLowercase; // f13
            var fchUppercase_arg = fchUppercase; // f14
            var fnameUppercase_arg = fnameUppercase; // f14
            var fchPhoneNumber_arg = fchPhoneNumber; // f15
            var fnamePhoneNumber_arg = fnamePhoneNumber; // f15
            var fchCurrencyPNum_arg = fchCurrencyPNum; // f16
            var fnameCurrencyPNum_arg = fnameCurrencyPNum; // f16
            var fchNumPpercent_arg = fchNumPpercent; // f17
            var fnameNumPpercent_arg = fnameNumPpercent; // f17
            var fchRingtelPNum_arg = fchRingtelPNum; // f18
            var fnamefchRingtelPNum_arg = fnamefchRingtelPNum; // f18
            var fchDateTime_arg = fchDateTime; // f19
            var fnameDateTime_arg = fnameDateTime; // f19
            var fchLongStrNum_arg = fchLongStrNum; // f20
            var fnameLongStrNum_arg = fnameLongStrNum; // f20
            var fchEmail_arg = fchEmail; // f21
            var fnameEmail_arg = fnameEmail; // f21
            var fchCurrencySymb_arg = fchCurrencySymb; // f22
            var fnameCurrencySymb_arg = fnameCurrencySymb; // f22
            var fchServiceNum_arg = fchServiceNum; // f23
            var fnameServiceNum_arg = fnameServiceNum; // f23
            var fchCurrencyWord_arg = fchCurrencyWord; // f24
            var fnameCurrencyWord_arg = fnameCurrencyWord; // f24
            var fchCountSpamKeywords_arg = fchCountSpamKeywords; // f25
            var fnameCountSpamKeywords_arg = fnameCountSpamKeywords; // f25
            var fchPreSpamKeywords_arg = fchPreSpamKeywords; // f26
            var fnamePreSpamKeywords_arg = fnamePreSpamKeywords; // f26

            var MLBoostingAlg_arg = parMLBoostingAlg;
            var parK_features_arg = parK_features;
            var parFeatSelecType_arg = parFeatSelecType;
            var parScore_arg = parScore;
        
            var featureSelectState_arg = featureSelectState;
            var reportFileName_arg = reportFileName;

            var showGBMAccuracyTime_arg = showGBMAccuracyTime;
            var showGBMEvaluation_arg = showGBMEvaluation;
            var showXGBAccuracyTime_arg = showXGBAccuracyTime;
            var showXGBEvaluation_arg = showXGBEvaluation;
            var showLGBMAccuracyTime_arg = showLGBMAccuracyTime;
            var showLGBMEvaluation_arg = showLGBMEvaluation;

            psi.Arguments = $"\"{script}\" \"{datasetPath_arg}\" \"{columnClass_arg}\" \"{columnMessage_arg}\"" +
                $" \"{fchMessageLenght_arg}\" \"{fnameMessageLength_arg}\" \"{fchCountSlashes_arg}\" \"{fnameCountSlashes_arg}\" " +
                $" \"{fchCountPunct_arg}\" \"{fnameCountPunct_arg}\" \"{fchCountAlphaNum_arg}\" \"{fnameCountAlphaNum_arg}\" " +
                $" \"{fchCountNumTerms_arg}\" \"{fnameCountNumTerms_arg}\" \"{fchCountUpperCaseLetter_arg}\" \"{fnameCountUpperCaseLetter_arg}\" \"{fchCountWordsNum_arg}\" \"{fnameCountWordsNum_arg}\" " +
                $" \"{fchMathSymbol_arg}\" \"{fnameMathSymbol_arg}\" \"{fchURL_arg}\" \"{fnameURL_arg}\" " +
                $" \"{fchDots_arg}\" \"{fnameDots_arg}\" \"{fchSpecialSymbol_arg}\" \"{fnameSpecialSymbol_arg}\" " +
                $" \"{fchEmotions_arg}\" \"{fnameEmotions_arg}\" \"{fchLowercase_arg}\" \"{fnameLowercase_arg}\" " +
                $" \"{fchUppercase_arg}\" \"{fnameUppercase_arg}\" \"{fchPhoneNumber_arg}\" \"{fnamePhoneNumber_arg}\" " +
                $" \"{fchCurrencyPNum_arg}\" \"{fnameCurrencyPNum_arg}\" \"{fchNumPpercent_arg}\" \"{fnameNumPpercent_arg}\" " +
                $" \"{fchRingtelPNum_arg}\" \"{fnamefchRingtelPNum_arg}\" \"{fchDateTime_arg}\" \"{fnameDateTime_arg}\" " +
                $" \"{fchLongStrNum_arg}\" \"{fnameLongStrNum_arg}\" \"{fchEmail_arg}\" \"{fnameEmail_arg}\" " +
                $" \"{fchCurrencySymb_arg}\" \"{fnameCurrencySymb_arg}\" \"{fchServiceNum_arg}\" \"{fnameServiceNum_arg}\" \"{fchCurrencyWord_arg}\" \"{fnameCurrencyWord_arg}\"" +
                $" \"{fchCountSpamKeywords_arg}\" \"{fnameCountSpamKeywords_arg}\" \"{fchPreSpamKeywords_arg}\" \"{fnamePreSpamKeywords_arg}\" " +
                $" \"{MLBoostingAlg_arg}\" \"{parK_features_arg}\" \"{parFeatSelecType_arg}\" \"{parScore_arg}\" \"{featureSelectState_arg}\" \"{reportFileName_arg}\" " +
                $" \"{showGBMAccuracyTime_arg}\" \"{showGBMEvaluation_arg}\" \"{showXGBAccuracyTime_arg}\" \"{showXGBEvaluation_arg}\" \"{showLGBMAccuracyTime_arg}\" \"{showLGBMEvaluation_arg}\" " +
                $"  ";


            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
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


        /* 
         Section of features
         selecting features to be fed into the feature selection algorithm
         - all features
         - numeric features
         - binary features
        */

        public void enabilityOfCheckboxes()
        {
            chbFeature1.Enabled = true;
            chbFeature2.Enabled = true;
            chbFeature3.Enabled = true;
            chbFeature4.Enabled = true;
            chbFeature5.Enabled = true;
            chbFeature6.Enabled = true;
            chbFeature7.Enabled = true;
            chbFeature8.Enabled = true;
            chbFeature9.Enabled = true;
            chbFeature10.Enabled = true;
            chbFeature11.Enabled = true;
            chbFeature12.Enabled = true;
            chbFeature13.Enabled = true;
            chbFeature14.Enabled = true;
            chbFeature15.Enabled = true;
            chbFeature16.Enabled = true;
            chbFeature17.Enabled = true;
            chbFeature18.Enabled = true;
            chbFeature19.Enabled = true;
            chbFeature20.Enabled = true;
            chbFeature21.Enabled = true;
            chbFeature22.Enabled = true;
            chbFeature23.Enabled = true;
            chbFeature24.Enabled = true;
            chbFeature25.Enabled = true;
            chbFeature26.Enabled = true;
        }
        public void checkingOfCheckboxes()
        {
            chbFeature1.Checked = false;
            chbFeature2.Checked = false;
            chbFeature3.Checked = false;
            chbFeature4.Checked = false;
            chbFeature5.Checked = false;
            chbFeature6.Checked = false;
            chbFeature7.Checked = false;
            chbFeature8.Checked = false;
            chbFeature9.Checked = false;
            chbFeature10.Checked = false;
            chbFeature11.Checked = false;
            chbFeature12.Checked = false;
            chbFeature13.Checked = false;
            chbFeature14.Checked = false;
            chbFeature15.Checked = false;
            chbFeature16.Checked = false;
            chbFeature17.Checked = false;
            chbFeature18.Checked = false;
            chbFeature19.Checked = false;
            chbFeature20.Checked = false;
            chbFeature21.Checked = false;
            chbFeature22.Checked = false;
            chbFeature23.Checked = false;
            chbFeature24.Checked = false;
            chbFeature25.Checked = false;
            chbFeature26.Checked = false;
        }
        public void resetChkFeatureValues()
        {
            fchMessageLength = 0;
            fchCountSlashes = 0;
            fchCountPunct = 0;
            fchCountAlphaNum = 0;
            fchCountNumTerms = 0;
            fchCountUpperCaseLetter = 0;
            fchCountWordsNum = 0;
            fchMathSymbol = 0;
            fchURL = 0;
            fchDots = 0;
            fchSpecialSymbol = 0;
            fchEmotions = 0;
            fchLowercase = 0;
            fchUppercase = 0;
            fchPhoneNumber = 0;
            fchCurrencyPNum = 0;
            fchNumPpercent = 0;
            fchRingtelPNum = 0;
            fchDateTime = 0;
            fchLongStrNum = 0;
            fchEmail = 0;
            fchCurrencySymb = 0;
            fchServiceNum = 0;
            fchCurrencyWord = 0;
            fchCountSpamKeywords = 0;
            fchPreSpamKeywords = 0;
        }

        // - all features
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
            lblFeature24.Text = "feature24 (currency in word)";
            lblFeature25.Text = "feature25 (count of spam keywords)";

            lblFeature26.Text = "feature26 (presence of spam keyword)";
        }
        public void renameAllFeatures_pyth()
        {
            fnameMessageLength = "feature1";
            fnameCountSlashes = "feature2";
            fnameCountPunct = "feature3";
            fnameCountAlphaNum = "feature4";
            fnameCountNumTerms = "feature5";
            fnameCountUpperCaseLetter = "feature6";
            fnameCountWordsNum = "feature7";

            fnameMathSymbol = "feature8";
            fnameURL = "feature9";
            fnameDots = "feature10";
            fnameSpecialSymbol = "feature11";
            fnameEmotions = "feature12";
            fnameLowercase = "feature13";
            fnameUppercase = "feature14";
            fnamePhoneNumber = "feature15";
            fnameCurrencyPNum = "feature16";
            fnameNumPpercent = "feature17";
            fnamefchRingtelPNum = "feature18";
            fnameDateTime = "feature19";
            fnameLongStrNum = "feature20";
            fnameEmail = "feature21";
            fnameCurrencySymb = "feature22";
            fnameServiceNum = "feature23";
            fnameCurrencyWord = "feature24";

            fnameCountSpamKeywords = "feature25";
            fnamePreSpamKeywords = "feature26";

        }
        public void visiblityAll()
        {
            lblFeature1.Visible = true;
            lblFeature2.Visible = true;
            lblFeature3.Visible = true;
            lblFeature4.Visible = true;
            lblFeature5.Visible = true;
            lblFeature6.Visible = true;
            lblFeature7.Visible = true;
            lblFeature8.Visible = true;
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

            chbFeature1.Visible = true;
            chbFeature2.Visible = true;
            chbFeature3.Visible = true;
            chbFeature4.Visible = true;
            chbFeature5.Visible = true;
            chbFeature6.Visible = true;
            chbFeature7.Visible = true;
            chbFeature8.Visible = true;
            chbFeature9.Visible = true;
            chbFeature10.Visible = true;
            chbFeature11.Visible = true;
            chbFeature12.Visible = true;
            chbFeature13.Visible = true;
            chbFeature14.Visible = true;
            chbFeature15.Visible = true;
            chbFeature16.Visible = true;
            chbFeature17.Visible = true;
            chbFeature18.Visible = true;
            chbFeature19.Visible = true;
            chbFeature20.Visible = true;
            chbFeature21.Visible = true;
            chbFeature22.Visible = true;
            chbFeature23.Visible = true;
            chbFeature24.Visible = true;
            chbFeature25.Visible = true;
            chbFeature26.Visible = true;
            
        }

        // - numeric features
        public void renameLabelsNum()
        {
            lblFeature1.Text = "feature1 (message length)";
            lblFeature2.Text = "feature2 (Count of slash)";
            lblFeature3.Text = "feature3 (non-alphanumeric char)";
            lblFeature4.Text = "feature4 (alphanumeric words)";
            lblFeature5.Text = "feature5 (numeric words)";
            lblFeature6.Text = "feature6 (uppercase letter)";
            lblFeature7.Text = "feature7 (number of words)";
            lblFeature8.Text = "feature8 (count of spam keywords)";
        }
        public void renameNumFeatures_pyth()
        {
            fnameMessageLength = "feature1";
            fnameCountSlashes = "feature2";
            fnameCountPunct = "feature3";
            fnameCountAlphaNum = "feature4";
            fnameCountNumTerms = "feature5";
            fnameCountUpperCaseLetter = "feature6";
            fnameCountWordsNum = "feature7";
            fnameCountSpamKeywords = "feature8";
        }
        public void visiblityNValueNumeric() {

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

            chbFeature9.Visible = false;
            chbFeature10.Visible = false;
            chbFeature11.Visible = false;
            chbFeature12.Visible = false;
            chbFeature13.Visible = false;
            chbFeature14.Visible = false;
            chbFeature15.Visible = false;
            chbFeature16.Visible = false;
            chbFeature17.Visible = false;
            chbFeature18.Visible = false;
            chbFeature19.Visible = false;
            chbFeature20.Visible = false;
            chbFeature21.Visible = false;
            chbFeature22.Visible = false;
            chbFeature23.Visible = false;
            chbFeature24.Visible = false;
            chbFeature25.Visible = false;
            chbFeature26.Visible = false;
        }

        // - binary features
        public void renameLabelsBinnary()
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
            lblFeature18.Text = "feature18 (presence of spam keyword)";
        }
        public void renameBinFeatures_pyth()
        {
            fnameMathSymbol = "feature1";
            fnameURL = "feature2";
            fnameDots = "feature3";
            fnameSpecialSymbol = "feature4";
            fnameEmotions = "feature5";
            fnameLowercase = "feature6";
            fnameUppercase = "feature7";
            fnamePhoneNumber = "feature8";
            fnameCurrencyPNum = "feature9";
            fnameNumPpercent = "feature10";
            fnamefchRingtelPNum = "feature11";
            fnameDateTime = "feature12";
            fnameLongStrNum = "feature13";
            fnameEmail = "feature14";
            fnameCurrencySymb = "feature15";
            fnameServiceNum = "feature16";
            fnameCurrencyWord = "feature17";
            fnamePreSpamKeywords = "feature18";
        }
        public void visiblityBin()
        {
            lblFeature1.Visible = true;
            lblFeature2.Visible = true;
            lblFeature3.Visible = true;
            lblFeature4.Visible = true;
            lblFeature5.Visible = true;
            lblFeature6.Visible = true;
            lblFeature7.Visible = true;
            lblFeature8.Visible = true;
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

            chbFeature1.Visible = true;
            chbFeature2.Visible = true;
            chbFeature3.Visible = true;
            chbFeature4.Visible = true;
            chbFeature5.Visible = true;
            chbFeature6.Visible = true;
            chbFeature7.Visible = true;
            chbFeature8.Visible = true;
            chbFeature9.Visible = true;
            chbFeature10.Visible = true;
            chbFeature11.Visible = true;
            chbFeature12.Visible = true;
            chbFeature13.Visible = true;
            chbFeature14.Visible = true;
            chbFeature15.Visible = true;
            chbFeature16.Visible = true;
            chbFeature17.Visible = true;
            chbFeature18.Visible = true;
            chbFeature19.Visible = false;
            chbFeature20.Visible = false;
            chbFeature21.Visible = false;
            chbFeature22.Visible = false;
            chbFeature23.Visible = false;
            chbFeature24.Visible = false;
            chbFeature25.Visible = false;
            chbFeature26.Visible = false;

        }



        private void rbAllFeatures_CheckedChanged(object sender, EventArgs e)
        {
            tbLogsFeatures.AppendText(rbAllFeatures.Text + " index changed" + System.Environment.NewLine);

            if (rbAllFeatures.Checked == true)
            {
                enabilityOfCheckboxes();
                checkingOfCheckboxes();
                resetChkFeatureValues();

                renameLabelsAll();
                renameAllFeatures_pyth();
                visiblityAll();

                checkAllFeatures();
            }
        }


        private void rbNumericFeatures_CheckedChanged(object sender, EventArgs e)
        {
            tbLogsFeatures.AppendText(rbNumericFeatures.Text + " index changed" + System.Environment.NewLine);

            if (rbNumericFeatures.Checked == true)
            {
                enabilityOfCheckboxes();
                checkingOfCheckboxes();
                resetChkFeatureValues();

                renameLabelsNum();
                renameNumFeatures_pyth();
                visiblityNValueNumeric();

                checkNumericFeatures();
            }
        }
        

        private void rbBinaryFeatures_CheckedChanged(object sender, EventArgs e)
        {
            tbLogsFeatures.AppendText(rbBinaryFeatures.Text + " index changed" + System.Environment.NewLine);

            if (rbBinaryFeatures.Checked == true)
            {
                enabilityOfCheckboxes();
                checkingOfCheckboxes();
                resetChkFeatureValues();

                renameLabelsBinnary();
                renameBinFeatures_pyth();
                visiblityBin();

                checkBinaryFeatures();
            }
        }


        private void chbFeature1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature1.Checked == false)
                    fchMessageLength = 0;
                else
                    fchMessageLength = 1;
            }
            else if (rbNumericFeatures.Checked == true)
            {
                if (chbFeature1.Checked == false)
                    fchMessageLength = 0;
                else
                    fchMessageLength = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature1.Checked == false)
                    fchMathSymbol = 0;
                else
                    fchMathSymbol = 1;
            }

            tbLogsFeatures.AppendText(lblFeature1.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature2.Checked == false)
                    fchCountSlashes = 0;
                else
                    fchCountSlashes = 1;
            }
            else if (rbNumericFeatures.Checked == true)
            {
                if (chbFeature2.Checked == false)
                    fchCountSlashes = 0;
                else
                    fchCountSlashes = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature2.Checked == false)
                    fchURL = 0;
                else
                    fchURL = 1;
            }

            tbLogsFeatures.AppendText(lblFeature2.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature3.Checked == false)
                    fchCountPunct = 0;
                else
                    fchCountPunct = 1;
            }
            else if (rbNumericFeatures.Checked == true)
            {
                if (chbFeature3.Checked == false)
                    fchCountPunct = 0;
                else
                    fchCountPunct = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature3.Checked == false)
                    fchDots = 0;
                else
                    fchDots = 1;
            }

            tbLogsFeatures.AppendText(lblFeature3.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature4.Checked == false)
                    fchCountAlphaNum = 0;
                else
                    fchCountAlphaNum = 1;
            }
            else if (rbNumericFeatures.Checked == true)
            {
                if (chbFeature4.Checked == false)
                    fchCountAlphaNum = 0;
                else
                    fchCountAlphaNum = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature4.Checked == false)
                    fchSpecialSymbol = 0;
                else
                    fchSpecialSymbol = 1;
            }

            tbLogsFeatures.AppendText(lblFeature4.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature5.Checked == false)
                    fchCountNumTerms = 0;
                else
                    fchCountNumTerms = 1;
            }
            else if (rbNumericFeatures.Checked == true)
            {
                if (chbFeature5.Checked == false)
                    fchCountNumTerms = 0;
                else
                    fchCountNumTerms = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature5.Checked == false)
                    fchEmotions = 0;
                else
                    fchEmotions = 1;
            }

            tbLogsFeatures.AppendText(lblFeature5.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature6.Checked == false)
                    fchCountUpperCaseLetter = 0;
                else
                    fchCountUpperCaseLetter = 1;
            }
            else if (rbNumericFeatures.Checked == true)
            {
                if (chbFeature6.Checked == false)
                    fchCountUpperCaseLetter = 0;
                else
                    fchCountUpperCaseLetter = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature6.Checked == false)
                    fchLowercase = 0;
                else
                    fchLowercase = 1;
            }

            tbLogsFeatures.AppendText(lblFeature6.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature7_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature7.Checked == false)
                    fchCountWordsNum = 0;
                else
                    fchCountWordsNum = 1;
            }
            else if (rbNumericFeatures.Checked == true)
            {
                if (chbFeature7.Checked == false)
                    fchCountWordsNum = 0;
                else
                    fchCountWordsNum = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature7.Checked == false)
                    fchUppercase = 0;
                else
                    fchUppercase = 1;
            }

            tbLogsFeatures.AppendText(lblFeature7.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature8_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature8.Checked == false)
                    fchMathSymbol = 0;
                else
                    fchMathSymbol = 1;
            }
            else if (rbNumericFeatures.Checked == true)
            {
                if (chbFeature8.Checked == false)
                    fchCountSpamKeywords = 0;
                else
                    fchCountSpamKeywords = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature8.Checked == false)
                    fchPhoneNumber = 0;
                else
                    fchPhoneNumber = 1;
            }

            tbLogsFeatures.AppendText(lblFeature8.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature9_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature9.Checked == false)
                    fchURL = 0;
                else
                    fchURL = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature9.Checked == false)
                    fchCurrencyPNum = 0;
                else
                    fchCurrencyPNum = 1;
            }

            tbLogsFeatures.AppendText(lblFeature9.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature10.Checked == false)
                    fchDots = 0;
                else
                    fchDots = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature10.Checked == false)
                    fchNumPpercent = 0;
                else
                    fchNumPpercent = 1;
            }

            tbLogsFeatures.AppendText(lblFeature10.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature11_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature11.Checked == false)
                    fchSpecialSymbol = 0;
                else
                    fchSpecialSymbol = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature11.Checked == false)
                    fchRingtelPNum = 0;
                else
                    fchRingtelPNum = 1;
            }

            tbLogsFeatures.AppendText(lblFeature11.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature12_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature12.Checked == false)
                    fchEmotions = 0;
                else
                    fchEmotions = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature12.Checked == false)
                    fchDateTime = 0;
                else
                    fchDateTime = 1;
            }

            tbLogsFeatures.AppendText(lblFeature12.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature13_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature13.Checked == false)
                    fchLowercase = 0;
                else
                    fchLowercase = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature13.Checked == false)
                    fchLongStrNum = 0;
                else
                    fchLongStrNum = 1;
            }

            tbLogsFeatures.AppendText(lblFeature13.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature14_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature14.Checked == false)
                    fchUppercase = 0;
                else
                    fchUppercase = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature14.Checked == false)
                    fchEmail = 0;
                else
                    fchEmail = 1;
            }

            tbLogsFeatures.AppendText(lblFeature14.Text + " index changed" + System.Environment.NewLine);
        }
        
        private void chbFeature15_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature15.Checked == false)
                    fchPhoneNumber = 0;
                else
                    fchPhoneNumber = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature15.Checked == false)
                    fchCurrencySymb = 0;
                else
                    fchCurrencySymb = 1;
            }

            tbLogsFeatures.AppendText(lblFeature15.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature16_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature16.Checked == false)
                    fchCurrencyPNum = 0;
                else
                    fchCurrencyPNum = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature16.Checked == false)
                    fchServiceNum = 0;
                else
                    fchServiceNum = 1;
            }

            tbLogsFeatures.AppendText(lblFeature16.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature17_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature17.Checked == false)
                    fchNumPpercent = 0;
                else
                    fchNumPpercent = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature17.Checked == false)
                    fchCurrencyWord = 0;
                else
                    fchCurrencyWord = 1;
            }

            tbLogsFeatures.AppendText(lblFeature17.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature18_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature18.Checked == false)
                    fchRingtelPNum = 0;
                else
                    fchRingtelPNum = 1;
            }
            else if (rbBinaryFeatures.Checked == true)
            {
                if (chbFeature18.Checked == false)
                    fchPreSpamKeywords = 0;
                else
                    fchPreSpamKeywords = 1;
            }

            tbLogsFeatures.AppendText(lblFeature18.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature19_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature19.Checked == false)
                    fchDateTime = 0;
                else
                    fchDateTime = 1;
            }

            tbLogsFeatures.AppendText(lblFeature19.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature20_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature20.Checked == false)
                    fchLongStrNum = 0;
                else
                    fchLongStrNum = 1;
            }

            tbLogsFeatures.AppendText(lblFeature20.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature21_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature21.Checked == false)
                    fchEmail = 0;
                else
                    fchEmail = 1;
            }

            tbLogsFeatures.AppendText(lblFeature21.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature22_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature22.Checked == false)
                    fchCurrencySymb = 0;
                else
                    fchCurrencySymb = 1;
            }

            tbLogsFeatures.AppendText(lblFeature22.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature23_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature23.Checked == false)
                    fchServiceNum = 0;
                else
                    fchServiceNum = 1;
            }

            tbLogsFeatures.AppendText(lblFeature23.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature24_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature24.Checked == false)
                    fchCurrencyWord = 0;
                else
                    fchCurrencyWord = 1;
            }

            tbLogsFeatures.AppendText(lblFeature24.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature25_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature25.Checked == false)
                    fchCountSpamKeywords = 0;
                else
                    fchCountSpamKeywords = 1;
            }

            tbLogsFeatures.AppendText(lblFeature25.Text + " index changed" + System.Environment.NewLine);
        }

        private void chbFeature26_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllFeatures.Checked == true)
            {
                if (chbFeature26.Checked == false)
                    fchPreSpamKeywords = 0;
                else
                    fchPreSpamKeywords = 1;
            }

            tbLogsFeatures.AppendText(lblFeature26.Text + " index changed" + System.Environment.NewLine);
        }
    
        // feature slection section

        private void chbParK_features_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbParK_features.Checked == true)
            {
                parK_features = tbParameterK_features.Text;
                chbParK_features.Text = parK_features;
            }
            else {
                tbParameterK_features.Text = null;
                parK_features = null;
                chbParK_features.Text = "K_features (stoping at K Number of feature)";
            }
            
        }

        private void chblblParScoring_CheckedChanged(object sender, EventArgs e)
        {
            if (chbParScoring.Checked == true)
            {
                parScore = tbParameterScoring.Text;
                chbParScoring.Text = parScore;
            }
            else
            {
                tbParameterScoring.Text = null;
                parScore = null;
                chbParScoring.Text = "Scoring (ex: Accuracy or Recall)";
            }
        }

        private void chbParameterGBM_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (chbParameterGBM.Checked == true) {
                chbParameterXGBoost.Checked = false;
                chbParameterLGB.Checked = false;
            }
            */
        }

        private void chbParameterXGBoost_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (chbParameterXGBoost.Checked == true)
            {
                chbParameterGBM.Checked = false;
                chbParameterLGB.Checked = false;
            }
            */
        }

        private void chbParameterLGB_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (chbParameterLGB.Checked == true)
            {
                chbParameterGBM.Checked = false;
                chbParameterXGBoost.Checked = false;
            }
            */
        }

        private void btnStratFeatSelect_Click(object sender, EventArgs e)
        {
            if (rbParameterXGBoost.Checked == true)
                parMLBoostingAlg = 1;

            if (rbParameterLGB.Checked == true)
                parMLBoostingAlg = 2;

            if (rbParameterGBM.Checked == true)
                parMLBoostingAlg = 3;

            if (rbParameterSFS.Checked == true)
                parFeatSelecType = "true";

            if (rbParameterSBS.Checked == true)
                parFeatSelecType = "false";
              

            featureSelectState = 1;

            //tbFeatureSelctLogs.Text = Python_ExecProcess();
            startTask();
        }

        string featureSelectionResult;
        // this method will run on UI, but it is async so it wont freez the UI or block it
        private async void startTask() {

            tbFeatureSelctLogs.Enabled = false;
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            await Task.Run(() => longRunningTask());
            progressBar1.Visible = false;
            tbFeatureSelctLogs.Enabled = true;
            tbFeatureSelctLogs.Text = featureSelectionResult;
            
        }

        // this will be run on seperate thread
        private void longRunningTask() {

            //Thread.Sleep(2000);
            featureSelectionResult = Python_ExecProcess();
        }
        
        private void btnReportFileCreate_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    reportFileName = saveFileDialog1.FileName;
                    tbReportFileDir.Text = reportFileName;
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        private void btnGBMEvaluateModel_Click(object sender, EventArgs e)
        {
            showGBMEvaluation = 1;

            tbEvalTimeLogs.Text = Python_ExecProcess();
        }

        private void btnGBMAccTime_Click(object sender, EventArgs e)
        {
            featureSelectState = 0;
            showGBMEvaluation = 0;

            showGBMAccuracyTime = 1;

            tbEvalTimeLogs.AppendText(Python_ExecProcess());
        }

        private void btnXGBAccTime_Click(object sender, EventArgs e)
        {
            featureSelectState = 0;
            showXGBEvaluation = 0;

            showXGBAccuracyTime = 1;

            tbEvalTimeLogs.AppendText(Python_ExecProcess());
        }

        private void btnXGBEvaluateModel_Click(object sender, EventArgs e)
        {
            showXGBEvaluation = 1;

            tbEvalTimeLogs.Text = Python_ExecProcess();
        }

        private void btnLGBMAccTime_Click(object sender, EventArgs e)
        {
            featureSelectState = 0;
            showLGBMEvaluation = 0;

            showLGBMAccuracyTime = 1;

            tbEvalTimeLogs.AppendText(Python_ExecProcess());
        }

        private void btnLGBMEvaluateModel_Click(object sender, EventArgs e)
        {
            showLGBMEvaluation = 1;

            tbEvalTimeLogs.Text = Python_ExecProcess();
        }

        string theWholeReport;

        private string extractFeatureSetNumber(string line)
        {
            string[] parts1 = line.Split(new string[] { @":" }, StringSplitOptions.None);
            string[] parts2 = Regex.Split(line, @":");
            String finalText = parts2[0];

            return finalText;
        }

        private void lboxNoFeatures_Click(object sender, EventArgs e)
        {
            string featuresetNum = lboxNoFeatures.GetItemText(lboxNoFeatures.SelectedItem);

            extrfeaturesNames(extrFeatureFromFset(theWholeReport, featuresetNum));

            uncheckAllFeatures();

            checkingFeature();
        }

        private string extrFeatureFromFset(string line, string num)
        {
            string[] parts1 = line.Split(new string[] {@"\b"+ num + @":" }, StringSplitOptions.None);
            string[] parts2 = Regex.Split(line, @"\b" + num + @":");
            String fstText = parts2[1];
            string[] parts3 = fstText.Split(new string[] { @"\)}," }, StringSplitOptions.None);
            string[] parts4 = Regex.Split(fstText, @"\)},");
            String sndText = parts4[0];

            return sndText;
        }

        List<string> listFeatNames;
        private void extrfeaturesNames(string textFile)
        {
            listFeatNames = new List<string>();

            if (Regex.IsMatch(textFile, @"feature\d+"))
            {
                foreach (Match match in Regex.Matches(textFile, @"feature\d+"))
                {
                    if (match.Success)
                    {
                        listFeatNames.Add(match.Value);
                    }
                }
                var message = string.Join(Environment.NewLine, listFeatNames);

                lboxFeatures.DataSource = listFeatNames;

                string featureNamesVar = string.Join(",", listFeatNames.ToArray());
                SetSelectedFeatureNames = featureNamesVar;
            }
            else
            {
                // false;
            }
        }

        private void uncheckAllFeatures() {

            chbFeature1.Checked = false;
            chbFeature2.Checked = false;
            chbFeature3.Checked = false;
            chbFeature4.Checked = false;
            chbFeature5.Checked = false;
            chbFeature6.Checked = false;
            chbFeature7.Checked = false;
            chbFeature8.Checked = false;
            chbFeature9.Checked = false;
            chbFeature10.Checked = false;
            chbFeature11.Checked = false;
            chbFeature12.Checked = false;
            chbFeature13.Checked = false;
            chbFeature14.Checked = false;
            chbFeature15.Checked = false;
            chbFeature16.Checked = false;
            chbFeature17.Checked = false;
            chbFeature18.Checked = false;
            chbFeature19.Checked = false;
            chbFeature20.Checked = false;
            chbFeature21.Checked = false;
            chbFeature22.Checked = false;
            chbFeature23.Checked = false;
            chbFeature24.Checked = false;
            chbFeature25.Checked = false;
            chbFeature26.Checked = false;
        }

        private void checkAllFeatures()
        {
            chbFeature1.Checked = true;
            chbFeature2.Checked = true;
            chbFeature3.Checked = true;
            chbFeature4.Checked = true;
            chbFeature5.Checked = true;
            chbFeature6.Checked = true;
            chbFeature7.Checked = true;
            chbFeature8.Checked = true;
            chbFeature9.Checked = true;
            chbFeature10.Checked = true;
            chbFeature11.Checked = true;
            chbFeature12.Checked = true;
            chbFeature13.Checked = true;
            chbFeature14.Checked = true;
            chbFeature15.Checked = true;
            chbFeature16.Checked = true;
            chbFeature17.Checked = true;
            chbFeature18.Checked = true;
            chbFeature19.Checked = true;
            chbFeature20.Checked = true;
            chbFeature21.Checked = true;
            chbFeature22.Checked = true;
            chbFeature23.Checked = true;
            chbFeature24.Checked = true;
            chbFeature25.Checked = true;
            chbFeature26.Checked = true;
        }

        private void checkNumericFeatures()
        {
            chbFeature1.Checked = true;
            chbFeature2.Checked = true;
            chbFeature3.Checked = true;
            chbFeature4.Checked = true;
            chbFeature5.Checked = true;
            chbFeature6.Checked = true;
            chbFeature7.Checked = true;
            chbFeature8.Checked = true;
        }

        private void checkBinaryFeatures()
        {
            chbFeature1.Checked = true;
            chbFeature2.Checked = true;
            chbFeature3.Checked = true;
            chbFeature4.Checked = true;
            chbFeature5.Checked = true;
            chbFeature6.Checked = true;
            chbFeature7.Checked = true;
            chbFeature8.Checked = true;
            chbFeature9.Checked = true;
            chbFeature10.Checked = true;
            chbFeature11.Checked = true;
            chbFeature12.Checked = true;
            chbFeature13.Checked = true;
            chbFeature14.Checked = true;
            chbFeature15.Checked = true;
            chbFeature16.Checked = true;
            chbFeature17.Checked = true;
            chbFeature18.Checked = true;
        }

        private void checkingFeature() {

            foreach (string feature in listFeatNames)
            {

                if (feature == removeChb(chbFeature1.Name.ToString().ToLower()))
                {
                    chbFeature1.Checked = true;
                }
                else if (feature == removeChb(chbFeature2.Name.ToString().ToLower()))
                {
                    chbFeature2.Checked = true;
                }
                else if (feature == removeChb(chbFeature3.Name.ToString().ToLower()))
                {
                    chbFeature3.Checked = true;
                }
                else if (feature == removeChb(chbFeature4.Name.ToString().ToLower()))
                {
                    chbFeature4.Checked = true;
                }

                else if (feature == removeChb(chbFeature5.Name.ToString().ToLower()))
                {
                    chbFeature5.Checked = true;
                }

                else if (feature == removeChb(chbFeature6.Name.ToString().ToLower()))
                {
                    chbFeature6.Checked = true;
                }
                else if (feature == removeChb(chbFeature7.Name.ToString().ToLower()))
                {
                    chbFeature7.Checked = true;
                }
                else if (feature == removeChb(chbFeature8.Name.ToString().ToLower()))
                {
                    chbFeature8.Checked = true;
                }
                else if (feature == removeChb(chbFeature9.Name.ToString().ToLower()))
                {
                    chbFeature9.Checked = true;
                }
                else if (feature == removeChb(chbFeature10.Name.ToString().ToLower()))
                {
                    chbFeature10.Checked = true;
                }
                else if (feature == removeChb(chbFeature11.Name.ToString().ToLower()))
                {
                    chbFeature11.Checked = true;
                }
                else if (feature == removeChb(chbFeature12.Name.ToString().ToLower()))
                {
                    chbFeature12.Checked = true;
                }
                else if (feature == removeChb(chbFeature13.Name.ToString().ToLower()))
                {
                    chbFeature13.Checked = true;
                }
                else if (feature == removeChb(chbFeature14.Name.ToString().ToLower()))
                {
                    chbFeature14.Checked = true;
                }
                else if (feature == removeChb(chbFeature15.Name.ToString().ToLower()))
                {
                    chbFeature15.Checked = true;
                }
                else if (feature == removeChb(chbFeature16.Name.ToString().ToLower()))
                {
                    chbFeature16.Checked = true;
                }
                else if (feature == removeChb(chbFeature17.Name.ToString().ToLower()))
                {
                    chbFeature17.Checked = true;
                }
                else if (feature == removeChb(chbFeature18.Name.ToString().ToLower()))
                {
                    chbFeature18.Checked = true;
                }
                else if (feature == removeChb(chbFeature19.Name.ToString().ToLower()))
                {
                    chbFeature19.Checked = true;
                }
                else if (feature == removeChb(chbFeature20.Name.ToString().ToLower()))
                {
                    chbFeature20.Checked = true;
                }
                else if (feature == removeChb(chbFeature21.Name.ToString().ToLower()))
                {
                    chbFeature21.Checked = true;
                }
                else if (feature == removeChb(chbFeature22.Name.ToString().ToLower()))
                {
                    chbFeature22.Checked = true;
                }
                else if (feature == removeChb(chbFeature23.Name.ToString().ToLower()))
                {
                    chbFeature23.Checked = true;
                }
                else if (feature == removeChb(chbFeature24.Name.ToString().ToLower()))
                {
                    chbFeature24.Checked = true;
                }
                else if (feature == removeChb(chbFeature25.Name.ToString().ToLower()))
                {
                    chbFeature25.Checked = true;
                }
                else if (feature == removeChb(chbFeature26.Name.ToString().ToLower()))
                {
                    chbFeature26.Checked = true;
                }
            }

        }

        private string removeChb(string line)
        {
            string[] parts1 = line.Split(new string[] { @"chb" }, StringSplitOptions.None);
            string[] parts2 = Regex.Split(line, @"chb");
            String finalText = parts2[1];

            return finalText;
        }

        private void rbParameterGBM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParameterGBM.Checked == true)
            {
                rbParameterXGBoost.Checked = false;
                rbParameterLGB.Checked = false;
            }
        }

        private void rbParameterXGBoost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParameterXGBoost.Checked == true)
            {
                rbParameterGBM.Checked = false;
                rbParameterLGB.Checked = false;
            }
        }

        private void rbParameterLGB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParameterLGB.Checked == true)
            {
                rbParameterGBM.Checked = false;
                rbParameterXGBoost.Checked = false;
            }
        }

        private void btnLoadCurentDS_Click(object sender, EventArgs e)
        {
            if (rbLoadFSRprtAuto.Checked == true)
            {
                theWholeReport = File.ReadAllText(reportFileName);
                tbEvalTimeLogs.Text = theWholeReport;

                List<string> listFeatureSetNumber = new List<string>();

                if (Regex.IsMatch(theWholeReport, @"\b\d+\b:\s{'feature_idx'"))
                {
                    foreach (Match match in Regex.Matches(theWholeReport, @"\b\d+\b:\s{'feature_idx'"))
                    {
                        if (match.Success)
                        {
                            listFeatureSetNumber.Add(extractFeatureSetNumber(match.Value));
                        }
                    }
                    var message = string.Join(Environment.NewLine, listFeatureSetNumber);

                    lboxNoFeatures.DataSource = listFeatureSetNumber;
                }
                else
                {
                    // false;
                }
            }
        }

        private void btnSelectionResult_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Tesxt File|*.txt";
            openFileDialog1.Title = "Select Feature Selection Result Report";

            // default directory
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            // Show the Dialog.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                reportPath = openFileDialog1.FileName;

                tbSelectionResult.Text = reportPath;

                // the selection modification part
                theWholeReport = File.ReadAllText(reportPath);
                tbEvalTimeLogs.Text = theWholeReport;

                List<string> listFeatureSetNumber = new List<string>();

                if (Regex.IsMatch(theWholeReport, @"\b\d+\b:\s{'feature_idx'"))
                {
                    foreach (Match match in Regex.Matches(theWholeReport, @"\b\d+\b:\s{'feature_idx'"))
                    {
                        if (match.Success)
                        {
                            listFeatureSetNumber.Add(extractFeatureSetNumber(match.Value));
                        }
                    }
                    var message = string.Join(Environment.NewLine, listFeatureSetNumber);

                    lboxNoFeatures.DataSource = listFeatureSetNumber;
                    
                }
                else
                {
                    // false;
                }
            }
        }

        private void rbLoadFSRprtAuto_CheckedChanged(object sender, EventArgs e)
        {
            btnLoadCurentDS.Visible = true;

            tbSelectionResult.Visible = false;
            btnSelectionResult.Visible = false;
        }

        private void rbLoadFSRprtManual_CheckedChanged(object sender, EventArgs e)
        {
            btnLoadCurentDS.Visible = false;

            tbSelectionResult.Visible = true;
            btnSelectionResult.Visible = true;
        }

        private void btnBackToForm1_Click(object sender, EventArgs e)
        {
            Form1 formOne = new Form1();
            this.Hide();
            formOne.ShowDialog();
            this.Close();
        }

        private void btnThirdPhase_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
    }
}
