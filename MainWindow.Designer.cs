namespace WindowsFormsApplication1
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ADD_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Auto_Toot_button = new System.Windows.Forms.Button();
            this.TodoList_GUILIST = new System.Windows.Forms.ListBox();
            this.Add_Text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.HashTagOption = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ADD_button
            // 
            this.ADD_button.Location = new System.Drawing.Point(508, 34);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(108, 36);
            this.ADD_button.TabIndex = 0;
            this.ADD_button.Text = "追加";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(508, 110);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(108, 36);
            this.Delete_button.TabIndex = 1;
            this.Delete_button.Text = "削除";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Location = new System.Drawing.Point(508, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "トゥート";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Toot_button_Click);
            // 
            // Auto_Toot_button
            // 
            this.Auto_Toot_button.Location = new System.Drawing.Point(508, 294);
            this.Auto_Toot_button.Name = "Auto_Toot_button";
            this.Auto_Toot_button.Size = new System.Drawing.Size(119, 36);
            this.Auto_Toot_button.TabIndex = 4;
            this.Auto_Toot_button.Text = "自動トゥート";
            this.Auto_Toot_button.UseVisualStyleBackColor = true;
            this.Auto_Toot_button.Click += new System.EventHandler(this.Auto_Toot_button_Click);
            // 
            // TodoList_GUILIST
            // 
            this.TodoList_GUILIST.BackColor = System.Drawing.SystemColors.Info;
            this.TodoList_GUILIST.FormattingEnabled = true;
            this.TodoList_GUILIST.ItemHeight = 18;
            this.TodoList_GUILIST.Location = new System.Drawing.Point(22, 74);
            this.TodoList_GUILIST.Name = "TodoList_GUILIST";
            this.TodoList_GUILIST.Size = new System.Drawing.Size(466, 256);
            this.TodoList_GUILIST.TabIndex = 5;
            this.TodoList_GUILIST.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Add_Text
            // 
            this.Add_Text.BackColor = System.Drawing.SystemColors.Info;
            this.Add_Text.Location = new System.Drawing.Point(22, 34);
            this.Add_Text.Name = "Add_Text";
            this.Add_Text.Size = new System.Drawing.Size(466, 25);
            this.Add_Text.TabIndex = 6;
            this.Add_Text.TextChanged += new System.EventHandler(this.Add_text_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "セーブ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(22, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 9;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(23, 326);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(0, 18);
            this.link.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "ハッシュタグオプション（名前を入れるとハッシュタグに含まれます）";
            // 
            // HashTagOption
            // 
            this.HashTagOption.BackColor = System.Drawing.SystemColors.Info;
            this.HashTagOption.Location = new System.Drawing.Point(26, 384);
            this.HashTagOption.Name = "HashTagOption";
            this.HashTagOption.Size = new System.Drawing.Size(466, 25);
            this.HashTagOption.TabIndex = 14;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.HashTagOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_Text);
            this.Controls.Add(this.TodoList_GUILIST);
            this.Controls.Add(this.Auto_Toot_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.ADD_button);
            this.Name = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Auto_Toot_button;
        private System.Windows.Forms.ListBox TodoList_GUILIST;
        private System.Windows.Forms.TextBox Add_Text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HashTagOption;
    }
}

