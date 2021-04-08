using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compiler
{
    public partial class Form1 : Form
    {
        string text = "";
        enum tokenType
        {
            T_Identifer, T_Number, T_String, T_LeftParen, T_RightParen, T_OpenBrace, T_CloseBrace, T_Int,
            T_Float, T_Plus, T_Minus, T_Divide, T_Assign, T_Less, T_Greter, T_SemiColon, T_Repeat
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            richTextBox1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string splittedText = richTextBox1.Text;
            int index = 0;
            string Identifier;
            LinkedList<String> tokenList = new LinkedList<String>();
            LinkedList<String> lexemeList = new LinkedList<String>();



            while (index < splittedText.Length)
            {

                if (Char.IsLetter(splittedText, index))
                {
                    Identifier = "";


                    while (Char.IsLetter(splittedText, index) || Char.IsDigit(splittedText, index))
                    {
                        Identifier += splittedText[index];
                        index++;

                        if (index == splittedText.Length)
                            break;

                    }


                    lexemeList.AddLast(Identifier);
                    tokenList.AddLast(tokenType.T_Identifer + "");


                }

                else index++;


            }


            while (lexemeList.Count > 0)
            {
                text += lexemeList.First.Value;
                text += "\t";
                text += tokenList.First.Value;
                text += "\n";
                tokenList.RemoveFirst();
                lexemeList.RemoveFirst();

            }


            richTextBox1.Text = text;
        }
    }
}
