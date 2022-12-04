using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProgrammeCryptage
{
    public partial class Form1 : Form
    {
        CryptagePerso cryptMessage;
        CryptagePerso decryptMessage;
        CryptageNet cryptNet;
        CryptageNet decryptNet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCryptagePerso_Click(object sender, EventArgs e)
        {
            this.cryptMessage = new CryptagePerso();
            string result;
            string text;

            List<string> encryptMsg = new List<string>();

            if (txtCryptMessage.Text==null)
            {
                MessageBox.Show("Error no written text!", "Error");
            }
            else
            {
                text = txtCryptMessage.Text;
                encryptMsg=cryptMessage.Crypt(text.ToLower());
                result = string.Join("", encryptMsg);
                txtResult.Text = result;   
            }

        }

        private void btnDecryptPerso_Click(object sender, EventArgs e)
        {
            this.decryptMessage = new CryptagePerso();
            string result;
            string text;
            List<char> decryptMsg = new List<char>();

            if (txtDecrypt.Text == null)
            {
                MessageBox.Show("Error no written text!", "Error");
            }

            text = txtDecrypt.Text;
            decryptMsg = decryptMessage.Decrypt(text);
            result = string.Join("", decryptMsg);
            txtDecrptResult.Text = result;
        }

        private void btnCryptageNet_Click(object sender, EventArgs e)
        {
            this.cryptNet = new CryptageNet();
            string text;
            string result;
            text = txtCryptMessage.Text;

            if (txtCryptMessage == null)
            {
                MessageBox.Show("Error no written text!", "Error");
            }
            result = cryptNet.Encryption(text);
            txtResult.Text = result;

        }

        private void btnDecryptNet_Click(object sender, EventArgs e)
        {
            this.decryptNet = new CryptageNet();
            string result;
            string text;

            if (txtCryptMessage == null)
            {
                MessageBox.Show("Error no written text!", "Error");
            }
            text = txtDecrypt.Text;
            result = decryptNet.Decryption(text);
            txtDecrptResult.Text = result;

        }
    }
}
