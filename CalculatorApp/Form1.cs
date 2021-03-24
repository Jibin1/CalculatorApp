using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public TextBox Disp;
     
        private Boolean hasfunc;
        private Boolean hasDecimal;
        private Boolean isNegative;
      
      
       
        Function function;
        public Form1()
        {
            InitializeComponent();
            Disp = DisplayBox;
            //Disp.SelectedText = "0";
            startfunction();
            

         
        }

        private void startfunction()
        {
            function = new Function();
            hasDecimal = false;
            hasfunc = false;
            isNegative = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "2";
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "9";
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(hasfunc == true)
            {
                function.removeLastFunction();
                function.setFunc('+');
            }
            else
            {
                function.setNumber(Convert.ToDouble(Disp.Text));
                double temp = function.getResult();
                Disp.Clear();
                Disp.Text = "" + temp;
                function.setFunc('+');
                hasfunc = true;
                hasDecimal = false;
            }
 
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

            if (hasfunc == true)
            {
                function.removeLastFunction();
                function.setFunc('-');
            }
            else
            {
                function.setNumber(Convert.ToDouble(Disp.Text));
                double temp = function.getResult();
                Disp.Clear();
                Disp.Text = "" + temp;
                function.setFunc('-');
                hasfunc = true;
                hasDecimal = false;
            }
          
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (hasfunc == true)
            {
                function.removeLastFunction();
                function.setFunc('-');
            }
            else
            {
                function.setNumber(Convert.ToDouble(Disp.Text));
                double temp = function.getResult();
                Disp.Clear();
                Disp.Text = "" + temp;
                function.setFunc('*');
                hasfunc = true;
            }
        
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (hasfunc == true)
            {
                function.removeLastFunction();
                function.setFunc('/');
            }
            else
            {
                function.setNumber(Convert.ToDouble(Disp.Text));
                double temp = function.getResult();
                Disp.Clear();
                Disp.Text = "" + temp;
                function.setFunc('/');
                hasfunc = true;
            }
 
            
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            Disp.Clear();
            startfunction();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            function.setNumber(Convert.ToDouble(Disp.Text));
            double temp = function.getResult();
            Disp.Clear();
            Disp.Text = "" + temp;
            hasfunc = true;
            startfunction();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            hasFunction();
            Disp.SelectedText = "0";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            hasFunction();
            if (hasDecimal == false)
            {
                Disp.SelectedText = ".";
                hasDecimal = true;
            }
            
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            String temp = Disp.Text;

            if (temp != "")
            {

                if (isNegative == false)
                {

                    temp = temp.Insert(0, "-");
                    isNegative = true;

                }
                else
                {
                    temp = Disp.Text.Substring(1);
                    isNegative = false;
                }
            }
            else
            {
                temp = "-0";
            }
            Disp.Clear();
            Disp.SelectedText = temp;

        } 

        private void hasFunction()
        {
            if(hasfunc == true)
            {
                Disp.Clear();
                hasfunc = false;
                
            }
        }

        private void hasNum()
        {
            
        }

       
    }
}



//Code that was rejected




//if (hasNum1 == false)
//{

//    function.setFunc('+');
//    hasNum1 = true;
//    hasfunc = true;
//}
//else
//{

//    double temp = function.getResult();
//    Disp.Clear();
//    Disp.Text = "" + temp;
//    function.setFunc('+');
//    hasfunc = true;
//}

//if (isCheked == false)
//{
//    double temp = Convert.ToDouble(Disp.Text);
//    function.setNumber(temp);
//    function.setFunc('+');
//    isCheked = true;
//    Disp.Clear();
//}
//else
//{
//    double temp = function.getResult();
//    Disp.Clear();
//    Disp.Text = "" + temp;
//    function.setFunc('+');
//    //Disp.SelectedText = " + ";
//    //Disp.Clear();
//}



//public void addToHolder(int num)
//{ 
//    if(sig == 0)
//    {
//        numHolder = num;
//        sig++;
//    }
//    else
//    {
//       numHolder = (numHolder * Math.Pow(10, sig)) + num;
//        sig++;
//    }

//}