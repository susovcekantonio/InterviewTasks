using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanieliZadatci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            int rowCount = Int32.Parse(rowBox.Text);

            textBoxOut.Clear();

            textBoxOut.AppendText(headerBox.Text + Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < rowCount-1; i++)
            {
                string spaces = new string(' ', rowCount - i);

                if (i == 0)
                {
                    textBoxOut.AppendText(spaces + '*' + Environment.NewLine);
                }
                else if (i == rowCount - 2)
                {
                    string stars = new string('*', (2 * i)+1);
                    string treeBase = new string(' ', rowCount);
                    textBoxOut.AppendText(spaces + stars + Environment.NewLine + treeBase + '*' + Environment.NewLine);
                }
                else
                {
                    string centerSpace = new string(' ', (2*i)-1);
                    textBoxOut.AppendText(spaces + '*' + centerSpace + '*' + Environment.NewLine);
                }
            }

            textBoxOut.AppendText(Environment.NewLine + footerBox.Text);

        }

        private void form2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();           
        }
    }
}
