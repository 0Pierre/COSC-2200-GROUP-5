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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem2 = new ToolStripMenuItem();
            ButtomSubmit = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TextBoxPOne = new TextBox();
            TextBoxPTwo = new TextBox();
            TextBoxPThree = new TextBox();
            TextBoxP4 = new TextBox();
            label6 = new Label();
            TextBoxScore = new TextBox();
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
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(815, 26);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { rulesToolStripMenuItem, aboutToolStripMenuItem2 });
            aboutToolStripMenuItem1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(56, 22);
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
            // ButtomSubmit
            // 
            ButtomSubmit.Location = new Point(351, 385);
            ButtomSubmit.Name = "ButtomSubmit";
            ButtomSubmit.Size = new Size(94, 29);
            ButtomSubmit.TabIndex = 3;
            ButtomSubmit.Text = "Submit";
            ButtomSubmit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Player 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 219);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Player 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(664, 120);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Player 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(664, 219);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Player 4";
            // 
            // TextBoxPOne
            // 
            TextBoxPOne.Location = new Point(21, 156);
            TextBoxPOne.Name = "TextBoxPOne";
            TextBoxPOne.Size = new Size(125, 27);
            TextBoxPOne.TabIndex = 8;
            // 
            // TextBoxPTwo
            // 
            TextBoxPTwo.Location = new Point(21, 253);
            TextBoxPTwo.Name = "TextBoxPTwo";
            TextBoxPTwo.Size = new Size(125, 27);
            TextBoxPTwo.TabIndex = 9;
            // 
            // TextBoxPThree
            // 
            TextBoxPThree.Location = new Point(642, 156);
            TextBoxPThree.Name = "TextBoxPThree";
            TextBoxPThree.Size = new Size(125, 27);
            TextBoxPThree.TabIndex = 10;
            // 
            // TextBoxP4
            // 
            TextBoxP4.Location = new Point(642, 253);
            TextBoxP4.Name = "TextBoxP4";
            TextBoxP4.Size = new Size(125, 27);
            TextBoxP4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(815, 448);
            Controls.Add(TextBoxScore);
            Controls.Add(label6);
            Controls.Add(TextBoxP4);
            Controls.Add(TextBoxPThree);
            Controls.Add(TextBoxPTwo);
            Controls.Add(TextBoxPOne);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ButtomSubmit);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
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
        private Button ButtomSubmit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TextBoxPOne;
        private TextBox TextBoxPTwo;
        private TextBox TextBoxPThree;
        private TextBox TextBoxP4;
        private Label label6;
        private TextBox TextBoxScore;
    }
}