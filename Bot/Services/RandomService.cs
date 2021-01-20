using System;

namespace Bot.Services
{
    public class RandomService : IRandomService
    {
        private readonly Random random;

        public RandomService() 
        {
            random = new Random();
        }
        public int GenerateNumber()
        {
            return random.Next(1, 4);
        }
    }   
}