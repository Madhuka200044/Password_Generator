
using System;
using System.Security.Cryptography;

namespace Password_Generator
{
    public class Random
    {
        public int Next(int n)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            var randominteger = BitConverter.ToUInt32(byteArray, 0); 
            return (int)(randominteger % n);
        }
    }
}
