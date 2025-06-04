using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProject
{


    public class EvaluateString
    {
        public static int evaluate(string expression)
        {
            char[] tokens = expression.ToCharArray();

            // Stack for numbers: 'values' 
            Stack<int> values = new Stack<int>();

            // Stack for Operators: 'ops' 
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < tokens.Length; i++)
            {
                // Current token is a whitespace, skip it 
                if (tokens[i] == ' ')
                {
                    continue;
                }

                // Current token is a number, 
                // push it to stack for numbers 
                if (tokens[i] >= '0' && tokens[i] <= '9')
                {
                    StringBuilder sbuf = new StringBuilder();

                    // There may be more than 
                    // one digits in number 
                    while (i < tokens.Length &&
                            tokens[i] >= '0' &&
                                tokens[i] <= '9')
                    {
                        sbuf.Append(tokens[i++]);
                    }
                    values.Push(int.Parse(sbuf.ToString()));

                    // Right now the i points to 
                    // the character next to the digit,
                    // since the for loop also increases 
                    // the i, we would skip one 
                    //  token position; we need to 
                    // decrease the value of i by 1 to
                    // correct the offset.
                    i--;
                }

                // Current token is an opening 
                // brace, push it to 'ops' 
                else if (tokens[i] == '(')
                {
                    ops.Push(tokens[i]);
                }

                // Closing brace encountered, 
                // solve entire brace 
                else if (tokens[i] == ')')
                {
                    while (ops.Peek() != '(')
                    {
                        values.Push(applyOp(ops.Pop(),
                                         values.Pop(),
                                        values.Pop()));
                    }
                    ops.Pop();
                }

                // Current token is an operator. 
                else if (tokens[i] == '+' ||
                         tokens[i] == '-' ||
                         tokens[i] == '×' ||
                         tokens[i] == '÷')
                {

                    // While top of 'ops' has same 
                    // or greater precedence to current 
                    // token, which is an operator. 
                    // Apply operator on top of 'ops' 
                    // to top two elements in values stack 
                    while (ops.Count > 0 &&
                             hasPrecedence(tokens[i],
                                         ops.Peek()))
                    {
                        values.Push(applyOp(ops.Pop(),
                                         values.Pop(),
                                       values.Pop()));
                    }

                    // Push current token to 'ops'. 
                    ops.Push(tokens[i]);
                }
            }

            // Entire expression has been 
            // parsed at this point, apply remaining 
            // ops to remaining values 
            while (ops.Count > 0)
            {
                values.Push(applyOp(ops.Pop(),
                                 values.Pop(),
                                values.Pop()));
            }

            // Top of 'values' contains 
            // result, return it 
            return values.Pop();
        }

        // Returns true if 'op2' has 
        // higher or same precedence as 'op1', 
        // otherwise returns false. 
        public static bool hasPrecedence(char op1,
                                         char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }
            if ((op1 == '×' || op1 == '÷') &&
                   (op2 == '+' || op2 == '-'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // A utility method to apply an 
        // operator 'op' on operands 'a'  
        // and 'b'. Return the result. 
        public static int applyOp(char op,
                                int b, int a)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '×':
                    return a * b;
                case '÷':
                    if (b == 0)
                    {
                        throw new
                        System.NotSupportedException(
                               "Cannot divide by zero");
                    }
                    return a / b;
            }
            return 0;
        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int OpClDiff()
        {
            int ans = 0;
            foreach(char ch in textBox1.Text)
            {
                if (ch == '(') ans++;
                else if (ch == ')') ans--;
            }
            return ans;
        }

        private bool ValidityCheckonTextBox(char ch)
        {
            if(ch=='(')
            {
                if (textBox1.Text.Length == 0 || isOperator(textBox1.Text.Last())) return true;
                return false;
            }
            if(ch==')')
            {
                if(OpClDiff()<1) return false;
                if(textBox1.Text.Length==0 || textBox1.Text.Last()=='(' || isOperator(textBox1.Text.Last())) return false;
                return true;
            }
            if(textBox1.Text.Length == 0 || textBox1.Text.Last() == '(')
            {
                if (isNumber(ch) || ch == '-' || ch=='(') return true;
                return false;
            }
            if(isOperator(textBox1.Text.Last()) && isOperator(ch)) 
            {
                return false;
            }
            return true;
        }

        private void AddToTextBox(char ch)
        {
            
            if(ValidityCheckonTextBox(ch))
            {
                string text = textBox1.Text;
                text += ch;
                textBox1.Text = text;
            }
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }
        
        private bool isNumber(char ch)
        {
            if(ch>='0' && ch<= '9') return true;
            return false;
        }

        private bool isOperator(char ch)
        {
            if(ch=='+' || ch=='-' || ch== '×' || ch== '÷') return true;
            return false;
        }

        private bool StopAction(char ch)
        {
            if (isNumber(ch) || ch == '+' || ch == '-' || ch == '(' || ch == ')' || ch== '\b' || ch==(char)Keys.Delete) return false;
            return true;

        }
        private void OneButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('1');
        }


        private void TwoButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('2');
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('3');
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('4');
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('5');
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('6');
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('7');
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('8');
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('9');
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('0');
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('+');
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('-');
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('×');
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('÷');
        }

        private void LeftBracketButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox('(');
        }

        private void RightBracketButton_Click(object sender, EventArgs e)
        {
            this.AddToTextBox(')');
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '*')
            {
                e.Handled = true;
                this.AddToTextBox('×');
            }
            else if (e.KeyChar == '/')
            {
                e.Handled = true;
                this.AddToTextBox('÷');
            }
            else if (StopAction(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Pressed key is not appropriate");
            }
            else if (e.KeyChar == '\b')
            {
                //do nothing
                //extra comment added
            }
            else
            {
                e.Handled = true;
                this.AddToTextBox(e.KeyChar);
            }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 || OpClDiff()!=0 || isOperator(textBox1.Text.Last()) )
            {
                MessageBox.Show("Invalid Expression");
            }
            else
            {
                try
                {
                    int result = EvaluateString.evaluate(textBox1.Text);
                    textBox1.Text = textBox1.Text+" = "+result.ToString();
                }
                catch(Exception exp) 
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
    }
}
