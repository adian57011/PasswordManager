using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class Encryption
    {
        public byte[] StringToByteArray(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        public string Encrypt(string txt)
        {
            string keyHex = "1A2B3C4D5E6F7A899B8C7D6E5A4B3C2D";

            byte[] keyBytes = new byte[keyHex.Length / 2];
            for (int i = 0; i < keyBytes.Length; i++)
            {
                keyBytes[i] = Convert.ToByte(keyHex.Substring(i * 2, 2), 16);
            }

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = new byte[16];

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(cs))
                    {
                        swEncrypt.Write(txt);
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public string Decrypt(string txt)
        {
            string keyHex = "1A2B3C4D5E6F7A899B8C7D6E5A4B3C2D";
            byte[] keyBytes = new byte[keyHex.Length / 2];
            for (int i = 0; i < keyBytes.Length; i++)
            {
                keyBytes[i] = Convert.ToByte(keyHex.Substring(i * 2, 2), 16);
            }

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = new byte[16];

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] encryptedBytes = Convert.FromBase64String(txt);

                using (MemoryStream ms = new MemoryStream(encryptedBytes))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

    }
}
