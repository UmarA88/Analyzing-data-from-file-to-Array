namespace Assessment9A
{
    partial class StarsBrightnessAnalysisApplicationForm
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
            this.openStarsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblNumberOfMatchesPrompt = new System.Windows.Forms.Label();
            this.lblDimmerPrompt = new System.Windows.Forms.Label();
            this.lblBrighterPrompt = new System.Windows.Forms.Label();
            this.lblNumberOfMatches = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.listBoxDimmerStars = new System.Windows.Forms.ListBox();
            this.listBoxBrighterStars = new System.Windows.Forms.ListBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openStarsFileDialog
            // 
            this.openStarsFileDialog.FileName = "openStarsFileDialog";
            // 
            // lblNumberOfMatchesPrompt
            // 
            this.lblNumberOfMatchesPrompt.AutoSize = true;
            this.lblNumberOfMatchesPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMatchesPrompt.Location = new System.Drawing.Point(346, 381);
            this.lblNumberOfMatchesPrompt.Name = "lblNumberOfMatchesPrompt";
            this.lblNumberOfMatchesPrompt.Size = new System.Drawing.Size(162, 19);
            this.lblNumberOfMatchesPrompt.TabIndex = 0;
            this.lblNumberOfMatchesPrompt.Text = "Number Of Matches";
            // 
            // lblDimmerPrompt
            // 
            this.lblDimmerPrompt.AutoSize = true;
            this.lblDimmerPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimmerPrompt.Location = new System.Drawing.Point(357, 266);
            this.lblDimmerPrompt.Name = "lblDimmerPrompt";
            this.lblDimmerPrompt.Size = new System.Drawing.Size(124, 19);
            this.lblDimmerPrompt.TabIndex = 1;
            this.lblDimmerPrompt.Text = "Dimmer Values";
            // 
            // lblBrighterPrompt
            // 
            this.lblBrighterPrompt.AutoSize = true;
            this.lblBrighterPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrighterPrompt.Location = new System.Drawing.Point(357, 112);
            this.lblBrighterPrompt.Name = "lblBrighterPrompt";
            this.lblBrighterPrompt.Size = new System.Drawing.Size(124, 19);
            this.lblBrighterPrompt.TabIndex = 2;
            this.lblBrighterPrompt.Text = "Brighter Values";
            // 
            // lblNumberOfMatches
            // 
            this.lblNumberOfMatches.BackColor = System.Drawing.Color.White;
            this.lblNumberOfMatches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberOfMatches.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMatches.Location = new System.Drawing.Point(534, 370);
            this.lblNumberOfMatches.Name = "lblNumberOfMatches";
            this.lblNumberOfMatches.Size = new System.Drawing.Size(172, 30);
            this.lblNumberOfMatches.TabIndex = 3;
            this.lblNumberOfMatches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(148, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 49);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(394, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 49);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenFile1
            // 
            this.btnOpenFile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenFile1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile1.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile1.Location = new System.Drawing.Point(30, 250);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(210, 49);
            this.btnOpenFile1.TabIndex = 8;
            this.btnOpenFile1.Text = "Open And Analyse a File";
            this.btnOpenFile1.UseVisualStyleBackColor = false;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // listBoxDimmerStars
            // 
            this.listBoxDimmerStars.BackColor = System.Drawing.Color.White;
            this.listBoxDimmerStars.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDimmerStars.FormattingEnabled = true;
            this.listBoxDimmerStars.ItemHeight = 17;
            this.listBoxDimmerStars.Location = new System.Drawing.Point(534, 236);
            this.listBoxDimmerStars.Name = "listBoxDimmerStars";
            this.listBoxDimmerStars.Size = new System.Drawing.Size(172, 106);
            this.listBoxDimmerStars.TabIndex = 9;
            // 
            // listBoxBrighterStars
            // 
            this.listBoxBrighterStars.BackColor = System.Drawing.Color.White;
            this.listBoxBrighterStars.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBrighterStars.FormattingEnabled = true;
            this.listBoxBrighterStars.ItemHeight = 17;
            this.listBoxBrighterStars.Location = new System.Drawing.Point(534, 93);
            this.listBoxBrighterStars.Name = "listBoxBrighterStars";
            this.listBoxBrighterStars.Size = new System.Drawing.Size(172, 106);
            this.listBoxBrighterStars.TabIndex = 10;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(95, 21);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(521, 24);
            this.lblWelcome.TabIndex = 22;
            this.lblWelcome.Text = "Welcome To The Stars Brightness Analysis Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(597, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "© Ahmed Matoussi";
            // 
            // StarsBrightnessAnalysisApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(728, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.listBoxBrighterStars);
            this.Controls.Add(this.listBoxDimmerStars);
            this.Controls.Add(this.btnOpenFile1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNumberOfMatches);
            this.Controls.Add(this.lblBrighterPrompt);
            this.Controls.Add(this.lblDimmerPrompt);
            this.Controls.Add(this.lblNumberOfMatchesPrompt);
            this.Name = "StarsBrightnessAnalysisApplicationForm";
            this.Text = "Stars Brightness Analysis Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openStarsFileDialog;
        private System.Windows.Forms.Label lblNumberOfMatchesPrompt;
        private System.Windows.Forms.Label lblDimmerPrompt;
        private System.Windows.Forms.Label lblBrighterPrompt;
        private System.Windows.Forms.Label lblNumberOfMatches;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.ListBox listBoxDimmerStars;
        private System.Windows.Forms.ListBox listBoxBrighterStars;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label2;
    }
}

