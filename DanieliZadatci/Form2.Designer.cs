namespace DanieliZadatci
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stack = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.form3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stack
            // 
            this.stack.Location = new System.Drawing.Point(43, 25);
            this.stack.Name = "stack";
            this.stack.Size = new System.Drawing.Size(75, 23);
            this.stack.TabIndex = 0;
            this.stack.Text = "Stack";
            this.stack.UseVisualStyleBackColor = true;
            this.stack.Click += new System.EventHandler(this.stack_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(43, 67);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(492, 497);
            this.textBoxOut.TabIndex = 1;
            // 
            // form3
            // 
            this.form3.Location = new System.Drawing.Point(695, 541);
            this.form3.Name = "form3";
            this.form3.Size = new System.Drawing.Size(75, 23);
            this.form3.TabIndex = 2;
            this.form3.Text = "Zad 3";
            this.form3.UseVisualStyleBackColor = true;
            this.form3.Click += new System.EventHandler(this.form3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.form3);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.stack);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stack;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button form3;
    }
}