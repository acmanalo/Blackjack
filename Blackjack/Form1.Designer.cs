namespace Blackjack
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DealerHandTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PlayerHandTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BankrollTextBox = new System.Windows.Forms.TextBox();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentBetTextBox = new System.Windows.Forms.TextBox();
            this.AddBetGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveBetGroupBox = new System.Windows.Forms.GroupBox();
            this.DealButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenuItem,
            this.ExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewGameMenuItem
            // 
            this.NewGameMenuItem.Name = "NewGameMenuItem";
            this.NewGameMenuItem.Size = new System.Drawing.Size(132, 22);
            this.NewGameMenuItem.Text = "New Game";
            this.NewGameMenuItem.Click += new System.EventHandler(this.NewGameMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DealerHandTextBox);
            this.groupBox1.Location = new System.Drawing.Point(39, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dealer";
            // 
            // DealerHandTextBox
            // 
            this.DealerHandTextBox.Location = new System.Drawing.Point(6, 19);
            this.DealerHandTextBox.Multiline = true;
            this.DealerHandTextBox.Name = "DealerHandTextBox";
            this.DealerHandTextBox.ReadOnly = true;
            this.DealerHandTextBox.Size = new System.Drawing.Size(188, 75);
            this.DealerHandTextBox.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PlayerHandTextBox);
            this.groupBox2.Location = new System.Drawing.Point(39, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player";
            // 
            // PlayerHandTextBox
            // 
            this.PlayerHandTextBox.Location = new System.Drawing.Point(6, 19);
            this.PlayerHandTextBox.Multiline = true;
            this.PlayerHandTextBox.Name = "PlayerHandTextBox";
            this.PlayerHandTextBox.ReadOnly = true;
            this.PlayerHandTextBox.Size = new System.Drawing.Size(188, 75);
            this.PlayerHandTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bankroll:";
            // 
            // BankrollTextBox
            // 
            this.BankrollTextBox.Location = new System.Drawing.Point(123, 425);
            this.BankrollTextBox.Name = "BankrollTextBox";
            this.BankrollTextBox.ReadOnly = true;
            this.BankrollTextBox.Size = new System.Drawing.Size(66, 20);
            this.BankrollTextBox.TabIndex = 2;
            this.BankrollTextBox.Text = "$500";
            this.BankrollTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HitButton
            // 
            this.HitButton.Location = new System.Drawing.Point(39, 246);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(75, 23);
            this.HitButton.TabIndex = 3;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // StandButton
            // 
            this.StandButton.Location = new System.Drawing.Point(164, 246);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(75, 23);
            this.StandButton.TabIndex = 4;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Bet:";
            // 
            // CurrentBetTextBox
            // 
            this.CurrentBetTextBox.Location = new System.Drawing.Point(123, 399);
            this.CurrentBetTextBox.Name = "CurrentBetTextBox";
            this.CurrentBetTextBox.ReadOnly = true;
            this.CurrentBetTextBox.Size = new System.Drawing.Size(66, 20);
            this.CurrentBetTextBox.TabIndex = 8;
            this.CurrentBetTextBox.Text = "$0";
            this.CurrentBetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddBetGroupBox
            // 
            this.AddBetGroupBox.Location = new System.Drawing.Point(12, 282);
            this.AddBetGroupBox.Name = "AddBetGroupBox";
            this.AddBetGroupBox.Size = new System.Drawing.Size(268, 52);
            this.AddBetGroupBox.TabIndex = 9;
            this.AddBetGroupBox.TabStop = false;
            this.AddBetGroupBox.Text = "Add Bet";
            // 
            // RemoveBetGroupBox
            // 
            this.RemoveBetGroupBox.Enabled = false;
            this.RemoveBetGroupBox.Location = new System.Drawing.Point(12, 341);
            this.RemoveBetGroupBox.Name = "RemoveBetGroupBox";
            this.RemoveBetGroupBox.Size = new System.Drawing.Size(268, 52);
            this.RemoveBetGroupBox.TabIndex = 10;
            this.RemoveBetGroupBox.TabStop = false;
            this.RemoveBetGroupBox.Text = "Remove Bet";
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(195, 399);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(75, 23);
            this.DealButton.TabIndex = 12;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 459);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.RemoveBetGroupBox);
            this.Controls.Add(this.AddBetGroupBox);
            this.Controls.Add(this.CurrentBetTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.BankrollTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BankrollTextBox;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CurrentBetTextBox;
        private System.Windows.Forms.GroupBox AddBetGroupBox;
        private System.Windows.Forms.GroupBox RemoveBetGroupBox;
        private System.Windows.Forms.TextBox DealerHandTextBox;
        private System.Windows.Forms.TextBox PlayerHandTextBox;
        private System.Windows.Forms.Button DealButton;
    }
}

