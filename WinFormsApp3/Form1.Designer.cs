namespace WinFormsApp3
{
    partial class formLab1
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
            panel1 = new Panel();
            btnClear = new Button();
            btnDecipher = new Button();
            btnEncipher = new Button();
            dgwBaseGrille = new DataGridView();
            lblGrille = new Label();
            tbVigenereKey = new TextBox();
            lblKey = new Label();
            menuStrip1 = new MenuStrip();
            tsmiOpenFile = new ToolStripMenuItem();
            plaintextToolStripMenuItem = new ToolStripMenuItem();
            ciphertextToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            plaintextSaveToolStripMenuItem = new ToolStripMenuItem();
            ciphertextSaveToolStripMenuItem = new ToolStripMenuItem();
            lblMethods = new Label();
            cbMethods = new ComboBox();
            panel2 = new Panel();
            lblPlaintext = new Label();
            tbPlaintext = new TextBox();
            panel3 = new Panel();
            tbCiphertext = new TextBox();
            lblCiphertext = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwBaseGrille).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDecipher);
            panel1.Controls.Add(btnEncipher);
            panel1.Controls.Add(dgwBaseGrille);
            panel1.Controls.Add(lblGrille);
            panel1.Controls.Add(tbVigenereKey);
            panel1.Controls.Add(lblKey);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(lblMethods);
            panel1.Controls.Add(cbMethods);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 526);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(9, 373);
            btnClear.Margin = new Padding(2, 1, 2, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(250, 28);
            btnClear.TabIndex = 8;
            btnClear.Text = "Очистить матрицу";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDecipher
            // 
            btnDecipher.Location = new Point(9, 476);
            btnDecipher.Margin = new Padding(2, 1, 2, 1);
            btnDecipher.Name = "btnDecipher";
            btnDecipher.Size = new Size(250, 28);
            btnDecipher.TabIndex = 7;
            btnDecipher.Text = "Дешифровать";
            btnDecipher.UseVisualStyleBackColor = true;
            btnDecipher.Click += btnDecipher_Click;
            // 
            // btnEncipher
            // 
            btnEncipher.Location = new Point(9, 446);
            btnEncipher.Margin = new Padding(2, 1, 2, 1);
            btnEncipher.Name = "btnEncipher";
            btnEncipher.Size = new Size(250, 28);
            btnEncipher.TabIndex = 6;
            btnEncipher.Text = "Зашифровать";
            btnEncipher.UseVisualStyleBackColor = true;
            btnEncipher.Click += btnEncipher_Click;
            // 
            // dgwBaseGrille
            // 
            dgwBaseGrille.AllowUserToAddRows = false;
            dgwBaseGrille.AllowUserToDeleteRows = false;
            dgwBaseGrille.AllowUserToResizeColumns = false;
            dgwBaseGrille.AllowUserToResizeRows = false;
            dgwBaseGrille.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBaseGrille.ColumnHeadersVisible = false;
            dgwBaseGrille.Enabled = false;
            dgwBaseGrille.Location = new Point(36, 162);
            dgwBaseGrille.Margin = new Padding(2, 1, 2, 1);
            dgwBaseGrille.MultiSelect = false;
            dgwBaseGrille.Name = "dgwBaseGrille";
            dgwBaseGrille.ReadOnly = true;
            dgwBaseGrille.RowHeadersVisible = false;
            dgwBaseGrille.RowHeadersWidth = 82;
            dgwBaseGrille.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgwBaseGrille.RowTemplate.Height = 50;
            dgwBaseGrille.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgwBaseGrille.Size = new Size(200, 200);
            dgwBaseGrille.TabIndex = 5;
            dgwBaseGrille.CellClick += dgwBaseGrille_CellClick;
            dgwBaseGrille.SelectionChanged += dgwBaseGrille_SelectionChanged;
            dgwBaseGrille.Leave += dgwBaseGrille_Leave;
            // 
            // lblGrille
            // 
            lblGrille.AutoSize = true;
            lblGrille.Location = new Point(13, 132);
            lblGrille.Margin = new Padding(2, 0, 2, 0);
            lblGrille.Name = "lblGrille";
            lblGrille.Size = new Size(156, 15);
            lblGrille.TabIndex = 4;
            lblGrille.Text = "Введите ключ для решетки";
            // 
            // tbVigenereKey
            // 
            tbVigenereKey.Enabled = false;
            tbVigenereKey.Location = new Point(9, 105);
            tbVigenereKey.Margin = new Padding(2, 1, 2, 1);
            tbVigenereKey.Name = "tbVigenereKey";
            tbVigenereKey.Size = new Size(266, 23);
            tbVigenereKey.TabIndex = 0;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(9, 81);
            lblKey.Margin = new Padding(2, 0, 2, 0);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(163, 15);
            lblKey.TabIndex = 3;
            lblKey.Text = "Введите ключ для Виженера";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiOpenFile, saveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(281, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOpenFile
            // 
            tsmiOpenFile.DropDownItems.AddRange(new ToolStripItem[] { plaintextToolStripMenuItem, ciphertextToolStripMenuItem });
            tsmiOpenFile.Name = "tsmiOpenFile";
            tsmiOpenFile.Size = new Size(98, 22);
            tsmiOpenFile.Text = "Открыть файл";
            tsmiOpenFile.Click += toolStripMenuItem1_Click;
            // 
            // plaintextToolStripMenuItem
            // 
            plaintextToolStripMenuItem.Name = "plaintextToolStripMenuItem";
            plaintextToolStripMenuItem.Size = new Size(161, 22);
            plaintextToolStripMenuItem.Text = "Исходный текст";
            plaintextToolStripMenuItem.Click += plaintextToolStripMenuItem_Click;
            // 
            // ciphertextToolStripMenuItem
            // 
            ciphertextToolStripMenuItem.Name = "ciphertextToolStripMenuItem";
            ciphertextToolStripMenuItem.Size = new Size(161, 22);
            ciphertextToolStripMenuItem.Text = "Шифротекст";
            ciphertextToolStripMenuItem.Click += ciphertextToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { plaintextSaveToolStripMenuItem, ciphertextSaveToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(77, 22);
            saveToolStripMenuItem.Text = "Сохранить";
            // 
            // plaintextSaveToolStripMenuItem
            // 
            plaintextSaveToolStripMenuItem.Name = "plaintextSaveToolStripMenuItem";
            plaintextSaveToolStripMenuItem.Size = new Size(180, 22);
            plaintextSaveToolStripMenuItem.Text = "Исходный текст";
            plaintextSaveToolStripMenuItem.Click += plaintextSaveToolStripMenuItem_Click;
            // 
            // ciphertextSaveToolStripMenuItem
            // 
            ciphertextSaveToolStripMenuItem.Name = "ciphertextSaveToolStripMenuItem";
            ciphertextSaveToolStripMenuItem.Size = new Size(180, 22);
            ciphertextSaveToolStripMenuItem.Text = "Шифротекст";
            ciphertextSaveToolStripMenuItem.Click += ciphertextSaveToolStripMenuItem_Click;
            // 
            // lblMethods
            // 
            lblMethods.AutoSize = true;
            lblMethods.Location = new Point(6, 30);
            lblMethods.Margin = new Padding(2, 0, 2, 0);
            lblMethods.Name = "lblMethods";
            lblMethods.Size = new Size(173, 15);
            lblMethods.TabIndex = 1;
            lblMethods.Text = "Выберите метод шифрования";
            lblMethods.Click += lblMethods_Click;
            // 
            // cbMethods
            // 
            cbMethods.FormattingEnabled = true;
            cbMethods.Items.AddRange(new object[] { "Виженера с прог. ключом (рус)", "поворачивающейся решетки (англ)" });
            cbMethods.Location = new Point(9, 52);
            cbMethods.Margin = new Padding(2, 1, 2, 1);
            cbMethods.Name = "cbMethods";
            cbMethods.Size = new Size(266, 23);
            cbMethods.TabIndex = 0;
            cbMethods.SelectedIndexChanged += cbMethods_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPlaintext);
            panel2.Controls.Add(tbPlaintext);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(281, 0);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 264);
            panel2.TabIndex = 1;
            // 
            // lblPlaintext
            // 
            lblPlaintext.AutoSize = true;
            lblPlaintext.Location = new Point(10, 4);
            lblPlaintext.Margin = new Padding(2, 0, 2, 0);
            lblPlaintext.Name = "lblPlaintext";
            lblPlaintext.Size = new Size(94, 15);
            lblPlaintext.TabIndex = 2;
            lblPlaintext.Text = "Исходный текст";
            // 
            // tbPlaintext
            // 
            tbPlaintext.Location = new Point(10, 30);
            tbPlaintext.Margin = new Padding(2, 1, 2, 1);
            tbPlaintext.Multiline = true;
            tbPlaintext.Name = "tbPlaintext";
            tbPlaintext.Size = new Size(548, 226);
            tbPlaintext.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbCiphertext);
            panel3.Controls.Add(lblCiphertext);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(281, 264);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(566, 262);
            panel3.TabIndex = 2;
            // 
            // tbCiphertext
            // 
            tbCiphertext.Location = new Point(11, 33);
            tbCiphertext.Margin = new Padding(2, 1, 2, 1);
            tbCiphertext.Multiline = true;
            tbCiphertext.Name = "tbCiphertext";
            tbCiphertext.Size = new Size(548, 220);
            tbCiphertext.TabIndex = 4;
            // 
            // lblCiphertext
            // 
            lblCiphertext.AutoSize = true;
            lblCiphertext.Location = new Point(10, 9);
            lblCiphertext.Margin = new Padding(2, 0, 2, 0);
            lblCiphertext.Name = "lblCiphertext";
            lblCiphertext.Size = new Size(76, 15);
            lblCiphertext.TabIndex = 3;
            lblCiphertext.Text = "Шифротекст";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt";
            openFileDialog1.Title = "Выберите файл";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog1.Title = "Сохранить файл";
            // 
            // formLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 526);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formLab1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная работа 1, Лутай, 351003";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwBaseGrille).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblMethods;
        private ComboBox cbMethods;
        private Panel panel2;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiOpenFile;
        private TextBox tbVigenereKey;
        private Button btnEncipher;
        private DataGridView dgwBaseGrille;
        private Label lblGrille;
        private Label lblKey;
        private Label lblPlaintext;
        private TextBox tbPlaintext;
        private TextBox tbCiphertext;
        private Label lblCiphertext;
        private Button btnDecipher;
        private OpenFileDialog openFileDialog1;
        private Button btnClear;
        private ToolStripMenuItem plaintextToolStripMenuItem;
        private ToolStripMenuItem ciphertextToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem plaintextSaveToolStripMenuItem;
        private ToolStripMenuItem ciphertextSaveToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
    }
}
