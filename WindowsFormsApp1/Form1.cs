using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void MoveButton()
        {
            int maxX = ClientSize.Width - button1.Size.Width;
            int maxY = ClientSize.Height - button1.Size.Height;

            button1.Location = new Point(random.Next(maxX), random.Next(maxY));
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveButton();
        }
    }
}
