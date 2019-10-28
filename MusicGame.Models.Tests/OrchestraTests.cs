using System.Collections.Generic;
using System;
using Xunit;
using MusicGame.Models.Exceptions;
using MusicGame.Models.Activities;

namespace MusicGame.Models.Tests
{
    public class OrchestraTests
    {
        Orchestra orchestra;

        public OrchestraTests()
        {
            orchestra = new Orchestra("Test", new HashSet<Musician>(), new Dictionary<int, IList<Activity>>(), new HashSet<Activity>());
        }

        [Fact]
        public void BuyMusician_given_musician_adds_musician_to_orchestra()
        {
            var musician = new Musician("Musician", Instrument.Basoon, "Loves tests", 3, 100);

            orchestra.BuyMusician(musician);

            Assert.True(orchestra.Musicians.Contains(musician));
        }

        [Fact]
        public void BuyMusician_given_musician_removes_price_from_budget()
        {
            var musician = new Musician("Musician", Instrument.Basoon, "Loves tests", 3, 100);

            orchestra.BuyMusician(musician);

            Assert.Equal(900, orchestra.Budget);
        }

        [Fact]
        public void BuyPractice_added_to_unusedActivities()
        {
            var practice = new Practice(1);

            orchestra.BuyPractice(practice);

            Assert.Contains(practice, orchestra.UnusedActivities);
        }

        [Fact]
        public void BuyConcert_added_to_unusedActivities()
        {
            var concert = new Concert(1, 0, "TestLocation", 0, 0, 0);

            orchestra.BuyConcert(concert);

            Assert.Contains(concert, orchestra.UnusedActivities);
        }

        [Fact]
        public void BuyTrip_added_to_unusedActivities()
        {
            var trip = new Trip(1, 0, "TestLocation", 0);

            orchestra.BuyTrip(trip);

            Assert.Contains(trip, orchestra.UnusedActivities);
        }

        [Theory]
        [InlineData(100, 900)]
        [InlineData(50, 950)]
        [InlineData(1000, 0)]
        [InlineData(500, 500)]
        public void BuyTrip_price_removed_from_budget(int price, int newBudget)
        {
            var trip = new Trip(1, price, "TestLocation", 0);

            orchestra.BuyTrip(trip);

            Assert.Equal(newBudget, orchestra.Budget);
        }

        [Theory]
        [InlineData(100, 900)]
        [InlineData(50, 950)]
        [InlineData(1000, 0)]
        [InlineData(500, 500)]
        public void BuyConcert_price_removed_from_budget(int price, int newBudget)
        {
            var concert = new Concert(1, price, "TestLocation", 0, 0, 0);

            orchestra.BuyConcert(concert);

            Assert.Equal(newBudget, orchestra.Budget);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(500)]
        [InlineData(1000)]
        public void BuyConcert_not_enough_experience_throws_exception(int requiredExperience)
        {
            var concert = new Concert(1, 0, "TestLocation", 0, 0, requiredExperience);

            Assert.Throws<NotEnoughExperienceException>(() => orchestra.BuyConcert(concert));
        }

        [Theory]
        [InlineData(1001)]
        [InlineData(2000)]
        [InlineData(5000)]
        public void BuyConcert_not_enough_money_throws_exception(int price)
        {
            var concert = new Concert(1, price, "TestLocation", 0, 0, 0);

            Assert.Throws<NotEnoughMoneyException>(() => orchestra.BuyConcert(concert));
        }

        [Theory]
        [InlineData(1001)]
        [InlineData(2000)]
        [InlineData(5000)]
        public void BuyTrip_not_enough_money_throws_exception(int price)
        {
            var trip = new Trip(1, price, "TestLocation", 0);

            Assert.Throws<NotEnoughMoneyException>(() => orchestra.BuyTrip(trip));
        }
    }
}
