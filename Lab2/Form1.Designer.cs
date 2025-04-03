namespace Lab2
{
    partial class FormMain
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
            tbPlaintext = new TextBox();
            tbKey = new TextBox();
            tbCiphertext = new TextBox();
            menuStrip1 = new MenuStrip();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            lblPlaintext = new Label();
            lblKey = new Label();
            lblCiphertext = new Label();
            tbBaseState = new TextBox();
            lblDefaultRegister = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnGetKey = new Button();
            btnEncipher = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbPlaintext
            // 
            tbPlaintext.Location = new Point(10, 138);
            tbPlaintext.Multiline = true;
            tbPlaintext.Name = "tbPlaintext";
            tbPlaintext.Size = new Size(300, 321);
            tbPlaintext.TabIndex = 0;
            // 
            // tbKey
            // 
            tbKey.Location = new Point(320, 138);
            tbKey.Multiline = true;
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(300, 321);
            tbKey.TabIndex = 1;
            // 
            // tbCiphertext
            // 
            tbCiphertext.Location = new Point(630, 138);
            tbCiphertext.Multiline = true;
            tbCiphertext.Name = "tbCiphertext";
            tbCiphertext.Size = new Size(300, 321);
            tbCiphertext.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(939, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(67, 20);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(62, 20);
            saveFileToolStripMenuItem.Text = "Save file";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // lblPlaintext
            // 
            lblPlaintext.AutoSize = true;
            lblPlaintext.Location = new Point(12, 120);
            lblPlaintext.Name = "lblPlaintext";
            lblPlaintext.Size = new Size(94, 15);
            lblPlaintext.TabIndex = 4;
            lblPlaintext.Text = "Исходный текст";
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(320, 120);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(38, 15);
            lblKey.TabIndex = 5;
            lblKey.Text = "Ключ";
            // 
            // lblCiphertext
            // 
            lblCiphertext.AutoSize = true;
            lblCiphertext.Location = new Point(630, 120);
            lblCiphertext.Name = "lblCiphertext";
            lblCiphertext.Size = new Size(76, 15);
            lblCiphertext.TabIndex = 6;
            lblCiphertext.Text = "Шифротекст";
            // 
            // tbBaseState
            // 
            tbBaseState.Location = new Point(205, 35);
            tbBaseState.Multiline = true;
            tbBaseState.Name = "tbBaseState";
            tbBaseState.Size = new Size(606, 25);
            tbBaseState.TabIndex = 7;
            // 
            // lblDefaultRegister
            // 
            lblDefaultRegister.AutoSize = true;
            lblDefaultRegister.Location = new Point(10, 43);
            lblDefaultRegister.Name = "lblDefaultRegister";
            lblDefaultRegister.Size = new Size(180, 15);
            lblDefaultRegister.TabIndex = 8;
            lblDefaultRegister.Text = "Начальное состояние регистра";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGetKey
            // 
            btnGetKey.Location = new Point(817, 33);
            btnGetKey.Name = "btnGetKey";
            btnGetKey.Size = new Size(113, 25);
            btnGetKey.TabIndex = 9;
            btnGetKey.Text = "Получить ключ";
            btnGetKey.UseVisualStyleBackColor = true;
            btnGetKey.Click += btnGetKey_Click;
            // 
            // btnEncipher
            // 
            btnEncipher.Location = new Point(416, 78);
            btnEncipher.Name = "btnEncipher";
            btnEncipher.Size = new Size(113, 25);
            btnEncipher.TabIndex = 10;
            btnEncipher.Text = "Зашифровать";
            btnEncipher.UseVisualStyleBackColor = true;
            btnEncipher.Click += btnEncipher_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(939, 459);
            Controls.Add(btnEncipher);
            Controls.Add(btnGetKey);
            Controls.Add(lblDefaultRegister);
            Controls.Add(tbBaseState);
            Controls.Add(lblCiphertext);
            Controls.Add(lblKey);
            Controls.Add(lblPlaintext);
            Controls.Add(tbCiphertext);
            Controls.Add(tbKey);
            Controls.Add(tbPlaintext);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Лабораторная 2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPlaintext;
        private TextBox tbKey;
        private TextBox tbCiphertext;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private Label lblPlaintext;
        private Label lblKey;
        private Label lblCiphertext;
        private TextBox tbBaseState;
        private Label lblDefaultRegister;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnGetKey;
        private Button btnEncipher;
    }
}
