using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

/*
 *      3.	Analyze some text to count the f
 *          requency of each letter (a - z) in 
 *          it. 
 *          
 *          Write a GUI C# GUI program that 
 *          takes the string input and stores
 *          each letter in the string in an array. 	
 *          
 *          Count the frequency of each letter 
 *          and display the results. 
 *          
 *          Note: Use the String.Split() method here.
 */

namespace Practice8_3
{
    public partial class frmLetterCounter : Form
    {
        //  Declare and initialize program constant
        const int SIZE = 26;

        //  Declare and initailize class variables
        //string[] phrase = new string[1000];
        int[] numEachLetter = new int[SIZE];

        public frmLetterCounter()
        {
            InitializeComponent();
        }

        private void btnLetterSearch_Click(object sender, EventArgs e)
        {
            ValidateTextBoxIsNotEmpty();
        }

        private void ValidateTextBoxIsNotEmpty()
        {
            string input = txtResults.Text.Trim();

            if (input == "")
            {
                ShowErrorMessage("You Must Input Some Text In The Box",
                                 "TEXTBOX LEFT EMPTY");
                txtResults.Focus();
                return;
            }

            PerformLetterSearchCount();
        }

        private void PerformLetterSearchCount()
        {
            string input = txtResults.Text.Trim(); 
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            int eCount = 0;
            int fCount = 0;
            int gCount = 0;
            int hCount = 0;
            int iCount = 0;
            int jCount = 0;
            int kCount = 0;
            int lCount = 0;
            int mCount = 0;
            int nCount = 0;
            int oCount = 0;
            int pCount = 0;
            int qCount = 0;
            int rCount = 0;
            int sCount = 0;
            int tCount = 0;
            int uCount = 0;
            int vCount = 0;
            int wCount = 0;
            int xCount = 0;
            int yCount = 0;
            int zCount = 0;

            //var phrase = input.ToLower();

            char[] phrase = input.ToCharArray();

            for (int lcv = 0; lcv < phrase.Length; lcv++)
            {
                switch(phrase[lcv])
                {
                    case 'a':
                        ++aCount;
                        break;

                    case 'b':
                        ++bCount;
                        break;

                    case 'c':
                        ++cCount;
                        break;

                    case 'd':
                        ++dCount;
                        break;

                    case 'e':
                        ++eCount;
                        break;

                    case 'f':
                        ++fCount;
                        break;

                    case 'g':
                        ++gCount;
                        break;

                    case 'h':
                        ++hCount;
                        break;

                    case 'i':
                        ++iCount;
                        break;

                    case 'j':
                        ++jCount;
                        break;

                    case 'k':
                        ++kCount;
                        break;

                    case 'l':
                        ++lCount;
                        break;

                    case 'm':
                        ++mCount;
                        break;

                    case 'n':
                        ++nCount;
                        break;

                    case 'o':
                        ++oCount;
                        break;

                    case 'p':
                        ++pCount;
                        break;

                    case 'q':
                        ++qCount;
                        break;

                    case 'r':
                        ++rCount;
                        break;

                    case 's':
                        ++sCount;
                        break;

                    case 't':
                        ++tCount;
                        break;

                    case 'u':
                        ++uCount;
                        break;

                    case 'v':
                        ++vCount;
                        break;

                    case 'w':
                        ++wCount;
                        break;

                    case 'x':
                        ++xCount;
                        break;

                    case 'y':
                        ++yCount;
                        break;

                    case 'z':
                        ++zCount;
                        break;

                    default:
                        break;
                }

            }

            DisplayLetterCount(aCount, bCount, cCount, dCount, eCount, fCount,
                               gCount, hCount, iCount, jCount, kCount, lCount,
                               mCount, nCount, oCount, pCount, qCount, rCount,
                               sCount, tCount, uCount, vCount, wCount, xCount,
            yCount, zCount);
        }
        private void DisplayLetterCount(int a, int b, int c, int d, int e,
                                        int f, int g, int h, int i, int j,
                                        int k, int l, int m, int n, int o,
                                        int p, int q, int r, int s, int t,
                                        int u, int v, int w, int x, int y, int z)
        {
            ClearForm();

            string outputStr = "";

            outputStr += ($"a - {a}\r\t");
            outputStr += ($"b - {b}\r\t");
            outputStr += ($"c - {c}\r\t");
            outputStr += ($"d - {d}\r\t");
            outputStr += ($"e - {e}\r\t");
            outputStr += ($"f - {f}\r\t\r\n");
            outputStr += ($"g - {g}\r\t");
            outputStr += ($"h - {h}\r\t");
            outputStr += ($"i - {i}\r\t");
            outputStr += ($"j - {j}\r\t");
            outputStr += ($"k - {k}\r\t");
            outputStr += ($"l - {l}\r\t\r\n");
            outputStr += ($"m - {m}\r\t");
            outputStr += ($"n - {n}\r\t");
            outputStr += ($"o - {o}\r\t");
            outputStr += ($"p - {p}\r\t");
            outputStr += ($"q - {q}\r\t");
            outputStr += ($"r - {r}\r\t\r\n");
            outputStr += ($"s - {s}\r\t");
            outputStr += ($"t - {t}\r\t");
            outputStr += ($"u - {u}\r\t");
            outputStr += ($"v - {v}\r\t");
            outputStr += ($"w - {w}\r\t");
            outputStr += ($"x - {x}\r\t\r\n");
            outputStr += ($"y - {y}\r\t");
            outputStr += ($"z - {z}\r\t");

            txtResults.Text = outputStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
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

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
