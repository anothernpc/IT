using System.Windows.Forms;

namespace Lab2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private byte[] key;
        private byte[] plaintext;
        private byte[] ciphertext;
        private static int REGISTER_SIZE = 36;

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                plaintext = File.ReadAllBytes(filePath);
                string s = string.Join("", plaintext.Take(REGISTER_SIZE*2).Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
                tbPlaintext.Text = s;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                File.WriteAllBytes(filePath, ciphertext);
            }
        }


        private byte[] GenerateKey(ulong baseState, int plaintextLength)
        {
            byte[] keyTemp = new byte[plaintextLength];
            ulong temp = 0;
            for (int i = 0; i < plaintextLength; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    temp = (temp << 1) + ((baseState >> 35) & 0x0001);
                    baseState = ((baseState << 1) & 0xFFFFFFFFF) + (((baseState & 0x000000400) >> 10) ^ ((baseState & 0x800000000) >> 35));
                }
                keyTemp[i] = (byte)temp;
                temp = 0;
            }
            return keyTemp;
        }


        private void btnGetKey_Click(object sender, EventArgs e)
        {
            if (plaintext.Length > 0)
            {
                key = GenerateKey(Convert.ToUInt64(tbBaseState.Text, 2), plaintext.Length);
                string s = string.Join("", key.Take(REGISTER_SIZE*2).Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
                tbKey.Text = s;
            }

        }

        private void btnEncipher_Click(object sender, EventArgs e)
        {
            if (tbKey.Text.Length > 0 && tbPlaintext.Text.Length > 0)
            {
                tbCiphertext.Text = "";
                ciphertext = new byte[plaintext.Length];
                for (int i = 0; i < plaintext.Length; i++)
                {
                    ciphertext[i] = (byte)((int)plaintext[i] ^ (int)key[i]);
                }
                string s = string.Join("", ciphertext.Take(REGISTER_SIZE * 2).Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
                tbCiphertext.Text = s;
            }
        }
    }
}
