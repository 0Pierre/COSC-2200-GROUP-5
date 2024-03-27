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
            label1.Location = new Point(227, 20);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(228, 38);
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
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(717, 27);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { rulesToolStripMenuItem, aboutToolStripMenuItem2 });
            aboutToolStripMenuItem1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            aboutToolStripMenuItem1.ForeColor = Color.White;
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(51, 23);
            aboutToolStripMenuItem1.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new Size(117, 24);
            rulesToolStripMenuItem.Text = "Rules";
            rulesToolStripMenuItem.Click += rulesToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem2
            // 
            aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            aboutToolStripMenuItem2.Size = new Size(117, 24);
            aboutToolStripMenuItem2.Text = "About";
            aboutToolStripMenuItem2.Click += aboutToolStripMenuItem2_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(49, 23);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(307, 289);
            ButtonSubmit.Margin = new Padding(3, 2, 3, 2);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(82, 22);
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
            label2.Location = new Point(38, 90);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 4;
            label2.Text = "Player 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 164);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 5;
            label3.Text = "Player 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(581, 90);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 6;
            label4.Text = "Player 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(581, 164);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 7;
            label5.Text = "Player 4";
            // 
            // p1Input
            // 
            p1Input.Location = new Point(18, 117);
            p1Input.Margin = new Padding(3, 2, 3, 2);
            p1Input.Name = "p1Input";
            p1Input.Size = new Size(110, 23);
            p1Input.TabIndex = 8;
            toolTip1.SetToolTip(p1Input, "Please enter a Player name no longer than 12 Characters and is alphabetic ");
            // 
            // p2Input
            // 
            p2Input.Location = new Point(18, 190);
            p2Input.Margin = new Padding(3, 2, 3, 2);
            p2Input.Name = "p2Input";
            p2Input.Size = new Size(110, 23);
            p2Input.TabIndex = 9;
            toolTip1.SetToolTip(p2Input, "Please enter a Player name no longer than 12 Characters and is alphabetic ");
            // 
            // p3Input
            // 
            p3Input.Location = new Point(562, 117);
            p3Input.Margin = new Padding(3, 2, 3, 2);
            p3Input.Name = "p3Input";
            p3Input.Size = new Size(110, 23);
            p3Input.TabIndex = 10;
            toolTip1.SetToolTip(p3Input, "Please enter a Player name no longer than 12 Characters and is alphabetic ");
            // 
            // p4Input
            // 
            p4Input.Location = new Point(562, 190);
            p4Input.Margin = new Padding(3, 2, 3, 2);
            p4Input.Name = "p4Input";
            p4Input.Size = new Size(110, 23);
            p4Input.TabIndex = 11;
            toolTip1.SetToolTip(p4Input, "Please enter a Player name no longer than 12 Characters and is alphabetic ");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 266);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 12;
            label6.Text = "Choose Score:";
            // 
            // TextBoxScore
            // 
            TextBoxScore.Location = new Point(23, 290);
            TextBoxScore.Margin = new Padding(3, 2, 3, 2);
            TextBoxScore.Name = "TextBoxScore";
            TextBoxScore.Size = new Size(110, 23);
            TextBoxScore.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(717, 401);
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
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameOfHearts";
            Load += Form1_Load;
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
    }
}