namespace MyTextEncryptor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ActionGroupBox = new System.Windows.Forms.GroupBox();
            this.DecryptRadio = new System.Windows.Forms.RadioButton();
            this.EncryptRadio = new System.Windows.Forms.RadioButton();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.FormatTypeDropList = new System.Windows.Forms.ToolStripDropDownButton();
            this.base64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MD5ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenRepositoryButton = new System.Windows.Forms.ToolStripButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.CopyToBufferButton = new System.Windows.Forms.Button();
            this.ResetTextButton = new System.Windows.Forms.Button();
            this.ActionGroupBox.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(122, 28);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(450, 26);
            this.InputTextBox.TabIndex = 0;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLabel.Location = new System.Drawing.Point(23, 31);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(83, 22);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "Input text";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(18, 72);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(98, 22);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output text";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(122, 69);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(450, 26);
            this.OutputTextBox.TabIndex = 2;
            // 
            // ActionGroupBox
            // 
            this.ActionGroupBox.Controls.Add(this.DecryptRadio);
            this.ActionGroupBox.Controls.Add(this.EncryptRadio);
            this.ActionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionGroupBox.Location = new System.Drawing.Point(22, 130);
            this.ActionGroupBox.Name = "ActionGroupBox";
            this.ActionGroupBox.Size = new System.Drawing.Size(165, 112);
            this.ActionGroupBox.TabIndex = 4;
            this.ActionGroupBox.TabStop = false;
            this.ActionGroupBox.Text = "Action";
            // 
            // DecryptRadio
            // 
            this.DecryptRadio.AutoSize = true;
            this.DecryptRadio.Location = new System.Drawing.Point(12, 71);
            this.DecryptRadio.Name = "DecryptRadio";
            this.DecryptRadio.Size = new System.Drawing.Size(82, 24);
            this.DecryptRadio.TabIndex = 1;
            this.DecryptRadio.Text = "Decrypt";
            this.DecryptRadio.UseVisualStyleBackColor = true;
            this.DecryptRadio.CheckedChanged += new System.EventHandler(this.DecryptRadio_CheckedChanged);
            // 
            // EncryptRadio
            // 
            this.EncryptRadio.AutoSize = true;
            this.EncryptRadio.Location = new System.Drawing.Point(12, 32);
            this.EncryptRadio.Name = "EncryptRadio";
            this.EncryptRadio.Size = new System.Drawing.Size(81, 24);
            this.EncryptRadio.TabIndex = 0;
            this.EncryptRadio.Text = "Encrypt";
            this.EncryptRadio.UseVisualStyleBackColor = true;
            this.EncryptRadio.CheckedChanged += new System.EventHandler(this.EncryptRadio_CheckedChanged);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatTypeDropList,
            this.toolStripSeparator1,
            this.OpenRepositoryButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(584, 25);
            this.MainToolStrip.TabIndex = 5;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // FormatTypeDropList
            // 
            this.FormatTypeDropList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FormatTypeDropList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.base64ToolStripMenuItem,
            this.MD5ToolStrip,
            this.ASCIIToolStripMenuItem,
            this.binaryCodeToolStripMenuItem});
            this.FormatTypeDropList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FormatTypeDropList.Name = "FormatTypeDropList";
            this.FormatTypeDropList.Size = new System.Drawing.Size(86, 22);
            this.FormatTypeDropList.Text = "Format Type";
            // 
            // base64ToolStripMenuItem
            // 
            this.base64ToolStripMenuItem.Checked = true;
            this.base64ToolStripMenuItem.CheckOnClick = true;
            this.base64ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.base64ToolStripMenuItem.Name = "base64ToolStripMenuItem";
            this.base64ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.base64ToolStripMenuItem.Tag = "";
            this.base64ToolStripMenuItem.Text = "Base64";
            this.base64ToolStripMenuItem.Click += new System.EventHandler(this.base64ToolStripMenuItem_Click);
            // 
            // MD5ToolStrip
            // 
            this.MD5ToolStrip.CheckOnClick = true;
            this.MD5ToolStrip.Name = "MD5ToolStrip";
            this.MD5ToolStrip.Size = new System.Drawing.Size(138, 22);
            this.MD5ToolStrip.Tag = "";
            this.MD5ToolStrip.Text = "MD5";
            this.MD5ToolStrip.Click += new System.EventHandler(this.MD5ToolStrip_Click);
            // 
            // ASCIIToolStripMenuItem
            // 
            this.ASCIIToolStripMenuItem.Name = "ASCIIToolStripMenuItem";
            this.ASCIIToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ASCIIToolStripMenuItem.Text = "ASCII";
            this.ASCIIToolStripMenuItem.Click += new System.EventHandler(this.ASCIIToolStripMenuItem_Click);
            // 
            // binaryCodeToolStripMenuItem
            // 
            this.binaryCodeToolStripMenuItem.Name = "binaryCodeToolStripMenuItem";
            this.binaryCodeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.binaryCodeToolStripMenuItem.Text = "Binary Code";
            this.binaryCodeToolStripMenuItem.Click += new System.EventHandler(this.binaryCodeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // OpenRepositoryButton
            // 
            this.OpenRepositoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenRepositoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenRepositoryButton.Name = "OpenRepositoryButton";
            this.OpenRepositoryButton.Size = new System.Drawing.Size(108, 22);
            this.OpenRepositoryButton.Text = "GitHub Repository";
            this.OpenRepositoryButton.Click += new System.EventHandler(this.OpenRepositoryButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(410, 201);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(162, 41);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CopyToBufferButton
            // 
            this.CopyToBufferButton.Enabled = false;
            this.CopyToBufferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyToBufferButton.Location = new System.Drawing.Point(225, 201);
            this.CopyToBufferButton.Name = "CopyToBufferButton";
            this.CopyToBufferButton.Size = new System.Drawing.Size(162, 41);
            this.CopyToBufferButton.TabIndex = 7;
            this.CopyToBufferButton.Text = "Copy result";
            this.CopyToBufferButton.UseVisualStyleBackColor = true;
            this.CopyToBufferButton.Click += new System.EventHandler(this.CopyToBufferButton_Click);
            // 
            // ResetTextButton
            // 
            this.ResetTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetTextButton.Location = new System.Drawing.Point(410, 101);
            this.ResetTextButton.Name = "ResetTextButton";
            this.ResetTextButton.Size = new System.Drawing.Size(162, 41);
            this.ResetTextButton.TabIndex = 8;
            this.ResetTextButton.Text = "Reset";
            this.ResetTextButton.UseVisualStyleBackColor = true;
            this.ResetTextButton.Click += new System.EventHandler(this.ResetTextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 276);
            this.Controls.Add(this.ResetTextButton);
            this.Controls.Add(this.CopyToBufferButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.ActionGroupBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Text Encryptor";
            this.ActionGroupBox.ResumeLayout(false);
            this.ActionGroupBox.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.GroupBox ActionGroupBox;
        private System.Windows.Forms.RadioButton DecryptRadio;
        private System.Windows.Forms.RadioButton EncryptRadio;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton OpenRepositoryButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ToolStripDropDownButton FormatTypeDropList;
        private System.Windows.Forms.ToolStripMenuItem base64ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MD5ToolStrip;
        private System.Windows.Forms.Button CopyToBufferButton;
        private System.Windows.Forms.Button ResetTextButton;
        private System.Windows.Forms.ToolStripMenuItem ASCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryCodeToolStripMenuItem;
    }
}

