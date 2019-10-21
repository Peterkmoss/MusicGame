using System.Collections.Generic;
namespace Model
{
    public interface IOrchestra
    {
         void RunScheduledWeek();
         void BuyMusician(Musician musician);
         void BuyEvent(Activity activity);
         void BuyPracticeRoom(Room practiceRoom);
         void UpdateSchedule(int day, IList<Activity> activities);
    }
}