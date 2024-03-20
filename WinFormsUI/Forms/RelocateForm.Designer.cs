namespace WinFormsUI
{
    partial class RelocateForm
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
            RelocateButton = new Button();
            CantLocateFileLabel = new Label();
            LastSeenLabel = new Label();
            RemoveButton = new Button();
            SuspendLayout();
            // 
            // RelocateButton
            // 
            RelocateButton.BackColor = SystemColors.Highlight;
            RelocateButton.FlatStyle = FlatStyle.Flat;
            RelocateButton.Font = new Font("Segoe UI Emoji", 12F);
            RelocateButton.ForeColor = SystemColors.ButtonFace;
            RelocateButton.Location = new Point(291, 143);
            RelocateButton.Name = "RelocateButton";
            RelocateButton.Size = new Size(83, 37);
            RelocateButton.TabIndex = 13;
            RelocateButton.Text = "Relocate";
            RelocateButton.UseVisualStyleBackColor = false;
            RelocateButton.Click += RelocateButton_Click;
            // 
            // CantLocateFileLabel
            // 
            CantLocateFileLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CantLocateFileLabel.AutoSize = true;
            CantLocateFileLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            CantLocateFileLabel.ForeColor = SystemColors.ButtonFace;
            CantLocateFileLabel.Location = new Point(265, 39);
            CantLocateFileLabel.Name = "CantLocateFileLabel";
            CantLocateFileLabel.Size = new Size(238, 36);
            CantLocateFileLabel.TabIndex = 15;
            CantLocateFileLabel.Text = "Can't locate \"path\"";
            CantLocateFileLabel.TextChanged += CenterLabel_TextChanged;
            // 
            // LastSeenLabel
            // 
            LastSeenLabel.AutoSize = true;
            LastSeenLabel.Font = new Font("Segoe UI Emoji", 12F);
            LastSeenLabel.ForeColor = SystemColors.AppWorkspace;
            LastSeenLabel.Location = new Point(289, 75);
            LastSeenLabel.Name = "LastSeenLabel";
            LastSeenLabel.Size = new Size(191, 21);
            LastSeenLabel.TabIndex = 16;
            LastSeenLabel.Text = "It was last seen at <path>.";
            LastSeenLabel.TextChanged += CenterLabel_TextChanged;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.Highlight;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Segoe UI Emoji", 12F);
            RemoveButton.ForeColor = SystemColors.ButtonFace;
            RemoveButton.Location = new Point(380, 143);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(83, 37);
            RemoveButton.TabIndex = 17;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // RelocateForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(752, 209);
            Controls.Add(RemoveButton);
            Controls.Add(LastSeenLabel);
            Controls.Add(CantLocateFileLabel);
            Controls.Add(RelocateButton);
            Font = new Font("Segoe UI Emoji", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "RelocateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Relocate File";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button RelocateButton;
        private Label CantLocateFileLabel;
        private Label LastSeenLabel;
        private Button RemoveButton;
    }
}