using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//The program contains one window on which there will be a textbox.This textbox will take a string from a 
//speech to text program.The string in this textbox will be highlighted automatically so the screenreader 
//program JAWS will read it out and the user can check it for mistakes.Pressing a yet to be determined key 
//copies the string into the clipboard and automatically pastes it in a destination program such as Microsoft 
//Word.
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
         

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                object pasteFile = "C:\\Benutzer\\Admin\\Desktop\\test.txt";
                String clipboardText = txtInput.Text;

                try
                {
                    // empties clipboard and copies string from txtInput to clipboard as ANSI text format
                    Clipboard.SetText(clipboardText, 0);
                }
                // catches hitting enter on an empty textbox
                catch (ArgumentNullException)
                {
                    //empties clipboard so no old data is left
                    Clipboard.Clear();
                }
        }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // highlights the text in the textbox 
            txtInput.SelectAll();           
        }
    }
}
