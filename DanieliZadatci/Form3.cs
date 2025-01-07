using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanieliZadatci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<double> numbers = new List<double>();
        List<String> operations = new List<String>();
        bool isOperatorPressed=false;

        private void btNumber_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                resultBox.Clear();
                isOperatorPressed = false;
            }
            Button button = (Button)sender;
            resultBox.AppendText(button.Text);

        }

        private void btOp_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            numbers.Add(double.Parse(resultBox.Text));
            operations.Add(button.Text);
            isOperatorPressed=true;
            if (operations.Count > 1)
            {
                if ((operations[operations.Count - 1] == "+" || operations[operations.Count - 1] == "-") &&
                   (operations[operations.Count - 2] == "+" || operations[operations.Count - 2] == "-"))
                {
                    resultBox.Clear();
                    double currentResult = numbers[0];

                    for (int i = 1; i < operations.Count; i++)
                    {
                        currentResult = operations[i - 1] == "+" ? currentResult + numbers[i] : currentResult - numbers[i];
                    }

                    resultBox.AppendText(currentResult.ToString("0.##"));
                }

                else if ((operations[operations.Count - 1] == "*" || operations[operations.Count - 1] == "/") &&
                   (operations[operations.Count - 2] == "*" || operations[operations.Count - 2] == "/"))
                {
                    resultBox.Clear();

                    double currentResult = numbers[numbers.Count - 1];

                    currentResult = operations[operations.Count - 2] == "*" ? currentResult * numbers[numbers.Count - 2] : numbers[numbers.Count - 2] / currentResult;
                    numbers[numbers.Count - 1] = currentResult;
                    numbers.RemoveAt(numbers.Count - 2);
                    operations.RemoveAt(operations.Count - 2);

                    resultBox.AppendText(currentResult.ToString("0.##"));
                }

                else if (operations[operations.Count - 2] == "*" || operations[operations.Count - 2] == "/")
                {
                    resultBox.Clear();

                    for (int i = 1; i < operations.Count; i++)
                    {
                        if (operations[i - 1] == "*" || operations[i - 1] == "/")
                        {
                            double result = operations[i - 1] == "*" ? numbers[i - 1] * numbers[i] : numbers[i - 1] / numbers[i];
                            numbers[i - 1] = result;
                            numbers.RemoveAt(i);
                            operations.RemoveAt(i - 1);
                            i--;
                        }
                    }

                    double currentResult = numbers[0];

                    for (int i = 1; i < operations.Count; i++)
                    {
                        currentResult = operations[i - 1] == "+" ? currentResult + numbers[i] : currentResult - numbers[i];
                    }

                    resultBox.AppendText(currentResult.ToString("0.##"));
                }
            }          
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            numbers.Clear();
            operations.Clear();
            isOperatorPressed = false;

        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            numbers.Add(double.Parse(resultBox.Text));
            isOperatorPressed = true;
            resultBox.Clear();

            for (int i = 0; i < operations.Count; i++)
            {
                if (operations[i] == "*" || operations[i] == "/")
                {
                    double result = operations[i] == "*" ? numbers[i] * numbers[i + 1] : numbers[i] / numbers[i + 1];
                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                    i--;
                }
            }

            double finalResult = numbers[0];

            for (int i = 0; i < operations.Count; i++)
            {
                finalResult = operations[i] == "+" ? finalResult + numbers[i + 1] : finalResult - numbers[i + 1];
            }

            resultBox.AppendText(finalResult.ToString("0.##"));

            numbers.Clear();
            operations.Clear();
        }

    }
}
