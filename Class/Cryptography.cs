using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


    class Cryptography
    {
        private string valueToHash{ get; set; }
        private string ValueSalt{ get; set; }
        private const string constSalt = "BldANDSwd";
        public Cryptography(string value, string salt)
        {
            this.valueToHash = value;
            this.ValueSalt = salt;
        }
        public string GetHash()
        {
            byte[] valuesBytes = Encoding.ASCII.GetBytes(this.valueToHash+ValueSalt+constSalt);
            string SHA256Value = "";

            SHA256Managed hashedValue = new SHA256Managed();
            byte[] hashValueBytes = hashedValue.ComputeHash(valuesBytes);
            foreach(byte b in hashValueBytes)
            {
                SHA256Value += b.ToString("x2");
            }
            return SHA256Value;
        }
    }

