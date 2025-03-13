using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class formLab1 : Form
    {
        static int[,] BASE_GRILLE = { { 1, 2, 3, 1 }, { 3, 4, 4, 2 }, { 2, 4, 4, 3 }, { 1, 3, 2, 1 } };
        static int GRILLE_SIZE = 4;
        public bool[,] grille = new bool[4, 4];
        public int holesPicked = 0;

        public formLab1()
        {
            InitializeComponent();
            InitializeMatrix();
        }

        private void InitializeMatrix()
        {
            dgwBaseGrille.ColumnCount = GRILLE_SIZE;
            dgwBaseGrille.RowCount = GRILLE_SIZE;

            for (int i = 0; i < dgwBaseGrille.ColumnCount; i++)
            {
                dgwBaseGrille.Columns[i].Name = "Column " + (i + 1);
                dgwBaseGrille.Columns[i].Width = dgwBaseGrille.Width / GRILLE_SIZE;
                dgwBaseGrille.Rows[i].Height = dgwBaseGrille.Height / GRILLE_SIZE;
            }

            for (int i = 0; i < dgwBaseGrille.RowCount; i++)
            {
                for (int j = 0; j < dgwBaseGrille.RowCount; j++)
                {
                    dgwBaseGrille.Rows[i].Cells[j].Value = BASE_GRILLE[i, j];
                }

            }
        }

        public int chosenMethod = -1;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void lblMethods_Click(object sender, EventArgs e)
        {

        }

        bool CheckGrilleCorrectness()
        {
            bool[] areHolesCorrectArray = new bool[GRILLE_SIZE];
            bool areHolesCorrect = true;
            for (int i = 0; i < GRILLE_SIZE; i++)
            {
                for (int j = 0; j < GRILLE_SIZE; j++)
                {
                    if (grille[i, j])
                    {
                        int index = (int)dgwBaseGrille.Rows[i].Cells[j].Value - 1;
                        if (!areHolesCorrectArray[index])
                        {
                            areHolesCorrectArray[index] = true;
                        }
                        else
                        {
                            areHolesCorrect = false;
                        }

                    }
                }
            }

            for (int i = 0; i < areHolesCorrectArray.Length; i++)
            {
                if (!areHolesCorrectArray[i])
                {
                    areHolesCorrect = false;
                }
            }
            return areHolesCorrect;
        }

        private void btnEncipher_Click(object sender, EventArgs e)
        {
            if (chosenMethod == 0)
            {
                if (tbVigenereKey.Text.Length < 1)
                {
                    MessageBox.Show("Неверный ключ");
                } else if (tbPlaintext.Text.Length == 0)
                {
                    MessageBox.Show("Пустой исходный текст");
                } else
                {
                    tbCiphertext.Text = Program.EncipherVigenere(tbPlaintext.Text, tbVigenereKey.Text);
                }
                    
            }
            else
            {

                if (CheckGrilleCorrectness())
                {
                    if (tbPlaintext.Text.Length != 0)
                    {
                        tbCiphertext.Text = Program.EncipherGrille(tbPlaintext.Text, grille);
                    }
                    else
                    {
                        MessageBox.Show("Пустой исходный текст");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный ключ");
                }

            }
        }

        private void cbMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenMethod = cbMethods.SelectedIndex;
            if (cbMethods.SelectedIndex == 0)
            {
                tbVigenereKey.Enabled = true;
                dgwBaseGrille.Enabled = false;
                tbVigenereKey.Text = "";

            }
            else
            {
                tbVigenereKey.Enabled = false;
                dgwBaseGrille.Enabled = true;
                tbVigenereKey.Text = "";


            }

        }

        private void btnDecipher_Click(object sender, EventArgs e)
        {
            if (chosenMethod == 0)
            {
                if(tbVigenereKey.Text.Length < 1)
                {
                    MessageBox.Show("Неверный ключ");
                } else if (tbCiphertext.Text.Length == 0)
                {
                    MessageBox.Show("Пустой шифротекст");
                }
                else
                {
                    tbPlaintext.Text = Program.DecipherVigenere(tbCiphertext.Text, tbVigenereKey.Text);
                }
            }
            else
            {
                if (CheckGrilleCorrectness())
                {
                    if (tbCiphertext.Text.Length != 0)
                    {
                        tbPlaintext.Text = Program.DecipherGrille(tbCiphertext.Text, grille);
                    }
                    else
                    {
                        MessageBox.Show("Пустой шифротекст");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный ключ");
                }
            }
        }

        private void dgwBaseGrille_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgwBaseGrille.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && holesPicked < 4 && cell.Style.BackColor != Color.DarkRed)
            {
                cell.Style.BackColor = Color.DarkRed;
                grille[e.RowIndex, e.ColumnIndex] = true;
                holesPicked++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell;

            for (int i = 0; i < dgwBaseGrille.RowCount; i++)
            {
                for (int j = 0; j < dgwBaseGrille.RowCount; j++)
                {
                    cell = dgwBaseGrille.Rows[i].Cells[j];
                    cell.Style.BackColor = Color.White;
                    grille[i, j] = false;
                }

            }
            holesPicked = 0;
        }

        private void dgwBaseGrille_Leave(object sender, EventArgs e)
        {

        }

        private void dgwBaseGrille_SelectionChanged(object sender, EventArgs e)
        {
            dgwBaseGrille.ClearSelection();
        }

        private void plaintextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileContent = File.ReadAllText(filePath);

                tbPlaintext.Text = fileContent;
            }

        }

        private void ciphertextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileContent = File.ReadAllText(filePath);

                tbCiphertext.Text = fileContent;
            }
        }

        private void plaintextSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                File.WriteAllText(filePath, tbPlaintext.Text);
            }
        }

        private void ciphertextSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                File.WriteAllText(filePath, tbCiphertext.Text);
            }
        }
    }
}
