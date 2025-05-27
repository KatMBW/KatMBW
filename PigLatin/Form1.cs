using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word, piglatin;
            word = Input.Text;
            piglatin = word.Substring(1, word.Length - 1) + word.Substring(0, 1) + "ay";
            Output.Text = piglatin;
        }
    }
}
