using System;
using Bot.Services;
using Xunit;

namespace Bot.Tests.Unit
{
    public class RandomServiceTests
    {
        private readonly IRandomService randomService;
        private readonly Random random;

        public RandomServiceTests()
        {
            randomService = new RandomService();
        }

        [Fact]
        public void GenerateNumberReturnsAnIntLessThanFour()
        {
            var result = randomService.GenerateNumber();

            Assert.IsType<int>(result);
            Assert.True(result < 4);
        }
    }
}