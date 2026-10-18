namespace SNAKE_GAME
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnStart = new Button();
            btnRestart = new Button();
            btnPause = new Button();
            btnExit = new Button();
            cmbDifficuilty = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(571, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 46);
            label1.TabIndex = 0;
            label1.Text = "Snake Game";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(878, 26);
            label2.Name = "label2";
            label2.Size = new Size(136, 33);
            label2.TabIndex = 1;
            label2.Text = "Score : 0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(419, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 395);
            panel1.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LimeGreen;
            btnStart.Location = new Point(419, 477);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.DeepSkyBlue;
            btnRestart.Location = new Point(419, 517);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(112, 34);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Gold;
            btnPause.Location = new Point(419, 557);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(112, 34);
            btnPause.TabIndex = 5;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Tomato;
            btnExit.Location = new Point(419, 597);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // cmbDifficuilty
            // 
            cmbDifficuilty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDifficuilty.FormattingEnabled = true;
            cmbDifficuilty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cmbDifficuilty.Location = new Point(554, 477);
            cmbDifficuilty.Name = "cmbDifficuilty";
            cmbDifficuilty.Size = new Size(182, 33);
            cmbDifficuilty.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 666);
            Controls.Add(cmbDifficuilty);
            Controls.Add(btnExit);
            Controls.Add(btnPause);
            Controls.Add(btnRestart);
            Controls.Add(btnStart);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnStart;
        private Button btnRestart;
        private Button btnPause;
        private Button btnExit;
        private ComboBox cmbDifficuilty;
    }
}
