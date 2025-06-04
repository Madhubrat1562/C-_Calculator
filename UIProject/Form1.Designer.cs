namespace UIProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.LeftBracketButton = new System.Windows.Forms.Button();
            this.RightBracketButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(167, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(708, 71);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionButton.Location = new System.Drawing.Point(167, 257);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(82, 68);
            this.AdditionButton.TabIndex = 2;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractionButton.Location = new System.Drawing.Point(308, 257);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(71, 68);
            this.SubtractionButton.TabIndex = 3;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicationButton.Location = new System.Drawing.Point(431, 257);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(80, 68);
            this.MultiplicationButton.TabIndex = 4;
            this.MultiplicationButton.Text = "×";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionButton.Location = new System.Drawing.Point(554, 257);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(84, 68);
            this.DivisionButton.TabIndex = 5;
            this.DivisionButton.Text = "÷";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // LeftBracketButton
            // 
            this.LeftBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftBracketButton.Location = new System.Drawing.Point(678, 257);
            this.LeftBracketButton.Name = "LeftBracketButton";
            this.LeftBracketButton.Size = new System.Drawing.Size(80, 68);
            this.LeftBracketButton.TabIndex = 6;
            this.LeftBracketButton.Text = "(";
            this.LeftBracketButton.UseVisualStyleBackColor = true;
            this.LeftBracketButton.Click += new System.EventHandler(this.LeftBracketButton_Click);
            // 
            // RightBracketButton
            // 
            this.RightBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightBracketButton.Location = new System.Drawing.Point(795, 257);
            this.RightBracketButton.Name = "RightBracketButton";
            this.RightBracketButton.Size = new System.Drawing.Size(80, 68);
            this.RightBracketButton.TabIndex = 7;
            this.RightBracketButton.Text = ")";
            this.RightBracketButton.UseVisualStyleBackColor = true;
            this.RightBracketButton.Click += new System.EventHandler(this.RightBracketButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(167, 354);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(82, 70);
            this.OneButton.TabIndex = 8;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(308, 354);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(71, 70);
            this.TwoButton.TabIndex = 9;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(431, 354);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(80, 70);
            this.ThreeButton.TabIndex = 10;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(554, 354);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(84, 70);
            this.FourButton.TabIndex = 11;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(678, 354);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(80, 70);
            this.FiveButton.TabIndex = 12;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(795, 354);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(80, 70);
            this.SixButton.TabIndex = 13;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(167, 455);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(82, 68);
            this.SevenButton.TabIndex = 14;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(308, 455);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(71, 68);
            this.EightButton.TabIndex = 15;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(431, 455);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(80, 68);
            this.NineButton.TabIndex = 16;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(554, 455);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(74, 68);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.Location = new System.Drawing.Point(678, 455);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(197, 68);
            this.ResultButton.TabIndex = 18;
            this.ResultButton.Text = "=";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 709);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.RightBracketButton);
            this.Controls.Add(this.LeftBracketButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.Button AdditionButton;
        public System.Windows.Forms.Button SubtractionButton;
        public System.Windows.Forms.Button MultiplicationButton;
        public System.Windows.Forms.Button DivisionButton;
        public System.Windows.Forms.Button LeftBracketButton;
        public System.Windows.Forms.Button RightBracketButton;
        public System.Windows.Forms.Button OneButton;
        public System.Windows.Forms.Button TwoButton;
        public System.Windows.Forms.Button ThreeButton;
        public System.Windows.Forms.Button FourButton;
        public System.Windows.Forms.Button FiveButton;
        public System.Windows.Forms.Button SixButton;
        public System.Windows.Forms.Button SevenButton;
        public System.Windows.Forms.Button EightButton;
        public System.Windows.Forms.Button NineButton;
        public System.Windows.Forms.Button ZeroButton;
        public System.Windows.Forms.Button ResultButton;
    }
}

