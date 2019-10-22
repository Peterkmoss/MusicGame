using System.Collections.Generic;
namespace MusicGame.Models
{
    public interface IOrchestra
    {
        void RunScheduledWeek();
        void BuyMusician(Musician musician);
        void BuyActivity(Activity activity);
        void BuyPracticeRoom(Room practiceRoom);
        void UpdateSchedule(int day, IList<Activity> activities);
    }
}