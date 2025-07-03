namespace VirtualRubiksCube
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            moveQueueListBox = new ListBox();
            label1 = new Label();
            setQueueToSolutionButton = new Button();
            clearQueueButton = new Button();
            executeQueueButton = new Button();
            bPrimeButton = new Button();
            bButton = new Button();
            fPrimeButton = new Button();
            fButton = new Button();
            lPrimeButton = new Button();
            lButton = new Button();
            rPrimeButton = new Button();
            rButton = new Button();
            dPrimeButton = new Button();
            dButton = new Button();
            uPrimeButton = new Button();
            uButton = new Button();
            addToQueueRadioButton = new RadioButton();
            rotateRadioButton = new RadioButton();
            statusPanel = new Panel();
            faceLabel = new Label();
            zoomLabel = new Label();
            rotationLabel = new Label();
            statusLabel = new Label();
            showViewButton = new Button();
            viewGroupBox = new GroupBox();
            label2 = new Label();
            viewComboBox = new ComboBox();
            toolTip = new ToolTip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            scrambleToolStripMenuItem = new ToolStripMenuItem();
            enterColorToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            renderPanel = new Panel();
            label3 = new Label();
            groupBox1.SuspendLayout();
            statusPanel.SuspendLayout();
            viewGroupBox.SuspendLayout();
            menuStrip.SuspendLayout();
            renderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(moveQueueListBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(setQueueToSolutionButton);
            groupBox1.Controls.Add(clearQueueButton);
            groupBox1.Controls.Add(executeQueueButton);
            groupBox1.Controls.Add(bPrimeButton);
            groupBox1.Controls.Add(bButton);
            groupBox1.Controls.Add(fPrimeButton);
            groupBox1.Controls.Add(fButton);
            groupBox1.Controls.Add(lPrimeButton);
            groupBox1.Controls.Add(lButton);
            groupBox1.Controls.Add(rPrimeButton);
            groupBox1.Controls.Add(rButton);
            groupBox1.Controls.Add(dPrimeButton);
            groupBox1.Controls.Add(dButton);
            groupBox1.Controls.Add(uPrimeButton);
            groupBox1.Controls.Add(uButton);
            groupBox1.Controls.Add(addToQueueRadioButton);
            groupBox1.Controls.Add(rotateRadioButton);
            groupBox1.Location = new Point(824, 131);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(472, 741);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Moves";
            // 
            // moveQueueListBox
            // 
            moveQueueListBox.FormattingEnabled = true;
            moveQueueListBox.Location = new Point(109, 336);
            moveQueueListBox.Margin = new Padding(5, 4, 5, 4);
            moveQueueListBox.Name = "moveQueueListBox";
            moveQueueListBox.Size = new Size(355, 284);
            moveQueueListBox.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 336);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Move queue";
            // 
            // setQueueToSolutionButton
            // 
            setQueueToSolutionButton.Location = new Point(290, 629);
            setQueueToSolutionButton.Margin = new Padding(5, 4, 5, 4);
            setQueueToSolutionButton.Name = "setQueueToSolutionButton";
            setQueueToSolutionButton.Size = new Size(174, 36);
            setQueueToSolutionButton.TabIndex = 23;
            setQueueToSolutionButton.Text = "Set queue and slove";
            setQueueToSolutionButton.UseVisualStyleBackColor = true;
            setQueueToSolutionButton.Click += setQueueToSolutionButton_Click;
            // 
            // clearQueueButton
            // 
            clearQueueButton.Location = new Point(146, 629);
            clearQueueButton.Margin = new Padding(5, 4, 5, 4);
            clearQueueButton.Name = "clearQueueButton";
            clearQueueButton.Size = new Size(134, 36);
            clearQueueButton.TabIndex = 22;
            clearQueueButton.Text = "Clear queue";
            clearQueueButton.UseVisualStyleBackColor = true;
            clearQueueButton.Click += clearQueueButton_Click;
            // 
            // executeQueueButton
            // 
            executeQueueButton.Location = new Point(2, 629);
            executeQueueButton.Margin = new Padding(5, 4, 5, 4);
            executeQueueButton.Name = "executeQueueButton";
            executeQueueButton.Size = new Size(134, 36);
            executeQueueButton.TabIndex = 21;
            executeQueueButton.Text = "Execute queue";
            executeQueueButton.UseVisualStyleBackColor = true;
            executeQueueButton.Click += executeQueueButton_Click;
            // 
            // bPrimeButton
            // 
            bPrimeButton.Location = new Point(235, 292);
            bPrimeButton.Margin = new Padding(5, 4, 5, 4);
            bPrimeButton.Name = "bPrimeButton";
            bPrimeButton.Size = new Size(229, 36);
            bPrimeButton.TabIndex = 19;
            bPrimeButton.Text = "Back - Counterclockwise (B')";
            toolTip.SetToolTip(bPrimeButton, "[Shift + B]");
            bPrimeButton.UseVisualStyleBackColor = true;
            bPrimeButton.Click += bPrimeButton_Click;
            // 
            // bButton
            // 
            bButton.Location = new Point(15, 292);
            bButton.Margin = new Padding(5, 4, 5, 4);
            bButton.Name = "bButton";
            bButton.Size = new Size(214, 36);
            bButton.TabIndex = 18;
            bButton.Text = "Back - Clockwise (B)";
            toolTip.SetToolTip(bButton, "[B]");
            bButton.UseVisualStyleBackColor = true;
            bButton.Click += bButton_Click;
            // 
            // fPrimeButton
            // 
            fPrimeButton.Location = new Point(235, 248);
            fPrimeButton.Margin = new Padding(5, 4, 5, 4);
            fPrimeButton.Name = "fPrimeButton";
            fPrimeButton.Size = new Size(229, 36);
            fPrimeButton.TabIndex = 15;
            fPrimeButton.Text = "Front - Counterclockwise (F')";
            toolTip.SetToolTip(fPrimeButton, "[Shift + F]");
            fPrimeButton.UseVisualStyleBackColor = true;
            fPrimeButton.Click += fPrimeButton_Click;
            // 
            // fButton
            // 
            fButton.Location = new Point(15, 248);
            fButton.Margin = new Padding(5, 4, 5, 4);
            fButton.Name = "fButton";
            fButton.Size = new Size(214, 36);
            fButton.TabIndex = 14;
            fButton.Text = "Front - Clockwise (F)";
            toolTip.SetToolTip(fButton, "[F]");
            fButton.UseVisualStyleBackColor = true;
            fButton.Click += fButton_Click;
            // 
            // lPrimeButton
            // 
            lPrimeButton.Location = new Point(235, 160);
            lPrimeButton.Margin = new Padding(5, 4, 5, 4);
            lPrimeButton.Name = "lPrimeButton";
            lPrimeButton.Size = new Size(229, 36);
            lPrimeButton.TabIndex = 9;
            lPrimeButton.Text = "Left  - Counterclockwise (L')";
            toolTip.SetToolTip(lPrimeButton, "[Shift + L]");
            lPrimeButton.UseVisualStyleBackColor = true;
            lPrimeButton.Click += lPrimeButton_Click;
            // 
            // lButton
            // 
            lButton.Location = new Point(15, 160);
            lButton.Margin = new Padding(5, 4, 5, 4);
            lButton.Name = "lButton";
            lButton.Size = new Size(214, 36);
            lButton.TabIndex = 8;
            lButton.Text = "Left - Clockwise (L)";
            toolTip.SetToolTip(lButton, "[L]");
            lButton.UseVisualStyleBackColor = true;
            lButton.Click += lButton_Click;
            // 
            // rPrimeButton
            // 
            rPrimeButton.Location = new Point(235, 204);
            rPrimeButton.Margin = new Padding(5, 4, 5, 4);
            rPrimeButton.Name = "rPrimeButton";
            rPrimeButton.Size = new Size(229, 36);
            rPrimeButton.TabIndex = 13;
            rPrimeButton.Text = "Right - Counterclockwise (R')";
            toolTip.SetToolTip(rPrimeButton, "[Shift + R]");
            rPrimeButton.UseVisualStyleBackColor = true;
            rPrimeButton.Click += rPrimeButton_Click;
            // 
            // rButton
            // 
            rButton.Location = new Point(15, 204);
            rButton.Margin = new Padding(5, 4, 5, 4);
            rButton.Name = "rButton";
            rButton.Size = new Size(214, 36);
            rButton.TabIndex = 12;
            rButton.Text = "Right - Clockwise (R)";
            toolTip.SetToolTip(rButton, "[R]");
            rButton.UseVisualStyleBackColor = true;
            rButton.Click += rButton_Click;
            // 
            // dPrimeButton
            // 
            dPrimeButton.Location = new Point(235, 116);
            dPrimeButton.Margin = new Padding(5, 4, 5, 4);
            dPrimeButton.Name = "dPrimeButton";
            dPrimeButton.Size = new Size(229, 36);
            dPrimeButton.TabIndex = 7;
            dPrimeButton.Text = "Down - Counterclockwise (D')";
            toolTip.SetToolTip(dPrimeButton, "[Shift + D]");
            dPrimeButton.UseVisualStyleBackColor = true;
            dPrimeButton.Click += dPrimeButton_Click;
            // 
            // dButton
            // 
            dButton.Location = new Point(15, 116);
            dButton.Margin = new Padding(5, 4, 5, 4);
            dButton.Name = "dButton";
            dButton.Size = new Size(214, 36);
            dButton.TabIndex = 6;
            dButton.Text = "Down - Clockwise (D)";
            toolTip.SetToolTip(dButton, "[D]");
            dButton.UseVisualStyleBackColor = true;
            dButton.Click += dButton_Click;
            // 
            // uPrimeButton
            // 
            uPrimeButton.Location = new Point(235, 72);
            uPrimeButton.Margin = new Padding(5, 4, 5, 4);
            uPrimeButton.Name = "uPrimeButton";
            uPrimeButton.Size = new Size(229, 36);
            uPrimeButton.TabIndex = 3;
            uPrimeButton.Text = "Up - Counterclockwise (U')";
            toolTip.SetToolTip(uPrimeButton, "[Shift + U]");
            uPrimeButton.UseVisualStyleBackColor = true;
            uPrimeButton.Click += uPrimeButton_Click;
            // 
            // uButton
            // 
            uButton.Location = new Point(15, 72);
            uButton.Margin = new Padding(5, 4, 5, 4);
            uButton.Name = "uButton";
            uButton.Size = new Size(214, 36);
            uButton.TabIndex = 2;
            uButton.Text = "Up - Clockwise (U)";
            toolTip.SetToolTip(uButton, "[U]");
            uButton.UseVisualStyleBackColor = true;
            uButton.Click += uButton_Click;
            // 
            // addToQueueRadioButton
            // 
            addToQueueRadioButton.AutoSize = true;
            addToQueueRadioButton.Location = new Point(235, 29);
            addToQueueRadioButton.Margin = new Padding(5, 4, 5, 4);
            addToQueueRadioButton.Name = "addToQueueRadioButton";
            addToQueueRadioButton.Size = new Size(121, 24);
            addToQueueRadioButton.TabIndex = 1;
            addToQueueRadioButton.TabStop = true;
            addToQueueRadioButton.Text = "Add to queue";
            addToQueueRadioButton.UseVisualStyleBackColor = true;
            // 
            // rotateRadioButton
            // 
            rotateRadioButton.AutoSize = true;
            rotateRadioButton.Checked = true;
            rotateRadioButton.Location = new Point(97, 29);
            rotateRadioButton.Margin = new Padding(5, 4, 5, 4);
            rotateRadioButton.Name = "rotateRadioButton";
            rotateRadioButton.Size = new Size(74, 24);
            rotateRadioButton.TabIndex = 0;
            rotateRadioButton.TabStop = true;
            rotateRadioButton.Text = "Rotate";
            rotateRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(faceLabel);
            statusPanel.Controls.Add(zoomLabel);
            statusPanel.Controls.Add(rotationLabel);
            statusPanel.Controls.Add(statusLabel);
            statusPanel.Location = new Point(16, 827);
            statusPanel.Margin = new Padding(5, 4, 5, 4);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(800, 47);
            statusPanel.TabIndex = 0;
            // 
            // faceLabel
            // 
            faceLabel.AutoSize = true;
            faceLabel.Location = new Point(677, 9);
            faceLabel.Margin = new Padding(5, 0, 5, 0);
            faceLabel.Name = "faceLabel";
            faceLabel.Size = new Size(41, 20);
            faceLabel.TabIndex = 0;
            faceLabel.Text = "Face:";
            // 
            // zoomLabel
            // 
            zoomLabel.AutoSize = true;
            zoomLabel.Location = new Point(531, 9);
            zoomLabel.Margin = new Padding(5, 0, 5, 0);
            zoomLabel.Name = "zoomLabel";
            zoomLabel.Size = new Size(84, 20);
            zoomLabel.TabIndex = 0;
            zoomLabel.Text = "Zoom: 80%";
            // 
            // rotationLabel
            // 
            rotationLabel.AutoSize = true;
            rotationLabel.Location = new Point(193, 9);
            rotationLabel.Margin = new Padding(5, 0, 5, 0);
            rotationLabel.Name = "rotationLabel";
            rotationLabel.Size = new Size(186, 20);
            rotationLabel.TabIndex = 0;
            rotationLabel.Text = "Rotation: x = 0; y = 0; z = 0";
            rotationLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(5, 9);
            statusLabel.Margin = new Padding(5, 0, 5, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(97, 20);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Status: Ready";
            // 
            // showViewButton
            // 
            showViewButton.Location = new Point(350, 27);
            showViewButton.Margin = new Padding(5, 4, 5, 4);
            showViewButton.Name = "showViewButton";
            showViewButton.Size = new Size(101, 36);
            showViewButton.TabIndex = 1;
            showViewButton.Text = "Show";
            showViewButton.UseVisualStyleBackColor = true;
            showViewButton.Click += showViewButton_Click;
            // 
            // viewGroupBox
            // 
            viewGroupBox.Controls.Add(label2);
            viewGroupBox.Controls.Add(showViewButton);
            viewGroupBox.Controls.Add(viewComboBox);
            viewGroupBox.Location = new Point(824, 41);
            viewGroupBox.Margin = new Padding(5, 4, 5, 4);
            viewGroupBox.Name = "viewGroupBox";
            viewGroupBox.Padding = new Padding(5, 4, 5, 4);
            viewGroupBox.Size = new Size(472, 80);
            viewGroupBox.TabIndex = 1;
            viewGroupBox.TabStop = false;
            viewGroupBox.Text = "View";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 33);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 0;
            label2.Text = "View";
            // 
            // viewComboBox
            // 
            viewComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            viewComboBox.FormattingEnabled = true;
            viewComboBox.Items.AddRange(new object[] { "Defauft", "Top face", "Bottom face", "Left face", "Right face", "Front face", "Back face" });
            viewComboBox.Location = new Point(107, 29);
            viewComboBox.Margin = new Padding(5, 4, 5, 4);
            viewComboBox.Name = "viewComboBox";
            viewComboBox.Size = new Size(233, 28);
            viewComboBox.TabIndex = 0;
            viewComboBox.SelectedIndexChanged += viewComboBox_SelectedIndexChanged;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem, scrambleToolStripMenuItem, enterColorToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(107, 24);
            fileToolStripMenuItem.Text = "&Rubik's Cube";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            resetToolStripMenuItem.Size = new Size(224, 26);
            resetToolStripMenuItem.Text = "&Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // scrambleToolStripMenuItem
            // 
            scrambleToolStripMenuItem.Name = "scrambleToolStripMenuItem";
            scrambleToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            scrambleToolStripMenuItem.Size = new Size(224, 26);
            scrambleToolStripMenuItem.Text = "&Scramble";
            scrambleToolStripMenuItem.Click += scrambleToolStripMenuItem_Click;
            // 
            // enterColorToolStripMenuItem
            // 
            enterColorToolStripMenuItem.Name = "enterColorToolStripMenuItem";
            enterColorToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            enterColorToolStripMenuItem.Size = new Size(224, 26);
            enterColorToolStripMenuItem.Text = "enter Color";
            enterColorToolStripMenuItem.Click += enterColorToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(64, 24);
            helpToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1312, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // renderPanel
            // 
            renderPanel.Controls.Add(label3);
            renderPanel.Location = new Point(14, 41);
            renderPanel.Margin = new Padding(3, 4, 3, 4);
            renderPanel.Name = "renderPanel";
            renderPanel.Size = new Size(802, 761);
            renderPanel.TabIndex = 3;
            renderPanel.Paint += renderPanel_Paint;
            renderPanel.MouseClick += renderPanel_MouseClick;
            renderPanel.MouseMove += renderPanel_MouseMove;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 667);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 810);
            Controls.Add(renderPanel);
            Controls.Add(viewGroupBox);
            Controls.Add(statusPanel);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Virtual Rubik's Cube";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            viewGroupBox.ResumeLayout(false);
            viewGroupBox.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            renderPanel.ResumeLayout(false);
            renderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button setQueueToSolutionButton;
        private Button clearQueueButton;
        private Button executeQueueButton;
        private Button bPrimeButton;
        private Button bButton;
        private Button fPrimeButton;
        private Button fButton;
        private Button lPrimeButton;
        private Button lButton;
        private Button rPrimeButton;
        private Button rButton;
        private Button dPrimeButton;
        private Button dButton;
        private Button uPrimeButton;
        private Button uButton;
        private RadioButton addToQueueRadioButton;
        private RadioButton rotateRadioButton;
        private Label label1;
        private Panel statusPanel;
        private Label faceLabel;
        private Label zoomLabel;
        private Label rotationLabel;
        private Label statusLabel;
        private Button showViewButton;
        private GroupBox viewGroupBox;
        private ComboBox viewComboBox;
        private Label label2;
        private ListBox moveQueueListBox;
        private ToolTip toolTip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem enterColorToolStripMenuItem; // nhap mau item
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem scrambleToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip;
        private Panel renderPanel;
        private Label label3;
    }
}

