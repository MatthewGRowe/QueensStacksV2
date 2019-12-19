using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //To enable brief pause

namespace Queens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int lineNum = 0;    //Needs to be reset when the user click play, starts on zero as that's what computers do
        
        bool isOn;         //Used when turning off or on the highlight
        int timerFlash;  //Starts at zero works up to 3
        private void BtnPush_Click(object sender, EventArgs e)
        {

            string input = Microsoft.VisualBasic.Interaction.InputBox("What value would you like to push onto the stack?", "PUSH", "0", 0, 0);
            bool inputIsInt = false;  //Check value is an int

            do
            {
                try
                {
                    int value = Convert.ToInt32(input);
                    lstCode.Items.Add(lineNum + ". PUSH " + value);
                    lineNum++;
                    inputIsInt = true;
                }
                catch
                {
                    input = Microsoft.VisualBasic.Interaction.InputBox("What value would you like to push onto the stack?", "MUST BE AN INTEGER!", "0", 0, 0);
                }
            }
            while (!inputIsInt);


            /* This code will add the value to the stack, it will be needed later 
            Label label = new Label();
            //Get the value to push
            label.Text = Microsoft.VisualBasic.Interaction.InputBox("What value would you like to push onto the stack?", "PUSH", "0", 0, 0);
            label.Click += new EventHandler(label_Click);
            label.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label);
            label.BringToFront();
            */

        }

        //Will remove the label if you click on it.
        void label_Click(object sender, EventArgs e)
        {
            ((Label)sender).Click -= new EventHandler(label_Click);
            ((Label)sender).Dispose();
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            //Checking stack is empty etc. does not need to happen here, it will happen when the code is run (using the play button)
            lstCode.Items.Add(lineNum + ". POP");
            lineNum++;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Checking the stack has 2 values to add will not happen here, it will happen when the code is run (using the play button)
            lstCode.Items.Add(lineNum + ". ADD");
            lineNum++;
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            //Checking the stack has 2 values to multiply will not happen here, it will happen when the code is run (using the play button)
            lstCode.Items.Add(lineNum + ". MULT");
            lineNum++;
        }

        private void BtnDup_Click(object sender, EventArgs e)
        {
            //Checking the stack has a value to duplicate will not happen here, it will happen when the code is run (using the play button)
            lstCode.Items.Add(lineNum + ". DUP");
            lineNum++;
        }

        private void BtnBRNZ_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("What line number would you like to branch to?", "BRNZ", "0", 0, 0);
            bool inputIsInt = false;  //Check value is an int

            do
            {
                try
                {
                    int value = Convert.ToInt32(input);
                    lstCode.Items.Add(lineNum + ". BRNZ " + value);
                    lineNum++;
                    inputIsInt = true;
                }
                catch
                {
                    input = Microsoft.VisualBasic.Interaction.InputBox("What line number would you like to branch to?", "MUST BE AN INTEGER!", "0", 0, 0);
                }
            }
            while (!inputIsInt);
        }

        private void BrnBeep_Click(object sender, EventArgs e)
        {

            lstCode.Items.Add(lineNum + ". BEEP");
            lineNum++;
        }

        private void BtnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (lstCode.SelectedIndex >= 0)  //Have we selected a valid line?
            {
                //Delete that line.
                lstCode.Items.RemoveAt(lstCode.SelectedIndex);

                string[] numberedCode = new string[lstCode.Items.Count];  //Store all of our instructions
                List<string> notNumberedCode = new List<string>();  //Store all of our instructions

                //Re-draw the instructions with the correct line number

                //Copy all items to an array
                for (int i = 0; i < lstCode.Items.Count; i++)
                {
                    numberedCode[i] = lstCode.Items[i].ToString();
                }

                //Remove the numbers
                for (int i = 0; i < lstCode.Items.Count; i++)
                {
                    string myString = lstCode.Items[i].ToString();
                    string resultString = myString.IndexOf(' ') > -1 ? myString.Substring(myString.IndexOf(' ') + 1) : myString;
                    notNumberedCode.Add(resultString);
                }

                //Clear the listbox
                lstCode.Items.Clear();

                //Push the items back in
                for (int i = 0; i < notNumberedCode.Count; i++)
                {
                    lstCode.Items.Add(i + ". " + notNumberedCode[i]);
                }

            }



        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            //Clear all items from the instruction register
            lstCode.Items.Clear();
            lineNum = 0;
            //Clear all items from the stack
            lstStack.Items.Clear();
        }

        private void PlayCodeFromLine(int lineNum)
        {
            for (int i = lineNum; i < lstCode.Items.Count; i++)  //Count through all of the lines
            {
                string command = lstCode.Items[i].ToString().Split(' ')[1];
                lstCode.SelectedIndex = i; //.SelectedItem = 0;  //Highlight the item we are actioning
                SR(800);  //Sleep for 1/2 secon


                if (command == "ADD")
                {
                    Add();  //No arguments required
                }
                else if (command == "MULT")
                {
                    Mult();  //No arguments required
                }
                else if (command == "PUSH")
                {
                    Push(Convert.ToInt32(lstCode.Items[i].ToString().Split(' ')[2])); //Send value
                }
                else if (command == "POP")
                {
                    Pop(); //No arguments required
                }
                else if (command == "DUP")
                {
                    Dup(); //No arguments required
                }
                else if (command == "BRNZ")
                {
                    BRNZ(Convert.ToInt32(lstCode.Items[i].ToString().Split(' ')[2])); //Line number required
                }
                else if (command == "BEEP")
                {
                    Beep(); //No arguments required
                }
                else //Command is not recognized
                {
                    Crash("Command not recognized");
                }



            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

            PlayCodeFromLine(0); //Play all the code initially
            
     
        }

        private void Beep()
        {
            Console.Beep();
        }

        private void Crash(string error)
        {
            MessageBox.Show(error, "CRASH", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BRNZ(int lineNum)
        {
            decimal testNum = Convert.ToDecimal(lstStack.Items[0]); //Read item from top of stack
            Pop(); //Pop item from top of stack

            if (testNum != 0)
            {
                MessageBox.Show("Adding Branch code from line " + lineNum + " to end");
                SR(1000);
                PlayCodeFromLine(lineNum);
            }
            


        }

        private void Dup()
        {
            //check stack is not empty
            if (lstStack.Items.Count > 0)
            {
                string value = lstStack.Items[0].ToString();  //Top of stack is zero
                lstStack.Items.Insert(0, value);  //Assign at zero to push everything downwards.
                SR();  //Sleep/Refresh
            }
            else
            {
                Crash("DUP, You cannot duplicate as you have an empty stack");
            }

        }

        private void Pop()
        {
            if (lstStack.Items.Count >0)
            {
                string value = lstStack.Items[0].ToString();  //Top of stack is zero
                lstStack.Items.RemoveAt(0);
                MessageBox.Show("Removed " + value + " from top of stack.", "POP");
                lstStack.Refresh();  //Update the screen
            }
            else
            {
                Crash("Stack is empty, cannot pop from empty stack");
            }
        }

        private void Push(int value)
        {
            lstStack.Items.Insert(0, value);  //Assign at zero to push everything downwards.
            lstStack.Refresh();  //Update the screen
        }

        private void Mult()
        {
            if (lstStack.Items.Count>1) //Do we have at least 2 things in the stack?
            {
                int value1 = Convert.ToInt32(lstStack.Items[0]);
                lstStack.Items.RemoveAt(0);
                SR(200);  //Sleep/Refresh
                int value2 = Convert.ToInt32(lstStack.Items[0]);
                lstStack.Items.RemoveAt(0);
                SR(200); //Sleep/Refresh
                MessageBox.Show("Mult " + value1 + " x " + value2);
                lstStack.Items.Insert(0, value1 * value2);  //Add value to top of the stack
                SR(); //Sleep/Refresh
            }
            else
            {
                Crash("MULT error, You do not have enough items in your stack");
            }
        }

        private void Add()
        {
            if (lstStack.Items.Count > 1) //Do we have at least 2 things in the stack?
            {
                int value1 = Convert.ToInt32(lstStack.Items[0]);
                lstStack.Items.RemoveAt(0);
                SR(200);  //Sleep/Refresh
                int value2 = Convert.ToInt32(lstStack.Items[0]);
                lstStack.Items.RemoveAt(0);
                SR(200); //Sleep/Refresh
                MessageBox.Show("ADD " + value1 + " + " + value2);
                lstStack.Items.Insert(0, value1 + value2);  //Add value to top of the stack
                SR(); //Sleep/Refresh
            }
            else
            {
                Crash("MULT error, You do not have enough items in your stack");
            }
        }

       

        

        private void SR()
        {
            //Sleep and refresh for default 500ms
            Thread.Sleep(500);
            lstStack.Refresh();
            lstCode.Refresh();
        }

        private void SR(int sleepTime)
        {
            //Sleep and refresh for set time
            Thread.Sleep(sleepTime);
            lstStack.Refresh();
            lstCode.Refresh();
        }

        
    }

    

}
