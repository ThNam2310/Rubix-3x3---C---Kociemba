namespace VirtualRubiksCube
{

    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxDescription;

        private void InitializeComponent()
        {
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // textBoxDescription
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.ScrollBars = ScrollBars.Vertical;
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Dock = DockStyle.Fill;
            //this.textBoxDescription.Font = new System.Drawing.Font("Arial",12,FontStyle.Bold);

            // AboutBox
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.textBoxDescription);
            this.Text = "About Virtual Rubik's Cube";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}