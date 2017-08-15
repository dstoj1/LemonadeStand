using System;
using LemonadeStand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonadeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Weather weather = new Weather();
            //Act
            weather.GetWeather();
            //Assert
            Assert.IsTrue(weather.TodaysWeather == "Sunny" || weather.TodaysWeather == "Partly Cloudy" || weather.TodaysWeather == "Cloudy" || weather.TodaysWeather == "Rainy");

        }

        [TestMethod]

        public void MakeWeather_Sunny_Temp86()
        {
            Weather weather = new Weather();
            weather.TodaysWeather = "Sunny";
            //Act
            weather.MakeWeather();
            //Assert
            Assert.AreEqual(weather.Temperature, 86);
        }
    }  
}
