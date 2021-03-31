
namespace Calculator
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
            this.plusMinus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.equalButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plusMinus
            // 
            this.plusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.plusMinus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.plusMinus.Location = new System.Drawing.Point(12, 379);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(57, 59);
            this.plusMinus.TabIndex = 3;
            this.plusMinus.Text = "+/-";
            this.plusMinus.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 101);
            this.textBox1.TabIndex = 13;
            this.textBox1.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.equalButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.equalButton.Location = new System.Drawing.Point(12, 444);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(246, 59);
            this.equalButton.TabIndex = 14;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.Result_Click);
            // 
            // pointButton
            // 
            this.pointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.pointButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pointButton.Location = new System.Drawing.Point(138, 379);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(57, 59);
            this.pointButton.TabIndex = 15;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button0.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button0.Location = new System.Drawing.Point(75, 379);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(57, 59);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button3.Location = new System.Drawing.Point(138, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 59);
            this.button3.TabIndex = 17;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(75, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 59);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(12, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 59);
            this.button1.TabIndex = 19;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.plus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.plus.Location = new System.Drawing.Point(200, 379);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(57, 59);
            this.plus.TabIndex = 20;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.PlusButton);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.minus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.minus.Location = new System.Drawing.Point(200, 314);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(57, 59);
            this.minus.TabIndex = 21;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.MinuseButton);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button4.Location = new System.Drawing.Point(12, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 59);
            this.button4.TabIndex = 22;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button5.Location = new System.Drawing.Point(75, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 59);
            this.button5.TabIndex = 23;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button6.Location = new System.Drawing.Point(138, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 59);
            this.button6.TabIndex = 24;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button9.Location = new System.Drawing.Point(138, 184);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 59);
            this.button9.TabIndex = 25;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button8.Location = new System.Drawing.Point(75, 184);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 59);
            this.button8.TabIndex = 26;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.divide.ForeColor = System.Drawing.SystemColors.MenuText;
            this.divide.Location = new System.Drawing.Point(201, 184);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(57, 59);
            this.divide.TabIndex = 27;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.DivideButton);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button7.Location = new System.Drawing.Point(12, 184);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 59);
            this.button7.TabIndex = 28;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Delete.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Delete.Location = new System.Drawing.Point(12, 119);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(57, 59);
            this.Delete.TabIndex = 29;
            this.Delete.Text = "CE";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button18.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button18.Location = new System.Drawing.Point(138, 119);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(57, 59);
            this.button18.TabIndex = 30;
            this.button18.Text = "%";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(75, 119);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(57, 59);
            this.button19.TabIndex = 31;
            this.button19.Text = "C";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button20.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button20.Location = new System.Drawing.Point(201, 119);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(57, 59);
            this.button20.TabIndex = 32;
            this.button20.Text = "←";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.multiplication.ForeColor = System.Drawing.SystemColors.MenuText;
            this.multiplication.Location = new System.Drawing.Point(201, 249);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(57, 59);
            this.multiplication.TabIndex = 33;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.MultiplicationButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(269, 524);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plusMinus);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "CalCooLator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button plusMinus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button multiplication;
    }
}

