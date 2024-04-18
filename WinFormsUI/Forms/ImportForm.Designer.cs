namespace WinFormsUI.Forms
{
    partial class ImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            ImportButton = new Button();
            OpenLabel = new Label();
            OpenButton = new Button();
            SaveToLabel = new Label();
            SaveToButton = new Button();
            MenuStrip = new MenuStrip();
            CloseMenuItem = new ToolStripMenuItem();
            ImportToolStripMenuItem = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ImportButton
            // 
            ImportButton.BackColor = Color.Silver;
            ImportButton.Enabled = false;
            ImportButton.FlatStyle = FlatStyle.Flat;
            ImportButton.Font = new Font("Segoe UI Emoji", 12F);
            ImportButton.ForeColor = SystemColors.ButtonFace;
            ImportButton.Location = new Point(236, 201);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(83, 37);
            ImportButton.TabIndex = 15;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = false;
            ImportButton.Click += ImportButton_Click;
            // 
            // OpenLabel
            // 
            OpenLabel.AutoSize = true;
            OpenLabel.Font = new Font("Segoe UI Emoji", 12F);
            OpenLabel.ForeColor = SystemColors.ButtonFace;
            OpenLabel.Location = new Point(128, 82);
            OpenLabel.Name = "OpenLabel";
            OpenLabel.Size = new Size(19, 21);
            OpenLabel.TabIndex = 14;
            OpenLabel.Text = "...";
            // 
            // OpenButton
            // 
            OpenButton.BackColor = SystemColors.Highlight;
            OpenButton.FlatStyle = FlatStyle.Flat;
            OpenButton.Font = new Font("Segoe UI Emoji", 12F);
            OpenButton.ForeColor = SystemColors.ButtonFace;
            OpenButton.Location = new Point(45, 74);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(83, 37);
            OpenButton.TabIndex = 13;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = false;
            OpenButton.Click += OpenButton_Click;
            // 
            // SaveToLabel
            // 
            SaveToLabel.AutoSize = true;
            SaveToLabel.Font = new Font("Segoe UI Emoji", 12F);
            SaveToLabel.ForeColor = SystemColors.ButtonFace;
            SaveToLabel.Location = new Point(128, 134);
            SaveToLabel.Name = "SaveToLabel";
            SaveToLabel.Size = new Size(19, 21);
            SaveToLabel.TabIndex = 12;
            SaveToLabel.Text = "...";
            // 
            // SaveToButton
            // 
            SaveToButton.BackColor = Color.Silver;
            SaveToButton.Enabled = false;
            SaveToButton.FlatStyle = FlatStyle.Flat;
            SaveToButton.Font = new Font("Segoe UI Emoji", 12F);
            SaveToButton.ForeColor = SystemColors.ButtonFace;
            SaveToButton.Location = new Point(45, 126);
            SaveToButton.Name = "SaveToButton";
            SaveToButton.Size = new Size(83, 37);
            SaveToButton.TabIndex = 11;
            SaveToButton.Text = "Save To";
            SaveToButton.UseVisualStyleBackColor = false;
            SaveToButton.Click += SaveToButton_Click;
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            MenuStrip.Font = new Font("Segoe UI Emoji", 10F);
            MenuStrip.Items.AddRange(new ToolStripItem[] { CloseMenuItem, ImportToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(541, 29);
            MenuStrip.TabIndex = 35;
            MenuStrip.Text = "menuStrip1";
            // 
            // CloseMenuItem
            // 
            CloseMenuItem.Alignment = ToolStripItemAlignment.Right;
            CloseMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            CloseMenuItem.ForeColor = SystemColors.AppWorkspace;
            CloseMenuItem.Margin = new Padding(0, 2, 0, 0);
            CloseMenuItem.Name = "CloseMenuItem";
            CloseMenuItem.Size = new Size(40, 23);
            CloseMenuItem.Text = "❌";
            CloseMenuItem.Click += CloseMenuItem_Click;
            // 
            // ImportToolStripMenuItem
            // 
            ImportToolStripMenuItem.Enabled = false;
            ImportToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            ImportToolStripMenuItem.Size = new Size(63, 25);
            ImportToolStripMenuItem.Text = "Import";
            // 
            // ImportForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(541, 278);
            ControlBox = false;
            Controls.Add(MenuStrip);
            Controls.Add(ImportButton);
            Controls.Add(OpenLabel);
            Controls.Add(OpenButton);
            Controls.Add(SaveToLabel);
            Controls.Add(SaveToButton);
            Font = new Font("Segoe UI Emoji", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ImportForm";
            StartPosition = FormStartPosition.CenterParent;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ImportButton;
        private Label OpenLabel;
        private Button OpenButton;
        private Label SaveToLabel;
        private Button SaveToButton;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem CloseMenuItem;
        private ToolStripMenuItem ImportToolStripMenuItem;
    }
}