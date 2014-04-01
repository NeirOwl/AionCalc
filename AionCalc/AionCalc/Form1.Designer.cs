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
            this.Answer.Size = new System.Drawing.Size(108, 20);
            this.Answer.TabIndex = 2;
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(12, 105);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(34, 32);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(52, 105);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(34, 32);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(92, 105);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(34, 32);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(132, 105);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(34, 32);
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
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второй аргумент";
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(172, 105);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(34, 32);
            this.Cos.TabIndex = 9;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(212, 105);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(34, 32);
            this.Sin.TabIndex = 10;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Tanh
            // 
            this.Tanh.Location = new System.Drawing.Point(252, 105);
            this.Tanh.Name = "Tanh";
            this.Tanh.Size = new System.Drawing.Size(37, 32);
            this.Tanh.TabIndex = 11;
            this.Tanh.Text = "tanh";
            this.Tanh.UseVisualStyleBackColor = true;
            this.Tanh.Click += new System.EventHandler(this.Tanh_Click);
            // 
            // Pow_10_x_
            // 
            this.Pow_10_x_.Location = new System.Drawing.Point(295, 105);
            this.Pow_10_x_.Name = "Pow_10_x_";
            this.Pow_10_x_.Size = new System.Drawing.Size(42, 32);
            this.Pow_10_x_.TabIndex = 12;
            this.Pow_10_x_.Text = "10^x";
            this.Pow_10_x_.UseVisualStyleBackColor = true;
            this.Pow_10_x_.Click += new System.EventHandler(this.Pow_10_x__Click);
            // 
            // Division_y_x_
            // 
            this.Division_y_x_.Location = new System.Drawing.Point(343, 105);
            this.Division_y_x_.Name = "Division_y_x_";
            this.Division_y_x_.Size = new System.Drawing.Size(42, 32);
            this.Division_y_x_.TabIndex = 13;
            this.Division_y_x_.Text = "y/x";
            this.Division_y_x_.UseVisualStyleBackColor = true;
            this.Division_y_x_.Click += new System.EventHandler(this.Division_y_x__Click);
            // 
            // Multiplication_10_x_
            // 
            this.Multiplication_10_x_.Location = new System.Drawing.Point(12, 143);
            this.Multiplication_10_x_.Name = "Multiplication_10_x_";
            this.Multiplication_10_x_.Size = new System.Drawing.Size(42, 32);
            this.Multiplication_10_x_.TabIndex = 14;
            this.Multiplication_10_x_.Text = "10*x";
            this.Multiplication_10_x_.UseVisualStyleBackColor = true;
            this.Multiplication_10_x_.Click += new System.EventHandler(this.Multiplication_10_x__Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(60, 143);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(42, 32);
            this.Sqrt.TabIndex = 15;
            this.Sqrt.Text = "sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Gradtorad
            // 
            this.Gradtorad.Location = new System.Drawing.Point(108, 143);
            this.Gradtorad.Name = "Gradtorad";
            this.Gradtorad.Size = new System.Drawing.Size(58, 32);
            this.Gradtorad.TabIndex = 16;
            this.Gradtorad.Text = "Gr->Rad";
            this.Gradtorad.UseVisualStyleBackColor = true;
            this.Gradtorad.Click += new System.EventHandler(this.Gradtorad_Click);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(172, 143);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(34, 32);
            this.Tan.TabIndex = 17;
            this.Tan.Text = "tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // Xpowy
            // 
            this.Xpowy.Location = new System.Drawing.Point(212, 143);
            this.Xpowy.Name = "Xpowy";
            this.Xpowy.Size = new System.Drawing.Size(34, 32);
            this.Xpowy.TabIndex = 18;
            this.Xpowy.Text = "x^y";
            this.Xpowy.UseVisualStyleBackColor = true;
            this.Xpowy.Click += new System.EventHandler(this.Xpowy_Click);
            // 
            // Exppowx
            // 
            this.Exppowx.Location = new System.Drawing.Point(252, 143);
            this.Exppowx.Name = "Exppowx";
            this.Exppowx.Size = new System.Drawing.Size(37, 32);
            this.Exppowx.TabIndex = 19;
            this.Exppowx.Text = "e^x";
            this.Exppowx.UseVisualStyleBackColor = true;
            this.Exppowx.Click += new System.EventHandler(this.Exppowx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 384);
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
    }
}

