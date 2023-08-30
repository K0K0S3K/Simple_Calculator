namespace Simple_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            Button_9 = new Button();
            Button_8 = new Button();
            Button_7 = new Button();
            Add = new Button();
            Button_6 = new Button();
            Button_5 = new Button();
            Button_4 = new Button();
            Substract = new Button();
            Button_3 = new Button();
            Button_2 = new Button();
            Button_1 = new Button();
            Multiply = new Button();
            Clear_Button = new Button();
            Button_0 = new Button();
            Equal_To = new Button();
            Division = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(1, 9);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(317, 39);
            textBox1.TabIndex = 0;
            // 
            // Button_9
            // 
            Button_9.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_9.Location = new Point(0, 57);
            Button_9.Name = "Button_9";
            Button_9.Size = new Size(75, 75);
            Button_9.TabIndex = 1;
            Button_9.Text = "9";
            Button_9.UseVisualStyleBackColor = true;
            Button_9.Click += Click;
            // 
            // Button_8
            // 
            Button_8.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_8.Location = new Point(81, 57);
            Button_8.Name = "Button_8";
            Button_8.Size = new Size(75, 75);
            Button_8.TabIndex = 3;
            Button_8.Text = "8";
            Button_8.UseVisualStyleBackColor = true;
            Button_8.Click += Click;
            // 
            // Button_7
            // 
            Button_7.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_7.Location = new Point(162, 57);
            Button_7.Name = "Button_7";
            Button_7.Size = new Size(75, 75);
            Button_7.TabIndex = 4;
            Button_7.Text = "7";
            Button_7.UseVisualStyleBackColor = true;
            Button_7.Click += Click;
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(243, 57);
            Add.Name = "Add";
            Add.Size = new Size(75, 75);
            Add.TabIndex = 5;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += MathSign_Click;
            // 
            // Button_6
            // 
            Button_6.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_6.Location = new Point(0, 138);
            Button_6.Name = "Button_6";
            Button_6.Size = new Size(75, 75);
            Button_6.TabIndex = 6;
            Button_6.Text = "6";
            Button_6.UseVisualStyleBackColor = true;
            Button_6.Click += Click;
            // 
            // Button_5
            // 
            Button_5.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_5.Location = new Point(81, 138);
            Button_5.Name = "Button_5";
            Button_5.Size = new Size(75, 75);
            Button_5.TabIndex = 7;
            Button_5.Text = "5";
            Button_5.UseVisualStyleBackColor = true;
            Button_5.Click += Click;
            // 
            // Button_4
            // 
            Button_4.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_4.Location = new Point(162, 138);
            Button_4.Name = "Button_4";
            Button_4.Size = new Size(75, 75);
            Button_4.TabIndex = 8;
            Button_4.Text = "4";
            Button_4.UseVisualStyleBackColor = true;
            Button_4.Click += Click;
            // 
            // Substract
            // 
            Substract.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Substract.Location = new Point(242, 138);
            Substract.Name = "Substract";
            Substract.Size = new Size(75, 75);
            Substract.TabIndex = 9;
            Substract.Text = "-";
            Substract.UseVisualStyleBackColor = true;
            Substract.Click += MathSign_Click;
            // 
            // Button_3
            // 
            Button_3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_3.Location = new Point(0, 219);
            Button_3.Name = "Button_3";
            Button_3.Size = new Size(75, 75);
            Button_3.TabIndex = 10;
            Button_3.Text = "3";
            Button_3.UseVisualStyleBackColor = true;
            Button_3.Click += Click;
            // 
            // Button_2
            // 
            Button_2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_2.Location = new Point(81, 219);
            Button_2.Name = "Button_2";
            Button_2.Size = new Size(75, 75);
            Button_2.TabIndex = 11;
            Button_2.Text = "2";
            Button_2.UseVisualStyleBackColor = true;
            Button_2.Click += Click;
            // 
            // Button_1
            // 
            Button_1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_1.Location = new Point(162, 219);
            Button_1.Name = "Button_1";
            Button_1.Size = new Size(75, 75);
            Button_1.TabIndex = 12;
            Button_1.Text = "1";
            Button_1.UseVisualStyleBackColor = true;
            Button_1.Click += Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Multiply.Location = new Point(243, 219);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(75, 75);
            Multiply.TabIndex = 13;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += MathSign_Click;
            // 
            // Clear_Button
            // 
            Clear_Button.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Clear_Button.Location = new Point(0, 300);
            Clear_Button.Name = "Clear_Button";
            Clear_Button.Size = new Size(75, 75);
            Clear_Button.TabIndex = 14;
            Clear_Button.Text = "C";
            Clear_Button.UseVisualStyleBackColor = true;
            Clear_Button.Click += Clear_Click;
            // 
            // Button_0
            // 
            Button_0.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Button_0.Location = new Point(81, 300);
            Button_0.Name = "Button_0";
            Button_0.Size = new Size(75, 75);
            Button_0.TabIndex = 15;
            Button_0.Text = "0";
            Button_0.UseVisualStyleBackColor = true;
            Button_0.Click += Click;
            // 
            // Equal_To
            // 
            Equal_To.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Equal_To.Location = new Point(162, 300);
            Equal_To.Name = "Equal_To";
            Equal_To.Size = new Size(75, 75);
            Equal_To.TabIndex = 16;
            Equal_To.Text = "=";
            Equal_To.UseVisualStyleBackColor = true;
            Equal_To.Click += Equal_Click;
            // 
            // Division
            // 
            Division.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Division.Location = new Point(242, 300);
            Division.Name = "Division";
            Division.Size = new Size(75, 75);
            Division.TabIndex = 17;
            Division.Text = "/";
            Division.UseVisualStyleBackColor = true;
            Division.Click += MathSign_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 376);
            Controls.Add(Division);
            Controls.Add(Equal_To);
            Controls.Add(Button_0);
            Controls.Add(Clear_Button);
            Controls.Add(Multiply);
            Controls.Add(Button_1);
            Controls.Add(Button_2);
            Controls.Add(Button_3);
            Controls.Add(Substract);
            Controls.Add(Button_4);
            Controls.Add(Button_5);
            Controls.Add(Button_6);
            Controls.Add(Add);
            Controls.Add(Button_7);
            Controls.Add(Button_8);
            Controls.Add(Button_9);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Button_9;
        private Button Button_8;
        private Button Button_7;
        private Button Add;
        private Button Button_6;
        private Button Button_5;
        private Button Button_4;
        private Button Substract;
        private Button Button_3;
        private Button Button_2;
        private Button Button_1;
        private Button Multiply;
        private Button Clear_Button;
        private Button Button_0;
        private Button Equal_To;
        private Button Division;
    }
}