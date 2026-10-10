namespace SMSSpamFilterProject
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbAllFeatures = new System.Windows.Forms.RadioButton();
            this.rbNumericFeatures = new System.Windows.Forms.RadioButton();
            this.rbBinaryFeatures = new System.Windows.Forms.RadioButton();
            this.lblFeatureTitleExt = new System.Windows.Forms.Label();
            this.tabPageAlgorithm = new System.Windows.Forms.TabPage();
            this.lblCVNote = new System.Windows.Forms.Label();
            this.lblVarSelectedFG = new System.Windows.Forms.Label();
            this.lblSelectedFeatureGroup = new System.Windows.Forms.Label();
            this.btnLGBEvaluateModel = new System.Windows.Forms.Button();
            this.btnXGBEvaluateModel = new System.Windows.Forms.Button();
            this.btnGBMEvaluateModel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbModelEvalLogs = new System.Windows.Forms.TextBox();
            this.chbLGB = new System.Windows.Forms.CheckBox();
            this.chbXGBoost = new System.Windows.Forms.CheckBox();
            this.chbGBM = new System.Windows.Forms.CheckBox();
            this.lblModelTitle = new System.Windows.Forms.Label();
            this.tabPageFeatureExtr = new System.Windows.Forms.TabPage();
            this.tbFEMessage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFeature26 = new System.Windows.Forms.TextBox();
            this.lblFeature26 = new System.Windows.Forms.Label();
            this.tbFeature25 = new System.Windows.Forms.TextBox();
            this.lblFeature25 = new System.Windows.Forms.Label();
            this.tbFeature24 = new System.Windows.Forms.TextBox();
            this.lblFeature24 = new System.Windows.Forms.Label();
            this.tbFeature23 = new System.Windows.Forms.TextBox();
            this.lblFeature23 = new System.Windows.Forms.Label();
            this.tbFeature22 = new System.Windows.Forms.TextBox();
            this.lblFeature22 = new System.Windows.Forms.Label();
            this.tbFeature21 = new System.Windows.Forms.TextBox();
            this.lblFeature21 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFeature20 = new System.Windows.Forms.TextBox();
            this.lblFeature20 = new System.Windows.Forms.Label();
            this.tbFeature19 = new System.Windows.Forms.TextBox();
            this.lblFeature19 = new System.Windows.Forms.Label();
            this.tbFeature18 = new System.Windows.Forms.TextBox();
            this.lblFeature18 = new System.Windows.Forms.Label();
            this.tbFeature17 = new System.Windows.Forms.TextBox();
            this.lblFeature17 = new System.Windows.Forms.Label();
            this.tbFeature16 = new System.Windows.Forms.TextBox();
            this.lblFeature16 = new System.Windows.Forms.Label();
            this.tbFeature15 = new System.Windows.Forms.TextBox();
            this.lblFeature15 = new System.Windows.Forms.Label();
            this.tbFeature14 = new System.Windows.Forms.TextBox();
            this.lblFeature14 = new System.Windows.Forms.Label();
            this.tbFeature13 = new System.Windows.Forms.TextBox();
            this.lblFeature13 = new System.Windows.Forms.Label();
            this.tbFeature12 = new System.Windows.Forms.TextBox();
            this.lblFeature12 = new System.Windows.Forms.Label();
            this.tbFeature11 = new System.Windows.Forms.TextBox();
            this.lblFeature11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFeature10 = new System.Windows.Forms.TextBox();
            this.lblFeature10 = new System.Windows.Forms.Label();
            this.tbFeature9 = new System.Windows.Forms.TextBox();
            this.lblFeature9 = new System.Windows.Forms.Label();
            this.tbFeature8 = new System.Windows.Forms.TextBox();
            this.lblFeature8 = new System.Windows.Forms.Label();
            this.tbFeature7 = new System.Windows.Forms.TextBox();
            this.lblFeature7 = new System.Windows.Forms.Label();
            this.tbFeature6 = new System.Windows.Forms.TextBox();
            this.lblFeature6 = new System.Windows.Forms.Label();
            this.tbFeature5 = new System.Windows.Forms.TextBox();
            this.lblFeature5 = new System.Windows.Forms.Label();
            this.tbFeature4 = new System.Windows.Forms.TextBox();
            this.lblFeature4 = new System.Windows.Forms.Label();
            this.tbFeature3 = new System.Windows.Forms.TextBox();
            this.lblFeature3 = new System.Windows.Forms.Label();
            this.tbFeature2 = new System.Windows.Forms.TextBox();
            this.lblFeature2 = new System.Windows.Forms.Label();
            this.tbFeature1 = new System.Windows.Forms.TextBox();
            this.lblFeature1 = new System.Windows.Forms.Label();
            this.groupBoxMessageList = new System.Windows.Forms.GroupBox();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnShowDatasetMessages = new System.Windows.Forms.Button();
            this.tabPagePreprocessing = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chbShowClassDist = new System.Windows.Forms.CheckBox();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnSecondPhase = new System.Windows.Forms.Button();
            this.btnBackToStart = new System.Windows.Forms.Button();
            this.chbShowUsefulInfo = new System.Windows.Forms.CheckBox();
            this.btnFeature26 = new System.Windows.Forms.Button();
            this.btnFeature25 = new System.Windows.Forms.Button();
            this.btnFeature24 = new System.Windows.Forms.Button();
            this.btnFeature23 = new System.Windows.Forms.Button();
            this.btnFeature22 = new System.Windows.Forms.Button();
            this.btnFeature21 = new System.Windows.Forms.Button();
            this.btnFeature20 = new System.Windows.Forms.Button();
            this.btnFeature19 = new System.Windows.Forms.Button();
            this.btnFeature18 = new System.Windows.Forms.Button();
            this.btnFeature17 = new System.Windows.Forms.Button();
            this.btnFeature16 = new System.Windows.Forms.Button();
            this.btnFeature15 = new System.Windows.Forms.Button();
            this.btnFeature14 = new System.Windows.Forms.Button();
            this.btnFeature13 = new System.Windows.Forms.Button();
            this.btnFeature12 = new System.Windows.Forms.Button();
            this.btnFeature11 = new System.Windows.Forms.Button();
            this.btnFeature10 = new System.Windows.Forms.Button();
            this.btnFeature9 = new System.Windows.Forms.Button();
            this.btnFeature7 = new System.Windows.Forms.Button();
            this.btnFeature6 = new System.Windows.Forms.Button();
            this.btnFeature5 = new System.Windows.Forms.Button();
            this.btnFeature4 = new System.Windows.Forms.Button();
            this.btnFeature3 = new System.Windows.Forms.Button();
            this.btnFeature2 = new System.Windows.Forms.Button();
            this.btnFeature1 = new System.Windows.Forms.Button();
            this.btnFeature8 = new System.Windows.Forms.Button();
            this.chbClassGraph = new System.Windows.Forms.CheckBox();
            this.tabPageAlgorithm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageFeatureExtr.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxMessageList.SuspendLayout();
            this.tabPagePreprocessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxPreOutput.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAllFeatures
            // 
            this.rbAllFeatures.AutoSize = true;
            this.rbAllFeatures.Location = new System.Drawing.Point(296, 34);
            this.rbAllFeatures.Name = "rbAllFeatures";
            this.rbAllFeatures.Size = new System.Drawing.Size(275, 21);
            this.rbAllFeatures.TabIndex = 25;
            this.rbAllFeatures.Text = "All Features (Both Binary and Numeric)";
            this.rbAllFeatures.UseVisualStyleBackColor = true;
            this.rbAllFeatures.CheckedChanged += new System.EventHandler(this.rbAllFeatures_CheckedChanged);
            // 
            // rbNumericFeatures
            // 
            this.rbNumericFeatures.AutoSize = true;
            this.rbNumericFeatures.Location = new System.Drawing.Point(149, 34);
            this.rbNumericFeatures.Name = "rbNumericFeatures";
            this.rbNumericFeatures.Size = new System.Drawing.Size(141, 21);
            this.rbNumericFeatures.TabIndex = 24;
            this.rbNumericFeatures.Text = "Numeric Features";
            this.rbNumericFeatures.UseVisualStyleBackColor = true;
            this.rbNumericFeatures.CheckedChanged += new System.EventHandler(this.rbNumericFeatures_CheckedChanged);
            // 
            // rbBinaryFeatures
            // 
            this.rbBinaryFeatures.AutoSize = true;
            this.rbBinaryFeatures.Location = new System.Drawing.Point(14, 34);
            this.rbBinaryFeatures.Name = "rbBinaryFeatures";
            this.rbBinaryFeatures.Size = new System.Drawing.Size(129, 21);
            this.rbBinaryFeatures.TabIndex = 23;
            this.rbBinaryFeatures.Text = "Binary Features";
            this.rbBinaryFeatures.UseVisualStyleBackColor = true;
            this.rbBinaryFeatures.CheckedChanged += new System.EventHandler(this.rbBinaryFeatures_CheckedChanged);
            // 
            // lblFeatureTitleExt
            // 
            this.lblFeatureTitleExt.AutoSize = true;
            this.lblFeatureTitleExt.Location = new System.Drawing.Point(11, 14);
            this.lblFeatureTitleExt.Name = "lblFeatureTitleExt";
            this.lblFeatureTitleExt.Size = new System.Drawing.Size(203, 17);
            this.lblFeatureTitleExt.TabIndex = 22;
            this.lblFeatureTitleExt.Text = "Type of Features for Extraction";
            // 
            // tabPageAlgorithm
            // 
            this.tabPageAlgorithm.Controls.Add(this.lblCVNote);
            this.tabPageAlgorithm.Controls.Add(this.lblVarSelectedFG);
            this.tabPageAlgorithm.Controls.Add(this.lblSelectedFeatureGroup);
            this.tabPageAlgorithm.Controls.Add(this.btnLGBEvaluateModel);
            this.tabPageAlgorithm.Controls.Add(this.btnXGBEvaluateModel);
            this.tabPageAlgorithm.Controls.Add(this.btnGBMEvaluateModel);
            this.tabPageAlgorithm.Controls.Add(this.groupBox1);
            this.tabPageAlgorithm.Controls.Add(this.chbLGB);
            this.tabPageAlgorithm.Controls.Add(this.chbXGBoost);
            this.tabPageAlgorithm.Controls.Add(this.chbGBM);
            this.tabPageAlgorithm.Controls.Add(this.lblModelTitle);
            this.tabPageAlgorithm.Location = new System.Drawing.Point(4, 25);
            this.tabPageAlgorithm.Name = "tabPageAlgorithm";
            this.tabPageAlgorithm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlgorithm.Size = new System.Drawing.Size(1389, 597);
            this.tabPageAlgorithm.TabIndex = 2;
            this.tabPageAlgorithm.Text = "Classifier Performance";
            this.tabPageAlgorithm.UseVisualStyleBackColor = true;
            // 
            // lblCVNote
            // 
            this.lblCVNote.AutoSize = true;
            this.lblCVNote.Location = new System.Drawing.Point(18, 546);
            this.lblCVNote.Name = "lblCVNote";
            this.lblCVNote.Size = new System.Drawing.Size(426, 17);
            this.lblCVNote.TabIndex = 29;
            this.lblCVNote.Text = "( Note: Training and Testing done using 10-Fold Cross-validation )";
            // 
            // lblVarSelectedFG
            // 
            this.lblVarSelectedFG.AutoSize = true;
            this.lblVarSelectedFG.Location = new System.Drawing.Point(197, 42);
            this.lblVarSelectedFG.Name = "lblVarSelectedFG";
            this.lblVarSelectedFG.Size = new System.Drawing.Size(16, 17);
            this.lblVarSelectedFG.TabIndex = 28;
            this.lblVarSelectedFG.Text = "[]";
            // 
            // lblSelectedFeatureGroup
            // 
            this.lblSelectedFeatureGroup.AutoSize = true;
            this.lblSelectedFeatureGroup.Location = new System.Drawing.Point(18, 42);
            this.lblSelectedFeatureGroup.Name = "lblSelectedFeatureGroup";
            this.lblSelectedFeatureGroup.Size = new System.Drawing.Size(173, 17);
            this.lblSelectedFeatureGroup.TabIndex = 27;
            this.lblSelectedFeatureGroup.Text = "Selected group of feature:";
            // 
            // btnLGBEvaluateModel
            // 
            this.btnLGBEvaluateModel.Location = new System.Drawing.Point(336, 201);
            this.btnLGBEvaluateModel.Name = "btnLGBEvaluateModel";
            this.btnLGBEvaluateModel.Size = new System.Drawing.Size(423, 30);
            this.btnLGBEvaluateModel.TabIndex = 19;
            this.btnLGBEvaluateModel.Text = "LGB Model Evaluation";
            this.btnLGBEvaluateModel.UseVisualStyleBackColor = true;
            this.btnLGBEvaluateModel.Click += new System.EventHandler(this.btnLGBEvaluateModel_Click);
            // 
            // btnXGBEvaluateModel
            // 
            this.btnXGBEvaluateModel.Location = new System.Drawing.Point(336, 165);
            this.btnXGBEvaluateModel.Name = "btnXGBEvaluateModel";
            this.btnXGBEvaluateModel.Size = new System.Drawing.Size(423, 30);
            this.btnXGBEvaluateModel.TabIndex = 18;
            this.btnXGBEvaluateModel.Text = "XGBoost Model Evaluation";
            this.btnXGBEvaluateModel.UseVisualStyleBackColor = true;
            this.btnXGBEvaluateModel.Click += new System.EventHandler(this.btnXGBEvaluateModel_Click);
            // 
            // btnGBMEvaluateModel
            // 
            this.btnGBMEvaluateModel.Location = new System.Drawing.Point(336, 129);
            this.btnGBMEvaluateModel.Name = "btnGBMEvaluateModel";
            this.btnGBMEvaluateModel.Size = new System.Drawing.Size(423, 30);
            this.btnGBMEvaluateModel.TabIndex = 16;
            this.btnGBMEvaluateModel.Text = "GBM Model Evaluation";
            this.btnGBMEvaluateModel.UseVisualStyleBackColor = true;
            this.btnGBMEvaluateModel.Click += new System.EventHandler(this.btnEvaluateModel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbModelEvalLogs);
            this.groupBox1.Location = new System.Drawing.Point(903, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(480, 562);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // tbModelEvalLogs
            // 
            this.tbModelEvalLogs.Location = new System.Drawing.Point(5, 21);
            this.tbModelEvalLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModelEvalLogs.Multiline = true;
            this.tbModelEvalLogs.Name = "tbModelEvalLogs";
            this.tbModelEvalLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbModelEvalLogs.Size = new System.Drawing.Size(472, 528);
            this.tbModelEvalLogs.TabIndex = 4;
            // 
            // chbLGB
            // 
            this.chbLGB.AutoSize = true;
            this.chbLGB.Location = new System.Drawing.Point(20, 207);
            this.chbLGB.Name = "chbLGB";
            this.chbLGB.Size = new System.Drawing.Size(221, 21);
            this.chbLGB.TabIndex = 3;
            this.chbLGB.Text = "Light Gradient Boosting (LGB)";
            this.chbLGB.UseVisualStyleBackColor = true;
            this.chbLGB.CheckedChanged += new System.EventHandler(this.chbLGB_CheckedChanged);
            // 
            // chbXGBoost
            // 
            this.chbXGBoost.AutoSize = true;
            this.chbXGBoost.Location = new System.Drawing.Point(20, 171);
            this.chbXGBoost.Name = "chbXGBoost";
            this.chbXGBoost.Size = new System.Drawing.Size(269, 21);
            this.chbXGBoost.TabIndex = 2;
            this.chbXGBoost.Text = "Extreme Gradient Boosting (XGBoost)";
            this.chbXGBoost.UseVisualStyleBackColor = true;
            this.chbXGBoost.CheckedChanged += new System.EventHandler(this.chbXGBoost_CheckedChanged);
            // 
            // chbGBM
            // 
            this.chbGBM.AutoSize = true;
            this.chbGBM.Location = new System.Drawing.Point(20, 135);
            this.chbGBM.Name = "chbGBM";
            this.chbGBM.Size = new System.Drawing.Size(246, 21);
            this.chbGBM.TabIndex = 1;
            this.chbGBM.Text = "Gradient Boosting Machine (GBM)";
            this.chbGBM.UseVisualStyleBackColor = true;
            this.chbGBM.CheckedChanged += new System.EventHandler(this.chbGBM_CheckedChanged);
            // 
            // lblModelTitle
            // 
            this.lblModelTitle.AutoSize = true;
            this.lblModelTitle.Location = new System.Drawing.Point(18, 98);
            this.lblModelTitle.Name = "lblModelTitle";
            this.lblModelTitle.Size = new System.Drawing.Size(425, 17);
            this.lblModelTitle.TabIndex = 0;
            this.lblModelTitle.Text = "Select any Boosting Algorithm in order to evaluate its performance";
            // 
            // tabPageFeatureExtr
            // 
            this.tabPageFeatureExtr.Controls.Add(this.tbFEMessage);
            this.tabPageFeatureExtr.Controls.Add(this.tableLayoutPanel3);
            this.tabPageFeatureExtr.Controls.Add(this.rbAllFeatures);
            this.tabPageFeatureExtr.Controls.Add(this.tableLayoutPanel2);
            this.tabPageFeatureExtr.Controls.Add(this.tableLayoutPanel1);
            this.tabPageFeatureExtr.Controls.Add(this.rbNumericFeatures);
            this.tabPageFeatureExtr.Controls.Add(this.groupBoxMessageList);
            this.tabPageFeatureExtr.Controls.Add(this.rbBinaryFeatures);
            this.tabPageFeatureExtr.Controls.Add(this.lblFeatureTitleExt);
            this.tabPageFeatureExtr.Location = new System.Drawing.Point(4, 25);
            this.tabPageFeatureExtr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFeatureExtr.Name = "tabPageFeatureExtr";
            this.tabPageFeatureExtr.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFeatureExtr.Size = new System.Drawing.Size(1389, 597);
            this.tabPageFeatureExtr.TabIndex = 1;
            this.tabPageFeatureExtr.Text = "Feature Extraction";
            this.tabPageFeatureExtr.UseVisualStyleBackColor = true;
            // 
            // tbFEMessage
            // 
            this.tbFEMessage.Location = new System.Drawing.Point(15, 75);
            this.tbFEMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFEMessage.Name = "tbFEMessage";
            this.tbFEMessage.Size = new System.Drawing.Size(865, 22);
            this.tbFEMessage.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnFeature26, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnFeature25, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnFeature24, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnFeature23, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnFeature22, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnFeature21, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbFeature26, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblFeature26, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbFeature25, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblFeature25, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbFeature24, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblFeature24, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbFeature23, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblFeature23, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbFeature22, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblFeature22, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbFeature21, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblFeature21, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(604, 122);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 270);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tbFeature26
            // 
            this.tbFeature26.Location = new System.Drawing.Point(178, 222);
            this.tbFeature26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature26.Name = "tbFeature26";
            this.tbFeature26.Size = new System.Drawing.Size(51, 22);
            this.tbFeature26.TabIndex = 11;
            // 
            // lblFeature26
            // 
            this.lblFeature26.AutoSize = true;
            this.lblFeature26.Location = new System.Drawing.Point(3, 220);
            this.lblFeature26.Name = "lblFeature26";
            this.lblFeature26.Size = new System.Drawing.Size(69, 17);
            this.lblFeature26.TabIndex = 10;
            this.lblFeature26.Text = "feature26";
            // 
            // tbFeature25
            // 
            this.tbFeature25.Location = new System.Drawing.Point(178, 178);
            this.tbFeature25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature25.Name = "tbFeature25";
            this.tbFeature25.Size = new System.Drawing.Size(51, 22);
            this.tbFeature25.TabIndex = 9;
            // 
            // lblFeature25
            // 
            this.lblFeature25.AutoSize = true;
            this.lblFeature25.Location = new System.Drawing.Point(3, 176);
            this.lblFeature25.Name = "lblFeature25";
            this.lblFeature25.Size = new System.Drawing.Size(69, 17);
            this.lblFeature25.TabIndex = 8;
            this.lblFeature25.Text = "feature25";
            // 
            // tbFeature24
            // 
            this.tbFeature24.Location = new System.Drawing.Point(178, 134);
            this.tbFeature24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature24.Name = "tbFeature24";
            this.tbFeature24.Size = new System.Drawing.Size(51, 22);
            this.tbFeature24.TabIndex = 7;
            // 
            // lblFeature24
            // 
            this.lblFeature24.AutoSize = true;
            this.lblFeature24.Location = new System.Drawing.Point(3, 132);
            this.lblFeature24.Name = "lblFeature24";
            this.lblFeature24.Size = new System.Drawing.Size(69, 17);
            this.lblFeature24.TabIndex = 6;
            this.lblFeature24.Text = "feature24";
            // 
            // tbFeature23
            // 
            this.tbFeature23.Location = new System.Drawing.Point(178, 90);
            this.tbFeature23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature23.Name = "tbFeature23";
            this.tbFeature23.Size = new System.Drawing.Size(51, 22);
            this.tbFeature23.TabIndex = 5;
            // 
            // lblFeature23
            // 
            this.lblFeature23.AutoSize = true;
            this.lblFeature23.Location = new System.Drawing.Point(3, 88);
            this.lblFeature23.Name = "lblFeature23";
            this.lblFeature23.Size = new System.Drawing.Size(69, 17);
            this.lblFeature23.TabIndex = 4;
            this.lblFeature23.Text = "feature23";
            // 
            // tbFeature22
            // 
            this.tbFeature22.Location = new System.Drawing.Point(178, 46);
            this.tbFeature22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature22.Name = "tbFeature22";
            this.tbFeature22.Size = new System.Drawing.Size(51, 22);
            this.tbFeature22.TabIndex = 3;
            // 
            // lblFeature22
            // 
            this.lblFeature22.AutoSize = true;
            this.lblFeature22.Location = new System.Drawing.Point(3, 44);
            this.lblFeature22.Name = "lblFeature22";
            this.lblFeature22.Size = new System.Drawing.Size(69, 17);
            this.lblFeature22.TabIndex = 2;
            this.lblFeature22.Text = "feature22";
            // 
            // tbFeature21
            // 
            this.tbFeature21.Location = new System.Drawing.Point(178, 2);
            this.tbFeature21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature21.Name = "tbFeature21";
            this.tbFeature21.Size = new System.Drawing.Size(51, 22);
            this.tbFeature21.TabIndex = 1;
            // 
            // lblFeature21
            // 
            this.lblFeature21.AutoSize = true;
            this.lblFeature21.Location = new System.Drawing.Point(3, 0);
            this.lblFeature21.Name = "lblFeature21";
            this.lblFeature21.Size = new System.Drawing.Size(69, 17);
            this.lblFeature21.TabIndex = 0;
            this.lblFeature21.Text = "feature21";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnFeature20, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnFeature19, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnFeature18, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnFeature17, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnFeature16, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnFeature15, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnFeature14, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnFeature13, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnFeature12, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnFeature11, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature20, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature20, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature19, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature19, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature18, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature18, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature17, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature17, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature16, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature16, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature15, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature15, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature14, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature14, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature13, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature13, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature12, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbFeature11, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFeature11, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(307, 122);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 444);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tbFeature20
            // 
            this.tbFeature20.Location = new System.Drawing.Point(178, 398);
            this.tbFeature20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature20.Name = "tbFeature20";
            this.tbFeature20.Size = new System.Drawing.Size(51, 22);
            this.tbFeature20.TabIndex = 19;
            // 
            // lblFeature20
            // 
            this.lblFeature20.AutoSize = true;
            this.lblFeature20.Location = new System.Drawing.Point(3, 396);
            this.lblFeature20.Name = "lblFeature20";
            this.lblFeature20.Size = new System.Drawing.Size(69, 17);
            this.lblFeature20.TabIndex = 18;
            this.lblFeature20.Text = "feature20";
            // 
            // tbFeature19
            // 
            this.tbFeature19.Location = new System.Drawing.Point(178, 354);
            this.tbFeature19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature19.Name = "tbFeature19";
            this.tbFeature19.Size = new System.Drawing.Size(51, 22);
            this.tbFeature19.TabIndex = 17;
            // 
            // lblFeature19
            // 
            this.lblFeature19.AutoSize = true;
            this.lblFeature19.Location = new System.Drawing.Point(3, 352);
            this.lblFeature19.Name = "lblFeature19";
            this.lblFeature19.Size = new System.Drawing.Size(69, 17);
            this.lblFeature19.TabIndex = 16;
            this.lblFeature19.Text = "feature19";
            // 
            // tbFeature18
            // 
            this.tbFeature18.Location = new System.Drawing.Point(178, 310);
            this.tbFeature18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature18.Name = "tbFeature18";
            this.tbFeature18.Size = new System.Drawing.Size(51, 22);
            this.tbFeature18.TabIndex = 15;
            // 
            // lblFeature18
            // 
            this.lblFeature18.AutoSize = true;
            this.lblFeature18.Location = new System.Drawing.Point(3, 308);
            this.lblFeature18.Name = "lblFeature18";
            this.lblFeature18.Size = new System.Drawing.Size(69, 17);
            this.lblFeature18.TabIndex = 14;
            this.lblFeature18.Text = "feature18";
            // 
            // tbFeature17
            // 
            this.tbFeature17.Location = new System.Drawing.Point(178, 266);
            this.tbFeature17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature17.Name = "tbFeature17";
            this.tbFeature17.Size = new System.Drawing.Size(51, 22);
            this.tbFeature17.TabIndex = 13;
            // 
            // lblFeature17
            // 
            this.lblFeature17.AutoSize = true;
            this.lblFeature17.Location = new System.Drawing.Point(3, 264);
            this.lblFeature17.Name = "lblFeature17";
            this.lblFeature17.Size = new System.Drawing.Size(69, 17);
            this.lblFeature17.TabIndex = 12;
            this.lblFeature17.Text = "feature17";
            // 
            // tbFeature16
            // 
            this.tbFeature16.Location = new System.Drawing.Point(178, 222);
            this.tbFeature16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature16.Name = "tbFeature16";
            this.tbFeature16.Size = new System.Drawing.Size(51, 22);
            this.tbFeature16.TabIndex = 11;
            // 
            // lblFeature16
            // 
            this.lblFeature16.AutoSize = true;
            this.lblFeature16.Location = new System.Drawing.Point(3, 220);
            this.lblFeature16.Name = "lblFeature16";
            this.lblFeature16.Size = new System.Drawing.Size(69, 17);
            this.lblFeature16.TabIndex = 10;
            this.lblFeature16.Text = "feature16";
            // 
            // tbFeature15
            // 
            this.tbFeature15.Location = new System.Drawing.Point(178, 178);
            this.tbFeature15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature15.Name = "tbFeature15";
            this.tbFeature15.Size = new System.Drawing.Size(51, 22);
            this.tbFeature15.TabIndex = 9;
            // 
            // lblFeature15
            // 
            this.lblFeature15.AutoSize = true;
            this.lblFeature15.Location = new System.Drawing.Point(3, 176);
            this.lblFeature15.Name = "lblFeature15";
            this.lblFeature15.Size = new System.Drawing.Size(69, 17);
            this.lblFeature15.TabIndex = 8;
            this.lblFeature15.Text = "feature15";
            // 
            // tbFeature14
            // 
            this.tbFeature14.Location = new System.Drawing.Point(178, 134);
            this.tbFeature14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature14.Name = "tbFeature14";
            this.tbFeature14.Size = new System.Drawing.Size(51, 22);
            this.tbFeature14.TabIndex = 7;
            // 
            // lblFeature14
            // 
            this.lblFeature14.AutoSize = true;
            this.lblFeature14.Location = new System.Drawing.Point(3, 132);
            this.lblFeature14.Name = "lblFeature14";
            this.lblFeature14.Size = new System.Drawing.Size(69, 17);
            this.lblFeature14.TabIndex = 6;
            this.lblFeature14.Text = "feature14";
            // 
            // tbFeature13
            // 
            this.tbFeature13.Location = new System.Drawing.Point(178, 90);
            this.tbFeature13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature13.Name = "tbFeature13";
            this.tbFeature13.Size = new System.Drawing.Size(51, 22);
            this.tbFeature13.TabIndex = 5;
            // 
            // lblFeature13
            // 
            this.lblFeature13.AutoSize = true;
            this.lblFeature13.Location = new System.Drawing.Point(3, 88);
            this.lblFeature13.Name = "lblFeature13";
            this.lblFeature13.Size = new System.Drawing.Size(69, 17);
            this.lblFeature13.TabIndex = 4;
            this.lblFeature13.Text = "feature13";
            // 
            // tbFeature12
            // 
            this.tbFeature12.Location = new System.Drawing.Point(178, 46);
            this.tbFeature12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature12.Name = "tbFeature12";
            this.tbFeature12.Size = new System.Drawing.Size(51, 22);
            this.tbFeature12.TabIndex = 3;
            // 
            // lblFeature12
            // 
            this.lblFeature12.AutoSize = true;
            this.lblFeature12.Location = new System.Drawing.Point(3, 44);
            this.lblFeature12.Name = "lblFeature12";
            this.lblFeature12.Size = new System.Drawing.Size(69, 17);
            this.lblFeature12.TabIndex = 2;
            this.lblFeature12.Text = "feature12";
            // 
            // tbFeature11
            // 
            this.tbFeature11.Location = new System.Drawing.Point(178, 2);
            this.tbFeature11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature11.Name = "tbFeature11";
            this.tbFeature11.Size = new System.Drawing.Size(51, 22);
            this.tbFeature11.TabIndex = 1;
            // 
            // lblFeature11
            // 
            this.lblFeature11.AutoSize = true;
            this.lblFeature11.Location = new System.Drawing.Point(3, 0);
            this.lblFeature11.Name = "lblFeature11";
            this.lblFeature11.Size = new System.Drawing.Size(69, 17);
            this.lblFeature11.TabIndex = 0;
            this.lblFeature11.Text = "feature11";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnFeature10, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnFeature9, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnFeature7, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnFeature6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnFeature5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnFeature4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnFeature3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFeature2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFeature1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature10, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature9, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbFeature1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFeature1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFeature8, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 122);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 444);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbFeature10
            // 
            this.tbFeature10.Location = new System.Drawing.Point(178, 398);
            this.tbFeature10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature10.Name = "tbFeature10";
            this.tbFeature10.Size = new System.Drawing.Size(51, 22);
            this.tbFeature10.TabIndex = 19;
            // 
            // lblFeature10
            // 
            this.lblFeature10.AutoSize = true;
            this.lblFeature10.Location = new System.Drawing.Point(3, 396);
            this.lblFeature10.Name = "lblFeature10";
            this.lblFeature10.Size = new System.Drawing.Size(69, 17);
            this.lblFeature10.TabIndex = 18;
            this.lblFeature10.Text = "feature10";
            // 
            // tbFeature9
            // 
            this.tbFeature9.Location = new System.Drawing.Point(178, 354);
            this.tbFeature9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature9.Name = "tbFeature9";
            this.tbFeature9.Size = new System.Drawing.Size(51, 22);
            this.tbFeature9.TabIndex = 17;
            // 
            // lblFeature9
            // 
            this.lblFeature9.AutoSize = true;
            this.lblFeature9.Location = new System.Drawing.Point(3, 352);
            this.lblFeature9.Name = "lblFeature9";
            this.lblFeature9.Size = new System.Drawing.Size(61, 17);
            this.lblFeature9.TabIndex = 16;
            this.lblFeature9.Text = "feature9";
            // 
            // tbFeature8
            // 
            this.tbFeature8.Location = new System.Drawing.Point(178, 310);
            this.tbFeature8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature8.Name = "tbFeature8";
            this.tbFeature8.Size = new System.Drawing.Size(51, 22);
            this.tbFeature8.TabIndex = 15;
            // 
            // lblFeature8
            // 
            this.lblFeature8.AutoSize = true;
            this.lblFeature8.Location = new System.Drawing.Point(3, 308);
            this.lblFeature8.Name = "lblFeature8";
            this.lblFeature8.Size = new System.Drawing.Size(61, 17);
            this.lblFeature8.TabIndex = 14;
            this.lblFeature8.Text = "feature8";
            // 
            // tbFeature7
            // 
            this.tbFeature7.Location = new System.Drawing.Point(178, 266);
            this.tbFeature7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature7.Name = "tbFeature7";
            this.tbFeature7.Size = new System.Drawing.Size(51, 22);
            this.tbFeature7.TabIndex = 13;
            // 
            // lblFeature7
            // 
            this.lblFeature7.AutoSize = true;
            this.lblFeature7.Location = new System.Drawing.Point(3, 264);
            this.lblFeature7.Name = "lblFeature7";
            this.lblFeature7.Size = new System.Drawing.Size(61, 17);
            this.lblFeature7.TabIndex = 12;
            this.lblFeature7.Text = "feature7";
            // 
            // tbFeature6
            // 
            this.tbFeature6.Location = new System.Drawing.Point(178, 222);
            this.tbFeature6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature6.Name = "tbFeature6";
            this.tbFeature6.Size = new System.Drawing.Size(51, 22);
            this.tbFeature6.TabIndex = 11;
            // 
            // lblFeature6
            // 
            this.lblFeature6.AutoSize = true;
            this.lblFeature6.Location = new System.Drawing.Point(3, 220);
            this.lblFeature6.Name = "lblFeature6";
            this.lblFeature6.Size = new System.Drawing.Size(61, 17);
            this.lblFeature6.TabIndex = 10;
            this.lblFeature6.Text = "feature6";
            // 
            // tbFeature5
            // 
            this.tbFeature5.Location = new System.Drawing.Point(178, 178);
            this.tbFeature5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature5.Name = "tbFeature5";
            this.tbFeature5.Size = new System.Drawing.Size(51, 22);
            this.tbFeature5.TabIndex = 9;
            // 
            // lblFeature5
            // 
            this.lblFeature5.AutoSize = true;
            this.lblFeature5.Location = new System.Drawing.Point(3, 176);
            this.lblFeature5.Name = "lblFeature5";
            this.lblFeature5.Size = new System.Drawing.Size(61, 17);
            this.lblFeature5.TabIndex = 8;
            this.lblFeature5.Text = "feature5";
            // 
            // tbFeature4
            // 
            this.tbFeature4.Location = new System.Drawing.Point(178, 134);
            this.tbFeature4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature4.Name = "tbFeature4";
            this.tbFeature4.Size = new System.Drawing.Size(51, 22);
            this.tbFeature4.TabIndex = 7;
            // 
            // lblFeature4
            // 
            this.lblFeature4.AutoSize = true;
            this.lblFeature4.Location = new System.Drawing.Point(3, 132);
            this.lblFeature4.Name = "lblFeature4";
            this.lblFeature4.Size = new System.Drawing.Size(61, 17);
            this.lblFeature4.TabIndex = 6;
            this.lblFeature4.Text = "feature4";
            // 
            // tbFeature3
            // 
            this.tbFeature3.Location = new System.Drawing.Point(178, 90);
            this.tbFeature3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature3.Name = "tbFeature3";
            this.tbFeature3.Size = new System.Drawing.Size(51, 22);
            this.tbFeature3.TabIndex = 5;
            // 
            // lblFeature3
            // 
            this.lblFeature3.AutoSize = true;
            this.lblFeature3.Location = new System.Drawing.Point(3, 88);
            this.lblFeature3.Name = "lblFeature3";
            this.lblFeature3.Size = new System.Drawing.Size(61, 17);
            this.lblFeature3.TabIndex = 4;
            this.lblFeature3.Text = "feature3";
            // 
            // tbFeature2
            // 
            this.tbFeature2.Location = new System.Drawing.Point(178, 46);
            this.tbFeature2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature2.Name = "tbFeature2";
            this.tbFeature2.Size = new System.Drawing.Size(51, 22);
            this.tbFeature2.TabIndex = 3;
            // 
            // lblFeature2
            // 
            this.lblFeature2.AutoSize = true;
            this.lblFeature2.Location = new System.Drawing.Point(3, 44);
            this.lblFeature2.Name = "lblFeature2";
            this.lblFeature2.Size = new System.Drawing.Size(61, 17);
            this.lblFeature2.TabIndex = 2;
            this.lblFeature2.Text = "feature2";
            // 
            // tbFeature1
            // 
            this.tbFeature1.Location = new System.Drawing.Point(178, 2);
            this.tbFeature1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFeature1.Name = "tbFeature1";
            this.tbFeature1.Size = new System.Drawing.Size(51, 22);
            this.tbFeature1.TabIndex = 1;
            // 
            // lblFeature1
            // 
            this.lblFeature1.AutoSize = true;
            this.lblFeature1.Location = new System.Drawing.Point(3, 0);
            this.lblFeature1.Name = "lblFeature1";
            this.lblFeature1.Size = new System.Drawing.Size(61, 17);
            this.lblFeature1.TabIndex = 0;
            this.lblFeature1.Text = "feature1";
            // 
            // groupBoxMessageList
            // 
            this.groupBoxMessageList.Controls.Add(this.btnExportToCSV);
            this.groupBoxMessageList.Controls.Add(this.checkedListBox1);
            this.groupBoxMessageList.Controls.Add(this.btnShowDatasetMessages);
            this.groupBoxMessageList.Location = new System.Drawing.Point(903, 14);
            this.groupBoxMessageList.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMessageList.Name = "groupBoxMessageList";
            this.groupBoxMessageList.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMessageList.Size = new System.Drawing.Size(480, 562);
            this.groupBoxMessageList.TabIndex = 0;
            this.groupBoxMessageList.TabStop = false;
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(247, 15);
            this.btnExportToCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(224, 30);
            this.btnExportToCSV.TabIndex = 14;
            this.btnExportToCSV.Text = "Export Extracted Features";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(8, 61);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(463, 497);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnShowDatasetMessages
            // 
            this.btnShowDatasetMessages.Location = new System.Drawing.Point(7, 15);
            this.btnShowDatasetMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowDatasetMessages.Name = "btnShowDatasetMessages";
            this.btnShowDatasetMessages.Size = new System.Drawing.Size(204, 30);
            this.btnShowDatasetMessages.TabIndex = 13;
            this.btnShowDatasetMessages.Text = "Show Dataset Messages";
            this.btnShowDatasetMessages.UseVisualStyleBackColor = true;
            this.btnShowDatasetMessages.Click += new System.EventHandler(this.btnShowDatasetMessages_Click);
            // 
            // tabPagePreprocessing
            // 
            this.tabPagePreprocessing.Controls.Add(this.chbClassGraph);
            this.tabPagePreprocessing.Controls.Add(this.chart1);
            this.tabPagePreprocessing.Controls.Add(this.chbShowClassDist);
            this.tabPagePreprocessing.Controls.Add(this.chbShowUsefulInfo);
            this.tabPagePreprocessing.Controls.Add(this.chbrbEncodeClass);
            this.tabPagePreprocessing.Controls.Add(this.chbCheckMissingValue);
            this.tabPagePreprocessing.Controls.Add(this.btnShowNamedCol);
            this.tabPagePreprocessing.Controls.Add(this.groupBoxPreOutput);
            this.tabPagePreprocessing.Controls.Add(this.tbColumnV2);
            this.tabPagePreprocessing.Controls.Add(this.tbColumnV1);
            this.tabPagePreprocessing.Controls.Add(this.tbDataset);
            this.tabPagePreprocessing.Controls.Add(this.lblRenameCollumns);
            this.tabPagePreprocessing.Controls.Add(this.lblImportLibrary);
            this.tabPagePreprocessing.Controls.Add(this.lblImportDataset);
            this.tabPagePreprocessing.Controls.Add(this.btnBrowsDataset);
            this.tabPagePreprocessing.Location = new System.Drawing.Point(4, 25);
            this.tabPagePreprocessing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePreprocessing.Name = "tabPagePreprocessing";
            this.tabPagePreprocessing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePreprocessing.Size = new System.Drawing.Size(1389, 597);
            this.tabPagePreprocessing.TabIndex = 0;
            this.tabPagePreprocessing.Text = "Preprocessing";
            this.tabPagePreprocessing.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(23, 364);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Text Messages";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(245, 212);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "Dataset Statistics";
            // 
            // chbShowClassDist
            // 
            this.chbShowClassDist.AutoSize = true;
            this.chbShowClassDist.Location = new System.Drawing.Point(23, 206);
            this.chbShowClassDist.Name = "chbShowClassDist";
            this.chbShowClassDist.Size = new System.Drawing.Size(440, 21);
            this.chbShowClassDist.TabIndex = 27;
            this.chbShowClassDist.Text = "Show Class Distribution (ex: how many spam and how many ham)";
            this.chbShowClassDist.UseVisualStyleBackColor = true;
            this.chbShowClassDist.CheckedChanged += new System.EventHandler(this.chbShowClassDist_CheckedChanged);
            // 
            // chbrbEncodeClass
            // 
            this.chbrbEncodeClass.AutoSize = true;
            this.chbrbEncodeClass.Location = new System.Drawing.Point(23, 250);
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
            this.chbCheckMissingValue.Location = new System.Drawing.Point(23, 117);
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
            this.btnShowNamedCol.Location = new System.Drawing.Point(559, 156);
            this.btnShowNamedCol.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowNamedCol.Name = "btnShowNamedCol";
            this.btnShowNamedCol.Size = new System.Drawing.Size(139, 28);
            this.btnShowNamedCol.TabIndex = 15;
            this.btnShowNamedCol.Text = "Show Dataset";
            this.btnShowNamedCol.UseVisualStyleBackColor = true;
            this.btnShowNamedCol.Click += new System.EventHandler(this.btnShowNamedCol_Click);
            // 
            // groupBoxPreOutput
            // 
            this.groupBoxPreOutput.Controls.Add(this.tbPreLogs);
            this.groupBoxPreOutput.Location = new System.Drawing.Point(903, 14);
            this.groupBoxPreOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreOutput.Name = "groupBoxPreOutput";
            this.groupBoxPreOutput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreOutput.Size = new System.Drawing.Size(480, 562);
            this.groupBoxPreOutput.TabIndex = 14;
            this.groupBoxPreOutput.TabStop = false;
            // 
            // tbPreLogs
            // 
            this.tbPreLogs.Location = new System.Drawing.Point(5, 21);
            this.tbPreLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPreLogs.Multiline = true;
            this.tbPreLogs.Name = "tbPreLogs";
            this.tbPreLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPreLogs.Size = new System.Drawing.Size(471, 523);
            this.tbPreLogs.TabIndex = 4;
            this.tbPreLogs.WordWrap = false;
            // 
            // tbColumnV2
            // 
            this.tbColumnV2.Location = new System.Drawing.Point(421, 159);
            this.tbColumnV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColumnV2.Name = "tbColumnV2";
            this.tbColumnV2.Size = new System.Drawing.Size(129, 22);
            this.tbColumnV2.TabIndex = 10;
            // 
            // tbColumnV1
            // 
            this.tbColumnV1.Location = new System.Drawing.Point(285, 159);
            this.tbColumnV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColumnV1.Name = "tbColumnV1";
            this.tbColumnV1.Size = new System.Drawing.Size(129, 22);
            this.tbColumnV1.TabIndex = 9;
            // 
            // tbDataset
            // 
            this.tbDataset.Location = new System.Drawing.Point(173, 74);
            this.tbDataset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDataset.Name = "tbDataset";
            this.tbDataset.Size = new System.Drawing.Size(449, 22);
            this.tbDataset.TabIndex = 5;
            // 
            // lblRenameCollumns
            // 
            this.lblRenameCollumns.AutoSize = true;
            this.lblRenameCollumns.Location = new System.Drawing.Point(19, 161);
            this.lblRenameCollumns.Name = "lblRenameCollumns";
            this.lblRenameCollumns.Size = new System.Drawing.Size(249, 17);
            this.lblRenameCollumns.TabIndex = 8;
            this.lblRenameCollumns.Text = "Rename Dataset Collumns (ex: V1,V2)";
            // 
            // lblImportLibrary
            // 
            this.lblImportLibrary.AutoSize = true;
            this.lblImportLibrary.Location = new System.Drawing.Point(19, 39);
            this.lblImportLibrary.Name = "lblImportLibrary";
            this.lblImportLibrary.Size = new System.Drawing.Size(209, 17);
            this.lblImportLibrary.TabIndex = 7;
            this.lblImportLibrary.Text = "Note : first we import all libraries";
            // 
            // lblImportDataset
            // 
            this.lblImportDataset.AutoSize = true;
            this.lblImportDataset.Location = new System.Drawing.Point(19, 76);
            this.lblImportDataset.Name = "lblImportDataset";
            this.lblImportDataset.Size = new System.Drawing.Size(150, 17);
            this.lblImportDataset.TabIndex = 6;
            this.lblImportDataset.Text = "Browse for the dataset";
            // 
            // btnBrowsDataset
            // 
            this.btnBrowsDataset.Location = new System.Drawing.Point(628, 71);
            this.btnBrowsDataset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowsDataset.Name = "btnBrowsDataset";
            this.btnBrowsDataset.Size = new System.Drawing.Size(159, 28);
            this.btnBrowsDataset.TabIndex = 4;
            this.btnBrowsDataset.Text = "Browse (dataset)";
            this.btnBrowsDataset.UseVisualStyleBackColor = true;
            this.btnBrowsDataset.Click += new System.EventHandler(this.btnBrowsDataset_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePreprocessing);
            this.tabControl1.Controls.Add(this.tabPageFeatureExtr);
            this.tabControl1.Controls.Add(this.tabPageAlgorithm);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1397, 626);
            this.tabControl1.TabIndex = 2;
            // 
            // btnSecondPhase
            // 
            this.btnSecondPhase.Location = new System.Drawing.Point(1195, 656);
            this.btnSecondPhase.Name = "btnSecondPhase";
            this.btnSecondPhase.Size = new System.Drawing.Size(199, 38);
            this.btnSecondPhase.TabIndex = 26;
            this.btnSecondPhase.Text = "Feature Selection Phase >";
            this.btnSecondPhase.UseVisualStyleBackColor = true;
            this.btnSecondPhase.Click += new System.EventHandler(this.btnSecondPhase_Click);
            // 
            // btnBackToStart
            // 
            this.btnBackToStart.Location = new System.Drawing.Point(1033, 656);
            this.btnBackToStart.Name = "btnBackToStart";
            this.btnBackToStart.Size = new System.Drawing.Size(156, 38);
            this.btnBackToStart.TabIndex = 27;
            this.btnBackToStart.Text = "< Back to Start Form";
            this.btnBackToStart.UseVisualStyleBackColor = true;
            this.btnBackToStart.Click += new System.EventHandler(this.btnBackToStart_Click);
            // 
            // chbShowUsefulInfo
            // 
            this.chbShowUsefulInfo.AutoSize = true;
            this.chbShowUsefulInfo.Location = new System.Drawing.Point(23, 294);
            this.chbShowUsefulInfo.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowUsefulInfo.Name = "chbShowUsefulInfo";
            this.chbShowUsefulInfo.Size = new System.Drawing.Size(279, 21);
            this.chbShowUsefulInfo.TabIndex = 21;
            this.chbShowUsefulInfo.Text = "Stats and Information about the dataset";
            this.chbShowUsefulInfo.UseVisualStyleBackColor = true;
            this.chbShowUsefulInfo.CheckedChanged += new System.EventHandler(this.chbShowUsefulInfo_CheckedChanged);
            // 
            // btnFeature26
            // 
            this.btnFeature26.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature26.Location = new System.Drawing.Point(236, 222);
            this.btnFeature26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature26.Name = "btnFeature26";
            this.btnFeature26.Size = new System.Drawing.Size(39, 25);
            this.btnFeature26.TabIndex = 43;
            this.btnFeature26.UseVisualStyleBackColor = true;
            this.btnFeature26.Click += new System.EventHandler(this.btnFeature26_Click);
            // 
            // btnFeature25
            // 
            this.btnFeature25.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature25.Location = new System.Drawing.Point(236, 178);
            this.btnFeature25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature25.Name = "btnFeature25";
            this.btnFeature25.Size = new System.Drawing.Size(39, 25);
            this.btnFeature25.TabIndex = 42;
            this.btnFeature25.UseVisualStyleBackColor = true;
            this.btnFeature25.Click += new System.EventHandler(this.btnFeature25_Click);
            // 
            // btnFeature24
            // 
            this.btnFeature24.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature24.Location = new System.Drawing.Point(236, 134);
            this.btnFeature24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature24.Name = "btnFeature24";
            this.btnFeature24.Size = new System.Drawing.Size(39, 25);
            this.btnFeature24.TabIndex = 41;
            this.btnFeature24.UseVisualStyleBackColor = true;
            this.btnFeature24.Click += new System.EventHandler(this.btnFeature24_Click);
            // 
            // btnFeature23
            // 
            this.btnFeature23.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature23.Location = new System.Drawing.Point(236, 90);
            this.btnFeature23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature23.Name = "btnFeature23";
            this.btnFeature23.Size = new System.Drawing.Size(39, 25);
            this.btnFeature23.TabIndex = 40;
            this.btnFeature23.UseVisualStyleBackColor = true;
            this.btnFeature23.Click += new System.EventHandler(this.btnFeature23_Click);
            // 
            // btnFeature22
            // 
            this.btnFeature22.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature22.Location = new System.Drawing.Point(236, 46);
            this.btnFeature22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature22.Name = "btnFeature22";
            this.btnFeature22.Size = new System.Drawing.Size(39, 25);
            this.btnFeature22.TabIndex = 39;
            this.btnFeature22.UseVisualStyleBackColor = true;
            this.btnFeature22.Click += new System.EventHandler(this.btnFeature22_Click);
            // 
            // btnFeature21
            // 
            this.btnFeature21.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature21.Location = new System.Drawing.Point(236, 2);
            this.btnFeature21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature21.Name = "btnFeature21";
            this.btnFeature21.Size = new System.Drawing.Size(39, 25);
            this.btnFeature21.TabIndex = 38;
            this.btnFeature21.UseVisualStyleBackColor = true;
            this.btnFeature21.Click += new System.EventHandler(this.btnFeature21_Click);
            // 
            // btnFeature20
            // 
            this.btnFeature20.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature20.Location = new System.Drawing.Point(236, 398);
            this.btnFeature20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature20.Name = "btnFeature20";
            this.btnFeature20.Size = new System.Drawing.Size(39, 25);
            this.btnFeature20.TabIndex = 39;
            this.btnFeature20.UseVisualStyleBackColor = true;
            this.btnFeature20.Click += new System.EventHandler(this.btnFeature20_Click);
            // 
            // btnFeature19
            // 
            this.btnFeature19.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature19.Location = new System.Drawing.Point(236, 354);
            this.btnFeature19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature19.Name = "btnFeature19";
            this.btnFeature19.Size = new System.Drawing.Size(39, 25);
            this.btnFeature19.TabIndex = 37;
            this.btnFeature19.UseVisualStyleBackColor = true;
            this.btnFeature19.Click += new System.EventHandler(this.btnFeature19_Click);
            // 
            // btnFeature18
            // 
            this.btnFeature18.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature18.Location = new System.Drawing.Point(236, 310);
            this.btnFeature18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature18.Name = "btnFeature18";
            this.btnFeature18.Size = new System.Drawing.Size(39, 25);
            this.btnFeature18.TabIndex = 36;
            this.btnFeature18.UseVisualStyleBackColor = true;
            this.btnFeature18.Click += new System.EventHandler(this.btnFeature18_Click);
            // 
            // btnFeature17
            // 
            this.btnFeature17.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature17.Location = new System.Drawing.Point(236, 266);
            this.btnFeature17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature17.Name = "btnFeature17";
            this.btnFeature17.Size = new System.Drawing.Size(39, 25);
            this.btnFeature17.TabIndex = 35;
            this.btnFeature17.UseVisualStyleBackColor = true;
            this.btnFeature17.Click += new System.EventHandler(this.btnFeature17_Click);
            // 
            // btnFeature16
            // 
            this.btnFeature16.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature16.Location = new System.Drawing.Point(236, 222);
            this.btnFeature16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature16.Name = "btnFeature16";
            this.btnFeature16.Size = new System.Drawing.Size(39, 25);
            this.btnFeature16.TabIndex = 34;
            this.btnFeature16.UseVisualStyleBackColor = true;
            this.btnFeature16.Click += new System.EventHandler(this.btnFeature16_Click);
            // 
            // btnFeature15
            // 
            this.btnFeature15.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature15.Location = new System.Drawing.Point(236, 178);
            this.btnFeature15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature15.Name = "btnFeature15";
            this.btnFeature15.Size = new System.Drawing.Size(39, 25);
            this.btnFeature15.TabIndex = 33;
            this.btnFeature15.UseVisualStyleBackColor = true;
            this.btnFeature15.Click += new System.EventHandler(this.btnFeature15_Click);
            // 
            // btnFeature14
            // 
            this.btnFeature14.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature14.Location = new System.Drawing.Point(236, 134);
            this.btnFeature14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature14.Name = "btnFeature14";
            this.btnFeature14.Size = new System.Drawing.Size(39, 25);
            this.btnFeature14.TabIndex = 32;
            this.btnFeature14.UseVisualStyleBackColor = true;
            this.btnFeature14.Click += new System.EventHandler(this.btnFeature14_Click);
            // 
            // btnFeature13
            // 
            this.btnFeature13.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature13.Location = new System.Drawing.Point(236, 90);
            this.btnFeature13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature13.Name = "btnFeature13";
            this.btnFeature13.Size = new System.Drawing.Size(39, 25);
            this.btnFeature13.TabIndex = 31;
            this.btnFeature13.UseVisualStyleBackColor = true;
            this.btnFeature13.Click += new System.EventHandler(this.btnFeature13_Click);
            // 
            // btnFeature12
            // 
            this.btnFeature12.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature12.Location = new System.Drawing.Point(236, 46);
            this.btnFeature12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature12.Name = "btnFeature12";
            this.btnFeature12.Size = new System.Drawing.Size(39, 25);
            this.btnFeature12.TabIndex = 30;
            this.btnFeature12.UseVisualStyleBackColor = true;
            this.btnFeature12.Click += new System.EventHandler(this.btnFeature12_Click);
            // 
            // btnFeature11
            // 
            this.btnFeature11.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature11.Location = new System.Drawing.Point(236, 2);
            this.btnFeature11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature11.Name = "btnFeature11";
            this.btnFeature11.Size = new System.Drawing.Size(39, 25);
            this.btnFeature11.TabIndex = 29;
            this.btnFeature11.UseVisualStyleBackColor = true;
            this.btnFeature11.Click += new System.EventHandler(this.btnFeature11_Click);
            // 
            // btnFeature10
            // 
            this.btnFeature10.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature10.Location = new System.Drawing.Point(236, 398);
            this.btnFeature10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature10.Name = "btnFeature10";
            this.btnFeature10.Size = new System.Drawing.Size(39, 25);
            this.btnFeature10.TabIndex = 30;
            this.btnFeature10.UseVisualStyleBackColor = true;
            this.btnFeature10.Click += new System.EventHandler(this.btnFeature10_Click);
            // 
            // btnFeature9
            // 
            this.btnFeature9.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature9.Location = new System.Drawing.Point(236, 354);
            this.btnFeature9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature9.Name = "btnFeature9";
            this.btnFeature9.Size = new System.Drawing.Size(39, 25);
            this.btnFeature9.TabIndex = 28;
            this.btnFeature9.UseVisualStyleBackColor = true;
            this.btnFeature9.Click += new System.EventHandler(this.btnFeature9_Click);
            // 
            // btnFeature7
            // 
            this.btnFeature7.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature7.Location = new System.Drawing.Point(236, 266);
            this.btnFeature7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature7.Name = "btnFeature7";
            this.btnFeature7.Size = new System.Drawing.Size(39, 25);
            this.btnFeature7.TabIndex = 27;
            this.btnFeature7.UseVisualStyleBackColor = true;
            this.btnFeature7.Click += new System.EventHandler(this.btnFeature7_Click);
            // 
            // btnFeature6
            // 
            this.btnFeature6.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature6.Location = new System.Drawing.Point(236, 222);
            this.btnFeature6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature6.Name = "btnFeature6";
            this.btnFeature6.Size = new System.Drawing.Size(39, 25);
            this.btnFeature6.TabIndex = 26;
            this.btnFeature6.UseVisualStyleBackColor = true;
            this.btnFeature6.Click += new System.EventHandler(this.btnFeature6_Click);
            // 
            // btnFeature5
            // 
            this.btnFeature5.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature5.Location = new System.Drawing.Point(236, 178);
            this.btnFeature5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature5.Name = "btnFeature5";
            this.btnFeature5.Size = new System.Drawing.Size(39, 25);
            this.btnFeature5.TabIndex = 25;
            this.btnFeature5.UseVisualStyleBackColor = true;
            this.btnFeature5.Click += new System.EventHandler(this.btnFeature5_Click);
            // 
            // btnFeature4
            // 
            this.btnFeature4.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature4.Location = new System.Drawing.Point(236, 134);
            this.btnFeature4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature4.Name = "btnFeature4";
            this.btnFeature4.Size = new System.Drawing.Size(39, 25);
            this.btnFeature4.TabIndex = 24;
            this.btnFeature4.UseVisualStyleBackColor = true;
            this.btnFeature4.Click += new System.EventHandler(this.btnFeature4_Click);
            // 
            // btnFeature3
            // 
            this.btnFeature3.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature3.Location = new System.Drawing.Point(236, 90);
            this.btnFeature3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature3.Name = "btnFeature3";
            this.btnFeature3.Size = new System.Drawing.Size(39, 25);
            this.btnFeature3.TabIndex = 23;
            this.btnFeature3.UseVisualStyleBackColor = true;
            this.btnFeature3.Click += new System.EventHandler(this.btnFeature3_Click);
            // 
            // btnFeature2
            // 
            this.btnFeature2.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature2.Location = new System.Drawing.Point(236, 46);
            this.btnFeature2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature2.Name = "btnFeature2";
            this.btnFeature2.Size = new System.Drawing.Size(39, 25);
            this.btnFeature2.TabIndex = 22;
            this.btnFeature2.UseVisualStyleBackColor = true;
            this.btnFeature2.Click += new System.EventHandler(this.btnFeature2_Click);
            // 
            // btnFeature1
            // 
            this.btnFeature1.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature1.Location = new System.Drawing.Point(236, 2);
            this.btnFeature1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature1.Name = "btnFeature1";
            this.btnFeature1.Size = new System.Drawing.Size(39, 25);
            this.btnFeature1.TabIndex = 21;
            this.btnFeature1.UseVisualStyleBackColor = true;
            this.btnFeature1.Click += new System.EventHandler(this.btnFeature1_Click);
            // 
            // btnFeature8
            // 
            this.btnFeature8.Image = global::SMSSpamFilterProject.Properties.Resources.searchicon;
            this.btnFeature8.Location = new System.Drawing.Point(236, 310);
            this.btnFeature8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeature8.Name = "btnFeature8";
            this.btnFeature8.Size = new System.Drawing.Size(39, 25);
            this.btnFeature8.TabIndex = 20;
            this.btnFeature8.UseVisualStyleBackColor = true;
            this.btnFeature8.Click += new System.EventHandler(this.btnFeature8_Click);
            // 
            // chbClassGraph
            // 
            this.chbClassGraph.AutoSize = true;
            this.chbClassGraph.Location = new System.Drawing.Point(23, 337);
            this.chbClassGraph.Name = "chbClassGraph";
            this.chbClassGraph.Size = new System.Drawing.Size(355, 21);
            this.chbClassGraph.TabIndex = 32;
            this.chbClassGraph.Text = "Show Class Distribution in Graph ( Spam and Ham )";
            this.chbClassGraph.UseVisualStyleBackColor = true;
            this.chbClassGraph.CheckedChanged += new System.EventHandler(this.chbClassGraph_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 712);
            this.Controls.Add(this.btnBackToStart);
            this.Controls.Add(this.btnSecondPhase);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preprocessing and Feature Extraction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageAlgorithm.ResumeLayout(false);
            this.tabPageAlgorithm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageFeatureExtr.ResumeLayout(false);
            this.tabPageFeatureExtr.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxMessageList.ResumeLayout(false);
            this.tabPagePreprocessing.ResumeLayout(false);
            this.tabPagePreprocessing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxPreOutput.ResumeLayout(false);
            this.groupBoxPreOutput.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFeatureTitleExt;
        private System.Windows.Forms.RadioButton rbAllFeatures;
        private System.Windows.Forms.RadioButton rbNumericFeatures;
        private System.Windows.Forms.RadioButton rbBinaryFeatures;
        private System.Windows.Forms.TabPage tabPageAlgorithm;
        private System.Windows.Forms.Button btnLGBEvaluateModel;
        private System.Windows.Forms.Button btnXGBEvaluateModel;
        private System.Windows.Forms.Button btnGBMEvaluateModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbModelEvalLogs;
        private System.Windows.Forms.CheckBox chbLGB;
        private System.Windows.Forms.CheckBox chbXGBoost;
        private System.Windows.Forms.CheckBox chbGBM;
        private System.Windows.Forms.Label lblModelTitle;
        private System.Windows.Forms.TabPage tabPageFeatureExtr;
        private System.Windows.Forms.TextBox tbFEMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnFeature26;
        private System.Windows.Forms.Button btnFeature25;
        private System.Windows.Forms.Button btnFeature24;
        private System.Windows.Forms.Button btnFeature23;
        private System.Windows.Forms.Button btnFeature22;
        private System.Windows.Forms.Button btnFeature21;
        private System.Windows.Forms.TextBox tbFeature26;
        private System.Windows.Forms.Label lblFeature26;
        private System.Windows.Forms.TextBox tbFeature25;
        private System.Windows.Forms.Label lblFeature25;
        private System.Windows.Forms.TextBox tbFeature24;
        private System.Windows.Forms.Label lblFeature24;
        private System.Windows.Forms.TextBox tbFeature23;
        private System.Windows.Forms.Label lblFeature23;
        private System.Windows.Forms.TextBox tbFeature22;
        private System.Windows.Forms.Label lblFeature22;
        private System.Windows.Forms.TextBox tbFeature21;
        private System.Windows.Forms.Label lblFeature21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnFeature20;
        private System.Windows.Forms.Button btnFeature19;
        private System.Windows.Forms.Button btnFeature18;
        private System.Windows.Forms.Button btnFeature17;
        private System.Windows.Forms.Button btnFeature16;
        private System.Windows.Forms.Button btnFeature15;
        private System.Windows.Forms.Button btnFeature14;
        private System.Windows.Forms.Button btnFeature13;
        private System.Windows.Forms.Button btnFeature12;
        private System.Windows.Forms.Button btnFeature11;
        private System.Windows.Forms.TextBox tbFeature20;
        private System.Windows.Forms.Label lblFeature20;
        private System.Windows.Forms.TextBox tbFeature19;
        private System.Windows.Forms.Label lblFeature19;
        private System.Windows.Forms.TextBox tbFeature18;
        private System.Windows.Forms.Label lblFeature18;
        private System.Windows.Forms.TextBox tbFeature17;
        private System.Windows.Forms.Label lblFeature17;
        private System.Windows.Forms.TextBox tbFeature16;
        private System.Windows.Forms.Label lblFeature16;
        private System.Windows.Forms.TextBox tbFeature15;
        private System.Windows.Forms.Label lblFeature15;
        private System.Windows.Forms.TextBox tbFeature14;
        private System.Windows.Forms.Label lblFeature14;
        private System.Windows.Forms.TextBox tbFeature13;
        private System.Windows.Forms.Label lblFeature13;
        private System.Windows.Forms.TextBox tbFeature12;
        private System.Windows.Forms.Label lblFeature12;
        private System.Windows.Forms.TextBox tbFeature11;
        private System.Windows.Forms.Label lblFeature11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFeature10;
        private System.Windows.Forms.Button btnFeature9;
        private System.Windows.Forms.Button btnFeature7;
        private System.Windows.Forms.Button btnFeature6;
        private System.Windows.Forms.Button btnFeature5;
        private System.Windows.Forms.Button btnFeature4;
        private System.Windows.Forms.Button btnFeature3;
        private System.Windows.Forms.Button btnFeature2;
        private System.Windows.Forms.Button btnFeature1;
        private System.Windows.Forms.TextBox tbFeature10;
        private System.Windows.Forms.Label lblFeature10;
        private System.Windows.Forms.TextBox tbFeature9;
        private System.Windows.Forms.Label lblFeature9;
        private System.Windows.Forms.TextBox tbFeature8;
        private System.Windows.Forms.Label lblFeature8;
        private System.Windows.Forms.TextBox tbFeature7;
        private System.Windows.Forms.Label lblFeature7;
        private System.Windows.Forms.TextBox tbFeature6;
        private System.Windows.Forms.Label lblFeature6;
        private System.Windows.Forms.TextBox tbFeature5;
        private System.Windows.Forms.Label lblFeature5;
        private System.Windows.Forms.TextBox tbFeature4;
        private System.Windows.Forms.Label lblFeature4;
        private System.Windows.Forms.TextBox tbFeature3;
        private System.Windows.Forms.Label lblFeature3;
        private System.Windows.Forms.TextBox tbFeature2;
        private System.Windows.Forms.Label lblFeature2;
        private System.Windows.Forms.TextBox tbFeature1;
        private System.Windows.Forms.Label lblFeature1;
        private System.Windows.Forms.Button btnFeature8;
        private System.Windows.Forms.Button btnShowDatasetMessages;
        private System.Windows.Forms.GroupBox groupBoxMessageList;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage tabPagePreprocessing;
        private System.Windows.Forms.CheckBox chbShowClassDist;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnSecondPhase;
        private System.Windows.Forms.Label lblSelectedFeatureGroup;
        private System.Windows.Forms.Label lblVarSelectedFG;
        private System.Windows.Forms.Button btnBackToStart;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.Label lblCVNote;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox chbShowUsefulInfo;
        private System.Windows.Forms.CheckBox chbClassGraph;
    }
}

