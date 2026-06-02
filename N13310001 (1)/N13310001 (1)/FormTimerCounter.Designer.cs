namespace N13310001__1_
{
    partial class FormTimerCounter
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
            this.lb1Time = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb1Time
            // 
            this.lb1Time.AutoSize = true;
            this.lb1Time.Font = new System.Drawing.Font("新細明體", 36F);
            this.lb1Time.Location = new System.Drawing.Point(29, 28);
            this.lb1Time.Name = "lb1Time";
            this.lb1Time.Size = new System.Drawing.Size(91, 48);
            this.lb1Time.TabIndex = 0;
            this.lb1Time.Text = "0秒";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnStart.Location = new System.Drawing.Point(24, 90);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnPause.Location = new System.Drawing.Point(24, 136);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(96, 42);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 15F);
            this.btnReset.Location = new System.Drawing.Point(24, 185);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 43);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "歸零";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormTimerCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 548);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lb1Time);
            this.Name = "FormTimerCounter";
            this.Text = "FormTimerCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1Time;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
    }
}