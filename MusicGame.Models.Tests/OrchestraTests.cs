using System.Collections.Generic;
using System;
using Xunit;
using MusicGame.Models.Exceptions;

namespace MusicGame.Models.Tests
{
    public class OrchestraTests
    {
        [Fact]
        public void BuyMusician_given_musician_adds_musician_to_orchestra()
        {
            var musician = new Musician("Musician", Instrument.Basoon, "Loves tests", 3, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            orchestra.BuyMusician(musician);

            Assert.True(orchestra.Musicians.Contains(musician));
        }

        [Fact]
        public void BuyMusician_given_musician_removes_price_from_budget()
        {
            var musician = new Musician("Musician", Instrument.Basoon, "Loves tests", 3, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            orchestra.BuyMusician(musician);

            Assert.Equal(900, orchestra.Budget);
        }

        [Fact]
        public void BuyActivity_given_practice_added_to_unusedActivities()
        {
            var practice = new Practice();
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            orchestra.BuyActivity(practice);

            Assert.True(orchestra.UnusedActivities.Contains(practice));
        }

        [Fact]
        public void BuyActivity_given_concert_added_to_unusedActivities()
        {
            var concert = new Concert("TestLocation", 100, 50, 0, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            orchestra.BuyActivity(concert);

            Assert.True(orchestra.UnusedActivities.Contains(concert));
        }

        [Fact]
        public void BuyActivity_given_trip_added_to_unusedActivities()
        {
            var trip = new Trip("TestLocation", 100, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            orchestra.BuyActivity(trip);

            Assert.True(orchestra.UnusedActivities.Contains(trip));
        }

        [Fact]
        public void BuyActivity_given_trip_price_removed_from_budget()
        {
            var trip = new Trip("TestLocation", 100, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            orchestra.BuyActivity(trip);

            Assert.Equal(900, orchestra.Budget);
        }

        [Fact]
        public void BuyActivity_given_trip_experience_added_to_orchestra()
        {
            var trip = new Trip("TestLocation", 100, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            orchestra.BuyActivity(trip);

            Assert.Equal(100, orchestra.Experience);
        }

        [Fact]
        public void BuyActivity_given_concert_price_budget_changed_with_price_and_revenue()
        {
            var concert = new Concert("TestLocation", 100, 50, 0, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            orchestra.BuyActivity(concert);

            Assert.Equal(950, orchestra.Budget);
        }

        [Fact]
        public void BuyActivity_given_concert_experience_added_to_orchestra()
        {
            var concert = new Concert("TestLocation", 100, 50, 0, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            orchestra.BuyActivity(concert);

            Assert.Equal(100, orchestra.Experience);
        }

        [Fact]
        public void BuyActivity_given_concert_not_enough_experience_throws_exception()
        {
            var concert = new Concert("TestLocation", 100, 50, 1, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            Assert.Throws<NotEnoughExperienceException>(() => orchestra.BuyActivity(concert));
        }

        [Fact]
        public void BuyActivity_given_concert_not_enough_money_throws_exception()
        {
            var concert = new Concert("TestLocation", 1001, 50, 1, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            Assert.Throws<NotEnoughMoneyException>(() => orchestra.BuyActivity(concert));
        }

        [Fact]
        public void BuyActivity_given_trip_not_enough_money_throws_exception()
        {
            var concert = new Trip("TestLocation", 1001, 100);
            var orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>());

            Assert.Throws<NotEnoughMoneyException>(() => orchestra.BuyActivity(concert));
        }
    }
}
