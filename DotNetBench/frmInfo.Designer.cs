namespace DotNetBench
{
    partial class frmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
            this.txtTestInfo = new System.Windows.Forms.TextBox();
            this.lblTestInfoDesc = new System.Windows.Forms.Label();
            this.lblAppDesc = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTestInfo
            // 
            this.txtTestInfo.Location = new System.Drawing.Point(15, 69);
            this.txtTestInfo.Multiline = true;
            this.txtTestInfo.Name = "txtTestInfo";
            this.txtTestInfo.ReadOnly = true;
            this.txtTestInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTestInfo.Size = new System.Drawing.Size(371, 140);
            this.txtTestInfo.TabIndex = 0;
            this.txtTestInfo.Text = resources.GetString("txtTestInfo.Text");
            // 
            // lblTestInfoDesc
            // 
            this.lblTestInfoDesc.AutoSize = true;
            this.lblTestInfoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestInfoDesc.Location = new System.Drawing.Point(12, 53);
            this.lblTestInfoDesc.Name = "lblTestInfoDesc";
            this.lblTestInfoDesc.Size = new System.Drawing.Size(49, 13);
            this.lblTestInfoDesc.TabIndex = 1;
            this.lblTestInfoDesc.Text = "Test Info";
            // 
            // lblAppDesc
            // 
            this.lblAppDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDesc.Location = new System.Drawing.Point(12, 9);
            this.lblAppDesc.Name = "lblAppDesc";
            this.lblAppDesc.Size = new System.Drawing.Size(374, 44);
            this.lblAppDesc.TabIndex = 2;
            this.lblAppDesc.Text = "Benchmark tool for the Microsoft .Net Framework, designed to test commonly used f" +
                "eatures and classes included in the .NET framework. Created by FireXware for the" +
                " opensource community.\r\n";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(311, 215);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 244);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAppDesc);
            this.Controls.Add(this.lblTestInfoDesc);
            this.Controls.Add(this.txtTestInfo);
            this.Name = "frmInfo";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTestInfo;
        private System.Windows.Forms.Label lblTestInfoDesc;
        private System.Windows.Forms.Label lblAppDesc;
        private System.Windows.Forms.Button btnOK;
    }
}