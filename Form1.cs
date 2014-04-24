using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talker
{
    public partial class Form1 : Form
    {
        public static int speak(string thingToSay, int numberOftimes)
    {
        string finalString = "";
        for (int count =0; count < numberOftimes; count++)
        {
            finalString = finalString + thingToSay + "\n";
        }
        MessageBox.Show(finalString);
        return finalString.Length;

    }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Form1.speak(textBox1.Text, (int)numericUpDown1.Value);
        }
    }
}
