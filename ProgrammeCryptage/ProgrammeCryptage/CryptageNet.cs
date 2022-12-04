using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ProgrammeCryptage
{
    class CryptageNet
    {
        string publicKey = "KATE7895";
        string privateKey = "LENE1254";

        public CryptageNet()
        {

        }

        public string Encryption(string msg)
        {
            string result;

            byte[] publicKeyBytes = Encoding.UTF8.GetBytes(publicKey);
            byte[] privateKeyBytes = Encoding.UTF8.GetBytes(privateKey);
            byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(msg);
            //System cryptography
            using(DESCryptoServiceProvider provider=new DESCryptoServiceProvider())
            {
                //System IO
                var memoryStream = new MemoryStream();
                var cryptoStream = new CryptoStream(memoryStream,provider.CreateEncryptor(publicKeyBytes, privateKeyBytes), CryptoStreamMode.Write);
                cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                cryptoStream.FlushFinalBlock();
                result = Convert.ToBase64String(memoryStream.ToArray());
            }

            return result;
        }

        public string Decryption(string msg)
        {
            string result;

            byte[] publicKeyBytes = Encoding.UTF8.GetBytes(publicKey);
            byte[] privateKeyBytes = Encoding.UTF8.GetBytes(privateKey);
            byte[] inputByteArray = new byte[msg.Replace(" ", "+").Length];
            inputByteArray = Convert.FromBase64String(msg.Replace(" ", "+"));

            using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
            {
                var memoryStream = new MemoryStream();
                var cryptoStream = new CryptoStream(memoryStream, provider.CreateDecryptor(publicKeyBytes, privateKeyBytes), CryptoStreamMode.Write);
                cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                cryptoStream.FlushFinalBlock();
                result = Encoding.UTF8.GetString(memoryStream.ToArray());
            }

            return result;
        }

      

    }
}
