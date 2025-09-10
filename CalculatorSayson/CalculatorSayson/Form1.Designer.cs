namespace CalculatorSayson
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
            zeroButton = new Button();
            dotButton = new Button();
            plusButton = new Button();
            clearButton = new Button();
            equalButton = new Button();
            deleteButton = new Button();
            minusButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            multiplyButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            divideButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            tbResult = new TextBox();
            currentOperation = new Label();
            SuspendLayout();
            // 
            // zeroButton
            // 
            zeroButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zeroButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zeroButton.Location = new Point(19, 351);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(184, 73);
            zeroButton.TabIndex = 1;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += button2_Click;
            // 
            // dotButton
            // 
            dotButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dotButton.Font = new Font("Calibri", 15.75F);
            dotButton.Location = new Point(209, 351);
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(89, 73);
            dotButton.TabIndex = 2;
            dotButton.Text = ".";
            dotButton.UseVisualStyleBackColor = true;
            dotButton.Click += dotButton_Click;
            // 
            // plusButton
            // 
            plusButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plusButton.Font = new Font("Calibri", 15.75F);
            plusButton.Location = new Point(304, 351);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(89, 73);
            plusButton.TabIndex = 9;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += button12_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Calibri", 15.75F);
            clearButton.Location = new Point(403, 193);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(89, 73);
            clearButton.TabIndex = 14;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += button13_Click;
            // 
            // equalButton
            // 
            equalButton.Font = new Font("Calibri", 15.75F);
            equalButton.Location = new Point(403, 272);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(89, 152);
            equalButton.TabIndex = 13;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = true;
            equalButton.Click += equalButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Calibri", 15.75F);
            deleteButton.Location = new Point(403, 114);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(89, 73);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "<";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // minusButton
            // 
            minusButton.Font = new Font("Calibri", 15.75F);
            minusButton.Location = new Point(304, 272);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(89, 73);
            minusButton.TabIndex = 23;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // threeButton
            // 
            threeButton.Font = new Font("Calibri", 15.75F);
            threeButton.Location = new Point(209, 272);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(89, 73);
            threeButton.TabIndex = 22;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.Click += threeButton_Click;
            // 
            // twoButton
            // 
            twoButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            twoButton.Location = new Point(114, 272);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(89, 73);
            twoButton.TabIndex = 21;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            twoButton.Click += button6_Click;
            // 
            // oneButton
            // 
            oneButton.Font = new Font("Calibri", 15.75F);
            oneButton.Location = new Point(19, 272);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(89, 73);
            oneButton.TabIndex = 20;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            oneButton.Click += button7_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Font = new Font("Calibri", 15.75F);
            multiplyButton.Location = new Point(304, 193);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(89, 73);
            multiplyButton.TabIndex = 27;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // sixButton
            // 
            sixButton.Font = new Font("Calibri", 15.75F);
            sixButton.Location = new Point(209, 193);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(89, 73);
            sixButton.TabIndex = 26;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.Click += sixButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fiveButton.Location = new Point(114, 193);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(89, 73);
            fiveButton.TabIndex = 25;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.Click += button10_Click;
            // 
            // fourButton
            // 
            fourButton.Font = new Font("Calibri", 15.75F);
            fourButton.Location = new Point(19, 193);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(89, 73);
            fourButton.TabIndex = 24;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.Click += fourButton_Click;
            // 
            // divideButton
            // 
            divideButton.Font = new Font("Calibri", 15.75F);
            divideButton.Location = new Point(304, 114);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(89, 73);
            divideButton.TabIndex = 31;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // nineButton
            // 
            nineButton.Font = new Font("Calibri", 15.75F);
            nineButton.Location = new Point(209, 114);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(89, 73);
            nineButton.TabIndex = 30;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.Click += nineButton_Click;
            // 
            // eightButton
            // 
            eightButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eightButton.Location = new Point(114, 114);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(89, 73);
            eightButton.TabIndex = 29;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.Click += eightButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.Font = new Font("Calibri", 15.75F);
            sevenButton.Location = new Point(19, 114);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(89, 73);
            sevenButton.TabIndex = 28;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.Click += sevenButton_Click;
            // 
            // tbResult
            // 
            tbResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbResult.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbResult.Location = new Point(19, 43);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(473, 44);
            tbResult.TabIndex = 32;
            tbResult.TextAlign = HorizontalAlignment.Right;
            tbResult.TextChanged += tbResult_TextChanged;
            // 
            // currentOperation
            // 
            currentOperation.AutoSize = true;
            currentOperation.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            currentOperation.Location = new Point(477, 8);
            currentOperation.Name = "currentOperation";
            currentOperation.Size = new Size(0, 25);
            currentOperation.TabIndex = 33;
            currentOperation.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 450);
            Controls.Add(currentOperation);
            Controls.Add(tbResult);
            Controls.Add(divideButton);
            Controls.Add(nineButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(multiplyButton);
            Controls.Add(sixButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(minusButton);
            Controls.Add(threeButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(deleteButton);
            Controls.Add(clearButton);
            Controls.Add(equalButton);
            Controls.Add(plusButton);
            Controls.Add(dotButton);
            Controls.Add(zeroButton);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button zeroButton;
        private Button dotButton;
        private Button plusButton;
        private Button clearButton;
        private Button equalButton;
        private Button deleteButton;
        private Button minusButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private Button multiplyButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button divideButton;
        private Button nineButton;
        private Button eightButton;
        private Button sevenButton;
        private TextBox tbResult;
        private Label currentOperation;
    }
}
