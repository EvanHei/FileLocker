namespace WinFormsUI
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
            SaveToButton = new Button();
            SaveToLabel = new Label();
            OpenLabel = new Label();
            OpenButton = new Button();
            ImportButton = new Button();
            SuspendLayout();
            // 
            // SaveToButton
            // 
            SaveToButton.BackColor = Color.Silver;
            SaveToButton.Enabled = false;
            SaveToButton.FlatStyle = FlatStyle.Flat;
            SaveToButton.Font = new Font("Segoe UI Emoji", 12F);
            SaveToButton.ForeColor = SystemColors.ButtonFace;
            SaveToButton.Location = new Point(36, 130);
            SaveToButton.Name = "SaveToButton";
            SaveToButton.Size = new Size(83, 37);
            SaveToButton.TabIndex = 6;
            SaveToButton.Text = "Save To";
            SaveToButton.UseVisualStyleBackColor = false;
            SaveToButton.Click += SaveToButton_Click;
            // 
            // SaveToLabel
            // 
            SaveToLabel.AutoSize = true;
            SaveToLabel.Font = new Font("Segoe UI Emoji", 12F);
            SaveToLabel.ForeColor = SystemColors.ButtonFace;
            SaveToLabel.Location = new Point(119, 138);
            SaveToLabel.Name = "SaveToLabel";
            SaveToLabel.Size = new Size(19, 21);
            SaveToLabel.TabIndex = 7;
            SaveToLabel.Text = "...";
            // 
            // OpenLabel
            // 
            OpenLabel.AutoSize = true;
            OpenLabel.Font = new Font("Segoe UI Emoji", 12F);
            OpenLabel.ForeColor = SystemColors.ButtonFace;
            OpenLabel.Location = new Point(119, 86);
            OpenLabel.Name = "OpenLabel";
            OpenLabel.Size = new Size(19, 21);
            OpenLabel.TabIndex = 9;
            OpenLabel.Text = "...";
            // 
            // OpenButton
            // 
            OpenButton.BackColor = SystemColors.Highlight;
            OpenButton.FlatStyle = FlatStyle.Flat;
            OpenButton.Font = new Font("Segoe UI Emoji", 12F);
            OpenButton.ForeColor = SystemColors.ButtonFace;
            OpenButton.Location = new Point(36, 78);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(83, 37);
            OpenButton.TabIndex = 8;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = false;
            OpenButton.Click += OpenButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.BackColor = Color.Silver;
            ImportButton.Enabled = false;
            ImportButton.FlatStyle = FlatStyle.Flat;
            ImportButton.Font = new Font("Segoe UI Emoji", 12F);
            ImportButton.ForeColor = SystemColors.ButtonFace;
            ImportButton.Location = new Point(227, 205);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(83, 37);
            ImportButton.TabIndex = 10;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = false;
            ImportButton.Click += ImportButton_Click;
            // 
            // ImportForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(541, 278);
            Controls.Add(ImportButton);
            Controls.Add(OpenLabel);
            Controls.Add(OpenButton);
            Controls.Add(SaveToLabel);
            Controls.Add(SaveToButton);
            Font = new Font("Segoe UI Emoji", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ImportForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Import";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveToButton;
        private Label SaveToLabel;
        private Label OpenLabel;
        private Button OpenButton;
        private Button ImportButton;
    }
}