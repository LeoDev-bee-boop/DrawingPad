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
        Graphics graphics;
        Boolean cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;

        
        public Form1()
        {
            InitializeComponent();
            graphics = canvas.CreateGraphics();
            cursorPen = new Pen(Color.Black, 7);
        }

        private void pinkBox_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
        }
    }
}
