using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MesajlasmaProjesi
{
    public static class Encryption
    {
        private static readonly string aesKey = "1234567890qwerty"; // 16 karakter = 128 bit
        private static readonly string aesIV = "0123456789asdfgh";   // 16 karakter

        public static string AESEncrypt(string plainText)
        {
            using Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(aesKey);
            aes.IV = Encoding.UTF8.GetBytes(aesIV);

            using MemoryStream ms = new MemoryStream();
            using CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
            using (StreamWriter sw = new StreamWriter(cs))
            {
                sw.Write(plainText);
            }

            return Convert.ToBase64String(ms.ToArray());
        }

        public static string AESDecrypt(string encryptedText)
        {
            using Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(aesKey);
            aes.IV = Encoding.UTF8.GetBytes(aesIV);

            byte[] buffer = Convert.FromBase64String(encryptedText);

            using MemoryStream ms = new MemoryStream(buffer);
            using CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using StreamReader sr = new StreamReader(cs);
            {
                return sr.ReadToEnd();
            }
        }
    }
}
