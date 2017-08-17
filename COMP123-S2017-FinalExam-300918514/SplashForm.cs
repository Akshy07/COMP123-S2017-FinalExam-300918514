using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Akshay Patel
 * Date: August 17, 2017
 * StudentID: 300918514
 * Description: This is the SplashForm.
 * Version-0.1 : Created a SplashForm.
 */

namespace COMP123_S2017_FinalExam_300918514
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the TICK event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm card = new PickHighestCardForm();
            Program.card.Show();
            this.Hide();
            timer1_Tick.Enabled = false;
        
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
