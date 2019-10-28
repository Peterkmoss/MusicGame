using System.Collections.Generic;
using MusicGame.Models.Activities;

namespace MusicGame.Models
{
    public interface IOrchestra
    {
        void RunScheduledWeek();
        void BuyMusician(Musician musician);
        void BuyPractice(Practice activity);
        void BuyTrip(Trip activity);
        void BuyConcert(Concert activity);
        void BuyPracticeRoom(Room practiceRoom);
        void UpdateSchedule(int day, IList<Activity> activities);
    }
}