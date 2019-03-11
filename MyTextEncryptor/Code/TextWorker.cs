using System;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace MyTextEncryptor.TextWorking
{
    interface ITextWorker
    {
        string EncryptText(string plainText);
        string DecryptText(string encodedText);
    }
    enum FormatMethod { Encrypt, Decrypt }
    class Base64Worker : ITextWorker
    {
        public string EncryptText(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        public string DecryptText(string encodedText)
        {
            byte[] EncodedBytes = Convert.FromBase64String(encodedText);
            return Encoding.UTF8.GetString(EncodedBytes);
        }
    }
    class MD5Worker : ITextWorker
    {
        public string EncryptText(string plainText)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            return Convert.ToBase64String(hash);
        }
        public string DecryptText(string encodedText)
        {
            // It's impossible to reversively format to string
            return null;
        }
    }
    class ASCIIWorker : ITextWorker
    {
        public string EncryptText(string plainText)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in plainText)
            {
                string str = Convert.ToInt32(c).ToString() + " ";
                result.Append(str);
            }
            return result.ToString();
        }
        public string DecryptText(string encodedText)
        {
            StringBuilder result = new StringBuilder();

            string[] encodedNums = encodedText.Split(' ');
            foreach (string num in encodedNums)
            {
                string letter = Char.ConvertFromUtf32(Convert.ToInt32(num));
                result.Append(letter);
            }
            return result.ToString();
        }
    }
    class BinaryWorker : ITextWorker
    {
        public string EncryptText(string plainText)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);

            StringBuilder result = new StringBuilder();
            foreach (byte b in bytes)
            {
                result.Append(Convert.ToString(b, 2) + " ");
            }
            return result.ToString();
        }
        public string DecryptText(string encodedText)
        {
            List<byte> byteList = new List<byte>();
            string[] lettersBytes = encodedText.Split(' ');
            foreach (string lbyte in lettersBytes)
            {
                byteList.Add(Convert.ToByte(lbyte, 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
    }
    class TextFormatter
    {
        public ITextWorker TextWorker { get; set; }
        FormatMethod formatMethod;

        public TextFormatter(ITextWorker TextWorker, FormatMethod formatMethod)
        {
            this.TextWorker = TextWorker;
            this.formatMethod = formatMethod;
        }
        public string ExecuteProcess(string InputString)
        {
            switch (formatMethod)
            {
                case FormatMethod.Encrypt:
                    return TextWorker.EncryptText(InputString);
                case FormatMethod.Decrypt:
                    return TextWorker.DecryptText(InputString);
                default:
                    return null;
            }
        }
    }
}
