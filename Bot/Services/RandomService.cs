using System;
using System.Security.Cryptography;

namespace Bot.Services
{
    public class RandomService : IRandomService
    {
        private readonly RNGCryptoServiceProvider provider;
        private readonly int randomNumber;

        public RandomService()
        {
            provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            //convert 4 bytes to an integer
            randomNumber = (int) BitConverter.ToUInt32(byteArray, 0);
        }
        public int GenerateNumber()
        {
            return randomNumber;
        }
    }
}