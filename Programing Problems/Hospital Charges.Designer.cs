namespace CS161_Lab6.Programing_Problems
{
    partial class Hospital_Charges
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
            calculateButton = new Button();
            groupBox1 = new GroupBox();
            daysTextBox = new TextBox();
            groupBox2 = new GroupBox();
            medicationTextBox = new TextBox();
            groupBox3 = new GroupBox();
            surgicalTextBox = new TextBox();
            groupBox4 = new GroupBox();
            labTextBox = new TextBox();
            groupBox5 = new GroupBox();
            rehabTextBox = new TextBox();
            exitButton = new Button();
            groupBox6 = new GroupBox();
            totalLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.PeachPuff;
            calculateButton.Location = new Point(12, 136);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(635, 23);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate Hospital Bill";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(daysTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 56);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Days Spent in the Hospital";
            // 
            // daysTextBox
            // 
            daysTextBox.Location = new Point(6, 22);
            daysTextBox.Name = "daysTextBox";
            daysTextBox.Size = new Size(188, 23);
            daysTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(medicationTextBox);
            groupBox2.Location = new Point(231, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 56);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medication Charges";
            // 
            // medicationTextBox
            // 
            medicationTextBox.Location = new Point(6, 22);
            medicationTextBox.Name = "medicationTextBox";
            medicationTextBox.Size = new Size(188, 23);
            medicationTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(surgicalTextBox);
            groupBox3.Location = new Point(12, 74);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 56);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Surgical Charges";
            // 
            // surgicalTextBox
            // 
            surgicalTextBox.Location = new Point(6, 21);
            surgicalTextBox.Name = "surgicalTextBox";
            surgicalTextBox.Size = new Size(188, 23);
            surgicalTextBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labTextBox);
            groupBox4.Location = new Point(231, 74);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 56);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lab Fees";
            // 
            // labTextBox
            // 
            labTextBox.Location = new Point(6, 21);
            labTextBox.Name = "labTextBox";
            labTextBox.Size = new Size(188, 23);
            labTextBox.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rehabTextBox);
            groupBox5.Location = new Point(447, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 56);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Physical Rehabilitation Charges";
            // 
            // rehabTextBox
            // 
            rehabTextBox.Location = new Point(6, 22);
            rehabTextBox.Name = "rehabTextBox";
            rehabTextBox.Size = new Size(188, 23);
            rehabTextBox.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(12, 165);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(635, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(totalLabel);
            groupBox6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox6.Location = new Point(447, 74);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(200, 56);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Total Charges";
            // 
            // totalLabel
            // 
            totalLabel.BackColor = SystemColors.ControlLight;
            totalLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(6, 21);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(188, 23);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "and I'm feeling 22";
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Hospital_Charges
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 202);
            Controls.Add(groupBox6);
            Controls.Add(exitButton);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(calculateButton);
            Name = "Hospital_Charges";
            Text = "Hospital_Charges";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button calculateButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button exitButton;
        private GroupBox groupBox6;
        private TextBox daysTextBox;
        private Label totalLabel;
        private TextBox medicationTextBox;
        private TextBox surgicalTextBox;
        private TextBox labTextBox;
        private TextBox rehabTextBox;
    }
}