namespace AionCalc
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstArgument = new System.Windows.Forms.TextBox();
            this.SecondArgument = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cos = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Tanh = new System.Windows.Forms.Button();
            this.Pow_10_x_ = new System.Windows.Forms.Button();
            this.Division_y_x_ = new System.Windows.Forms.Button();
            this.Multiplication_10_x_ = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Gradtorad = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Xpowy = new System.Windows.Forms.Button();
            this.Exppowx = new System.Windows.Forms.Button();
            this.Twodivisionx = new System.Windows.Forms.Button();
            this.Sqrtpow3x = new System.Windows.Forms.Button();
            this.Sqrtpowyx = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Tendivisionx = new System.Windows.Forms.Button();
            this.Tenmultiplyxdivisiony = new System.Windows.Forms.Button();
            this.Xpow3 = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Sinh = new System.Windows.Forms.Button();
            this.Cosh = new System.Windows.Forms.Button();
            this.Twomultiplyxdivisiony = new System.Windows.Forms.Button();
            this.Lg = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.SortingBubble = new System.Windows.Forms.Button();
            this.SortingSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArgument
            // 
            this.FirstArgument.Location = new System.Drawing.Point(12, 12);
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new System.Drawing.Size(108, 20);
            this.FirstArgument.TabIndex = 0;
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new System.Drawing.Point(12, 38);
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new System.Drawing.Size(108, 20);
            this.SecondArgument.TabIndex = 1;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(12, 64);
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Size = new System.Drawing.Size(223, 20);
            this.Answer.TabIndex = 2;
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(12, 105);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(59, 32);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(77, 105);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(59, 32);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(142, 105);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(59, 32);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(207, 105);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(59, 32);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первый аргумент - X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второй аргумент - Y";
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(12, 144);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(59, 31);
            this.Cos.TabIndex = 9;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(77, 144);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(59, 31);
            this.Sin.TabIndex = 10;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Tanh
            // 
            this.Tanh.Location = new System.Drawing.Point(338, 144);
            this.Tanh.Name = "Tanh";
            this.Tanh.Size = new System.Drawing.Size(59, 31);
            this.Tanh.TabIndex = 11;
            this.Tanh.Text = "tanh";
            this.Tanh.UseVisualStyleBackColor = true;
            this.Tanh.Click += new System.EventHandler(this.Tanh_Click);
            // 
            // Pow_10_x_
            // 
            this.Pow_10_x_.Location = new System.Drawing.Point(77, 259);
            this.Pow_10_x_.Name = "Pow_10_x_";
            this.Pow_10_x_.Size = new System.Drawing.Size(59, 32);
            this.Pow_10_x_.TabIndex = 12;
            this.Pow_10_x_.Text = "10^x";
            this.Pow_10_x_.UseVisualStyleBackColor = true;
            this.Pow_10_x_.Click += new System.EventHandler(this.Pow_10_x__Click);
            // 
            // Division_y_x_
            // 
            this.Division_y_x_.Location = new System.Drawing.Point(274, 221);
            this.Division_y_x_.Name = "Division_y_x_";
            this.Division_y_x_.Size = new System.Drawing.Size(58, 32);
            this.Division_y_x_.TabIndex = 13;
            this.Division_y_x_.Text = "y/x";
            this.Division_y_x_.UseVisualStyleBackColor = true;
            this.Division_y_x_.Click += new System.EventHandler(this.Division_y_x__Click);
            // 
            // Multiplication_10_x_
            // 
            this.Multiplication_10_x_.Location = new System.Drawing.Point(77, 221);
            this.Multiplication_10_x_.Name = "Multiplication_10_x_";
            this.Multiplication_10_x_.Size = new System.Drawing.Size(59, 32);
            this.Multiplication_10_x_.TabIndex = 14;
            this.Multiplication_10_x_.Text = "10*x";
            this.Multiplication_10_x_.UseVisualStyleBackColor = true;
            this.Multiplication_10_x_.Click += new System.EventHandler(this.Multiplication_10_x__Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(12, 182);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(59, 33);
            this.Sqrt.TabIndex = 15;
            this.Sqrt.Text = "sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Gradtorad
            // 
            this.Gradtorad.Location = new System.Drawing.Point(340, 259);
            this.Gradtorad.Name = "Gradtorad";
            this.Gradtorad.Size = new System.Drawing.Size(58, 32);
            this.Gradtorad.TabIndex = 16;
            this.Gradtorad.Text = "Gr->Rad";
            this.Gradtorad.UseVisualStyleBackColor = true;
            this.Gradtorad.Click += new System.EventHandler(this.Gradtorad_Click);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(142, 144);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(58, 31);
            this.Tan.TabIndex = 17;
            this.Tan.Text = "tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // Xpowy
            // 
            this.Xpowy.Location = new System.Drawing.Point(144, 259);
            this.Xpowy.Name = "Xpowy";
            this.Xpowy.Size = new System.Drawing.Size(56, 32);
            this.Xpowy.TabIndex = 18;
            this.Xpowy.Text = "x^y";
            this.Xpowy.UseVisualStyleBackColor = true;
            this.Xpowy.Click += new System.EventHandler(this.Xpowy_Click);
            // 
            // Exppowx
            // 
            this.Exppowx.Location = new System.Drawing.Point(338, 182);
            this.Exppowx.Name = "Exppowx";
            this.Exppowx.Size = new System.Drawing.Size(60, 33);
            this.Exppowx.TabIndex = 19;
            this.Exppowx.Text = "e^x";
            this.Exppowx.UseVisualStyleBackColor = true;
            this.Exppowx.Click += new System.EventHandler(this.Exppowx_Click);
            // 
            // Twodivisionx
            // 
            this.Twodivisionx.Location = new System.Drawing.Point(12, 221);
            this.Twodivisionx.Name = "Twodivisionx";
            this.Twodivisionx.Size = new System.Drawing.Size(59, 32);
            this.Twodivisionx.TabIndex = 20;
            this.Twodivisionx.Text = "2/x";
            this.Twodivisionx.UseVisualStyleBackColor = true;
            this.Twodivisionx.Click += new System.EventHandler(this.Twodivisionx_Click);
            // 
            // Sqrtpow3x
            // 
            this.Sqrtpow3x.Location = new System.Drawing.Point(274, 259);
            this.Sqrtpow3x.Name = "Sqrtpow3x";
            this.Sqrtpow3x.Size = new System.Drawing.Size(58, 32);
            this.Sqrtpow3x.TabIndex = 21;
            this.Sqrtpow3x.Text = "sqrt^3(x)";
            this.Sqrtpow3x.UseVisualStyleBackColor = true;
            this.Sqrtpow3x.Click += new System.EventHandler(this.Sqrtpow3x_Click);
            // 
            // Sqrtpowyx
            // 
            this.Sqrtpowyx.Location = new System.Drawing.Point(209, 259);
            this.Sqrtpowyx.Name = "Sqrtpowyx";
            this.Sqrtpowyx.Size = new System.Drawing.Size(59, 32);
            this.Sqrtpowyx.TabIndex = 22;
            this.Sqrtpowyx.Text = "Sqrt^y(x)";
            this.Sqrtpowyx.UseVisualStyleBackColor = true;
            this.Sqrtpowyx.Click += new System.EventHandler(this.Sqrtpowyx_Click);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(77, 182);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(59, 33);
            this.Factorial.TabIndex = 23;
            this.Factorial.Text = "x!";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Tendivisionx
            // 
            this.Tendivisionx.Location = new System.Drawing.Point(144, 221);
            this.Tendivisionx.Name = "Tendivisionx";
            this.Tendivisionx.Size = new System.Drawing.Size(56, 32);
            this.Tendivisionx.TabIndex = 24;
            this.Tendivisionx.Text = "10/x";
            this.Tendivisionx.UseVisualStyleBackColor = true;
            this.Tendivisionx.Click += new System.EventHandler(this.Tendivisionx_Click);
            // 
            // Tenmultiplyxdivisiony
            // 
            this.Tenmultiplyxdivisiony.Location = new System.Drawing.Point(209, 221);
            this.Tenmultiplyxdivisiony.Name = "Tenmultiplyxdivisiony";
            this.Tenmultiplyxdivisiony.Size = new System.Drawing.Size(59, 32);
            this.Tenmultiplyxdivisiony.TabIndex = 25;
            this.Tenmultiplyxdivisiony.Text = "10*x/y";
            this.Tenmultiplyxdivisiony.UseVisualStyleBackColor = true;
            this.Tenmultiplyxdivisiony.Click += new System.EventHandler(this.Tenmultiplyxdivisiony_Click);
            // 
            // Xpow3
            // 
            this.Xpow3.Location = new System.Drawing.Point(12, 259);
            this.Xpow3.Name = "Xpow3";
            this.Xpow3.Size = new System.Drawing.Size(59, 32);
            this.Xpow3.TabIndex = 26;
            this.Xpow3.Text = "x^3";
            this.Xpow3.UseVisualStyleBackColor = true;
            this.Xpow3.Click += new System.EventHandler(this.Xpow3_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(144, 182);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(56, 33);
            this.Log.TabIndex = 27;
            this.Log.Text = "log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Sinh
            // 
            this.Sinh.Location = new System.Drawing.Point(273, 144);
            this.Sinh.Name = "Sinh";
            this.Sinh.Size = new System.Drawing.Size(59, 31);
            this.Sinh.TabIndex = 28;
            this.Sinh.Text = "sinh";
            this.Sinh.UseVisualStyleBackColor = true;
            this.Sinh.Click += new System.EventHandler(this.Sinh_Click);
            // 
            // Cosh
            // 
            this.Cosh.Location = new System.Drawing.Point(208, 144);
            this.Cosh.Name = "Cosh";
            this.Cosh.Size = new System.Drawing.Size(59, 31);
            this.Cosh.TabIndex = 29;
            this.Cosh.Text = "cosh";
            this.Cosh.UseVisualStyleBackColor = true;
            this.Cosh.Click += new System.EventHandler(this.Cosh_Click);
            // 
            // Twomultiplyxdivisiony
            // 
            this.Twomultiplyxdivisiony.Location = new System.Drawing.Point(340, 221);
            this.Twomultiplyxdivisiony.Name = "Twomultiplyxdivisiony";
            this.Twomultiplyxdivisiony.Size = new System.Drawing.Size(58, 32);
            this.Twomultiplyxdivisiony.TabIndex = 30;
            this.Twomultiplyxdivisiony.Text = "2*x/y";
            this.Twomultiplyxdivisiony.UseVisualStyleBackColor = true;
            this.Twomultiplyxdivisiony.Click += new System.EventHandler(this.Twomultiplyxdivisiony_Click);
            // 
            // Lg
            // 
            this.Lg.Location = new System.Drawing.Point(209, 182);
            this.Lg.Name = "Lg";
            this.Lg.Size = new System.Drawing.Size(58, 32);
            this.Lg.TabIndex = 31;
            this.Lg.Text = "lg";
            this.Lg.UseVisualStyleBackColor = true;
            this.Lg.Click += new System.EventHandler(this.Lg_Click);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(273, 183);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(59, 32);
            this.Ln.TabIndex = 32;
            this.Ln.Text = "ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.Ln_Click);
            // 
            // SortingBubble
            // 
            this.SortingBubble.Location = new System.Drawing.Point(273, 8);
            this.SortingBubble.Name = "SortingBubble";
            this.SortingBubble.Size = new System.Drawing.Size(125, 24);
            this.SortingBubble.TabIndex = 33;
            this.SortingBubble.Text = "SortingBubble";
            this.SortingBubble.UseVisualStyleBackColor = true;
            this.SortingBubble.Click += new System.EventHandler(this.Sorting_Click);
            // 
            // SortingSelection
            // 
            this.SortingSelection.Location = new System.Drawing.Point(274, 34);
            this.SortingSelection.Name = "SortingSelection";
            this.SortingSelection.Size = new System.Drawing.Size(124, 24);
            this.SortingSelection.TabIndex = 34;
            this.SortingSelection.Text = "SortingSelection";
            this.SortingSelection.UseVisualStyleBackColor = true;
            this.SortingSelection.Click += new System.EventHandler(this.SortingSelection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 299);
            this.Controls.Add(this.SortingSelection);
            this.Controls.Add(this.SortingBubble);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Lg);
            this.Controls.Add(this.Twomultiplyxdivisiony);
            this.Controls.Add(this.Cosh);
            this.Controls.Add(this.Sinh);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Xpow3);
            this.Controls.Add(this.Tenmultiplyxdivisiony);
            this.Controls.Add(this.Tendivisionx);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Sqrtpowyx);
            this.Controls.Add(this.Sqrtpow3x);
            this.Controls.Add(this.Twodivisionx);
            this.Controls.Add(this.Exppowx);
            this.Controls.Add(this.Xpowy);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Gradtorad);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Multiplication_10_x_);
            this.Controls.Add(this.Division_y_x_);
            this.Controls.Add(this.Pow_10_x_);
            this.Controls.Add(this.Tanh);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.SecondArgument);
            this.Controls.Add(this.FirstArgument);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstArgument;
        private System.Windows.Forms.TextBox SecondArgument;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Tanh;
        private System.Windows.Forms.Button Pow_10_x_;
        private System.Windows.Forms.Button Division_y_x_;
        private System.Windows.Forms.Button Multiplication_10_x_;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Gradtorad;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Xpowy;
        private System.Windows.Forms.Button Exppowx;
        private System.Windows.Forms.Button Twodivisionx;
        private System.Windows.Forms.Button Sqrtpow3x;
        private System.Windows.Forms.Button Sqrtpowyx;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Tendivisionx;
        private System.Windows.Forms.Button Tenmultiplyxdivisiony;
        private System.Windows.Forms.Button Xpow3;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button Sinh;
        private System.Windows.Forms.Button Cosh;
        private System.Windows.Forms.Button Twomultiplyxdivisiony;
        private System.Windows.Forms.Button Lg;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button SortingBubble;
        private System.Windows.Forms.Button SortingSelection;
    }
}

