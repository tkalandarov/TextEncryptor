using System;
using System.Windows.Forms;
using MyTextEncryptor.TextWorking;
using MyTextEncryptor.Tools;

namespace MyTextEncryptor
{
    public partial class MainForm : Form
    {
        ITextWorker TextWorker;
        FormatMethod FormatMethod;
        enum PossibleFormatMethods { Everything, EncryptionOnly, DecryptionOnly }

        public MainForm()
        {
            InitializeComponent();
            ActiveControl = InputTextBox;
            // Default format type is Base64
            TextWorker = new Base64Worker();
        }

        private void base64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormatMethod(sender, new Base64Worker(), PossibleFormatMethods.Everything);
        }
        private void MD5ToolStrip_Click(object sender, EventArgs e)
        {
            ChangeFormatMethod(sender, new MD5Worker(), PossibleFormatMethods.EncryptionOnly);
        }
        private void ASCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormatMethod(sender, new ASCIIWorker(), PossibleFormatMethods.Everything);
        }
        private void binaryCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormatMethod(sender, new BinaryWorker(), PossibleFormatMethods.Everything);
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!EncryptRadio.Checked && !DecryptRadio.Checked)
            {
                ShowErrorWindow("Choose an option first");
                return;
            }
            if (InputTextBox.Text == "")
            {
                ShowErrorWindow("Check the correction of your input");
                return;
            }
            TextFormatter Formatter = new TextFormatter(TextWorker, FormatMethod);

            // Make sure that text is clean of unuseful spaces
            string targetText = InputTextBox.Text.DeleteLeadingAndTrailingSpaces();
            string result = Formatter.ExecuteProcess(targetText).DeleteLeadingAndTrailingSpaces();
            OutputTextBox.Text = result;
            CopyToBufferButton.Enabled = true;
        }
        private void ResetTextButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            OutputTextBox.Clear();
            CopyToBufferButton.Enabled = false;
            ActiveControl = InputTextBox;
        }
        private void CopyToBufferButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(OutputTextBox.Text);
                MessageBox.Show("Copied succesfully!", "Text Encryptor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                ShowErrorWindow(ex.Message);
            }
        }
        private void EncryptRadio_CheckedChanged(object sender, EventArgs e)
        {
            FormatMethod = FormatMethod.Encrypt;
            OutputTextBox.Clear();
        }
        private void DecryptRadio_CheckedChanged(object sender, EventArgs e)
        {
            FormatMethod = FormatMethod.Decrypt;
            OutputTextBox.Clear();
        }
        private void OpenRepositoryButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitlab.com/jellysandwich/textencryptor");
        }

        // Useful additional methods:
        private void ChangeFormatMethod(object SelectedToolStripObject, ITextWorker textWorker, PossibleFormatMethods formatMethods)
        {
            UncheckToolStripMenuItems(SelectedToolStripObject);
            TextWorker = textWorker;
            switch (formatMethods)
            {
                case PossibleFormatMethods.Everything:
                    EnableEverything();
                    break;
                case PossibleFormatMethods.EncryptionOnly:
                    EncryptionOnly();
                    break;
                case PossibleFormatMethods.DecryptionOnly:
                    DecryptionOnly();
                    break;
            }
            ResetUI();
        }
        private void UncheckToolStripMenuItems(object sender)
        {
            foreach (ToolStripMenuItem item in ((ToolStripMenuItem)sender).GetCurrentParent().Items)
            {
                if (item == sender) item.Checked = true;
                if (item != sender) item.Checked = false;
            }
        }
        private void DecryptionOnly()
        {
            EncryptRadio.Enabled = false;
            DecryptRadio.Enabled = true;
        }
        private void EncryptionOnly()
        {
            EncryptRadio.Enabled = true;
            DecryptRadio.Enabled = false;
        }
        private void EnableEverything()
        {
            EncryptRadio.Enabled = true;
            DecryptRadio.Enabled = true;
        }
        private void ResetUI()
        {
            if (!EncryptRadio.Enabled)
                DecryptRadio.Checked = true;
            else if (!DecryptRadio.Enabled)
                EncryptRadio.Checked = true;
            else
            {
                EncryptRadio.Checked = false;
                DecryptRadio.Checked = false;
            }
            InputTextBox.Clear();
            OutputTextBox.Clear();
            CopyToBufferButton.Enabled = false;
        }
        private void ShowErrorWindow(string exceptionLog)
        {
            MessageBox.Show($"{exceptionLog}", "An exception has occured!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
