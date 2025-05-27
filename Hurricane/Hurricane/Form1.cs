using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Hurricane
{
    public partial class Hurricane : Form
    {
        public Hurricane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int Category5 = 157, Category4 = 130, Category3 = 111, Category2 = 96, Category1 = 74;
            double Windspeed = Convert.ToDouble(textBox1.Text);
            string Category;

            if (Windspeed >= Category5)
                Category = "it is a category 5 hurricane.";
            else if (Windspeed >= Category4)
                Category = "it is a category 4 hurricane.";
            else if (Windspeed >= Category3)
                Category = "it is a category 3 hurricane.";
            else if (Windspeed >= Category2)
                Category = "it is a category 2 hurricane.";
            else if (Windspeed >= Category1)
                Category = "it is a category 1 hurricane.";
            else Category = "it is not a hurricane.";

            label2.Text = "The wind speed is " + Windspeed + "mph. Which means that " + Category;
        }
    }
}
