using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Akshay Patel
 * Date: August 17, 2017
 * StudentID: 300918514
 * Description: This is the Driver class
 * Version-0.1 : Added to overwrite method.
 */

namespace COMP123_S2017_FinalExam_300918514
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PickHighestCardForm());
        }
    }
}
