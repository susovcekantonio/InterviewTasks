namespace DanieliZadatci
{
    partial class Form1
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
            this.generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.headerBox = new System.Windows.Forms.TextBox();
            this.rowBox = new System.Windows.Forms.TextBox();
            this.footerBox = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(104, 172);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 0;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Header:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Row count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Footer:";
            // 
            // headerBox
            // 
            this.headerBox.Location = new System.Drawing.Point(169, 78);
            this.headerBox.Name = "headerBox";
            this.headerBox.Size = new System.Drawing.Size(100, 20);
            this.headerBox.TabIndex = 4;
            // 
            // rowBox
            // 
            this.rowBox.Location = new System.Drawing.Point(169, 109);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(100, 20);
            this.rowBox.TabIndex = 5;
            // 
            // footerBox
            // 
            this.footerBox.Location = new System.Drawing.Point(169, 135);
            this.footerBox.Name = "footerBox";
            this.footerBox.Size = new System.Drawing.Size(100, 20);
            this.footerBox.TabIndex = 6;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOut.Location = new System.Drawing.Point(93, 230);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(244, 208);
            this.textBoxOut.TabIndex = 7;
            // 
            // form2
            // 
            this.form2.Location = new System.Drawing.Point(691, 409);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(75, 23);
            this.form2.TabIndex = 8;
            this.form2.Text = "Zad 2";
            this.form2.UseVisualStyleBackColor = true;
            this.form2.Click += new System.EventHandler(this.form2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.form2);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.footerBox);
            this.Controls.Add(this.rowBox);
            this.Controls.Add(this.headerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox headerBox;
        private System.Windows.Forms.TextBox rowBox;
        private System.Windows.Forms.TextBox footerBox;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button form2;
    }
}

