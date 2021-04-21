namespace Connect4
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
            this.btn_col1 = new System.Windows.Forms.Button();
            this.btn_col2 = new System.Windows.Forms.Button();
            this.btn_col3 = new System.Windows.Forms.Button();
            this.btn_col4 = new System.Windows.Forms.Button();
            this.btn_col5 = new System.Windows.Forms.Button();
            this.btn_col6 = new System.Windows.Forms.Button();
            this.btn_col7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeStarterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_col1
            // 
            this.btn_col1.Location = new System.Drawing.Point(75, 26);
            this.btn_col1.Name = "btn_col1";
            this.btn_col1.Size = new System.Drawing.Size(50, 25);
            this.btn_col1.TabIndex = 0;
            this.btn_col1.Text = "V";
            this.btn_col1.UseVisualStyleBackColor = true;
            this.btn_col1.Click += new System.EventHandler(this.btn_col1_Click);
            // 
            // btn_col2
            // 
            this.btn_col2.Location = new System.Drawing.Point(175, 26);
            this.btn_col2.Name = "btn_col2";
            this.btn_col2.Size = new System.Drawing.Size(50, 25);
            this.btn_col2.TabIndex = 1;
            this.btn_col2.Text = "V";
            this.btn_col2.UseVisualStyleBackColor = true;
            this.btn_col2.Click += new System.EventHandler(this.btn_col2_Click);
            // 
            // btn_col3
            // 
            this.btn_col3.Location = new System.Drawing.Point(275, 26);
            this.btn_col3.Name = "btn_col3";
            this.btn_col3.Size = new System.Drawing.Size(50, 25);
            this.btn_col3.TabIndex = 2;
            this.btn_col3.Text = "V";
            this.btn_col3.UseVisualStyleBackColor = true;
            this.btn_col3.Click += new System.EventHandler(this.btn_col3_Click);
            // 
            // btn_col4
            // 
            this.btn_col4.Location = new System.Drawing.Point(375, 26);
            this.btn_col4.Name = "btn_col4";
            this.btn_col4.Size = new System.Drawing.Size(50, 25);
            this.btn_col4.TabIndex = 3;
            this.btn_col4.Text = "V";
            this.btn_col4.UseVisualStyleBackColor = true;
            this.btn_col4.Click += new System.EventHandler(this.btn_col4_Click);
            // 
            // btn_col5
            // 
            this.btn_col5.Location = new System.Drawing.Point(475, 26);
            this.btn_col5.Name = "btn_col5";
            this.btn_col5.Size = new System.Drawing.Size(50, 25);
            this.btn_col5.TabIndex = 4;
            this.btn_col5.Text = "V";
            this.btn_col5.UseVisualStyleBackColor = true;
            this.btn_col5.Click += new System.EventHandler(this.btn_col5_Click);
            // 
            // btn_col6
            // 
            this.btn_col6.Location = new System.Drawing.Point(575, 26);
            this.btn_col6.Name = "btn_col6";
            this.btn_col6.Size = new System.Drawing.Size(50, 25);
            this.btn_col6.TabIndex = 5;
            this.btn_col6.Text = "V";
            this.btn_col6.UseVisualStyleBackColor = true;
            this.btn_col6.Click += new System.EventHandler(this.btn_col6_Click);
            // 
            // btn_col7
            // 
            this.btn_col7.Location = new System.Drawing.Point(675, 26);
            this.btn_col7.Name = "btn_col7";
            this.btn_col7.Size = new System.Drawing.Size(50, 25);
            this.btn_col7.TabIndex = 6;
            this.btn_col7.Text = "V";
            this.btn_col7.UseVisualStyleBackColor = true;
            this.btn_col7.Click += new System.EventHandler(this.btn_col7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.playerOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenuItem,
            this.QuitGameMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.toolStripMenuItem1.Text = "Game Options";
            // 
            // NewGameMenuItem
            // 
            this.NewGameMenuItem.Name = "NewGameMenuItem";
            this.NewGameMenuItem.Size = new System.Drawing.Size(132, 22);
            this.NewGameMenuItem.Text = "New Game";
            this.NewGameMenuItem.Click += new System.EventHandler(this.NewGameMenuItem_Click);
            // 
            // QuitGameMenuItem
            // 
            this.QuitGameMenuItem.Name = "QuitGameMenuItem";
            this.QuitGameMenuItem.Size = new System.Drawing.Size(132, 22);
            this.QuitGameMenuItem.Text = "Quit Game";
            this.QuitGameMenuItem.Click += new System.EventHandler(this.QuitGameMenuItem_Click);
            // 
            // playerOptionsToolStripMenuItem
            // 
            this.playerOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeStarterMenuItem});
            this.playerOptionsToolStripMenuItem.Name = "playerOptionsToolStripMenuItem";
            this.playerOptionsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.playerOptionsToolStripMenuItem.Text = "Player Options";
            // 
            // ChangeStarterMenuItem
            // 
            this.ChangeStarterMenuItem.Name = "ChangeStarterMenuItem";
            this.ChangeStarterMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ChangeStarterMenuItem.Text = "Change Starter to: Red";
            this.ChangeStarterMenuItem.Click += new System.EventHandler(this.ChangeStarterMenuItem_Click);
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(267, 675);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(273, 25);
            this.CurrentPlayerLabel.TabIndex = 8;
            this.CurrentPlayerLabel.Text = "Current Player: YELLOW";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 729);
            this.Controls.Add(this.CurrentPlayerLabel);
            this.Controls.Add(this.btn_col7);
            this.Controls.Add(this.btn_col6);
            this.Controls.Add(this.btn_col5);
            this.Controls.Add(this.btn_col4);
            this.Controls.Add(this.btn_col3);
            this.Controls.Add(this.btn_col2);
            this.Controls.Add(this.btn_col1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4 - Gene Pressinger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_col1;
        private System.Windows.Forms.Button btn_col2;
        private System.Windows.Forms.Button btn_col3;
        private System.Windows.Forms.Button btn_col4;
        private System.Windows.Forms.Button btn_col5;
        private System.Windows.Forms.Button btn_col6;
        private System.Windows.Forms.Button btn_col7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeStarterMenuItem;
        private System.Windows.Forms.Label CurrentPlayerLabel;
    }
}

