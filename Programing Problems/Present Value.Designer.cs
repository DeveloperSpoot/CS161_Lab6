namespace CS161_Lab6.Programing_Problems
{
    partial class Present_Value
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
            groupBox1 = new GroupBox();
            depositNeededLabel = new Label();
            groupBox2 = new GroupBox();
            futureTextBox = new TextBox();
            groupBox3 = new GroupBox();
            interestRateTextBox = new TextBox();
            groupBox4 = new GroupBox();
            yearsTextBox = new TextBox();
            calculateButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(depositNeededLabel);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(218, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 62);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deposit Today";
            // 
            // depositNeededLabel
            // 
            depositNeededLabel.BackColor = SystemColors.ControlLight;
            depositNeededLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            depositNeededLabel.Location = new Point(8, 23);
            depositNeededLabel.Name = "depositNeededLabel";
            depositNeededLabel.Size = new Size(186, 24);
            depositNeededLabel.TabIndex = 0;
            depositNeededLabel.Text = "(one, two, three) And all the-";
            depositNeededLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(futureTextBox);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 62);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Future Goal";
            // 
            // futureTextBox
            // 
            futureTextBox.Location = new Point(8, 25);
            futureTextBox.Name = "futureTextBox";
            futureTextBox.Size = new Size(186, 23);
            futureTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(interestRateTextBox);
            groupBox3.Location = new Point(218, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 62);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Annual Interest Rate";
            // 
            // interestRateTextBox
            // 
            interestRateTextBox.Location = new Point(8, 25);
            interestRateTextBox.Name = "interestRateTextBox";
            interestRateTextBox.Size = new Size(186, 23);
            interestRateTextBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(yearsTextBox);
            groupBox4.Location = new Point(12, 80);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 62);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Number of Years";
            // 
            // yearsTextBox
            // 
            yearsTextBox.Location = new Point(6, 22);
            yearsTextBox.Name = "yearsTextBox";
            yearsTextBox.Size = new Size(186, 23);
            yearsTextBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.PeachPuff;
            calculateButton.Location = new Point(12, 148);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(406, 23);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(12, 186);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(406, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Present_Value
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 225);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Present_Value";
            Text = "Present_Value";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox futureTextBox;
        private GroupBox groupBox3;
        private TextBox interestRateTextBox;
        private GroupBox groupBox4;
        private TextBox yearsTextBox;
        private Label depositNeededLabel;
        private Button calculateButton;
        private Button exitButton;
    }
}