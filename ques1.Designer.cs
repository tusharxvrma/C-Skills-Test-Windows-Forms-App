namespace mcqForms
{
    partial class ques1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.radBtnA4 = new System.Windows.Forms.RadioButton();
            this.radBtnA3 = new System.Windows.Forms.RadioButton();
            this.radBtnA2 = new System.Windows.Forms.RadioButton();
            this.radBtnA1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(269, 397);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(411, 397);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(11, 397);
            this.prgBar.Margin = new System.Windows.Forms.Padding(4);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(189, 28);
            this.prgBar.TabIndex = 30;
            this.prgBar.Click += new System.EventHandler(this.prgBar_Click);
            // 
            // radBtnA4
            // 
            this.radBtnA4.AutoSize = true;
            this.radBtnA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnA4.Location = new System.Drawing.Point(58, 275);
            this.radBtnA4.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnA4.Name = "radBtnA4";
            this.radBtnA4.Size = new System.Drawing.Size(149, 24);
            this.radBtnA4.TabIndex = 29;
            this.radBtnA4.TabStop = true;
            this.radBtnA4.Text = "D. asterisk (*)";
            this.radBtnA4.UseVisualStyleBackColor = true;
            // 
            // radBtnA3
            // 
            this.radBtnA3.AutoSize = true;
            this.radBtnA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnA3.Location = new System.Drawing.Point(58, 220);
            this.radBtnA3.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnA3.Name = "radBtnA3";
            this.radBtnA3.Size = new System.Drawing.Size(180, 24);
            this.radBtnA3.TabIndex = 28;
            this.radBtnA3.TabStop = true;
            this.radBtnA3.Text = "C. and operator (&)";
            this.radBtnA3.UseVisualStyleBackColor = true;
            // 
            // radBtnA2
            // 
            this.radBtnA2.AutoSize = true;
            this.radBtnA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnA2.Location = new System.Drawing.Point(58, 168);
            this.radBtnA2.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnA2.Name = "radBtnA2";
            this.radBtnA2.Size = new System.Drawing.Size(105, 24);
            this.radBtnA2.TabIndex = 27;
            this.radBtnA2.TabStop = true;
            this.radBtnA2.Text = "B. typeof";
            this.radBtnA2.UseVisualStyleBackColor = true;
            // 
            // radBtnA1
            // 
            this.radBtnA1.AutoSize = true;
            this.radBtnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnA1.Location = new System.Drawing.Point(58, 116);
            this.radBtnA1.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnA1.Name = "radBtnA1";
            this.radBtnA1.Size = new System.Drawing.Size(104, 24);
            this.radBtnA1.TabIndex = 26;
            this.radBtnA1.TabStop = true;
            this.radBtnA1.Text = "A. sizeof";
            this.radBtnA1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Q1. What operartor returns the address of a variable in c#?";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(12, 456);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(109, 17);
            this.timerLabel.TabIndex = 46;
            this.timerLabel.Text = "Time remaining:";
            // 
            // ques1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 493);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.radBtnA4);
            this.Controls.Add(this.radBtnA3);
            this.Controls.Add(this.radBtnA2);
            this.Controls.Add(this.radBtnA1);
            this.Controls.Add(this.label1);
            this.Name = "ques1";
            this.Text = "ques1";
            this.Load += new System.EventHandler(this.ques1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.RadioButton radBtnA4;
        private System.Windows.Forms.RadioButton radBtnA3;
        private System.Windows.Forms.RadioButton radBtnA2;
        private System.Windows.Forms.RadioButton radBtnA1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
    }
}