namespace Demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDetect = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbxMaximumSize = new System.Windows.Forms.ComboBox();
            this.lblMaximumSize = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxMinimumSize = new System.Windows.Forms.ComboBox();
            this.lblMinimumSize = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDetectionType = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxMinNeighbors = new System.Windows.Forms.ComboBox();
            this.lblMinNeighbors = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxScaleFactor = new System.Windows.Forms.ComboBox();
            this.lblScaleFactor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxHaarCascade = new System.Windows.Forms.ComboBox();
            this.lblHaarCascade = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgResult = new Emgu.CV.UI.ImageBox();
            this.ckbDetectionType = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(704, 17);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(50, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(6, 19);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(692, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png|All Images|*.jpg;*.jpeg;*.png";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 482);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnDetect);
            this.panel8.Location = new System.Drawing.Point(6, 426);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(188, 50);
            this.panel8.TabIndex = 8;
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(44, 10);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(100, 30);
            this.btnDetect.TabIndex = 0;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbxMaximumSize);
            this.panel7.Controls.Add(this.lblMaximumSize);
            this.panel7.Location = new System.Drawing.Point(6, 299);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(188, 50);
            this.panel7.TabIndex = 7;
            // 
            // cbxMaximumSize
            // 
            this.cbxMaximumSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaximumSize.FormattingEnabled = true;
            this.cbxMaximumSize.Location = new System.Drawing.Point(3, 23);
            this.cbxMaximumSize.Name = "cbxMaximumSize";
            this.cbxMaximumSize.Size = new System.Drawing.Size(182, 21);
            this.cbxMaximumSize.TabIndex = 3;
            // 
            // lblMaximumSize
            // 
            this.lblMaximumSize.AutoSize = true;
            this.lblMaximumSize.Location = new System.Drawing.Point(3, 7);
            this.lblMaximumSize.Name = "lblMaximumSize";
            this.lblMaximumSize.Size = new System.Drawing.Size(74, 13);
            this.lblMaximumSize.TabIndex = 2;
            this.lblMaximumSize.Text = "Maximum Size";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbxMinimumSize);
            this.panel6.Controls.Add(this.lblMinimumSize);
            this.panel6.Location = new System.Drawing.Point(6, 243);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(188, 50);
            this.panel6.TabIndex = 6;
            // 
            // cbxMinimumSize
            // 
            this.cbxMinimumSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinimumSize.FormattingEnabled = true;
            this.cbxMinimumSize.Location = new System.Drawing.Point(3, 23);
            this.cbxMinimumSize.Name = "cbxMinimumSize";
            this.cbxMinimumSize.Size = new System.Drawing.Size(182, 21);
            this.cbxMinimumSize.TabIndex = 3;
            // 
            // lblMinimumSize
            // 
            this.lblMinimumSize.AutoSize = true;
            this.lblMinimumSize.Location = new System.Drawing.Point(3, 7);
            this.lblMinimumSize.Name = "lblMinimumSize";
            this.lblMinimumSize.Size = new System.Drawing.Size(71, 13);
            this.lblMinimumSize.TabIndex = 2;
            this.lblMinimumSize.Text = "Minimum Size";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ckbDetectionType);
            this.panel5.Controls.Add(this.lblDetectionType);
            this.panel5.Location = new System.Drawing.Point(6, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 50);
            this.panel5.TabIndex = 5;
            // 
            // lblDetectionType
            // 
            this.lblDetectionType.AutoSize = true;
            this.lblDetectionType.Location = new System.Drawing.Point(3, 9);
            this.lblDetectionType.Name = "lblDetectionType";
            this.lblDetectionType.Size = new System.Drawing.Size(80, 13);
            this.lblDetectionType.TabIndex = 2;
            this.lblDetectionType.Text = "Detection Type";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxMinNeighbors);
            this.panel4.Controls.Add(this.lblMinNeighbors);
            this.panel4.Location = new System.Drawing.Point(6, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 50);
            this.panel4.TabIndex = 4;
            // 
            // cbxMinNeighbors
            // 
            this.cbxMinNeighbors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinNeighbors.FormattingEnabled = true;
            this.cbxMinNeighbors.Location = new System.Drawing.Point(3, 23);
            this.cbxMinNeighbors.Name = "cbxMinNeighbors";
            this.cbxMinNeighbors.Size = new System.Drawing.Size(182, 21);
            this.cbxMinNeighbors.TabIndex = 3;
            // 
            // lblMinNeighbors
            // 
            this.lblMinNeighbors.AutoSize = true;
            this.lblMinNeighbors.Location = new System.Drawing.Point(3, 7);
            this.lblMinNeighbors.Name = "lblMinNeighbors";
            this.lblMinNeighbors.Size = new System.Drawing.Size(99, 13);
            this.lblMinNeighbors.TabIndex = 2;
            this.lblMinNeighbors.Text = "Minimum Neighbors";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxScaleFactor);
            this.panel3.Controls.Add(this.lblScaleFactor);
            this.panel3.Location = new System.Drawing.Point(6, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 50);
            this.panel3.TabIndex = 3;
            // 
            // cbxScaleFactor
            // 
            this.cbxScaleFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxScaleFactor.FormattingEnabled = true;
            this.cbxScaleFactor.Location = new System.Drawing.Point(3, 23);
            this.cbxScaleFactor.Name = "cbxScaleFactor";
            this.cbxScaleFactor.Size = new System.Drawing.Size(182, 21);
            this.cbxScaleFactor.TabIndex = 3;
            // 
            // lblScaleFactor
            // 
            this.lblScaleFactor.AutoSize = true;
            this.lblScaleFactor.Location = new System.Drawing.Point(3, 7);
            this.lblScaleFactor.Name = "lblScaleFactor";
            this.lblScaleFactor.Size = new System.Drawing.Size(67, 13);
            this.lblScaleFactor.TabIndex = 2;
            this.lblScaleFactor.Text = "Scale Factor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxHaarCascade);
            this.panel2.Controls.Add(this.lblHaarCascade);
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 50);
            this.panel2.TabIndex = 2;
            // 
            // cbxHaarCascade
            // 
            this.cbxHaarCascade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHaarCascade.FormattingEnabled = true;
            this.cbxHaarCascade.Location = new System.Drawing.Point(3, 23);
            this.cbxHaarCascade.Name = "cbxHaarCascade";
            this.cbxHaarCascade.Size = new System.Drawing.Size(182, 21);
            this.cbxHaarCascade.TabIndex = 1;
            // 
            // lblHaarCascade
            // 
            this.lblHaarCascade.AutoSize = true;
            this.lblHaarCascade.Location = new System.Drawing.Point(3, 7);
            this.lblHaarCascade.Name = "lblHaarCascade";
            this.lblHaarCascade.Size = new System.Drawing.Size(75, 13);
            this.lblHaarCascade.TabIndex = 0;
            this.lblHaarCascade.Text = "Haar Cascade";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(218, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 482);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imgResult);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 457);
            this.panel1.TabIndex = 0;
            // 
            // imgResult
            // 
            this.imgResult.Location = new System.Drawing.Point(0, 0);
            this.imgResult.Name = "imgResult";
            this.imgResult.Size = new System.Drawing.Size(23, 23);
            this.imgResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgResult.TabIndex = 2;
            this.imgResult.TabStop = false;
            // 
            // ckbDetectionType
            // 
            this.ckbDetectionType.AutoSize = true;
            this.ckbDetectionType.Checked = true;
            this.ckbDetectionType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDetectionType.Location = new System.Drawing.Point(6, 25);
            this.ckbDetectionType.Name = "ckbDetectionType";
            this.ckbDetectionType.Size = new System.Drawing.Size(95, 17);
            this.ckbDetectionType.TabIndex = 3;
            this.ckbDetectionType.Text = "Canny Pruning";
            this.ckbDetectionType.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haar Cascade Detection Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private Emgu.CV.UI.ImageBox imgResult;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxHaarCascade;
        private System.Windows.Forms.Label lblHaarCascade;
        private System.Windows.Forms.ComboBox cbxScaleFactor;
        private System.Windows.Forms.Label lblScaleFactor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxMinNeighbors;
        private System.Windows.Forms.Label lblMinNeighbors;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDetectionType;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbxMaximumSize;
        private System.Windows.Forms.Label lblMaximumSize;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbxMinimumSize;
        private System.Windows.Forms.Label lblMinimumSize;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.CheckBox ckbDetectionType;
    }
}

