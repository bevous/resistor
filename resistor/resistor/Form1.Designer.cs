namespace resistor
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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.BandOneComboBox = new System.Windows.Forms.ComboBox();
            this.BandTwoComboBox = new System.Windows.Forms.ComboBox();
            this.BandFourComboBox = new System.Windows.Forms.ComboBox();
            this.BandThreeComboBox = new System.Windows.Forms.ComboBox();
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BandOneLabel = new System.Windows.Forms.Label();
            this.BandTwoLabel = new System.Windows.Forms.Label();
            this.BandThreeLabel = new System.Windows.Forms.Label();
            this.BandFourLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(154, 246);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(182, 36);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // BandOneComboBox
            // 
            this.BandOneComboBox.FormattingEnabled = true;
            this.BandOneComboBox.Location = new System.Drawing.Point(12, 39);
            this.BandOneComboBox.Name = "BandOneComboBox";
            this.BandOneComboBox.Size = new System.Drawing.Size(121, 28);
            this.BandOneComboBox.TabIndex = 1;
            // 
            // BandTwoComboBox
            // 
            this.BandTwoComboBox.FormattingEnabled = true;
            this.BandTwoComboBox.Location = new System.Drawing.Point(12, 106);
            this.BandTwoComboBox.Name = "BandTwoComboBox";
            this.BandTwoComboBox.Size = new System.Drawing.Size(121, 28);
            this.BandTwoComboBox.TabIndex = 2;
            // 
            // BandFourComboBox
            // 
            this.BandFourComboBox.FormattingEnabled = true;
            this.BandFourComboBox.Location = new System.Drawing.Point(12, 241);
            this.BandFourComboBox.Name = "BandFourComboBox";
            this.BandFourComboBox.Size = new System.Drawing.Size(121, 28);
            this.BandFourComboBox.TabIndex = 4;
            // 
            // BandThreeComboBox
            // 
            this.BandThreeComboBox.FormattingEnabled = true;
            this.BandThreeComboBox.Location = new System.Drawing.Point(12, 178);
            this.BandThreeComboBox.Name = "BandThreeComboBox";
            this.BandThreeComboBox.Size = new System.Drawing.Size(121, 28);
            this.BandThreeComboBox.TabIndex = 3;
            // 
            // ResultRichTextBox
            // 
            this.ResultRichTextBox.Location = new System.Drawing.Point(154, 12);
            this.ResultRichTextBox.Name = "ResultRichTextBox";
            this.ResultRichTextBox.Size = new System.Drawing.Size(182, 228);
            this.ResultRichTextBox.TabIndex = 5;
            this.ResultRichTextBox.Text = "";
            // 
            // BandOneLabel
            // 
            this.BandOneLabel.AutoSize = true;
            this.BandOneLabel.Location = new System.Drawing.Point(39, 16);
            this.BandOneLabel.Name = "BandOneLabel";
            this.BandOneLabel.Size = new System.Drawing.Size(60, 20);
            this.BandOneLabel.TabIndex = 6;
            this.BandOneLabel.Text = "Band 1";
            // 
            // BandTwoLabel
            // 
            this.BandTwoLabel.AutoSize = true;
            this.BandTwoLabel.Location = new System.Drawing.Point(39, 83);
            this.BandTwoLabel.Name = "BandTwoLabel";
            this.BandTwoLabel.Size = new System.Drawing.Size(60, 20);
            this.BandTwoLabel.TabIndex = 7;
            this.BandTwoLabel.Text = "Band 2";
            // 
            // BandThreeLabel
            // 
            this.BandThreeLabel.AutoSize = true;
            this.BandThreeLabel.Location = new System.Drawing.Point(39, 155);
            this.BandThreeLabel.Name = "BandThreeLabel";
            this.BandThreeLabel.Size = new System.Drawing.Size(60, 20);
            this.BandThreeLabel.TabIndex = 8;
            this.BandThreeLabel.Text = "Band 3";
            // 
            // BandFourLabel
            // 
            this.BandFourLabel.AutoSize = true;
            this.BandFourLabel.Location = new System.Drawing.Point(39, 218);
            this.BandFourLabel.Name = "BandFourLabel";
            this.BandFourLabel.Size = new System.Drawing.Size(60, 20);
            this.BandFourLabel.TabIndex = 9;
            this.BandFourLabel.Text = "Band 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 295);
            this.Controls.Add(this.BandFourLabel);
            this.Controls.Add(this.BandThreeLabel);
            this.Controls.Add(this.BandTwoLabel);
            this.Controls.Add(this.BandOneLabel);
            this.Controls.Add(this.ResultRichTextBox);
            this.Controls.Add(this.BandFourComboBox);
            this.Controls.Add(this.BandThreeComboBox);
            this.Controls.Add(this.BandTwoComboBox);
            this.Controls.Add(this.BandOneComboBox);
            this.Controls.Add(this.GenerateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.ComboBox BandOneComboBox;
        private System.Windows.Forms.ComboBox BandTwoComboBox;
        private System.Windows.Forms.ComboBox BandFourComboBox;
        private System.Windows.Forms.ComboBox BandThreeComboBox;
        private System.Windows.Forms.RichTextBox ResultRichTextBox;
        private System.Windows.Forms.Label BandOneLabel;
        private System.Windows.Forms.Label BandTwoLabel;
        private System.Windows.Forms.Label BandThreeLabel;
        private System.Windows.Forms.Label BandFourLabel;
    }
}

