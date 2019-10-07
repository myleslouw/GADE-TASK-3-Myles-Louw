using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GADE_Task_1;


namespace GADE_Task_1
{
    public partial class Form1 : Form
    {
        GameEngine engine;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine = new GameEngine(this, this.gbxGameProgress);
        }

        public void displayInfo(string message)
        {
            rtbxGameProgression.Text += message;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            engine.UpdateMap();
            engine.UpdateDisplay();
            lblRound.Text += (++count).ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
        }
    }
}