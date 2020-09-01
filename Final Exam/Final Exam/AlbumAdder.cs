//Programmed By Hunter Calley - Have A Good Summer Dr. Kelley!
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Exam
{
    public partial class AlbumAdder : Form
    {
        public AlbumAdder()
        {
            InitializeComponent();

            MessageBox.Show("Note: any new entry will overwrite anything in the albumadder.txt file");
        }

        private void AlbumAdder_Load(object sender, EventArgs e)
        {

        }

        private void albumAdderButton_Click(object sender, EventArgs e)
        {
            albumListBox.Items.Add(artistTextBox.Text + " - " + titleTextBox.Text);

            artistTextBox.Text = "";
            titleTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string sPath = "albumadder.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in albumListBox.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Albums Saved!");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye, World!");
            this.Close();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type an artist in, followed by an album title. This will write to a text file in the Debug Folder."); 
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void soundtrackButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is what I listened to while programming this");
           
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=PMOD-iU81-k");
        }
    }
}
