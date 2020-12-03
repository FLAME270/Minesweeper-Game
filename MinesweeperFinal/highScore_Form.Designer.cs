namespace MinesweeperFinal
{
    partial class highScore_Form
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
 

        #endregion
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highscore_btn = new System.Windows.Forms.Button();
            this.initials_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yourScore_label = new System.Windows.Forms.Label();
            this.highscore_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top 5 HighScores";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(125, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 2);
            this.label2.TabIndex = 1;
            // 
            // highscore_btn
            // 
            this.highscore_btn.BackColor = System.Drawing.Color.Lime;
            this.highscore_btn.Location = new System.Drawing.Point(263, 278);
            this.highscore_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highscore_btn.Name = "highscore_btn";
            this.highscore_btn.Size = new System.Drawing.Size(100, 37);
            this.highscore_btn.TabIndex = 3;
            this.highscore_btn.Text = "submit";
            this.highscore_btn.UseVisualStyleBackColor = false;
            this.highscore_btn.Click += new System.EventHandler(this.highscore_btn_Click);
            // 
            // initials_textbox
            // 
            this.initials_textbox.Location = new System.Drawing.Point(16, 278);
            this.initials_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.initials_textbox.Name = "initials_textbox";
            this.initials_textbox.Size = new System.Drawing.Size(117, 22);
            this.initials_textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(16, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 2);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Your Initials";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Your Score:";
            // 
            // yourScore_label
            // 
            this.yourScore_label.Location = new System.Drawing.Point(259, 242);
            this.yourScore_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yourScore_label.Name = "yourScore_label";
            this.yourScore_label.Size = new System.Drawing.Size(107, 16);
            this.yourScore_label.TabIndex = 8;
            this.yourScore_label.Text = "Your Score:";
            // 
            // highscore_label
            // 
            this.highscore_label.Location = new System.Drawing.Point(100, 42);
            this.highscore_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highscore_label.Name = "highscore_label";
            this.highscore_label.Size = new System.Drawing.Size(200, 190);
            this.highscore_label.TabIndex = 9;
            this.highscore_label.Text = "label6";
            this.highscore_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highScore_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.highscore_label);
            this.Controls.Add(this.yourScore_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initials_textbox);
            this.Controls.Add(this.highscore_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "highScore_Form";
            this.Text = "highScore_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button highscore_btn;
        private System.Windows.Forms.TextBox initials_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label yourScore_label;
        private System.Windows.Forms.Label highscore_label;
    }
}
