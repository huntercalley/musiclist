using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam
{
    class InfoClass
    {
        public void Link()
        {
            MessageBox.Show("this is what I listened to while programming this");
            
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=PMOD-iU81-k");
        }

        public void Info()
        {
            MessageBox.Show("Type an artist in, followed by an album title. This will write to a text file in the Debug Folder.");
        }

    }

   

}
