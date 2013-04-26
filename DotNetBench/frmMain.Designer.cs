namespace DotNetBench
{
    partial class frmMain
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
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblResultsDesc = new System.Windows.Forms.Label();
            this.btnSqRoot = new System.Windows.Forms.Button();
            this.grpTests = new System.Windows.Forms.GroupBox();
            this.btnRam = new System.Windows.Forms.Button();
            this.btnInfinateBurn = new System.Windows.Forms.Button();
            this.btnStopTests = new System.Windows.Forms.Button();
            this.btnPrimeNumbers = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.btnRC4CBC = new System.Windows.Forms.Button();
            this.btnBigStrings = new System.Windows.Forms.Button();
            this.btnMath = new System.Windows.Forms.Button();
            this.btnBlankFunctions = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnGUI = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtThreadCount = new System.Windows.Forms.TextBox();
            this.lblThreadCountDesc = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTestInfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkShowThreadInfo = new System.Windows.Forms.CheckBox();
            this.grpTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(265, 25);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(240, 197);
            this.txtResults.TabIndex = 0;
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged);
            // 
            // lblResultsDesc
            // 
            this.lblResultsDesc.AutoSize = true;
            this.lblResultsDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsDesc.Location = new System.Drawing.Point(262, 9);
            this.lblResultsDesc.Name = "lblResultsDesc";
            this.lblResultsDesc.Size = new System.Drawing.Size(42, 13);
            this.lblResultsDesc.TabIndex = 1;
            this.lblResultsDesc.Text = "Results";
            // 
            // btnSqRoot
            // 
            this.btnSqRoot.Location = new System.Drawing.Point(6, 19);
            this.btnSqRoot.Name = "btnSqRoot";
            this.btnSqRoot.Size = new System.Drawing.Size(75, 23);
            this.btnSqRoot.TabIndex = 2;
            this.btnSqRoot.Tag = "sqrt";
            this.btnSqRoot.Text = "Sqare Root";
            this.btnSqRoot.UseVisualStyleBackColor = true;
            this.btnSqRoot.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // grpTests
            // 
            this.grpTests.Controls.Add(this.btnRam);
            this.grpTests.Controls.Add(this.btnInfinateBurn);
            this.grpTests.Controls.Add(this.btnStopTests);
            this.grpTests.Controls.Add(this.btnPrimeNumbers);
            this.grpTests.Controls.Add(this.btnAES);
            this.grpTests.Controls.Add(this.btnRC4CBC);
            this.grpTests.Controls.Add(this.btnBigStrings);
            this.grpTests.Controls.Add(this.btnMath);
            this.grpTests.Controls.Add(this.btnBlankFunctions);
            this.grpTests.Controls.Add(this.btnLoop);
            this.grpTests.Controls.Add(this.btnGUI);
            this.grpTests.Controls.Add(this.btnList);
            this.grpTests.Controls.Add(this.btnSqRoot);
            this.grpTests.Location = new System.Drawing.Point(9, 25);
            this.grpTests.Name = "grpTests";
            this.grpTests.Size = new System.Drawing.Size(250, 166);
            this.grpTests.TabIndex = 3;
            this.grpTests.TabStop = false;
            this.grpTests.Text = "Tests";
            // 
            // btnRam
            // 
            this.btnRam.Location = new System.Drawing.Point(87, 106);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(75, 23);
            this.btnRam.TabIndex = 14;
            this.btnRam.Tag = "ram";
            this.btnRam.Text = "RAM";
            this.btnRam.UseVisualStyleBackColor = true;
            this.btnRam.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnInfinateBurn
            // 
            this.btnInfinateBurn.Location = new System.Drawing.Point(168, 106);
            this.btnInfinateBurn.Name = "btnInfinateBurn";
            this.btnInfinateBurn.Size = new System.Drawing.Size(75, 23);
            this.btnInfinateBurn.TabIndex = 13;
            this.btnInfinateBurn.Tag = "burn";
            this.btnInfinateBurn.Text = "Infinate Burn";
            this.btnInfinateBurn.UseVisualStyleBackColor = true;
            this.btnInfinateBurn.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnStopTests
            // 
            this.btnStopTests.Location = new System.Drawing.Point(6, 135);
            this.btnStopTests.Name = "btnStopTests";
            this.btnStopTests.Size = new System.Drawing.Size(237, 23);
            this.btnStopTests.TabIndex = 9;
            this.btnStopTests.Text = "Stop Test";
            this.btnStopTests.UseVisualStyleBackColor = true;
            this.btnStopTests.Click += new System.EventHandler(this.btnStopTests_Click);
            // 
            // btnPrimeNumbers
            // 
            this.btnPrimeNumbers.Location = new System.Drawing.Point(6, 106);
            this.btnPrimeNumbers.Name = "btnPrimeNumbers";
            this.btnPrimeNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeNumbers.TabIndex = 12;
            this.btnPrimeNumbers.Tag = "prime";
            this.btnPrimeNumbers.Text = "Primes";
            this.btnPrimeNumbers.UseVisualStyleBackColor = true;
            this.btnPrimeNumbers.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnAES
            // 
            this.btnAES.Location = new System.Drawing.Point(168, 77);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(75, 23);
            this.btnAES.TabIndex = 11;
            this.btnAES.Tag = "aes";
            this.btnAES.Text = "AES";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRC4CBC
            // 
            this.btnRC4CBC.Location = new System.Drawing.Point(87, 77);
            this.btnRC4CBC.Name = "btnRC4CBC";
            this.btnRC4CBC.Size = new System.Drawing.Size(75, 23);
            this.btnRC4CBC.TabIndex = 10;
            this.btnRC4CBC.Tag = "rc4";
            this.btnRC4CBC.Text = "RC4";
            this.btnRC4CBC.UseVisualStyleBackColor = true;
            this.btnRC4CBC.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnBigStrings
            // 
            this.btnBigStrings.Location = new System.Drawing.Point(6, 77);
            this.btnBigStrings.Name = "btnBigStrings";
            this.btnBigStrings.Size = new System.Drawing.Size(75, 23);
            this.btnBigStrings.TabIndex = 9;
            this.btnBigStrings.Tag = "string";
            this.btnBigStrings.Text = "Big String";
            this.btnBigStrings.UseVisualStyleBackColor = true;
            this.btnBigStrings.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnMath
            // 
            this.btnMath.Location = new System.Drawing.Point(168, 48);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(75, 23);
            this.btnMath.TabIndex = 8;
            this.btnMath.Tag = "math";
            this.btnMath.Text = "Math";
            this.btnMath.UseVisualStyleBackColor = true;
            this.btnMath.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnBlankFunctions
            // 
            this.btnBlankFunctions.Location = new System.Drawing.Point(87, 48);
            this.btnBlankFunctions.Name = "btnBlankFunctions";
            this.btnBlankFunctions.Size = new System.Drawing.Size(75, 23);
            this.btnBlankFunctions.TabIndex = 7;
            this.btnBlankFunctions.Tag = "empty";
            this.btnBlankFunctions.Text = "Empty Calls";
            this.btnBlankFunctions.UseVisualStyleBackColor = true;
            this.btnBlankFunctions.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(6, 48);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 6;
            this.btnLoop.Tag = "loop";
            this.btnLoop.Text = "Empy Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnGUI
            // 
            this.btnGUI.Location = new System.Drawing.Point(168, 19);
            this.btnGUI.Name = "btnGUI";
            this.btnGUI.Size = new System.Drawing.Size(75, 23);
            this.btnGUI.TabIndex = 5;
            this.btnGUI.Tag = "gui";
            this.btnGUI.Text = "GUI";
            this.btnGUI.UseVisualStyleBackColor = true;
            this.btnGUI.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(87, 19);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 3;
            this.btnList.Tag = "list";
            this.btnList.Text = "List<string>";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtThreadCount
            // 
            this.txtThreadCount.Location = new System.Drawing.Point(87, 6);
            this.txtThreadCount.Name = "txtThreadCount";
            this.txtThreadCount.Size = new System.Drawing.Size(33, 20);
            this.txtThreadCount.TabIndex = 4;
            // 
            // lblThreadCountDesc
            // 
            this.lblThreadCountDesc.AutoSize = true;
            this.lblThreadCountDesc.Location = new System.Drawing.Point(6, 9);
            this.lblThreadCountDesc.Name = "lblThreadCountDesc";
            this.lblThreadCountDesc.Size = new System.Drawing.Size(75, 13);
            this.lblThreadCountDesc.TabIndex = 5;
            this.lblThreadCountDesc.Text = "Thread Count:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(430, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTestInfo
            // 
            this.btnTestInfo.Location = new System.Drawing.Point(349, 228);
            this.btnTestInfo.Name = "btnTestInfo";
            this.btnTestInfo.Size = new System.Drawing.Size(75, 23);
            this.btnTestInfo.TabIndex = 7;
            this.btnTestInfo.Text = "Info";
            this.btnTestInfo.UseVisualStyleBackColor = true;
            this.btnTestInfo.Click += new System.EventHandler(this.btnTestInfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(268, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 22);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 233);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(236, 13);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "This program is open source, feel free to share it.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 197);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // chkShowThreadInfo
            // 
            this.chkShowThreadInfo.AutoSize = true;
            this.chkShowThreadInfo.Checked = true;
            this.chkShowThreadInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowThreadInfo.Location = new System.Drawing.Point(352, 8);
            this.chkShowThreadInfo.Name = "chkShowThreadInfo";
            this.chkShowThreadInfo.Size = new System.Drawing.Size(153, 17);
            this.chkShowThreadInfo.TabIndex = 12;
            this.chkShowThreadInfo.Text = "Show individual thread info";
            this.chkShowThreadInfo.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 254);
            this.Controls.Add(this.chkShowThreadInfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTestInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblThreadCountDesc);
            this.Controls.Add(this.txtThreadCount);
            this.Controls.Add(this.grpTests);
            this.Controls.Add(this.lblResultsDesc);
            this.Controls.Add(this.txtResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = ".Net Framework Benchmark Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grpTests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblResultsDesc;
        private System.Windows.Forms.Button btnSqRoot;
        private System.Windows.Forms.GroupBox grpTests;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnGUI;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btnRC4CBC;
        private System.Windows.Forms.Button btnBigStrings;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.Button btnBlankFunctions;
        private System.Windows.Forms.TextBox txtThreadCount;
        private System.Windows.Forms.Label lblThreadCountDesc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTestInfo;
        private System.Windows.Forms.Button btnPrimeNumbers;
        private System.Windows.Forms.Button btnStopTests;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnInfinateBurn;
        private System.Windows.Forms.Button btnRam;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chkShowThreadInfo;
    }
}

