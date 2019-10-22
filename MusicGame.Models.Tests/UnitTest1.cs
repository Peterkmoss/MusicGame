using System;
using Xunit;
using MusicGame.Models;

namespace MusicGame.Models.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var orchestra = new Orchestra();
            orchestra.Budget = 0;
        }
    }
}
