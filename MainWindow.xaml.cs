using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1 = 0;
        double number2 = 0;
        string operation = "";
        string operation2 = "";
        string comma = "";
        //double fractional1 = 0.1;
        //double fractional2 = 0.1;
        double memory = 0;
        bool bProgrammer = false;
        bool flag1 = true;


        public MainWindow()
        {
            InitializeComponent();

            txtMemory.Visibility = Visibility.Hidden;

            btnMC2.Visibility = Visibility.Hidden;
            btnMR2.Visibility = Visibility.Hidden;
            btnMPlus2.Visibility = Visibility.Hidden;
            btnMMinus2.Visibility = Visibility.Hidden;
            btnMS2.Visibility = Visibility.Hidden;

            btnX22.Visibility = Visibility.Hidden;
            btnXY.Visibility = Visibility.Hidden;
            btnSin.Visibility = Visibility.Hidden;
            btnCos.Visibility = Visibility.Hidden;
            btnTan.Visibility = Visibility.Hidden;

            btnSqrt2.Visibility = Visibility.Hidden;
            btn10X.Visibility = Visibility.Hidden;
            btnLog.Visibility = Visibility.Hidden;
            btnExp.Visibility = Visibility.Hidden;
            btnMod.Visibility = Visibility.Hidden;

            btnTagh.Visibility = Visibility.Hidden;
            btnCE2.Visibility = Visibility.Hidden;
            btnC2.Visibility = Visibility.Hidden;
            btnBackSpase2.Visibility = Visibility.Hidden;
            btnDiv2.Visibility = Visibility.Hidden;

            btnPI.Visibility = Visibility.Hidden;
            btn72.Visibility = Visibility.Hidden;
            btn82.Visibility = Visibility.Hidden;
            btn92.Visibility = Visibility.Hidden;
            btnMult2.Visibility = Visibility.Hidden;

            btnN.Visibility = Visibility.Hidden;
            btn42.Visibility = Visibility.Hidden;
            btn52.Visibility = Visibility.Hidden;
            btn62.Visibility = Visibility.Hidden;
            btnMinus2.Visibility = Visibility.Hidden;

            btnPlusMinus2.Visibility = Visibility.Hidden;
            btn12.Visibility = Visibility.Hidden;
            btn22.Visibility = Visibility.Hidden;
            btn32.Visibility = Visibility.Hidden;
            btnPlus2.Visibility = Visibility.Hidden;

            btnSinh.Visibility = Visibility.Hidden;
            btnCosh.Visibility = Visibility.Hidden;
            btn02.Visibility = Visibility.Hidden;
            btnComma2.Visibility = Visibility.Hidden;
            btnEquals2.Visibility = Visibility.Hidden;

            //Programmer Area
            btnCE3.Visibility = Visibility.Hidden;
            btnC3.Visibility = Visibility.Hidden;
            btnBackSpase3.Visibility = Visibility.Hidden;
            btnDiv3.Visibility = Visibility.Hidden;

            btn73.Visibility = Visibility.Hidden;
            btn83.Visibility = Visibility.Hidden;
            btn93.Visibility = Visibility.Hidden;
            btnMult3.Visibility = Visibility.Hidden;

            btn43.Visibility = Visibility.Hidden;
            btn53.Visibility = Visibility.Hidden;
            btn63.Visibility = Visibility.Hidden;
            btnMinus3.Visibility = Visibility.Hidden;

            btn13.Visibility = Visibility.Hidden;
            btn23.Visibility = Visibility.Hidden;
            btn33.Visibility = Visibility.Hidden;
            btnPlus3.Visibility = Visibility.Hidden;

            btnPlusMinus3.Visibility = Visibility.Hidden;
            btn03.Visibility = Visibility.Hidden;
            btnComma3.Visibility = Visibility.Hidden;
            btnEquals3.Visibility = Visibility.Hidden;

            txtDisplayHex.Visibility = Visibility.Hidden;
            txtDisplayHexLabel.Visibility = Visibility.Hidden;
            txtDisplayDec.Visibility = Visibility.Hidden;
            txtDisplayDecLabel.Visibility = Visibility.Hidden;
            txtDisplayOct.Visibility = Visibility.Hidden;
            txtDisplayOctLabel.Visibility = Visibility.Hidden;
            txtDisplayBin.Visibility = Visibility.Hidden;
            txtDisplayBinLabel.Visibility = Visibility.Hidden;

        }

        private void BtnStandart_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            operation2 = "";
            comma = "";
            //fractional1 = 0.1;
            //fractional2 = 0.1;
            txtDisplay.Text = "0";
            bProgrammer = false;
            DisplayNumberProgrammer(0);

            btnMC2.Visibility = Visibility.Hidden;
            btnMR2.Visibility = Visibility.Hidden;
            btnMPlus2.Visibility = Visibility.Hidden;
            btnMMinus2.Visibility = Visibility.Hidden;
            btnMS2.Visibility = Visibility.Hidden;

            btnX22.Visibility = Visibility.Hidden;
            btnXY.Visibility = Visibility.Hidden;
            btnSin.Visibility = Visibility.Hidden;
            btnCos.Visibility = Visibility.Hidden;
            btnTan.Visibility = Visibility.Hidden;

            btnMC.Visibility = Visibility.Visible;
            btnMR.Visibility = Visibility.Visible;
            btnMPlus.Visibility = Visibility.Visible;
            btnMMinus.Visibility = Visibility.Visible;
            btnMS.Visibility = Visibility.Visible;

            btnSqrt2.Visibility = Visibility.Hidden;
            btn10X.Visibility = Visibility.Hidden;
            btnLog.Visibility = Visibility.Hidden;
            btnExp.Visibility = Visibility.Hidden;
            btnMod.Visibility = Visibility.Hidden;


            btnPercent.Visibility = Visibility.Visible;
            btnCE.Visibility = Visibility.Visible;
            btnC.Visibility = Visibility.Visible;
            btnBackSpase.Visibility = Visibility.Visible;
            btnDiv.Visibility = Visibility.Visible;

            btnTagh.Visibility = Visibility.Hidden;
            btnCE2.Visibility = Visibility.Hidden;
            btnC2.Visibility = Visibility.Hidden;
            btnBackSpase2.Visibility = Visibility.Hidden;
            btnDiv2.Visibility = Visibility.Hidden;


            btnSqrt.Visibility = Visibility.Visible;
            btn7.Visibility = Visibility.Visible;
            btn8.Visibility = Visibility.Visible;
            btn9.Visibility = Visibility.Visible;
            btnMult.Visibility = Visibility.Visible;

            btnPI.Visibility = Visibility.Hidden;
            btn72.Visibility = Visibility.Hidden;
            btn82.Visibility = Visibility.Hidden;
            btn92.Visibility = Visibility.Hidden;
            btnMult2.Visibility = Visibility.Hidden;


            btnX2.Visibility = Visibility.Visible;
            btn4.Visibility = Visibility.Visible;
            btn5.Visibility = Visibility.Visible;
            btn6.Visibility = Visibility.Visible;
            btnMinus.Visibility = Visibility.Visible;

            btnN.Visibility = Visibility.Hidden;
            btn42.Visibility = Visibility.Hidden;
            btn52.Visibility = Visibility.Hidden;
            btn62.Visibility = Visibility.Hidden;
            btnMinus2.Visibility = Visibility.Hidden;


            btnX3.Visibility = Visibility.Visible;
            btn1.Visibility = Visibility.Visible;
            btn2.Visibility = Visibility.Visible;
            btn3.Visibility = Visibility.Visible;
            btnPlus.Visibility = Visibility.Visible;

            btnPlusMinus2.Visibility = Visibility.Hidden;
            btn12.Visibility = Visibility.Hidden;
            btn22.Visibility = Visibility.Hidden;
            btn32.Visibility = Visibility.Hidden;
            btnPlus2.Visibility = Visibility.Hidden;


            btn1X.Visibility = Visibility.Visible;
            btnPlusMinus.Visibility = Visibility.Visible;
            btn0.Visibility = Visibility.Visible;
            btnComma.Visibility = Visibility.Visible;
            btnEquals.Visibility = Visibility.Visible;

            btnSinh.Visibility = Visibility.Hidden;
            btnCosh.Visibility = Visibility.Hidden;
            btn02.Visibility = Visibility.Hidden;
            btnComma2.Visibility = Visibility.Hidden;
            btnEquals2.Visibility = Visibility.Hidden;

            //Programmer Area
            btnCE3.Visibility = Visibility.Hidden;
            btnC3.Visibility = Visibility.Hidden;
            btnBackSpase3.Visibility = Visibility.Hidden;
            btnDiv3.Visibility = Visibility.Hidden;

            btn73.Visibility = Visibility.Hidden;
            btn83.Visibility = Visibility.Hidden;
            btn93.Visibility = Visibility.Hidden;
            btnMult3.Visibility = Visibility.Hidden;

            btn43.Visibility = Visibility.Hidden;
            btn53.Visibility = Visibility.Hidden;
            btn63.Visibility = Visibility.Hidden;
            btnMinus3.Visibility = Visibility.Hidden;

            btn13.Visibility = Visibility.Hidden;
            btn23.Visibility = Visibility.Hidden;
            btn33.Visibility = Visibility.Hidden;
            btnPlus3.Visibility = Visibility.Hidden;

            btnPlusMinus3.Visibility = Visibility.Hidden;
            btn03.Visibility = Visibility.Hidden;
            btnComma3.Visibility = Visibility.Hidden;
            btnEquals3.Visibility = Visibility.Hidden;

            txtDisplayHex.Visibility = Visibility.Hidden;
            txtDisplayHexLabel.Visibility = Visibility.Hidden;
            txtDisplayDec.Visibility = Visibility.Hidden;
            txtDisplayDecLabel.Visibility = Visibility.Hidden;
            txtDisplayOct.Visibility = Visibility.Hidden;
            txtDisplayOctLabel.Visibility = Visibility.Hidden;
            txtDisplayBin.Visibility = Visibility.Hidden;
            txtDisplayBinLabel.Visibility = Visibility.Hidden;


        }

        private void BtnScientific_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            operation2 = "";
            comma = "";
            //fractional1 = 0.1;
            //fractional2 = 0.1;
            txtDisplay.Text = "0";
            bProgrammer = false;
            DisplayNumberProgrammer(0);

            btnMC2.Visibility = Visibility.Visible;
            btnMR2.Visibility = Visibility.Visible;
            btnMPlus2.Visibility = Visibility.Visible;
            btnMMinus2.Visibility = Visibility.Visible;
            btnMS2.Visibility = Visibility.Visible;

            btnX22.Visibility = Visibility.Visible;
            btnXY.Visibility = Visibility.Visible;
            btnSin.Visibility = Visibility.Visible;
            btnCos.Visibility = Visibility.Visible;
            btnTan.Visibility = Visibility.Visible;


            btnMC.Visibility = Visibility.Hidden;
            btnMR.Visibility = Visibility.Hidden;
            btnMPlus.Visibility = Visibility.Hidden;
            btnMMinus.Visibility = Visibility.Hidden;
            btnMS.Visibility = Visibility.Hidden;

            btnSqrt2.Visibility = Visibility.Visible;
            btn10X.Visibility = Visibility.Visible;
            btnLog.Visibility = Visibility.Visible;
            btnExp.Visibility = Visibility.Visible;
            btnMod.Visibility = Visibility.Visible;


            btnPercent.Visibility = Visibility.Hidden;
            btnCE.Visibility = Visibility.Hidden;
            btnC.Visibility = Visibility.Hidden;
            btnBackSpase.Visibility = Visibility.Hidden;
            btnDiv.Visibility = Visibility.Hidden;

            btnTagh.Visibility = Visibility.Visible;
            btnCE2.Visibility = Visibility.Visible;
            btnC2.Visibility = Visibility.Visible;
            btnBackSpase2.Visibility = Visibility.Visible;
            btnDiv2.Visibility = Visibility.Visible;


            btnSqrt.Visibility = Visibility.Hidden;
            btn7.Visibility = Visibility.Hidden;
            btn8.Visibility = Visibility.Hidden;
            btn9.Visibility = Visibility.Hidden;
            btnMult.Visibility = Visibility.Hidden;

            btnPI.Visibility = Visibility.Visible;
            btn72.Visibility = Visibility.Visible;
            btn82.Visibility = Visibility.Visible;
            btn92.Visibility = Visibility.Visible;
            btnMult2.Visibility = Visibility.Visible;


            btnX2.Visibility = Visibility.Hidden;
            btn4.Visibility = Visibility.Hidden;
            btn5.Visibility = Visibility.Hidden;
            btn6.Visibility = Visibility.Hidden;
            btnMinus.Visibility = Visibility.Hidden;

            btnN.Visibility = Visibility.Visible;
            btn42.Visibility = Visibility.Visible;
            btn52.Visibility = Visibility.Visible;
            btn62.Visibility = Visibility.Visible;
            btnMinus2.Visibility = Visibility.Visible;


            btnX3.Visibility = Visibility.Hidden;
            btn1.Visibility = Visibility.Hidden;
            btn2.Visibility = Visibility.Hidden;
            btn3.Visibility = Visibility.Hidden;
            btnPlus.Visibility = Visibility.Hidden;

            btnPlusMinus2.Visibility = Visibility.Visible;
            btn12.Visibility = Visibility.Visible;
            btn22.Visibility = Visibility.Visible;
            btn32.Visibility = Visibility.Visible;
            btnPlus2.Visibility = Visibility.Visible;


            btn1X.Visibility = Visibility.Hidden;
            btnPlusMinus.Visibility = Visibility.Hidden;
            btn0.Visibility = Visibility.Hidden;
            btnComma.Visibility = Visibility.Hidden;
            btnEquals.Visibility = Visibility.Hidden;

            btnSinh.Visibility = Visibility.Visible;
            btnCosh.Visibility = Visibility.Visible;
            btn02.Visibility = Visibility.Visible;
            btnComma2.Visibility = Visibility.Visible;
            btnEquals2.Visibility = Visibility.Visible;

            //Programmer Area
            btnCE3.Visibility = Visibility.Hidden;
            btnC3.Visibility = Visibility.Hidden;
            btnBackSpase3.Visibility = Visibility.Hidden;
            btnDiv3.Visibility = Visibility.Hidden;

            btn73.Visibility = Visibility.Hidden;
            btn83.Visibility = Visibility.Hidden;
            btn93.Visibility = Visibility.Hidden;
            btnMult3.Visibility = Visibility.Hidden;

            btn43.Visibility = Visibility.Hidden;
            btn53.Visibility = Visibility.Hidden;
            btn63.Visibility = Visibility.Hidden;
            btnMinus3.Visibility = Visibility.Hidden;

            btn13.Visibility = Visibility.Hidden;
            btn23.Visibility = Visibility.Hidden;
            btn33.Visibility = Visibility.Hidden;
            btnPlus3.Visibility = Visibility.Hidden;

            btnPlusMinus3.Visibility = Visibility.Hidden;
            btn03.Visibility = Visibility.Hidden;
            btnComma3.Visibility = Visibility.Hidden;
            btnEquals3.Visibility = Visibility.Hidden;

            txtDisplayHex.Visibility = Visibility.Hidden;
            txtDisplayHexLabel.Visibility = Visibility.Hidden;
            txtDisplayDec.Visibility = Visibility.Hidden;
            txtDisplayDecLabel.Visibility = Visibility.Hidden;
            txtDisplayOct.Visibility = Visibility.Hidden;
            txtDisplayOctLabel.Visibility = Visibility.Hidden;
            txtDisplayBin.Visibility = Visibility.Hidden;
            txtDisplayBinLabel.Visibility = Visibility.Hidden;

        }

        private void BtnProgrammer_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            operation2 = "";
            comma = "";
            //fractional1 = 0.1;
            //fractional2 = 0.1;
            txtDisplay.Text = "0";
            bProgrammer = true;
            DisplayNumberProgrammer(0);


            btnMC2.Visibility = Visibility.Hidden;
            btnMR2.Visibility = Visibility.Hidden;
            btnMPlus2.Visibility = Visibility.Hidden;
            btnMMinus2.Visibility = Visibility.Hidden;
            btnMS2.Visibility = Visibility.Hidden;

            btnX22.Visibility = Visibility.Hidden;
            btnXY.Visibility = Visibility.Hidden;
            btnSin.Visibility = Visibility.Hidden;
            btnCos.Visibility = Visibility.Hidden;
            btnTan.Visibility = Visibility.Hidden;


            btnMC.Visibility = Visibility.Hidden;
            btnMR.Visibility = Visibility.Hidden;
            btnMPlus.Visibility = Visibility.Hidden;
            btnMMinus.Visibility = Visibility.Hidden;
            btnMS.Visibility = Visibility.Hidden;

            btnSqrt2.Visibility = Visibility.Hidden;
            btn10X.Visibility = Visibility.Hidden;
            btnLog.Visibility = Visibility.Hidden;
            btnExp.Visibility = Visibility.Hidden;
            btnMod.Visibility = Visibility.Hidden;

            btnPercent.Visibility = Visibility.Hidden;
            btnCE.Visibility = Visibility.Hidden;
            btnC.Visibility = Visibility.Hidden;
            btnBackSpase.Visibility = Visibility.Hidden;
            btnDiv.Visibility = Visibility.Hidden;

            btnTagh.Visibility = Visibility.Hidden;
            btnCE2.Visibility = Visibility.Hidden;
            btnC2.Visibility = Visibility.Hidden;
            btnBackSpase2.Visibility = Visibility.Hidden;
            btnDiv2.Visibility = Visibility.Hidden;

            btnSqrt.Visibility = Visibility.Hidden;
            btn7.Visibility = Visibility.Hidden;
            btn8.Visibility = Visibility.Hidden;
            btn9.Visibility = Visibility.Hidden;
            btnMult.Visibility = Visibility.Hidden;

            btnPI.Visibility = Visibility.Hidden;
            btn72.Visibility = Visibility.Hidden;
            btn82.Visibility = Visibility.Hidden;
            btn92.Visibility = Visibility.Hidden;
            btnMult2.Visibility = Visibility.Hidden;

            btnX2.Visibility = Visibility.Hidden;
            btn4.Visibility = Visibility.Hidden;
            btn5.Visibility = Visibility.Hidden;
            btn6.Visibility = Visibility.Hidden;
            btnMinus.Visibility = Visibility.Hidden;

            btnN.Visibility = Visibility.Hidden;
            btn42.Visibility = Visibility.Hidden;
            btn52.Visibility = Visibility.Hidden;
            btn62.Visibility = Visibility.Hidden;
            btnMinus2.Visibility = Visibility.Hidden;


            btnX3.Visibility = Visibility.Hidden;
            btn1.Visibility = Visibility.Hidden;
            btn2.Visibility = Visibility.Hidden;
            btn3.Visibility = Visibility.Hidden;
            btnPlus.Visibility = Visibility.Hidden;

            btnPlusMinus2.Visibility = Visibility.Hidden;
            btn12.Visibility = Visibility.Hidden;
            btn22.Visibility = Visibility.Hidden;
            btn32.Visibility = Visibility.Hidden;
            btnPlus2.Visibility = Visibility.Hidden;

            btn1X.Visibility = Visibility.Hidden;
            btnPlusMinus.Visibility = Visibility.Hidden;
            btn0.Visibility = Visibility.Hidden;
            btn02.Visibility = Visibility.Hidden;
            btnComma.Visibility = Visibility.Hidden;
            btnEquals.Visibility = Visibility.Hidden;

            btnSinh.Visibility = Visibility.Hidden;
            btnCosh.Visibility = Visibility.Hidden;
            btn02.Visibility = Visibility.Hidden;
            btnComma2.Visibility = Visibility.Hidden;
            btnEquals2.Visibility = Visibility.Hidden;

            //Programmer Area
            btnCE3.Visibility = Visibility.Visible;
            btnC3.Visibility = Visibility.Visible;
            btnBackSpase3.Visibility = Visibility.Visible;
            btnDiv3.Visibility = Visibility.Visible;

            btn73.Visibility = Visibility.Visible;
            btn83.Visibility = Visibility.Visible;
            btn93.Visibility = Visibility.Visible;
            btnMult3.Visibility = Visibility.Visible;

            btn43.Visibility = Visibility.Visible;
            btn53.Visibility = Visibility.Visible;
            btn63.Visibility = Visibility.Visible;
            btnMinus3.Visibility = Visibility.Visible;

            btn13.Visibility = Visibility.Visible;
            btn23.Visibility = Visibility.Visible;
            btn33.Visibility = Visibility.Visible;
            btnPlus3.Visibility = Visibility.Visible;

            btnPlusMinus3.Visibility = Visibility.Visible;
            btn03.Visibility = Visibility.Visible;
            btnComma3.Visibility = Visibility.Visible;
            btnEquals3.Visibility = Visibility.Visible;

            txtDisplayHex.Visibility = Visibility.Visible;
            txtDisplayHexLabel.Visibility = Visibility.Visible;
            txtDisplayDec.Visibility = Visibility.Visible;
            txtDisplayDecLabel.Visibility = Visibility.Visible;
            txtDisplayOct.Visibility = Visibility.Visible;
            txtDisplayOctLabel.Visibility = Visibility.Visible;
            txtDisplayBin.Visibility = Visibility.Visible;
            txtDisplayBinLabel.Visibility = Visibility.Visible;

        }

        private void BtnMemory_Click(object sender, RoutedEventArgs e)
        {
            if (flag1)
            {
                txtMemory.Visibility = Visibility.Visible;
                flag1 = false;
            }
            else
            {
                txtMemory.Visibility = Visibility.Hidden;
                flag1 = true;
            }
        }


        //section standart
        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }

        private void BtnComma_Click(object sender, RoutedEventArgs e)
        {
            if (comma == "")
            {
                comma = ",";
                txtDisplay.Text += ",";
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer();
            else
            {
                EnterNumber();
            }
        }

        private void BtnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                txtDisplay.Text = number1.ToString();
                if (bProgrammer)
                {
                    DisplayNumberProgrammer((Int64)number1);
                }
            }
            else
            {
                number2 *= -1;
                txtDisplay.Text = number2.ToString();
                if (bProgrammer)
                {
                    DisplayNumberProgrammer((Int64)number2);
                }
            }
        }

        private void Btn1X_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (number1 == 0)
                {
                    txtDisplay.Text = "Division by zero";
                }
                else
                {
                    number1 = 1 / number1;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                number2 = 1 / number1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {

            comma = "";
            if (operation == "")
            {
                number1 = Double.Parse(txtDisplay.Text);
                number2 = 0;
                EnterOperation("+");
            }
            else
            {
                Calculate();
                EnterOperation("+");
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer(3);
            else
            {
                EnterNumber(3);
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer(2);
            else
            {
                EnterNumber(2);
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer(1);
            else
            {
                EnterNumber(1);
            }
        }

        private void BtnX3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.Pow(number1, 3);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Math.Pow(number2, 3);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            comma = "";
            if (operation == "")
            {
                number1 = Double.Parse(txtDisplay.Text);
                number2 = 0;
                EnterOperation("-");
            }
            else
            {
                Calculate();
                EnterOperation("-");
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer(6);
            else
            {
                EnterNumber(6);
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer(5);
            else
            {
                EnterNumber(5);
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer(4);
            else
            {
                EnterNumber(4);
            }
        }

        private void BtnX2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.Pow(number1, 2);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Math.Pow(number2, 2);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnMult_Click(object sender, RoutedEventArgs e)
        {
            comma = "";
            if (operation == "")
            {
                number1 = Double.Parse(txtDisplay.Text);
                number2 = 0;
                EnterOperation("*");
            }
            else
            {
                Calculate();
                EnterOperation("*");
            }

            //{
            //    if (operation == "")
            //    {
            //        operation = "*";
            //        txtDisplay.Text = "*";
            //    }
            //    else
            //    {
            //        number1 = number1 * number2;
            //        number2 = 0;
            //        txtDisplay.Text = number1.ToString();
            //    }

            //}
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer(9);
            else
            {
                EnterNumber(9);
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer(8);
            else
            {
                EnterNumber(8);
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (bProgrammer)
                EnterNumberProgrammer(7);
            else
            {
                EnterNumber(7);
            }
        }

        private void BtnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.Sqrt(number1);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Math.Sqrt(number2);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {

            comma = "";
            if (operation == "")
            {
                number1 = Double.Parse(txtDisplay.Text);
                number2 = 0;
                EnterOperation("/");
            }
            else
            {
                Calculate();
                EnterOperation("/");
            }
        }

        private void BtnBackSpase_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            bool flag = false;
            str = txtDisplay.Text;
            foreach (char c in str)
            {
                if (c == ',')
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                if (operation == "")
                {
                    number1 = (int)number1 / 10;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (int)number2 / 10;
                    txtDisplay.Text = number1.ToString();
                }
            }
            else
            {
                if (operation == "")
                {
                    int length = str.Length - 1;
                    if (str[length] == ',')
                    {
                        comma = "";
                    }
                    str = str.Remove(length);
                    txtDisplay.Text = str;
                    number1 = Convert.ToDouble(str);
                }
                else
                {
                    int length = str.Length - 1;
                    str = str.Remove(length);
                    txtDisplay.Text = str;
                    number2 = Convert.ToDouble(str);
                }
            }

        }


        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            operation2 = "";
            comma = "";
            //fractional1 = 0.1;
            //fractional2 = 0.1;
            txtDisplay.Text = "0";
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtDisplay.Text = "0";
        }

        private void BtnPercent_Click(object sender, RoutedEventArgs e)
        {
            operation2 = "%";
            txtDisplay.Text = "%";
        }

        // Memory
        private void BtnMS_Click(object sender, RoutedEventArgs e)
        {
            memory = Convert.ToDouble(txtDisplay.Text);
            txtMemory.Text = txtDisplay.Text;
            btnMR.Background = Brushes.LightGray;
            btnMR2.Background = Brushes.LightGray;
            btnMC.Background = Brushes.LightGray;
            btnMC2.Background = Brushes.LightGray;
        }

        private void BtnMMinus_Click(object sender, RoutedEventArgs e)
        {
            memory -= Convert.ToDouble(txtDisplay.Text);
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtMemory.Text = memory.ToString();
            btnMR.Background = Brushes.LightGray;
            btnMC.Background = Brushes.LightGray;
        }

        private void BtnMPlus_Click(object sender, RoutedEventArgs e)
        {
            memory += Convert.ToDouble(txtDisplay.Text);
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtMemory.Text = memory.ToString();
            btnMR.Background = Brushes.LightGray;
            btnMC.Background = Brushes.LightGray;
        }

        private void BtnMS2_Click(object sender, RoutedEventArgs e)
        {
            memory = Convert.ToDouble(txtDisplay.Text);
            txtMemory.Text = txtDisplay.Text;
            btnMR2.Background = Brushes.LightGray;
            btnMC2.Background = Brushes.LightGray;
        }

        private void BtnMMinus2_Click(object sender, RoutedEventArgs e)
        {
            memory -= Convert.ToDouble(txtDisplay.Text);
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtMemory.Text = memory.ToString();
            btnMR2.Background = Brushes.LightGray;
            btnMC2.Background = Brushes.LightGray;
        }

        private void BtnMPlus2_Click(object sender, RoutedEventArgs e)
        {
            memory += Convert.ToDouble(txtDisplay.Text);
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtMemory.Text = memory.ToString();
            btnMR2.Background = Brushes.LightGray;
            btnMC2.Background = Brushes.LightGray;
        }

        private void BtnMR_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = memory;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = memory;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnMC_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
            txtMemory.Text = "0";
        }

        // section methods
        private void EnterNumber(byte n = 0)
        {
            int allowedLength = 16;

            if (comma == "")
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + n;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + n;
                    txtDisplay.Text = number2.ToString();
                }
            }
            else
            {
                if (operation == "")
                {
                    string str = txtDisplay.Text;

                    if (str.Length < allowedLength)
                    {
                        str += n.ToString();
                    }

                    number1 = Double.Parse(str);
                    txtDisplay.Text = str;
                }
                else
                {
                    string str = txtDisplay.Text;

                    if (str.Length < allowedLength)
                    {
                        str += n.ToString();
                    }
                    number2 = Double.Parse(str);
                    txtDisplay.Text = str;
                }
            }
        }

        private void EnterNumberProgrammer(byte n = 0)
        {

            if (operation == "")
            {
                number1 = (number1 * 10) + n;
                txtDisplay.Text = number1.ToString();
                if (bProgrammer)
                {
                    DisplayNumberProgrammer((Int64)number1);
                }
            }
            else
            {
                number2 = (number2 * 10) + n;
                txtDisplay.Text = number2.ToString();
                if (bProgrammer)
                {
                    DisplayNumberProgrammer((Int64)number2);
                }
            }
        }

        private void DisplayNumberProgrammer(long num = 0)
        {

            txtDisplayHex.Text = ConvertToHex((Int64)num);
            txtDisplayDec.Text = num.ToString();
            txtDisplayOct.Text = ConvertToOct((Int64)num);
            txtDisplayBin.Text = ConvertToBin((Int64)num);
        }

        private string ConvertToBin(long n = 0)
        {

            string str = Convert.ToString(n, 2);

            return str;
        }

        private string ConvertToHex(long n = 0)
        {

            string str = Convert.ToString(n, 16);

            return str;
        }

        private string ConvertToOct(long n = 0)
        {

            string str = Convert.ToString(n, 8);

            return str;
        }

        private long ConvertToDec(string num, string system = "Bin")
        {
            long n = 0;
            if (system == "Bin")
            {
                n = Convert.ToInt64(num, 2);
            }
            else if (system == "Oct")
            {
                n = Convert.ToInt64(num, 8);
            }
            else if (system == "Hex")
            {
                n = Convert.ToInt64(num, 8);
            }

            return n;
        }

        private void EnterOperation(string s)
        {
            operation = s;
            txtDisplay.Text = s;
            if (bProgrammer)
            {
                DisplayNumberProgrammer(0);
            }
        }
        private void Calculate()
        {
            if (operation2 == "")
            {
                switch (operation)
                {
                    case "+":
                        txtDisplay.Text = (number1 + number2).ToString();
                        if (bProgrammer)
                        {
                            DisplayNumberProgrammer(Int64.Parse(txtDisplay.Text));//((Int64)(number1 + number2));
                        }
                        break;
                    case "-":
                        txtDisplay.Text = (number1 - number2).ToString();
                        if (bProgrammer)
                        {
                            DisplayNumberProgrammer(Int64.Parse(txtDisplay.Text));//((Int64)(txtDisplay.Text));
                        }
                        break;
                    case "*":
                        txtDisplay.Text = (number1 * number2).ToString();
                        number2 = 0;
                        if (bProgrammer)
                        {
                            DisplayNumberProgrammer(Int64.Parse(txtDisplay.Text));
                        }
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            //double fSize = txtDisplay.FontSize;
                            //txtDisplay.FontSize = 20;
                            txtDisplay.Text = "Division by zero is not allowed";
                            //txtDisplay.FontSize = fSize;
                        }
                        else
                        {
                            txtDisplay.Text = (number1 / number2).ToString();
                            if (bProgrammer)
                            {
                                DisplayNumberProgrammer(Int64.Parse(txtDisplay.Text));//((Int64)(number1 / number2));
                            }
                        }
                        break;
                    case "xY":
                        {
                            number1 = Math.Pow(number1, number2);
                            txtDisplay.Text = number1.ToString();
                            break;
                        }
                    case "Mod":
                        {
                            number1 = number1 % number2;
                            txtDisplay.Text = number1.ToString();
                            break;
                        }
                    case ".e+0":
                        {
                            number1 = number1 * Math.Pow(10, number2); //number2;
                            txtDisplay.Text = number1.ToString();
                            break;
                        }

                }
            }
            else if (operation2 == "%")
            {
                double res = ((double)number1 / 100) * (double)number2;
                switch (operation)
                {
                    case "+":
                        txtDisplay.Text = (number1 + res).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (number1 - res).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = res.ToString();
                        break;
                }
            }

            if (txtDisplay.Text != "Division by zero is not allowed")
            {
                number1 = Convert.ToDouble(txtDisplay.Text);
            }

            number2 = 0;
            operation = "";
            operation2 = "";
            comma = "";
        }

        // section scientific

        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {
            EnterOperation("Mod");
        }

        private void BtnExp_Click(object sender, RoutedEventArgs e)
        {
            operation = ".e+0";
            txtDisplay.Text = number1.ToString() + ".e+0";
            //txtDisplay.Text = number1.ToString() + ".e+0" + number2.ToString();
        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.Log(number1);
                number1 /= Math.Log(10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Math.Log(number2);
                number2 /= Math.Log(10);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn10X_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.Pow(10, number1);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Math.Pow(10, number2);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnTagh_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.Tanh(number1);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Math.Tanh(number2);
                txtDisplay.Text = number2.ToString();
            }

        }

        private void BtnSinh_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.Sinh(number1);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Math.Sinh(number2);
                txtDisplay.Text = number2.ToString();
            }


        }

        private void BtnCosh_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.Cosh(number1);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Math.Cosh(number2);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnPI_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.PI;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Math.PI;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnFact_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Int32.Parse(txtDisplay.Text);
                number1 = Factorial((Int32)number1);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = Factorial((Int32)number2);
                txtDisplay.Text = number2.ToString();
            }
        }

        private long Factorial(int n)
        {
            long fact;
            try
            {
                if (n == 0)
                {
                    fact = 1;
                }
                else
                {
                    fact = n * Factorial(n - 1);
                }
            }

            catch (System.StackOverflowException)
            {
                txtDisplay.Text = "Too big value";
                fact = 1;
                throw;
            }

            return fact;
        }

        private void BtnTan_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                double radian = number1 * Math.PI / 180;
                number1 = Math.Tan(radian);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                double radian = number2 * Math.PI / 180;
                number2 = Math.Tan(radian);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnCos_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                double radian = number1 * Math.PI / 180;
                number1 = Math.Cos(radian);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                double radian = number2 * Math.PI / 180;
                number2 = Math.Cos(radian);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnSin_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                double radian = number1 * Math.PI / 180;
                number1 = Math.Sin(radian);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                double radian = number2 * Math.PI / 180;
                number2 = Math.Sin(radian);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnXY_Click(object sender, RoutedEventArgs e)
        {
            operation = "xY";
            txtDisplay.Text = "xY";
        }

        private void BtnComma3_Click(object sender, RoutedEventArgs e)
        {
            //nothing to do here because will not workl on programmer tab
        }

    }
}
