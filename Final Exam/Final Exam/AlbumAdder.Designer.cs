namespace Final_Exam
{
    partial class AlbumAdder
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.albumAdderButton = new System.Windows.Forms.Button();
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.soundtrackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save Listbox to Text File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Album Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Artist";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(249, 90);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 21;
            this.titleTextBox.Text = "World!";
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(143, 90);
            this.artistTextBox.Multiline = true;
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(100, 20);
            this.artistTextBox.TabIndex = 20;
            this.artistTextBox.Text = "Hello";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Keep Track of Albums Listened To";
            // 
            // albumAdderButton
            // 
            this.albumAdderButton.Location = new System.Drawing.Point(168, 230);
            this.albumAdderButton.Name = "albumAdderButton";
            this.albumAdderButton.Size = new System.Drawing.Size(75, 54);
            this.albumAdderButton.TabIndex = 18;
            this.albumAdderButton.Text = "Add to Listbox";
            this.albumAdderButton.UseVisualStyleBackColor = true;
            this.albumAdderButton.Click += new System.EventHandler(this.albumAdderButton_Click);
            // 
            // albumListBox
            // 
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.Location = new System.Drawing.Point(140, 116);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(271, 108);
            this.albumListBox.TabIndex = 17;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(222, 290);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(13, 13);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(75, 23);
            this.infoButton.TabIndex = 26;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // soundtrackButton
            // 
            this.soundtrackButton.Location = new System.Drawing.Point(13, 42);
            this.soundtrackButton.Name = "soundtrackButton";
            this.soundtrackButton.Size = new System.Drawing.Size(75, 40);
            this.soundtrackButton.TabIndex = 27;
            this.soundtrackButton.Text = "Program Soundtrack";
            this.soundtrackButton.UseVisualStyleBackColor = true;
            this.soundtrackButton.Click += new System.EventHandler(this.soundtrackButton_Click);
            // 
            // AlbumAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 336);
            this.Controls.Add(this.soundtrackButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.albumAdderButton);
            this.Controls.Add(this.albumListBox);
            this.Name = "AlbumAdder";
            this.Text = "AlbumAdder";
            this.Load += new System.EventHandler(this.AlbumAdder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button albumAdderButton;
        private System.Windows.Forms.ListBox albumListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button soundtrackButton;
    }
}