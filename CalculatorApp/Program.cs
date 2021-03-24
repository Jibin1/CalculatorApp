using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Function temp = new Function();
            //temp.setNumber(-5);
            //temp.setNumber(5);
            //temp.setNumber(4);
            //temp.setNumber(4);

            //temp.setFunc('-');
            //temp.setFunc('*');
            ////temp.setFunc('*');


            //temp.calculateResults();
            //Console.WriteLine(4%2);

        }



    }
}
