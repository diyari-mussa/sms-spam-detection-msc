namespace SMSSpamFilterProject
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.groupBoxEss = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFeatureSelPyFile = new System.Windows.Forms.Button();
            this.btnPreporcessPyFile = new System.Windows.Forms.Button();
            this.btnPythonFile = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblProjDesc = new System.Windows.Forms.Label();
            this.lblTitle1st = new System.Windows.Forms.Label();
            this.lblTitle2nd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxEss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEss
            // 
            this.groupBoxEss.Controls.Add(this.button1);
            this.groupBoxEss.Controls.Add(this.btnFeatureSelPyFile);
            this.groupBoxEss.Controls.Add(this.btnPreporcessPyFile);
            this.groupBoxEss.Controls.Add(this.btnPythonFile);
            this.groupBoxEss.Location = new System.Drawing.Point(570, 40);
            this.groupBoxEss.Name = "groupBoxEss";
            this.groupBoxEss.Size = new System.Drawing.Size(229, 271);
            this.groupBoxEss.TabIndex = 0;
            this.groupBoxEss.TabStop = false;
            this.groupBoxEss.Text = "Requirements";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "TestNewDataset.py auto detection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFeatureSelPyFile
            // 
            this.btnFeatureSelPyFile.Location = new System.Drawing.Point(6, 151);
            this.btnFeatureSelPyFile.Name = "btnFeatureSelPyFile";
            this.btnFeatureSelPyFile.Size = new System.Drawing.Size(217, 52);
            this.btnFeatureSelPyFile.TabIndex = 6;
            this.btnFeatureSelPyFile.Text = "FeatureSelection.py auto detection";
            this.btnFeatureSelPyFile.UseVisualStyleBackColor = true;
            this.btnFeatureSelPyFile.Click += new System.EventHandler(this.btnFeatureSelPyFile_Click);
            // 
            // btnPreporcessPyFile
            // 
            this.btnPreporcessPyFile.Location = new System.Drawing.Point(6, 93);
            this.btnPreporcessPyFile.Name = "btnPreporcessPyFile";
            this.btnPreporcessPyFile.Size = new System.Drawing.Size(217, 52);
            this.btnPreporcessPyFile.TabIndex = 5;
            this.btnPreporcessPyFile.Text = "Preprocessing.py auto detection";
            this.btnPreporcessPyFile.UseVisualStyleBackColor = true;
            this.btnPreporcessPyFile.Click += new System.EventHandler(this.btnPreporcessPyFile_Click);
            // 
            // btnPythonFile
            // 
            this.btnPythonFile.Location = new System.Drawing.Point(6, 35);
            this.btnPythonFile.Name = "btnPythonFile";
            this.btnPythonFile.Size = new System.Drawing.Size(217, 52);
            this.btnPythonFile.TabIndex = 2;
            this.btnPythonFile.Text = "Python file auto detection";
            this.btnPythonFile.UseVisualStyleBackColor = true;
            this.btnPythonFile.Click += new System.EventHandler(this.btnPythonFile_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(570, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(229, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblProjDesc
            // 
            this.lblProjDesc.AutoSize = true;
            this.lblProjDesc.Location = new System.Drawing.Point(90, 209);
            this.lblProjDesc.Name = "lblProjDesc";
            this.lblProjDesc.Size = new System.Drawing.Size(16, 17);
            this.lblProjDesc.TabIndex = 2;
            this.lblProjDesc.Text = "[]";
            this.lblProjDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle1st
            // 
            this.lblTitle1st.AutoSize = true;
            this.lblTitle1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1st.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(95)))), ((int)(((byte)(124)))));
            this.lblTitle1st.Location = new System.Drawing.Point(131, 53);
            this.lblTitle1st.Name = "lblTitle1st";
            this.lblTitle1st.Size = new System.Drawing.Size(315, 36);
            this.lblTitle1st.TabIndex = 3;
            this.lblTitle1st.Text = "SMS Spam Detection";
            // 
            // lblTitle2nd
            // 
            this.lblTitle2nd.AutoSize = true;
            this.lblTitle2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2nd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle2nd.Location = new System.Drawing.Point(132, 89);
            this.lblTitle2nd.Name = "lblTitle2nd";
            this.lblTitle2nd.Size = new System.Drawing.Size(294, 29);
            this.lblTitle2nd.TabIndex = 4;
            this.lblTitle2nd.Text = "Using Machine Learning";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMSSpamFilterProject.Properties.Resources.imageedit_3_2667537428;
            this.pictureBox1.Location = new System.Drawing.Point(54, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle2nd);
            this.Controls.Add(this.lblTitle1st);
            this.Controls.Add(this.lblProjDesc);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBoxEss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS spam detection Proj.";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.groupBoxEss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEss;
        private System.Windows.Forms.Button btnPythonFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblProjDesc;
        private System.Windows.Forms.Label lblTitle1st;
        private System.Windows.Forms.Label lblTitle2nd;
        private System.Windows.Forms.Button btnFeatureSelPyFile;
        private System.Windows.Forms.Button btnPreporcessPyFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}