using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public double num1;
        public double num2;
        public int operation = 0;
        public int a = 0;// shows if a button of +,-,/,* or sqrt was clicked
        public int c = 0;// shows the previous button clicked
        public int f=0;//for checking if M+ button was clicked before
        public int d = 0;//for checking if M- button was clicked before
        public bool WasClicked = false;// for checking if a equall button was clicked
        public double memoryValue1 = 0;
        public double memoryValue2 = 0;
        public int c1 = 0;//indicates if M+ or M- is clicked 


        public Form1()
        {
            InitializeComponent();
        }
        private void EquallClick()
        {
            if (WasClicked &&f==0&&d==0)
            {
                ResultLable.Text = "";
                
            }else if(!WasClicked && (f != 0 || d != 0))
            {
                ResultLable.Text = "";
            }
        }
        private void Number1_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "1";
                    
                }
                else
                {
                    InputLable1.Text = "1";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "1";
            }
            EquallClick();
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "2";

                }
                else
                {
                    InputLable1.Text = "2";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "2";
            }
            EquallClick();

        }

        private void Number3_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "3";

                }
                else
                {
                    InputLable1.Text = "3";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "3";

            }
            EquallClick();
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "0";

                }
                else
                {
                    InputLable1.Text = "0";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "0";
            }
            EquallClick();
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "4";

                }
                else
                {
                    InputLable1.Text = "4";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "4";
            }
            EquallClick();
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "5";

                }
                else
                {
                    InputLable1.Text = "5";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "5";
            }
            EquallClick();
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "6";

                }
                else
                {
                    InputLable1.Text = "6";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "6";
            }
            EquallClick();
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "7";

                }
                else
                {
                    InputLable1.Text = "7";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "7";
            }
            EquallClick();
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "8";

                }
                else
                {
                    InputLable1.Text = "8";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "8";
            }
            EquallClick();
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text != "0")
                {
                    InputLable1.Text = InputLable1.Text + "9";

                }
                else
                {
                    InputLable1.Text = "9";

                }
            }
            else
            {
                InputLable2.Text = InputLable2.Text + "9";
            }
            EquallClick();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            operation = 1;
            a++;
            Operations(operation);

        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            operation = 2;
            a++;
            Operations(operation);
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            operation = 3;
            a++;
            Operations(operation);
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            operation = 4;
            a++;
            Operations(operation);
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            operation = 5;
            a++;
            Operations(operation);

        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!(InputLable1.Text.Contains(","))&& a==0)
            {
                InputLable1.Text = InputLable1.Text + ",";
            }
            else if(!(InputLable2.Text.Contains(",")))
            {
                InputLable2.Text = InputLable2.Text + ",";
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
           
                InputLable1.Text = "0";
                InputLable2.Text = "";
                SymbolLable.Text = "";
                  a = 0;
            c = 0;
                ResultLable.Text = "";
            
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                if (InputLable1.Text.Length - 1 > 0)
                {
                    InputLable1.Text = InputLable1.Text.Remove(InputLable1.Text.Length - 1, 1);
                }
                else
                {
                    InputLable1.Text = "0";
                }
            }
            else
            {
                if (InputLable2.Text.Length - 1 > 0)
                {
                    InputLable2.Text = InputLable2.Text.Remove(InputLable2.Text.Length - 1, 1);
                }
                else
                {
                    InputLable2.Text = "";
                }
            }
            
        }

        private void Operations(int o)
        {
            switch (o)
            {
                case 1: {
                        SymbolLable.Text = "+";
                        
                        if (a == 1)
                        {
                             num1 = double.Parse(InputLable1.Text);
                            if (WasClicked == true)
                            {
                                ResultLable.Text = "";
                                WasClicked = false;
                            }
                            c = 1;
                        }
                        else
                        {
                            if (c != 5)
                            {

                                num2 = double.Parse(InputLable2.Text);
                            }
                            
                            
                            
                        }
                        if (c==1 )
                        {
                            num1 = num1 + num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                        }else if (c == 2)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 - num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 1;
                        }
                        else if (c == 3)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 * num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 1;
                        }
                        else if (c == 4)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            if (num2 != 0)
                            {
                                num1 = num1 / num2;
                                InputLable1.Text = num1.ToString();
                                InputLable2.Text = "";
                            }
                            else
                            {
                                ResultLable.Text = "No division by 0";
                                InputLable1.Text = "0";
                                a = 0;
                                InputLable2.Text = "";
                                SymbolLable.Text = "";
                            }

                            c = 1;
                        }
                        else if (c == 5)
                        {
                           
                            
                            c = 1;
                        }


                        break; }
                case 2: {
                        SymbolLable.Text = "-";
                        if (a == 1)
                        {
                            num1 = double.Parse(InputLable1.Text);
                            c = 2;
                        }
                        else 
                        {

                            if (c != 5)
                            {

                                num2 = double.Parse(InputLable2.Text);
                            }

                        }
                        if ( c==2)
                        {
                            num1 = num1 - num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                        }else if(c==1)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 + num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 2;
                        }
                        else if (c == 3)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 *num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 2;
                        }
                        else if (c == 4)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            if (num2 != 0)
                            {
                                num1 = num1 / num2;
                                InputLable1.Text = num1.ToString();
                                InputLable2.Text = "";
                            }
                            else
                            {
                                ResultLable.Text = "No division by 0";
                                InputLable1.Text = "0";
                                a = 0;
                                InputLable2.Text = "";
                                SymbolLable.Text = "";
                            }
                            
                            c = 2;
                        }
                        else if (c == 5)
                        {
                            
                            c = 2;
                        }


                        break; }
                case 3: {
                        SymbolLable.Text = "*";
                        if (a == 1)
                        {
                            num1 = double.Parse(InputLable1.Text);
                            c = 3;
                            num2 = 1;
                        }
                        else
                        {

                            if (c != 5)
                            {

                                num2 = double.Parse(InputLable2.Text);
                            }

                        }
                        if (c==3)
                        {
                            num1 = num1 * num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                        }
                        else if (c == 1)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 + num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 3;
                        }
                        else if (c == 2)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 - num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 3;
                        }
                        
                        else if (c == 4)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            if (num2 != 0)
                            {
                                num1 = num1 / num2;
                                InputLable1.Text = num1.ToString();
                                InputLable2.Text = "";
                            }
                            else
                            {
                                ResultLable.Text = "No division by 0";
                                InputLable1.Text = "0";
                                a = 0;
                                InputLable2.Text = "";
                                SymbolLable.Text = "";
                            }

                            c = 3;
                        }
                        else if (c == 5)
                        {
                            
                            c = 3;
                        }

                        break; }
                case 4: {
                        SymbolLable.Text = "÷";
                        if (a == 1)
                        {
                            num1 = double.Parse(InputLable1.Text);
                            c = 4;
                            num2 = 1;
                        }
                        else
                        {

                            if (c != 5)
                            {

                                num2 = double.Parse(InputLable2.Text);
                            }

                        }
                        if (c==4)
                        {
                            if (num2 != 0)
                            {
                                num1 = num1 / num2;
                                InputLable1.Text = num1.ToString();
                                InputLable2.Text = "";
                            }
                            else
                            {
                                ResultLable.Text = "No division by 0";
                                InputLable1.Text = "0";
                                a = 0;
                                InputLable2.Text = "";
                                SymbolLable.Text = "";
                            }
                            
                        }
                        else if (c == 1)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 + num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 4;
                        }
                        else if (c == 2)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 - num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 4;
                        }
                        else if (c == 3)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 * num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 4;
                        }
                      
                        else if (c == 5)
                        {
                            
                            c = 4;
                        }


                        break; }
                case 5: {
                        SymbolLable.Text = "√";
                        if (c == 0)
                        {
                            c = 5;
                        }
                        num1 = double.Parse(InputLable1.Text);
                       
                       
                        if (c == 2)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 - num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 5;
                        }
                        else if (c == 1)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 + num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 5;
                        }
                        else if (c == 3)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            num1 = num1 * num2;
                            InputLable1.Text = num1.ToString();
                            InputLable2.Text = "";
                            c = 5;
                        }
                        else if (c == 4)
                        {
                            num2 = double.Parse(InputLable2.Text);
                            if (num2 != 0)
                            {
                                num1 = num1 / num2;
                                InputLable1.Text = num1.ToString();
                                InputLable2.Text = "";
                            }
                            else
                            {
                                ResultLable.Text = "No division by 0";
                                InputLable1.Text = "0";
                                a = 0;
                                InputLable2.Text = "";
                                SymbolLable.Text = "";
                            }

                            c = 5;
                        }
                        else if (c == 5)
                        {
                            if (num1 >= 0)
                            {
                                num1 = Math.Sqrt(num1);
                                InputLable1.Text = num1.ToString();
                                InputLable2.Text = "";
                            }
                            else
                            {
                                ResultLable.Text = "It's a negative number";
                                InputLable1.Text = "0";
                                a = 0;
                                InputLable2.Text = "";
                                SymbolLable.Text = "";
                            }

                           
                        }

                        break; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SymbolLable.Text = "";
            InputLable2.Text = "";
            ResultLable.Text = "";
            MemoryLable.Text = "";
        }

        private void EquallsButton_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 1:
                    {
                   
                            num2 = double.Parse(InputLable2.Text);
                            ResultLable.Text = (num1 + num2).ToString();
                       
                        break;
                    }
                case 2:
                    {

                        num2 = double.Parse(InputLable2.Text);
                        ResultLable.Text = (num1 - num2).ToString();

                        break;
                    }
                case 3:
                    {

                        num2 = double.Parse(InputLable2.Text);
                        ResultLable.Text = (num1 * num2).ToString();

                        break;
                    }
                case 4:
                    {

                        num2 = double.Parse(InputLable2.Text);
                        if (num2 != 0)
                        {
                            ResultLable.Text = (num1 / num2).ToString();
                        }
                        else
                        {
                            ResultLable.Text = "No division by 0";
                        }
                        

                        break;
                    }
                case 5:
                    {
                        if (num1 >= 0)
                        {
                            num1 = Math.Sqrt(num1);
                            ResultLable.Text = (num1).ToString();
                        }
                        else
                        {
                            InputLable1.Text = "It's negative number";
                        }
                          
                        break;
                    }


            }
            a = 0;
            c = 0;
            WasClicked = true;
            InputLable1.Text = "0";
            num1 = 0;
            num2 = 0;
            InputLable2.Text = "";
            SymbolLable.Text = "";
        }

        private void MPlusButton_Click(object sender, EventArgs e)
        {
            MCButton.Enabled = true;
            MRButton.Enabled = true;
            c1 = 1;
            MButtonClicked(1);
            f++;

        }

        private void MButtonClicked(int m)
        {
            switch (m)
            {
                case 1:
                    {
                       
                            if (a == 0 && !WasClicked)
                            {

                               
                            if (f > 0)
                            {
                                memoryValue2 = double.Parse(InputLable1.Text);
                                memoryValue1 += memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                            }
                            else if (d == 0)
                            {

                                memoryValue1 = double.Parse(InputLable1.Text);
                                MemoryLable.Text = memoryValue1.ToString();
                            }
                            else if (d > 0)
                            {
                                memoryValue2 = double.Parse(InputLable1.Text);
                                memoryValue1 -= memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                                d = 0;
                            }


                        }
                            else if (f == 0 && !WasClicked)
                            {
                            if (d == 0)
                            {
                                MemoryLable.Text = InputLable2.Text;
                                memoryValue1 = double.Parse(MemoryLable.Text);
                            }
                            else
                            {
                                memoryValue2 = -double.Parse(InputLable2.Text);
                                memoryValue1 -= memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                                d = 0;
                            }
                                
                            }
                            else if (!WasClicked)
                            {
                            if (d == 0)
                            {
                                memoryValue2 = double.Parse(InputLable2.Text);
                                memoryValue1 += memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                            }
                            else
                            {
                                memoryValue2 = double.Parse(InputLable2.Text);
                                memoryValue1 -= memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                                d = 0;
                            }
                                
                            }
                            if (WasClicked)
                            {
                                if (f == 0 && d==0)
                                {
                                if (!ResultLable.Text.Contains("N"))
                                {
                                    MemoryLable.Text = ResultLable.Text;
                                    memoryValue1 = double.Parse(MemoryLable.Text);

                                }
                                
                                
                                }
                                else if(d == 0)
                                {
                                if (!ResultLable.Text.Contains("N"))
                                {
                                    memoryValue2 = double.Parse(ResultLable.Text);
                                    memoryValue1 += memoryValue2;
                                    MemoryLable.Text = memoryValue1.ToString();
                                }
                                       
                                }
                            else
                            {
                                memoryValue2 = -double.Parse(ResultLable.Text);
                                memoryValue1 -= memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                            }
                            WasClicked = false;
                        }

                        break; }
                case 2: {
                       
                            if (a == 0 && !WasClicked)
                            {

                                if (d > 0)
                                {
                                    memoryValue2 = double.Parse(InputLable1.Text);
                                    memoryValue1 -= memoryValue2;
                                    MemoryLable.Text = memoryValue1.ToString();
                                }
                                else if(f==0)
                                {
                                    
                                    memoryValue1 = -double.Parse(InputLable1.Text);
                                    MemoryLable.Text = memoryValue1.ToString();
                                }
                                else if (f>0)
                                {
                                    memoryValue2 = double.Parse(InputLable1.Text);
                                    memoryValue1 -= memoryValue2;
                                    MemoryLable.Text = memoryValue1.ToString();
                                    f = 0;
                                }

                            }
                            else if (d == 0 && !WasClicked)
                            {
                             if (f == 0)
                            {
                                MemoryLable.Text = InputLable2.Text;
                                memoryValue1 = -double.Parse(MemoryLable.Text);
                            }
                            else
                            {
                                memoryValue2 = -double.Parse(InputLable2.Text);
                                memoryValue1 += memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                                f = 0;
                            }
                            
                            }
                            else if (!WasClicked)
                            {
                            if (f == 0)
                            {
                                memoryValue2 = double.Parse(InputLable2.Text);
                                memoryValue1 -= memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                            }
                            else
                            {
                                memoryValue2 = double.Parse(InputLable2.Text);
                                memoryValue1 += memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                                f = 0;
                            }
                            
                            }
                            if (WasClicked)
                            {
                            if (f == 0 && d == 0)
                            {
                                if (!ResultLable.Text.Contains("N"))
                                {
                                    memoryValue1 = -double.Parse(InputLable1.Text);
                                    MemoryLable.Text = memoryValue1.ToString();
                                    
                                }


                            }
                            else if (f == 0)
                            {
                                if (!ResultLable.Text.Contains("N"))
                                {
                                    memoryValue2 = double.Parse(ResultLable.Text);
                                    memoryValue1 -= memoryValue2;
                                    MemoryLable.Text = memoryValue1.ToString();
                                }

                            }
                            else
                            {
                                memoryValue2 = double.Parse(ResultLable.Text);
                                memoryValue1 -= memoryValue2;
                                MemoryLable.Text = memoryValue1.ToString();
                            }
                            
                            
                            WasClicked = false;
                        }
                        
                        
                        break;
                    }
            }
        }
        private void MminusButton_Click(object sender, EventArgs e)
        {
            MCButton.Enabled = true;
            MRButton.Enabled = true;
            c1 = 2;
            MButtonClicked(2);
            d++;
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            MCButton.Enabled = false;
            MRButton.Enabled = false;
            MemoryLable.Text = "There is nothing in the memory.";
            memoryValue1 = 0;
            memoryValue2 = 0;
            f = 0;
            d = 0;
            c1 = 0;
        }

        private void MRButton_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                InputLable1.Text = MemoryLable.Text;
                num1 = double.Parse(InputLable1.Text);
            }
            else
            {
                InputLable2.Text = MemoryLable.Text;
                num2 = double.Parse(InputLable2.Text);
            }
        }
    }
}
