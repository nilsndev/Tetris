namespace Tetris.Form_Folder
{
    partial class Tetris_MainForm
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
            this.main_panel1 = new System.Windows.Forms.Panel();
            this.game_timer1 = new System.Windows.Forms.Timer(this.components);
            this.header_label1 = new System.Windows.Forms.Label();
            this.tetris_animation_timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_label3 = new System.Windows.Forms.Label();
            this.exit_label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_panel1
            // 
            this.main_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_panel1.Location = new System.Drawing.Point(658, 239);
            this.main_panel1.Name = "main_panel1";
            this.main_panel1.Size = new System.Drawing.Size(500, 750);
            this.main_panel1.TabIndex = 0;
            this.main_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel1_Paint);
            // 
            // game_timer1
            // 
            this.game_timer1.Enabled = true;
            this.game_timer1.Interval = 500;
            this.game_timer1.Tick += new System.EventHandler(this.game_timer1_Tick);
            // 
            // header_label1
            // 
            this.header_label1.AutoSize = true;
            this.header_label1.Font = new System.Drawing.Font("Impact", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label1.Location = new System.Drawing.Point(700, 30);
            this.header_label1.Name = "header_label1";
            this.header_label1.Size = new System.Drawing.Size(427, 161);
            this.header_label1.TabIndex = 5;
            this.header_label1.Text = "TETRIS";
            // 
            // tetris_animation_timer1
            // 
            this.tetris_animation_timer1.Interval = 400;
            this.tetris_animation_timer1.Tick += new System.EventHandler(this.tetris_animation_timer1_Tick);
            // 
            // start_label3
            // 
            this.start_label3.BackColor = System.Drawing.Color.Green;
            this.start_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_label3.Location = new System.Drawing.Point(1330, 456);
            this.start_label3.Name = "start_label3";
            this.start_label3.Size = new System.Drawing.Size(300, 150);
            this.start_label3.TabIndex = 11;
            this.start_label3.Text = "START";
            this.start_label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_label3.Click += new System.EventHandler(this.start_label3_Click);
            // 
            // exit_label3
            // 
            this.exit_label3.BackColor = System.Drawing.Color.Green;
            this.exit_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_label3.Location = new System.Drawing.Point(1330, 684);
            this.exit_label3.Name = "exit_label3";
            this.exit_label3.Size = new System.Drawing.Size(300, 150);
            this.exit_label3.TabIndex = 12;
            this.exit_label3.Text = "EXIT";
            this.exit_label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_label3.Click += new System.EventHandler(this.exit_label3_Click);
            // 
            // Tetris_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.exit_label3);
            this.Controls.Add(this.start_label3);
            this.Controls.Add(this.header_label1);
            this.Controls.Add(this.main_panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tetris_MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Tetris_MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tetris_MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tetris_MainForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_panel1;
        private System.Windows.Forms.Timer game_timer1;
        private System.Windows.Forms.Label header_label1;
        private System.Windows.Forms.Timer tetris_animation_timer1;
        private System.Windows.Forms.Label start_label3;
        private System.Windows.Forms.Label exit_label3;
    }
}