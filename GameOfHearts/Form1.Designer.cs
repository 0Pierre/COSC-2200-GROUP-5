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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            p1Input = new TextBox();
            p2Input = new TextBox();
            p3Input = new TextBox();
            p4Input = new TextBox();
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
            label1.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(259, 27);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(281, 48);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Hearts";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
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
            menuStrip1.Size = new Size(819, 35);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { rulesToolStripMenuItem, aboutToolStripMenuItem2 });
            aboutToolStripMenuItem1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            aboutToolStripMenuItem1.ForeColor = Color.White;
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(63, 29);
            aboutToolStripMenuItem1.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new Size(146, 30);
            rulesToolStripMenuItem.Text = "Rules";
            rulesToolStripMenuItem.Click += rulesToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem2
            // 
            aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            aboutToolStripMenuItem2.Size = new Size(146, 30);
            aboutToolStripMenuItem2.Text = "About";
            aboutToolStripMenuItem2.Click += aboutToolStripMenuItem2_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(60, 29);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(351, 385);
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
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(43, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Player 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 219);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Player 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(664, 120);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Player 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(664, 219);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Player 4";
            // 
            // p1Input
            // 
            p1Input.Location = new Point(21, 156);
            p1Input.Name = "p1Input";
            p1Input.Size = new Size(125, 27);
            p1Input.TabIndex = 8;
            toolTip1.SetToolTip(p1Input, "Please enter a Player name no longer than 12 Characters and is alphabetic ");
            // 
            // p2Input
            // 
            p2Input.Location = new Point(21, 253);
            p2Input.Name = "p2Input";
            p2Input.Size = new Size(125, 27);
            p2Input.TabIndex = 9;
            toolTip1.SetToolTip(p2Input, "Please enter a Player name no longer than 12 Characters and is alphabetic ");
            // 
            // p3Input
            // 
            p3Input.Location = new Point(642, 156);
            p3Input.Name = "p3Input";
            p3Input.Size = new Size(125, 27);
            p3Input.TabIndex = 10;
            toolTip1.SetToolTip(p3Input, "Please enter a Player name no longer than 12 Characters and is alphabetic ");
            // 
            // p4Input
            // 
            p4Input.Location = new Point(642, 253);
            p4Input.Name = "p4Input";
            p4Input.Size = new Size(125, 27);
            p4Input.TabIndex = 11;
            toolTip1.SetToolTip(p4Input, "Please enter a Player name no longer than 12 Characters and is alphabetic ");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(26, 355);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 12;
            label6.Text = "Choose Score:";
            // 
            // TextBoxScore
            // 
            TextBoxScore.Location = new Point(26, 387);
            TextBoxScore.Name = "TextBoxScore";
            TextBoxScore.Size = new Size(125, 27);
            TextBoxScore.TabIndex = 13;
            // 
            // ButtonAddPlayer
            // 
            ButtonAddPlayer.Location = new Point(649, 367);
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
            ButtonDeletePlayer.Location = new Point(649, 403);
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
            ClientSize = new Size(819, 535);
            Controls.Add(ButtonDeletePlayer);
            Controls.Add(ButtonAddPlayer);
            Controls.Add(TextBoxScore);
            Controls.Add(label6);
            Controls.Add(p4Input);
            Controls.Add(p3Input);
            Controls.Add(p2Input);
            Controls.Add(p1Input);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ButtonSubmit);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
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
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox p1Input;
        private TextBox p2Input;
        private TextBox p3Input;
        private TextBox p4Input;
        private Label label6;
        private TextBox TextBoxScore;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolTip toolTip1;
        private Button ButtonAddPlayer;
        private Button ButtonDeletePlayer;
    }
}