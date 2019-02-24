using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightsTourEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string line;
            using (StreamReader reader = new StreamReader("MilimLeeNonIntelligentMethod.txt"))
            {
                while (!reader.EndOfStream)
                {
                    richTextBox1.AppendText(reader.ReadLine());
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                }
            }

            KnightTour kt = new KnightTour();
            
            kt.Movement();
            Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // string line;
            using (StreamReader reader = new StreamReader("MilimLeeNonIntelligentMethod.txt"))
            {
                while (!reader.EndOfStream)
                {
                    richTextBox1.AppendText(reader.ReadLine());
                }
            }
            HeuristicsKnightTour hkt = new HeuristicsKnightTour();
            hkt.Movement();
            Console.ReadLine();
        }
    }
}
