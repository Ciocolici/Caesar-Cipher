namespace Caesar_Cryptography
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            encryptButton = new Button();
            decryptButton = new Button();
            saveFileButton = new Button();
            loadFileButton = new Button();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(31, 32);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(548, 23);
            inputTextBox.TabIndex = 0;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(31, 134);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(548, 23);
            outputTextBox.TabIndex = 1;
            outputTextBox.TextChanged += outputTextBox_TextChanged;
            // 
            // encryptButton
            // 
            encryptButton.Location = new Point(31, 61);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(92, 23);
            encryptButton.TabIndex = 2;
            encryptButton.Text = "Verschlüsseln";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Location = new Point(31, 163);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(94, 23);
            decryptButton.TabIndex = 4;
            decryptButton.Text = "Entschlüsseln";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // saveFileButton
            // 
            saveFileButton.Location = new Point(385, 163);
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(75, 23);
            saveFileButton.TabIndex = 6;
            saveFileButton.Text = "Speichern";
            saveFileButton.UseVisualStyleBackColor = true;
            saveFileButton.Click += saveFileButton_Click;
            // 
            // loadFileButton
            // 
            loadFileButton.Location = new Point(504, 163);
            loadFileButton.Name = "loadFileButton";
            loadFileButton.Size = new Size(75, 23);
            loadFileButton.TabIndex = 7;
            loadFileButton.Text = "Laden";
            loadFileButton.UseVisualStyleBackColor = true;
            loadFileButton.Click += loadFileButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 224);
            Controls.Add(loadFileButton);
            Controls.Add(saveFileButton);
            Controls.Add(decryptButton);
            Controls.Add(encryptButton);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Caeser Cryptography";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Button encryptButton;
        private Button decryptButton;
        private Button saveFileButton;
        private Button loadFileButton;
    }
}