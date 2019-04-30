using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneTimePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//test

        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            byte[] plaintextiBytes = Encoding.Unicode.GetBytes(txtPlaintexti.Text);

            byte[] celesi = gjeneroCelesin(plaintextiBytes.Length);

            txtCelesi.Text = Convert.ToBase64String(celesi);

            byte[] ciphertexti = enkripto(plaintextiBytes, celesi);

            txtCiphertexti.Text = Convert.ToBase64String(ciphertexti);

            byte[] ciphertextiFromBase64 = Convert.FromBase64String(txtCiphertexti.Text);

            txtDekriptuar.Text = null;
        }

        public static byte[] enkripto(byte[] texti, byte[] celesi)
        {
            var ciphertextiByte = new byte[texti.Length];
            for (int i = 0; i < texti.Length; i++)
            {
                var xor = (int)texti[i] ^ (int)celesi[i];

                ciphertextiByte[i] = (byte)xor;
            }
            return ciphertextiByte;
        }

        public static byte[] gjeneroCelesin(int length)
        {
            Random randObj = new Random();
            int seed = randObj.Next();
            var random = new Random(seed);

            var celesiByte = new byte[length];

            random.NextBytes(celesiByte);

            return celesiByte;
        }

        private void BtnDekripto_Click(object sender, EventArgs e)
        {
            byte[] ciphertextiBytes = Convert.FromBase64String(txtCiphertexti.Text);

            byte[] celesi = Convert.FromBase64String(txtCelesi.Text);

            byte[] textiDekriptuar = dekripto(ciphertextiBytes, celesi);

            txtDekriptuar.Text = Encoding.Unicode.GetString(textiDekriptuar);
        }

        public static byte[] dekripto(byte[] ciphertexti, byte[] celesi)
        {
            var dekriptuarByte = new byte[ciphertexti.Length];
            for (int i = 0; i < ciphertexti.Length; i++)
            {
                var xor = (int)ciphertexti[i] ^ (int)celesi[i];

                dekriptuarByte[i] = (byte)xor;
            }
            return dekriptuarByte;
        }
    }
}
