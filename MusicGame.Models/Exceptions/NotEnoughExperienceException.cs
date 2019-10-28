using System;

namespace MusicGame.Models.Exceptions
{
    public class NotEnoughExperienceException : Exception
    {
        public NotEnoughExperienceException() : base("Not enough experience!")
        {

        }
    }
}
