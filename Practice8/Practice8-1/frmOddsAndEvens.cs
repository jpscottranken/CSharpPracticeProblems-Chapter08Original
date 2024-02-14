using System;
using System.Windows.Forms;

/*
 *      1.	Write a C# GUI program to create an 
 *          array with 100 random integers between 
 *          1 - 100. 
 *          
 *          Separate the odd and even integers 
 *          into their own arrays. Allow the user 
 *          to print the contents of either array 
 *          using an associated button.
 */

namespace Practice8_1
{
    public partial class frmOddsAndEvens : Form
    {
        //  Declare and initialize program constant
        const int SIZE = 100;

        //  Declare and initialize class variable
        int[] numbers = new int[SIZE];
        int[] odds    = new int[SIZE];
        int[] evens   = new int[SIZE];

        public frmOddsAndEvens()
        {
            InitializeComponent();
        }

        private void btnFillArray_Click(object sender, EventArgs e)
        {
            FillTheArray();
        }

        private void FillTheArray()
        {
            Random rand = new Random();

            //  "Zero out" numbers array
            numbers[SIZE - 1] = 0;

            //  Fill the numbers array
            for (int lcv = 0; lcv < SIZE; lcv++)
            {
                numbers[lcv] = rand.Next(0, 101);
            }

            //for (int lcv = 0; lcv < SIZE; lcv++)
            //{
            //    txtResults.Text += numbers[lcv].ToString() + " ";
            //}

            ShowMessage("The Array Has Been Filled", "ARRAY FILLED");
            EnableOddAndEvenButtons();
        }

        private void btnShowOddNumbers_Click(object sender, EventArgs e)
        {
            string outputStr = "";

            txtResults.Text = "";

            int count = 0;

            for (int lcv = 0; lcv < SIZE; ++lcv)
            {
                if (numbers[lcv] % 2 != 0)
                {
                    odds[count] = numbers[lcv];
                    count++;
                }
            }

            for (int lcv = 0; lcv < count; ++lcv)
            {
                outputStr += odds[lcv] + " ";
            }

            //foreach(var number in numbers)
            //{
            //    if (number % 2 != 0)
            //    {
            //        outputStr += number + " ";
            //    }
            //}

            txtResults.Text = "Here Are The Odd Numbers:\r\n" + outputStr;
        }

        private void btnShowEvenNumbers_Click(object sender, EventArgs e)
        {
            string outputStr = "";

            txtResults.Text = "";

            int count = 0;

            for (int lcv = 0; lcv < SIZE; ++lcv)
            {
                if (numbers[lcv] % 2 == 0)
                {
                    evens[count] = numbers[lcv];
                    count++;
                }
            }

            for (int lcv = 0; lcv < count; ++lcv)
            {
                outputStr += evens[lcv] + " ";
            }

            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        outputStr += number + " ";
            //    }
            //}

            txtResults.Text = "Here Are The Even Numbers:\r\n" + outputStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void frmOddsAndEvens_Load(object sender, EventArgs e)
        {
            DisableOddAndEvenButtons();
        }

        private void DisableOddAndEvenButtons()
        {
            btnShowOddNumbers.Enabled  = false;
            btnShowEvenNumbers.Enabled = false;
        }

        private void EnableOddAndEvenButtons()
        {
            btnShowOddNumbers.Enabled  = true;
            btnShowEvenNumbers.Enabled = true;
        }
    }
}
