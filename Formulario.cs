using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Windows.Forms;
using sha1lib;

namespace Calculadora_de_Hash
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void BAsha1_Click(object sender, EventArgs e)
        {
            OPENfileDIALOG.Title = "Selecione o 'Arquivo'";
            OPENfileDIALOG.ShowDialog();
            TextBoxSHA1.Text = OPENfileDIALOG.FileName.ToString();
        }

        private void BCsha1_Click(object sender, EventArgs e)
        {
            sha1lib.ClassSHA1 sha1class = new sha1lib.ClassSHA1();
            string myFile = TextBoxSHA1.Text;
            string myHash = sha1class.GetSHA1(myFile);
            MessageBox.Show("O SHA1 deste é: " + myHash, "SHA1 Hash", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}