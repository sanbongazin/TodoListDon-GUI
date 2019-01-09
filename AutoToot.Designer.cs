namespace WindowsFormsApplication1
{
    partial class AutoToot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoTootButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.IntervalTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "何分おきにトゥートをしたいか、選択してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "分おきにトゥートします";
            // 
            // AutoTootButton
            // 
            this.AutoTootButton.AutoSize = true;
            this.AutoTootButton.Location = new System.Drawing.Point(388, 68);
            this.AutoTootButton.Name = "AutoTootButton";
            this.AutoTootButton.Size = new System.Drawing.Size(75, 28);
            this.AutoTootButton.TabIndex = 3;
            this.AutoTootButton.Text = "トゥート";
            this.AutoTootButton.UseVisualStyleBackColor = true;
            this.AutoTootButton.Click += new System.EventHandler(this.AutoTootButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.AutoSize = true;
            this.StopButton.Location = new System.Drawing.Point(388, 125);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 28);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "停止";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // IntervalTime
            // 
            this.IntervalTime.FormattingEnabled = true;
            this.IntervalTime.Location = new System.Drawing.Point(53, 91);
            this.IntervalTime.Name = "IntervalTime";
            this.IntervalTime.Size = new System.Drawing.Size(121, 26);
            this.IntervalTime.TabIndex = 5;
            // 
            // AutoToot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 182);
            this.Controls.Add(this.IntervalTime);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.AutoTootButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AutoToot";
            this.Text = "AutoToot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AutoTootButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ComboBox IntervalTime;
    }
}