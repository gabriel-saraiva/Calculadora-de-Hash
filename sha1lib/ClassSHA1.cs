using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace sha1lib
{
    public class ClassSHA1
    {
        public string GetSHA1(string filePath)
        {
                SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
                try
                {
                    FileStream fSHA1 = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 84192);
                    //, 84192
                    sha1.ComputeHash(fSHA1);
                    fSHA1.Close(); 
                }
                catch (DirectoryNotFoundException)
                {
                    Message M = new Message();
                    M.ShowDialog();
                }

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
        }
    }