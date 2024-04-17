namespace GameOfHearts
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem2 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ButtonSubmit = new Button();
            label2 = new Label();
            p1Input = new TextBox();
            label6 = new Label();
            TextBoxScore = new TextBox();
            toolTip1 = new ToolTip(components);
            ButtonAddPlayer = new Button();
            ButtonDeletePlayer = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(271, 35);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(236, 39);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Hearts";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(780, 29);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { rulesToolStripMenuItem, aboutToolStripMenuItem2 });
            aboutToolStripMenuItem1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            aboutToolStripMenuItem1.ForeColor = Color.White;
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(61, 23);
            aboutToolStripMenuItem1.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new Size(224, 26);
            rulesToolStripMenuItem.Text = "Rules";
            rulesToolStripMenuItem.Click += rulesToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem2
            // 
            aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            aboutToolStripMenuItem2.Size = new Size(224, 26);
            aboutToolStripMenuItem2.Text = "About";
            aboutToolStripMenuItem2.Click += aboutToolStripMenuItem2_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(50, 23);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSubmit.Location = new Point(594, 391);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(94, 29);
            ButtonSubmit.TabIndex = 3;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += submitBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(47, 146);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 4;
            label2.Text = "Your Name:";
            // 
            // p1Input
            // 
            p1Input.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            p1Input.Location = new Point(47, 182);
            p1Input.Name = "p1Input";
            p1Input.Size = new Size(125, 28);
            p1Input.TabIndex = 8;
            toolTip1.SetToolTip(p1Input, "Please enter a Player name no longer than 12 Characters and is alphabetic ");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(619, 146);
            label6.Name = "label6";
            label6.Size = new Size(130, 21);
            label6.TabIndex = 12;
            label6.Text = "Choose Score:";
            // 
            // TextBoxScore
            // 
            TextBoxScore.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxScore.Location = new Point(619, 182);
            TextBoxScore.Name = "TextBoxScore";
            TextBoxScore.Size = new Size(125, 28);
            TextBoxScore.TabIndex = 13;
            // 
            // ButtonAddPlayer
            // 
            ButtonAddPlayer.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAddPlayer.Location = new Point(114, 391);
            ButtonAddPlayer.Name = "ButtonAddPlayer";
            ButtonAddPlayer.Size = new Size(111, 30);
            ButtonAddPlayer.TabIndex = 14;
            ButtonAddPlayer.Text = "Add Player";
            toolTip1.SetToolTip(ButtonAddPlayer, "Click to add player");
            ButtonAddPlayer.UseVisualStyleBackColor = true;
            ButtonAddPlayer.Click += ButtonAddPlayer_Click;
            // 
            // ButtonDeletePlayer
            // 
            ButtonDeletePlayer.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDeletePlayer.Location = new Point(343, 392);
            ButtonDeletePlayer.Name = "ButtonDeletePlayer";
            ButtonDeletePlayer.Size = new Size(111, 29);
            ButtonDeletePlayer.TabIndex = 15;
            ButtonDeletePlayer.Text = "Delete Player";
            toolTip1.SetToolTip(ButtonDeletePlayer, "Click to delete player");
            ButtonDeletePlayer.UseVisualStyleBackColor = true;
            ButtonDeletePlayer.Click += ButtonDeletePlayer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(780, 462);
            Controls.Add(ButtonDeletePlayer);
            Controls.Add(ButtonAddPlayer);
            Controls.Add(TextBoxScore);
            Controls.Add(label6);
            Controls.Add(p1Input);
            Controls.Add(label2);
            Controls.Add(ButtonSubmit);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameOfHearts";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem2;
        private Button ButtonSubmit;
        private Label label2;
        private TextBox p1Input;
        private Label label6;
        private TextBox TextBoxScore;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolTip toolTip1;
        private Button ButtonAddPlayer;
        private Button ButtonDeletePlayer;
    }
}