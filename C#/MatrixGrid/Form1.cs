using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MatrixGrid
{

    public partial class Form1 : Form
    {
        // Add member variables
        public int m_Width;      //Width of the grid cell
        public int m_Height;  //height of the grid cell

        public int m_NoOfRows; // no of rows 
        public int m_NoOfColloumn;  //no of coloumn

        public int m_XOffset; //offset from which drawing start
        public int m_YOffset;
        int m_iCounter = 2;
        int m_iSize = 8;
        public Thread m_iTh;

        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 50;
        public const int DEFAULT_NO_ROWS = 2;
        public const int DEFAULT_NO_COLS = 2;
        public const int DEFAULT_WIDTH = 50;
        public const int DEFAULT_HEIGHT = 50;

        
        
        public Form1()
        {
            InitializeComponent();
            Initialize();
          
        }
        ManualResetEvent _event = new ManualResetEvent(true);

        private void toolStripButton1_Click(object sender, EventArgs e) //start button
        {
            
            m_iTh = new Thread(ThreadCounter);
            m_iTh.Start();
        }
        private void Form_Load(object sender,EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            _event.Reset();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            _event.Set();
        }

        public void Initialize()
        {
            m_Width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;

            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfColloumn = DEFAULT_NO_COLS;

            m_XOffset = DEFAULT_X_OFFSET;
            m_YOffset = DEFAULT_Y_OFFSET;
        }

        private void DrawGrid()
        {
            Graphics boardLayout = this.CreateGraphics();
            Pen layoutPen = new Pen(Color.Blue);
            layoutPen.Width = 5;

            //boardLayout.DrawLine(layoutPen,0,0,100,0)
            int X = DEFAULT_X_OFFSET;
            int Y = DEFAULT_Y_OFFSET;
            //draw rows

            for (int i = 0; i <= m_iCounter; i++)
            {
                boardLayout.DrawLine(layoutPen, X, Y, X + this.m_Width * this.m_iCounter, Y);
                Y = Y + m_Height;
            }

            //Draw cols
            X = DEFAULT_X_OFFSET;
            Y = DEFAULT_Y_OFFSET;
            for (int j = 0; j <= m_iCounter; j++)
            {
                boardLayout.DrawLine(layoutPen, X, Y, X, Y + this.m_Height * this.m_iCounter);
                X = X + this.m_Width;
            }

        }

        private void OnPaint(object sender, EventArgs e)
        {
            DrawGrid();
        }
        public void ThreadCounter()
        {
            while (true)
            {
                _event.WaitOne();
                m_iCounter++;

                if (m_iCounter > m_iSize)
                {
                    m_iCounter = 2;
                }
                Invalidate();
                Thread.Sleep(1000);
            }

        }

        private void x3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_iSize = 3;
            this.Refresh();
        }

        private void x4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_iSize = 4;
            this.Refresh();
        }

        private void x5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_iSize = 5;
            this.Refresh();
        }

        private void x6ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m_iSize = 6;
            this.Refresh();
        }

        private void x7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_iSize = 7;
            this.Refresh();
        }

        private void x8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_iSize = 8;
            this.Refresh();
        }
    }
}

