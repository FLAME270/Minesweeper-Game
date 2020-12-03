namespace MinesweeperFinal
{
    partial class Menu
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
        private void InitializeComponent()
        {
            this.playGame_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.difficult_btn = new System.Windows.Forms.RadioButton();
            this.moderate_btn = new System.Windows.Forms.RadioButton();
            this.easy_btn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playGame_btn
            // 
            this.playGame_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playGame_btn.BackColor = System.Drawing.Color.Lime;
            this.playGame_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.playGame_btn.Location = new System.Drawing.Point(119, 264);
            this.playGame_btn.Margin = new System.Windows.Forms.Padding(4);
            this.playGame_btn.Name = "playGame_btn";
            this.playGame_btn.Size = new System.Drawing.Size(157, 44);
            this.playGame_btn.TabIndex = 0;
            this.playGame_btn.Text = "Play Game";
            this.playGame_btn.UseVisualStyleBackColor = false;
            this.playGame_btn.Click += new System.EventHandler(this.playGame_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.difficult_btn);
            this.groupBox1.Controls.Add(this.moderate_btn);
            this.groupBox1.Controls.Add(this.easy_btn);
            this.groupBox1.Location = new System.Drawing.Point(60, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // difficult_btn
            // 
            this.difficult_btn.AutoSize = true;
            this.difficult_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.difficult_btn.Location = new System.Drawing.Point(59, 165);
            this.difficult_btn.Margin = new System.Windows.Forms.Padding(4);
            this.difficult_btn.Name = "difficult_btn";
            this.difficult_btn.Size = new System.Drawing.Size(118, 33);
            this.difficult_btn.TabIndex = 2;
            this.difficult_btn.TabStop = true;
            this.difficult_btn.Text = "Difficult";
            this.difficult_btn.UseVisualStyleBackColor = true;
            // 
            // moderate_btn
            // 
            this.moderate_btn.AutoSize = true;
            this.moderate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.moderate_btn.Location = new System.Drawing.Point(59, 98);
            this.moderate_btn.Margin = new System.Windows.Forms.Padding(4);
            this.moderate_btn.Name = "moderate_btn";
            this.moderate_btn.Size = new System.Drawing.Size(140, 33);
            this.moderate_btn.TabIndex = 1;
            this.moderate_btn.TabStop = true;
            this.moderate_btn.Text = "Moderate";
            this.moderate_btn.UseVisualStyleBackColor = true;
            // 
            // easy_btn
            // 
            this.easy_btn.AutoSize = true;
            this.easy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.easy_btn.Location = new System.Drawing.Point(59, 30);
            this.easy_btn.Margin = new System.Windows.Forms.Padding(4);
            this.easy_btn.Name = "easy_btn";
            this.easy_btn.Size = new System.Drawing.Size(91, 33);
            this.easy_btn.TabIndex = 0;
            this.easy_btn.TabStop = true;
            this.easy_btn.Text = "Easy";
            this.easy_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(63, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Level Difficulty";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playGame_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "MINESWEEPER";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }



        private System.Windows.Forms.Button playGame_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton difficult_btn;
        private System.Windows.Forms.RadioButton moderate_btn;
        private System.Windows.Forms.RadioButton easy_btn;
        private System.Windows.Forms.Label label1;
    }
}


