namespace VirtualRubiksCube
{
    partial class ScrambleDialog
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
            numberOfMovesLabel = new Label();
            numberOfMovesNumericUpDown = new NumericUpDown();
            okButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numberOfMovesNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // numberOfMovesLabel
            // 
            numberOfMovesLabel.AutoSize = true;
            numberOfMovesLabel.Location = new Point(43, 39);
            numberOfMovesLabel.Margin = new Padding(5, 0, 5, 0);
            numberOfMovesLabel.Name = "numberOfMovesLabel";
            numberOfMovesLabel.Size = new Size(128, 20);
            numberOfMovesLabel.TabIndex = 0;
            numberOfMovesLabel.Text = "Number of moves";
            // 
            // numberOfMovesNumericUpDown
            // 
            numberOfMovesNumericUpDown.Location = new Point(171, 36);
            numberOfMovesNumericUpDown.Margin = new Padding(5, 4, 5, 4);
            numberOfMovesNumericUpDown.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numberOfMovesNumericUpDown.Name = "numberOfMovesNumericUpDown";
            numberOfMovesNumericUpDown.Size = new Size(160, 27);
            numberOfMovesNumericUpDown.TabIndex = 0;
            numberOfMovesNumericUpDown.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numberOfMovesNumericUpDown.ValueChanged += numberOfMovesNumericUpDown_ValueChanged;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(154, 171);
            okButton.Margin = new Padding(5, 4, 5, 4);
            okButton.Name = "okButton";
            okButton.Size = new Size(101, 36);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(263, 171);
            cancelButton.Margin = new Padding(5, 4, 5, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(101, 36);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // ScrambleDialog
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(378, 224);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(numberOfMovesNumericUpDown);
            Controls.Add(numberOfMovesLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScrambleDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Scramble";
            ((System.ComponentModel.ISupportInitialize)numberOfMovesNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberOfMovesLabel;
        private NumericUpDown numberOfMovesNumericUpDown;
        private Button okButton;
        private Button cancelButton;
    }
}