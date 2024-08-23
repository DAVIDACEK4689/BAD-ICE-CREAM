namespace CSHra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uvodni_obrazek = new System.Windows.Forms.PictureBox();
            this.mute_button = new System.Windows.Forms.Button();
            this.unmute_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.victory = new System.Windows.Forms.PictureBox();
            this.continue_victory = new System.Windows.Forms.Button();
            this.prohra = new System.Windows.Forms.PictureBox();
            this.game_over = new System.Windows.Forms.Button();
            this.pozadi = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uvodni_obrazek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prohra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozadi)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.start_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.start_button.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.Location = new System.Drawing.Point(249, 460);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(340, 55);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Tap to play";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uvodni_obrazek
            // 
            this.uvodni_obrazek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uvodni_obrazek.Image = ((System.Drawing.Image)(resources.GetObject("uvodni_obrazek.Image")));
            this.uvodni_obrazek.Location = new System.Drawing.Point(168, 12);
            this.uvodni_obrazek.Name = "uvodni_obrazek";
            this.uvodni_obrazek.Size = new System.Drawing.Size(530, 430);
            this.uvodni_obrazek.TabIndex = 1;
            this.uvodni_obrazek.TabStop = false;
            // 
            // mute_button
            // 
            this.mute_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mute_button.BackgroundImage")));
            this.mute_button.Location = new System.Drawing.Point(813, 12);
            this.mute_button.Name = "mute_button";
            this.mute_button.Size = new System.Drawing.Size(44, 44);
            this.mute_button.TabIndex = 2;
            this.mute_button.UseVisualStyleBackColor = true;
            this.mute_button.Click += new System.EventHandler(this.mute_button_Click);
            // 
            // unmute_button
            // 
            this.unmute_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unmute_button.BackgroundImage")));
            this.unmute_button.Location = new System.Drawing.Point(813, 12);
            this.unmute_button.Name = "unmute_button";
            this.unmute_button.Size = new System.Drawing.Size(44, 44);
            this.unmute_button.TabIndex = 3;
            this.unmute_button.UseVisualStyleBackColor = true;
            this.unmute_button.Click += new System.EventHandler(this.unmute_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(159, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 77);
            this.button1.TabIndex = 0;
            this.button1.Tag = "";
            this.button1.Text = "Locked";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(306, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 77);
            this.button2.TabIndex = 14;
            this.button2.Tag = "";
            this.button2.Text = "Locked";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(454, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 77);
            this.button3.TabIndex = 37;
            this.button3.Tag = "";
            this.button3.Text = "Locked";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(595, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 77);
            this.button4.TabIndex = 56;
            this.button4.Text = "Locked";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(159, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 77);
            this.button5.TabIndex = 70;
            this.button5.Text = "Locked";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(306, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 77);
            this.button6.TabIndex = 103;
            this.button6.Text = "Locked";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(454, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 77);
            this.button7.TabIndex = 117;
            this.button7.Text = "Locked";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(595, 244);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 77);
            this.button8.TabIndex = 134;
            this.button8.Text = "Locked";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.ForeColor = System.Drawing.Color.Red;
            this.button9.Location = new System.Drawing.Point(159, 345);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 77);
            this.button9.TabIndex = 147;
            this.button9.Text = "Locked";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(350, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 61);
            this.label1.TabIndex = 20;
            this.label1.Text = "Levels";
            // 
            // victory
            // 
            this.victory.Image = ((System.Drawing.Image)(resources.GetObject("victory.Image")));
            this.victory.Location = new System.Drawing.Point(138, 91);
            this.victory.Name = "victory";
            this.victory.Size = new System.Drawing.Size(600, 315);
            this.victory.TabIndex = 21;
            this.victory.TabStop = false;
            // 
            // continue_victory
            // 
            this.continue_victory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.continue_victory.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continue_victory.Location = new System.Drawing.Point(256, 278);
            this.continue_victory.Name = "continue_victory";
            this.continue_victory.Size = new System.Drawing.Size(267, 43);
            this.continue_victory.TabIndex = 22;
            this.continue_victory.Text = "Continue";
            this.continue_victory.UseVisualStyleBackColor = false;
            this.continue_victory.Click += new System.EventHandler(this.continue_victory_Click);
            // 
            // prohra
            // 
            this.prohra.Image = ((System.Drawing.Image)(resources.GetObject("prohra.Image")));
            this.prohra.Location = new System.Drawing.Point(186, 36);
            this.prohra.Name = "prohra";
            this.prohra.Size = new System.Drawing.Size(500, 456);
            this.prohra.TabIndex = 23;
            this.prohra.TabStop = false;
            // 
            // game_over
            // 
            this.game_over.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.game_over.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.game_over.Location = new System.Drawing.Point(306, 395);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(274, 74);
            this.game_over.TabIndex = 24;
            this.game_over.Text = "Return to menu";
            this.game_over.UseVisualStyleBackColor = false;
            this.game_over.Click += new System.EventHandler(this.game_over_Click);
            // 
            // pozadi
            // 
            this.pozadi.Location = new System.Drawing.Point(0, 0);
            this.pozadi.Name = "pozadi";
            this.pozadi.Size = new System.Drawing.Size(807, 553);
            this.pozadi.TabIndex = 25;
            this.pozadi.TabStop = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(306, 345);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(115, 77);
            this.button10.TabIndex = 161;
            this.button10.Text = "Locked";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(454, 345);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(115, 77);
            this.button11.TabIndex = 180;
            this.button11.Text = "Locked";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(595, 345);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(115, 77);
            this.button12.TabIndex = 194;
            this.button12.Text = "Locked";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.ForeColor = System.Drawing.Color.Red;
            this.button13.Location = new System.Drawing.Point(159, 434);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(115, 77);
            this.button13.TabIndex = 208;
            this.button13.Text = "Locked";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.ForeColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(306, 434);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(115, 77);
            this.button14.TabIndex = 222;
            this.button14.Text = "Locked";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.ForeColor = System.Drawing.Color.Red;
            this.button15.Location = new System.Drawing.Point(454, 434);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(115, 77);
            this.button15.TabIndex = 245;
            this.button15.Text = "Locked";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.ForeColor = System.Drawing.Color.Red;
            this.button16.Location = new System.Drawing.Point(595, 434);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(115, 77);
            this.button16.TabIndex = 259;
            this.button16.Text = "Locked";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(860, 554);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.continue_victory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unmute_button);
            this.Controls.Add(this.mute_button);
            this.Controls.Add(this.uvodni_obrazek);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.victory);
            this.Controls.Add(this.pozadi);
            this.Controls.Add(this.prohra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bad Icecream";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.uvodni_obrazek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prohra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozadi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox uvodni_obrazek;
        private System.Windows.Forms.Button mute_button;
        private System.Windows.Forms.Button unmute_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox victory;
        private System.Windows.Forms.Button continue_victory;
        private System.Windows.Forms.PictureBox prohra;
        private System.Windows.Forms.Button game_over;
        private System.Windows.Forms.PictureBox pozadi;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

