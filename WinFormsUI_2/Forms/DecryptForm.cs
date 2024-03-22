using FileLockerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI_2;

namespace WinFormsUI_2;

public partial class DecryptForm : Form
{
    private IDecryptFormCaller caller;
    private FileModel model;
    private bool isEyeballLabelClicked = false;

    public DecryptForm(IDecryptFormCaller caller, FileModel model)
    {
        InitializeComponent();

        this.caller = caller;
        this.model = model;
    }

    private void EnterButton_Click(object sender, EventArgs e)
    {
    }

    private void EyeballLabel_Click(object sender, EventArgs e)
    {

    }
}
