using System;
namespace MusicGame.Models.Exceptions
{
    public class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException() : base("Not enough money!")
        {

        }
    }
}