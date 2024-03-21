using System.Windows.Forms;

namespace WinFormsUI_2
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            LockedFilePanel.Visible = true;
            NoFilesPanel.Visible = false;
            RelocationPanel.Visible = false;
        }

        private void AddButton_MouseDown(object sender, MouseEventArgs e)
        {
            AddButtonContextMenuStrip.Show(AddButton, 0, AddButton.Height);
        }

        private void AddExistingFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ImportArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RelocateButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnlockedShredButton_Click(object sender, EventArgs e)
        {

        }

        private void GenerateRandomButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void EyeballLabel_Click(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
