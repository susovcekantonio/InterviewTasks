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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class Box
        {
            public int Length { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public Box(int length, int width, int height)
            {
                Length = length;
                Width = width;
                Height = height;
            }

            public bool CanStack(Box box)
            {
                return ((this.Length <= box.Length && this.Width <= box.Width) || (this.Length <= box.Width && this.Width <= box.Length));
            }

            public override string ToString()
            {
                return $"({Length}, {Width}, {Height})";
            }
        }

        private void stack_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<Box> boxes = new List<Box>();

            for (int i = 0; i < 10; i++)
            {
                int length = random.Next(1, 11);
                int width = random.Next(1, 11);
                int height = random.Next(1, 11);
                boxes.Add(new Box(length, width, height));
            }

            textBoxOut.Clear();
            textBoxOut.AppendText("Generated boxes:" + Environment.NewLine);

            foreach (Box box in boxes)
            {
                textBoxOut.AppendText(box.ToString() + Environment.NewLine);
            }

            textBoxOut.AppendText("Sorted boxes:" + Environment.NewLine);

            boxes = boxes
                    .OrderByDescending(box => box.Length)
                    .ThenByDescending(box => box.Width)
                    .ToList();

            foreach (Box box in boxes)
            {
                textBoxOut.AppendText(box.ToString() + Environment.NewLine);
            }

            List<Box> highestStack = new List<Box>();
            int[] stackHistory = new int[boxes.Count];          
            int[] heights = new int[boxes.Count];

            for (int i = 0; i < boxes.Count; i++)
            {
                heights[i] = boxes[i].Height;
                stackHistory[i] = -1;
            }

            for (int i = 1; i < boxes.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (boxes[i].CanStack(boxes[j]) && (heights[i] < heights[j] + boxes[i].Height))
                    {
                        heights[i] = boxes[i].Height + heights[j];
                        stackHistory[i] = j;
                    }
                }
            }

            int highestPoint = Array.IndexOf(heights,heights.Max());

            textBoxOut.AppendText("Highest stack:" + heights.Max().ToString() + Environment.NewLine);

            while (highestPoint >= 0)
            {
                highestStack.Add(boxes[highestPoint]);
                highestPoint = stackHistory[highestPoint];
            }

            highestStack.Reverse();

            foreach (Box box in highestStack)
            {
                textBoxOut.AppendText(box.ToString() + Environment.NewLine);
            }

            List<List<Box>> stacks = new List<List<Box>>();

            foreach (var box in boxes)
            {
                bool placed = false;
                for (int i = 0; i < stacks.Count; i++)
                {
                    if (box.CanStack(stacks[i].Last()))
                    {
                        stacks[i].Add(box);
                        placed = true;
                        break;
                    }
                }

                if (!placed)
                {
                    stacks.Add(new List<Box> { box });
                }
            }

            textBoxOut.AppendText("Minimal stacks:" + stacks.Count.ToString() + Environment.NewLine);

            for (int i = 0; i < stacks.Count; i++)
            {
                textBoxOut.AppendText($"Stack {i + 1}:" + Environment.NewLine);
                foreach (var box in stacks[i])
                {
                    textBoxOut.AppendText(box.ToString() + Environment.NewLine);
                }
            }

        }

        private void form3_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.ShowDialog();
        }
    }
}