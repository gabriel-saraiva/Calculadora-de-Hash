using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_de_Hash
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        //md5 calculator start.
        public object GetMD5(string filePath)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream fMD5 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
            //, 84192

            fMD5 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
            //, 84192
            md5.ComputeHash(fMD5);
            fMD5.Close();

            byte[] hash = md5.Hash;
            StringBuilder buff = new StringBuilder();
            byte hashByte = 0;

            foreach (byte hashByte_loopVariable in hash)
            {
                hashByte = hashByte_loopVariable;
                buff.Append(string.Format("{0:X2}", hashByte));
            }

            string md5string = null;
            md5string = buff.ToString();

            return md5string;
        }
        //md5 calculator end.

        //sha1 calculator start.
        public object GetSHA1(string filePath)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            FileStream fSHA1 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
            //, 84192

            fSHA1 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
            //, 84192
            sha1.ComputeHash(fSHA1);
            fSHA1.Close();

            byte[] hash = sha1.Hash;
            StringBuilder buff = new StringBuilder();
            byte hashByte = 0;

            foreach (byte hashByte_loopVariable in hash)
            {
                hashByte = hashByte_loopVariable;
                buff.Append(string.Format("{0:X2}", hashByte));
            }

            string sha1string = null;
            sha1string = buff.ToString();

            return sha1string;
        }
        //sha1 calculator end.

        //sha256 calculator start.
        public object GetSHA256(string filePath)
        {
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            FileStream fSHA256 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
            //, 84192
            
            fSHA256 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
            //, 84192
            sha256.ComputeHash(fSHA256);
            fSHA256.Close();

            byte[] hash = sha256.Hash;
            StringBuilder buff = new StringBuilder();
            byte hashByte = 0;

            foreach (byte hashByte_loopVariable in hash)
            {
                hashByte = hashByte_loopVariable;
                buff.Append(string.Format("{0:X2}", hashByte));
            }

            string sha1string = null;
            sha1string = buff.ToString();

            return sha1string;
        }
        //sha256 calculator end.

        //sha384 calculator start.
        public object GetSHA384(string filePath)
        {
            SHA384CryptoServiceProvider sha384 = new SHA384CryptoServiceProvider();
            FileStream fSHA384 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
            //, 84192

            fSHA384 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
            //, 84192
            sha384.ComputeHash(fSHA384);
            fSHA384.Close();

            byte[] hash = sha384.Hash;
            StringBuilder buff = new StringBuilder();
            byte hashByte = 0;

            foreach (byte hashByte_loopVariable in hash)
            {
                hashByte = hashByte_loopVariable;
                buff.Append(string.Format("{0:X2}", hashByte));
            }

            string sha1string = null;
            sha1string = buff.ToString();

            return sha1string;
        }
        //sha384 calculator end.

        //sha512 calculator start.
        public object GetSHA512(string filePath)
        {
            SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider();
            FileStream fSHA512 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
            //, 84192

            try
            {
                fSHA512 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
                //, 84192
                sha512.ComputeHash(fSHA512);
                fSHA512.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Dot Net Perls is super.", "Important Note", MessageBoxButtons.OK);
            }


            byte[] hash = sha512.Hash;
            StringBuilder buff = new StringBuilder();
            byte hashByte = 0;

            foreach (byte hashByte_loopVariable in hash)
            {
                hashByte = hashByte_loopVariable;
                buff.Append(string.Format("{0:X2}", hashByte));
            }

            string sha1string = null;
            sha1string = buff.ToString();

            return sha1string;
        }
        //sha512 calculator end.
    }
}
