namespace CS161_Lab6
{
    partial class Main
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
            hospitalButton = new Button();
            presentValueButton = new Button();
            SuspendLayout();
            // 
            // hospitalButton
            // 
            hospitalButton.Location = new Point(17, 19);
            hospitalButton.Name = "hospitalButton";
            hospitalButton.Size = new Size(234, 29);
            hospitalButton.TabIndex = 0;
            hospitalButton.Text = "Hospital Charges";
            hospitalButton.UseVisualStyleBackColor = true;
            hospitalButton.Click += hospitalButton_Click;
            // 
            // presentValueButton
            // 
            presentValueButton.Location = new Point(17, 67);
            presentValueButton.Name = "presentValueButton";
            presentValueButton.Size = new Size(234, 29);
            presentValueButton.TabIndex = 1;
            presentValueButton.Text = "Present Value";
            presentValueButton.UseVisualStyleBackColor = true;
            presentValueButton.Click += presentValueButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 450);
            Controls.Add(presentValueButton);
            Controls.Add(hospitalButton);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button hospitalButton;
        private Button presentValueButton;
    }
}
