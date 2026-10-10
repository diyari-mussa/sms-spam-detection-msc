namespace SMSSpamFilterProject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePrediction = new System.Windows.Forms.TabPage();
            this.tbColumnV3 = new System.Windows.Forms.TextBox();
            this.chbShowClassDist = new System.Windows.Forms.CheckBox();
            this.chbShowUsefulInfo = new System.Windows.Forms.CheckBox();
            this.chbrbEncodeClass = new System.Windows.Forms.CheckBox();
            this.chbCheckMissingValue = new System.Windows.Forms.CheckBox();
            this.btnShowNamedCol = new System.Windows.Forms.Button();
            this.groupBoxPreOutput = new System.Windows.Forms.GroupBox();
            this.tbPreLogs = new System.Windows.Forms.TextBox();
            this.tbColumnV2 = new System.Windows.Forms.TextBox();
            this.tbColumnV1 = new System.Windows.Forms.TextBox();
            this.tbDataset = new System.Windows.Forms.TextBox();
            this.lblRenameCollumns = new System.Windows.Forms.Label();
            this.lblImportLibrary = new System.Windows.Forms.Label();
            this.lblImportDataset = new System.Windows.Forms.Label();
            this.btnBrowsDataset = new System.Windows.Forms.Button();
            this.tabPageEval = new System.Windows.Forms.TabPage();
            this.gBoxClassification = new System.Windows.Forms.GroupBox();
            this.tbClassifLogs = new System.Windows.Forms.TextBox();
            this.gBoxBoosters = new System.Windows.Forms.GroupBox();
            this.btnLGBClassifier = new System.Windows.Forms.Button();
            this.btnXGBClassifier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGBMClassifier = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.gBoxSelectedFeat = new System.Windows.Forms.GroupBox();
            this.lboxSelectedFeatures = new System.Windows.Forms.ListBox();
            this.lblPythonExe = new System.Windows.Forms.Label();
            this.btnBackToForm2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPagePrediction.SuspendLayout();
            this.groupBoxPreOutput.SuspendLayout();
            this.tabPageEval.SuspendLayout();
            this.gBoxClassification.SuspendLayout();
            this.gBoxBoosters.SuspendLayout();
            this.gBoxSelectedFeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePrediction);
            this.tabControl1.Controls.Add(this.tabPageEval);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1397, 626);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPagePrediction
            // 
            this.tabPagePrediction.Controls.Add(this.tbColumnV3);
            this.tabPagePrediction.Controls.Add(this.chbShowClassDist);
            this.tabPagePrediction.Controls.Add(this.chbShowUsefulInfo);
            this.tabPagePrediction.Controls.Add(this.chbrbEncodeClass);
            this.tabPagePrediction.Controls.Add(this.chbCheckMissingValue);
            this.tabPagePrediction.Controls.Add(this.btnShowNamedCol);
            this.tabPagePrediction.Controls.Add(this.groupBoxPreOutput);
            this.tabPagePrediction.Controls.Add(this.tbColumnV2);
            this.tabPagePrediction.Controls.Add(this.tbColumnV1);
            this.tabPagePrediction.Controls.Add(this.tbDataset);
            this.tabPagePrediction.Controls.Add(this.lblRenameCollumns);
            this.tabPagePrediction.Controls.Add(this.lblImportLibrary);
            this.tabPagePrediction.Controls.Add(this.lblImportDataset);
            this.tabPagePrediction.Controls.Add(this.btnBrowsDataset);
            this.tabPagePrediction.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrediction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePrediction.Name = "tabPagePrediction";
            this.tabPagePrediction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePrediction.Size = new System.Drawing.Size(1389, 597);
            this.tabPagePrediction.TabIndex = 0;
            this.tabPagePrediction.Text = "New Dataset Preprocessing";
            this.tabPagePrediction.UseVisualStyleBackColor = true;
            // 
            // tbColumnV3
            // 
            this.tbColumnV3.Location = new System.Drawing.Point(293, 224);
            this.tbColumnV3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColumnV3.Name = "tbColumnV3";
            this.tbColumnV3.Size = new System.Drawing.Size(129, 22);
            this.tbColumnV3.TabIndex = 28;
            // 
            // chbShowClassDist
            // 
            this.chbShowClassDist.AutoSize = true;
            this.chbShowClassDist.Location = new System.Drawing.Point(22, 282);
            this.chbShowClassDist.Name = "chbShowClassDist";
            this.chbShowClassDist.Size = new System.Drawing.Size(440, 21);
            this.chbShowClassDist.TabIndex = 27;
            this.chbShowClassDist.Text = "Show Class Distribution (ex: how many spam and how many ham)";
            this.chbShowClassDist.UseVisualStyleBackColor = true;
            this.chbShowClassDist.CheckedChanged += new System.EventHandler(this.chbShowClassDist_CheckedChanged);
            // 
            // chbShowUsefulInfo
            // 
            this.chbShowUsefulInfo.AutoSize = true;
            this.chbShowUsefulInfo.Location = new System.Drawing.Point(22, 370);
            this.chbShowUsefulInfo.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowUsefulInfo.Name = "chbShowUsefulInfo";
            this.chbShowUsefulInfo.Size = new System.Drawing.Size(279, 21);
            this.chbShowUsefulInfo.TabIndex = 21;
            this.chbShowUsefulInfo.Text = "Stats and Information about the dataset";
            this.chbShowUsefulInfo.UseVisualStyleBackColor = true;
            this.chbShowUsefulInfo.CheckedChanged += new System.EventHandler(this.chbShowUsefulInfo_CheckedChanged);
            // 
            // chbrbEncodeClass
            // 
            this.chbrbEncodeClass.AutoSize = true;
            this.chbrbEncodeClass.Location = new System.Drawing.Point(22, 326);
            this.chbrbEncodeClass.Margin = new System.Windows.Forms.Padding(4);
            this.chbrbEncodeClass.Name = "chbrbEncodeClass";
            this.chbrbEncodeClass.Size = new System.Drawing.Size(550, 21);
            this.chbrbEncodeClass.TabIndex = 19;
            this.chbrbEncodeClass.Text = "Class Encoding ( transfrom class or label to binary means spam to 1 and ham to 0)" +
    "";
            this.chbrbEncodeClass.UseVisualStyleBackColor = true;
            this.chbrbEncodeClass.CheckedChanged += new System.EventHandler(this.chbrbEncodeClass_CheckedChanged);
            // 
            // chbCheckMissingValue
            // 
            this.chbCheckMissingValue.AutoSize = true;
            this.chbCheckMissingValue.Location = new System.Drawing.Point(22, 156);
            this.chbCheckMissingValue.Margin = new System.Windows.Forms.Padding(4);
            this.chbCheckMissingValue.Name = "chbCheckMissingValue";
            this.chbCheckMissingValue.Size = new System.Drawing.Size(204, 21);
            this.chbCheckMissingValue.TabIndex = 18;
            this.chbCheckMissingValue.Text = "Checking For missing Value";
            this.chbCheckMissingValue.UseVisualStyleBackColor = true;
            this.chbCheckMissingValue.CheckedChanged += new System.EventHandler(this.chbCheckMissingValue_CheckedChanged);
            // 
            // btnShowNamedCol
            // 
            this.btnShowNamedCol.Location = new System.Drawing.Point(429, 221);
            this.btnShowNamedCol.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowNamedCol.Name = "btnShowNamedCol";
            this.btnShowNamedCol.Size = new System.Drawing.Size(268, 28);
            this.btnShowNamedCol.TabIndex = 15;
            this.btnShowNamedCol.Text = "Show Dataset";
            this.btnShowNamedCol.UseVisualStyleBackColor = true;
            this.btnShowNamedCol.Click += new System.EventHandler(this.btnShowNamedCol_Click);
            // 
            // groupBoxPreOutput
            // 
            this.groupBoxPreOutput.Controls.Add(this.tbPreLogs);
            this.groupBoxPreOutput.Location = new System.Drawing.Point(819, 14);
            this.groupBoxPreOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreOutput.Name = "groupBoxPreOutput";
            this.groupBoxPreOutput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreOutput.Size = new System.Drawing.Size(564, 562);
            this.groupBoxPreOutput.TabIndex = 14;
            this.groupBoxPreOutput.TabStop = false;
            // 
            // tbPreLogs
            // 
            this.tbPreLogs.Location = new System.Drawing.Point(6, 19);
            this.tbPreLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPreLogs.Multiline = true;
            this.tbPreLogs.Name = "tbPreLogs";
            this.tbPreLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPreLogs.Size = new System.Drawing.Size(552, 523);
            this.tbPreLogs.TabIndex = 4;
            // 
            // tbColumnV2
            // 
            this.tbColumnV2.Location = new System.Drawing.Point(158, 224);
            this.tbColumnV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColumnV2.Name = "tbColumnV2";
            this.tbColumnV2.Size = new System.Drawing.Size(129, 22);
            this.tbColumnV2.TabIndex = 10;
            // 
            // tbColumnV1
            // 
            this.tbColumnV1.Location = new System.Drawing.Point(22, 224);
            this.tbColumnV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColumnV1.Name = "tbColumnV1";
            this.tbColumnV1.Size = new System.Drawing.Size(129, 22);
            this.tbColumnV1.TabIndex = 9;
            // 
            // tbDataset
            // 
            this.tbDataset.Location = new System.Drawing.Point(21, 98);
            this.tbDataset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDataset.Name = "tbDataset";
            this.tbDataset.Size = new System.Drawing.Size(511, 22);
            this.tbDataset.TabIndex = 5;
            // 
            // lblRenameCollumns
            // 
            this.lblRenameCollumns.AutoSize = true;
            this.lblRenameCollumns.Location = new System.Drawing.Point(18, 200);
            this.lblRenameCollumns.Name = "lblRenameCollumns";
            this.lblRenameCollumns.Size = new System.Drawing.Size(270, 17);
            this.lblRenameCollumns.TabIndex = 8;
            this.lblRenameCollumns.Text = "Rename Dataset Collumns (ex: V1,V2,V3)";
            // 
            // lblImportLibrary
            // 
            this.lblImportLibrary.AutoSize = true;
            this.lblImportLibrary.Location = new System.Drawing.Point(19, 39);
            this.lblImportLibrary.Name = "lblImportLibrary";
            this.lblImportLibrary.Size = new System.Drawing.Size(180, 17);
            this.lblImportLibrary.TabIndex = 7;
            this.lblImportLibrary.Text = "Note : importing all libraries";
            // 
            // lblImportDataset
            // 
            this.lblImportDataset.AutoSize = true;
            this.lblImportDataset.Location = new System.Drawing.Point(19, 76);
            this.lblImportDataset.Name = "lblImportDataset";
            this.lblImportDataset.Size = new System.Drawing.Size(162, 17);
            this.lblImportDataset.TabIndex = 6;
            this.lblImportDataset.Text = "Browse the New Dataset";
            // 
            // btnBrowsDataset
            // 
            this.btnBrowsDataset.Location = new System.Drawing.Point(538, 95);
            this.btnBrowsDataset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowsDataset.Name = "btnBrowsDataset";
            this.btnBrowsDataset.Size = new System.Drawing.Size(159, 28);
            this.btnBrowsDataset.TabIndex = 4;
            this.btnBrowsDataset.Text = "Browse (dataset)";
            this.btnBrowsDataset.UseVisualStyleBackColor = true;
            this.btnBrowsDataset.Click += new System.EventHandler(this.btnBrowsDataset_Click);
            // 
            // tabPageEval
            // 
            this.tabPageEval.Controls.Add(this.gBoxClassification);
            this.tabPageEval.Controls.Add(this.gBoxBoosters);
            this.tabPageEval.Controls.Add(this.gBoxSelectedFeat);
            this.tabPageEval.Location = new System.Drawing.Point(4, 25);
            this.tabPageEval.Name = "tabPageEval";
            this.tabPageEval.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEval.Size = new System.Drawing.Size(1389, 597);
            this.tabPageEval.TabIndex = 1;
            this.tabPageEval.Text = "Classification and Evaluation";
            this.tabPageEval.UseVisualStyleBackColor = true;
            // 
            // gBoxClassification
            // 
            this.gBoxClassification.Controls.Add(this.tbClassifLogs);
            this.gBoxClassification.Location = new System.Drawing.Point(816, 25);
            this.gBoxClassification.Name = "gBoxClassification";
            this.gBoxClassification.Size = new System.Drawing.Size(555, 544);
            this.gBoxClassification.TabIndex = 2;
            this.gBoxClassification.TabStop = false;
            // 
            // tbClassifLogs
            // 
            this.tbClassifLogs.Location = new System.Drawing.Point(16, 21);
            this.tbClassifLogs.Multiline = true;
            this.tbClassifLogs.Name = "tbClassifLogs";
            this.tbClassifLogs.Size = new System.Drawing.Size(519, 501);
            this.tbClassifLogs.TabIndex = 0;
            // 
            // gBoxBoosters
            // 
            this.gBoxBoosters.Controls.Add(this.btnLGBClassifier);
            this.gBoxBoosters.Controls.Add(this.btnXGBClassifier);
            this.gBoxBoosters.Controls.Add(this.label2);
            this.gBoxBoosters.Controls.Add(this.btnGBMClassifier);
            this.gBoxBoosters.Controls.Add(this.lblNotes);
            this.gBoxBoosters.Location = new System.Drawing.Point(246, 25);
            this.gBoxBoosters.Name = "gBoxBoosters";
            this.gBoxBoosters.Size = new System.Drawing.Size(564, 544);
            this.gBoxBoosters.TabIndex = 1;
            this.gBoxBoosters.TabStop = false;
            // 
            // btnLGBClassifier
            // 
            this.btnLGBClassifier.Location = new System.Drawing.Point(36, 394);
            this.btnLGBClassifier.Name = "btnLGBClassifier";
            this.btnLGBClassifier.Size = new System.Drawing.Size(326, 38);
            this.btnLGBClassifier.TabIndex = 4;
            this.btnLGBClassifier.Text = "LightGBM Classifier";
            this.btnLGBClassifier.UseVisualStyleBackColor = true;
            this.btnLGBClassifier.Click += new System.EventHandler(this.btnLGBClassifier_Click);
            // 
            // btnXGBClassifier
            // 
            this.btnXGBClassifier.Location = new System.Drawing.Point(36, 336);
            this.btnXGBClassifier.Name = "btnXGBClassifier";
            this.btnXGBClassifier.Size = new System.Drawing.Size(326, 38);
            this.btnXGBClassifier.TabIndex = 3;
            this.btnXGBClassifier.Text = "XGBoost Classifier";
            this.btnXGBClassifier.UseVisualStyleBackColor = true;
            this.btnXGBClassifier.Click += new System.EventHandler(this.btnXGBClassifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gradient Boosting Classifiers :";
            // 
            // btnGBMClassifier
            // 
            this.btnGBMClassifier.Location = new System.Drawing.Point(36, 281);
            this.btnGBMClassifier.Name = "btnGBMClassifier";
            this.btnGBMClassifier.Size = new System.Drawing.Size(326, 38);
            this.btnGBMClassifier.TabIndex = 1;
            this.btnGBMClassifier.Text = "GBM Classifier";
            this.btnGBMClassifier.UseVisualStyleBackColor = true;
            this.btnGBMClassifier.Click += new System.EventHandler(this.btnGBMClassifier_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(33, 58);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(16, 17);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "[]";
            // 
            // gBoxSelectedFeat
            // 
            this.gBoxSelectedFeat.Controls.Add(this.lboxSelectedFeatures);
            this.gBoxSelectedFeat.Location = new System.Drawing.Point(9, 25);
            this.gBoxSelectedFeat.Name = "gBoxSelectedFeat";
            this.gBoxSelectedFeat.Size = new System.Drawing.Size(231, 544);
            this.gBoxSelectedFeat.TabIndex = 0;
            this.gBoxSelectedFeat.TabStop = false;
            // 
            // lboxSelectedFeatures
            // 
            this.lboxSelectedFeatures.FormattingEnabled = true;
            this.lboxSelectedFeatures.ItemHeight = 16;
            this.lboxSelectedFeatures.Location = new System.Drawing.Point(6, 17);
            this.lboxSelectedFeatures.Name = "lboxSelectedFeatures";
            this.lboxSelectedFeatures.Size = new System.Drawing.Size(219, 516);
            this.lboxSelectedFeatures.TabIndex = 0;
            // 
            // lblPythonExe
            // 
            this.lblPythonExe.AutoSize = true;
            this.lblPythonExe.Location = new System.Drawing.Point(22, 654);
            this.lblPythonExe.Name = "lblPythonExe";
            this.lblPythonExe.Size = new System.Drawing.Size(16, 17);
            this.lblPythonExe.TabIndex = 4;
            this.lblPythonExe.Text = "[]";
            // 
            // btnBackToForm2
            // 
            this.btnBackToForm2.Location = new System.Drawing.Point(1191, 654);
            this.btnBackToForm2.Name = "btnBackToForm2";
            this.btnBackToForm2.Size = new System.Drawing.Size(202, 38);
            this.btnBackToForm2.TabIndex = 28;
            this.btnBackToForm2.Text = "Back to Feature Selection";
            this.btnBackToForm2.UseVisualStyleBackColor = true;
            this.btnBackToForm2.Click += new System.EventHandler(this.btnBackToForm2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 712);
            this.Controls.Add(this.btnBackToForm2);
            this.Controls.Add(this.lblPythonExe);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testing on New Dataset";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePrediction.ResumeLayout(false);
            this.tabPagePrediction.PerformLayout();
            this.groupBoxPreOutput.ResumeLayout(false);
            this.groupBoxPreOutput.PerformLayout();
            this.tabPageEval.ResumeLayout(false);
            this.gBoxClassification.ResumeLayout(false);
            this.gBoxClassification.PerformLayout();
            this.gBoxBoosters.ResumeLayout(false);
            this.gBoxBoosters.PerformLayout();
            this.gBoxSelectedFeat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePrediction;
        private System.Windows.Forms.CheckBox chbShowClassDist;
        private System.Windows.Forms.CheckBox chbShowUsefulInfo;
        private System.Windows.Forms.CheckBox chbrbEncodeClass;
        private System.Windows.Forms.CheckBox chbCheckMissingValue;
        private System.Windows.Forms.Button btnShowNamedCol;
        private System.Windows.Forms.GroupBox groupBoxPreOutput;
        private System.Windows.Forms.TextBox tbPreLogs;
        private System.Windows.Forms.TextBox tbColumnV2;
        private System.Windows.Forms.TextBox tbColumnV1;
        private System.Windows.Forms.TextBox tbDataset;
        private System.Windows.Forms.Label lblRenameCollumns;
        private System.Windows.Forms.Label lblImportLibrary;
        private System.Windows.Forms.Label lblImportDataset;
        private System.Windows.Forms.Button btnBrowsDataset;
        private System.Windows.Forms.Label lblPythonExe;
        private System.Windows.Forms.TextBox tbColumnV3;
        private System.Windows.Forms.TabPage tabPageEval;
        private System.Windows.Forms.GroupBox gBoxSelectedFeat;
        private System.Windows.Forms.GroupBox gBoxClassification;
        private System.Windows.Forms.GroupBox gBoxBoosters;
        private System.Windows.Forms.ListBox lboxSelectedFeatures;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnGBMClassifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLGBClassifier;
        private System.Windows.Forms.Button btnXGBClassifier;
        private System.Windows.Forms.TextBox tbClassifLogs;
        private System.Windows.Forms.Button btnBackToForm2;
    }
}