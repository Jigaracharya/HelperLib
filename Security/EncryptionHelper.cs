using System;
using System.Collections.Generic;
using System.Text;

namespace Security
{
    public class EncryptionHelper
    {
        public string Encrypt(string encrypt)
        {
            return $"Encrypt {encrypt}";
        }

        public string Dencrypt(string dencrypt)
        {
            return $"Dencrypt {dencrypt}";
        }
    }
}
