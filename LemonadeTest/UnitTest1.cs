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
            //Arrange
            Weather weather = new Weather();
            weather.TodaysWeather = "Sunny";
            //Act
            weather.MakeWeather();
            //Assert
            Assert.AreEqual(weather.Temperature, 86);
        }
        [TestMethod]

        public void SellIceCubes_Number_Total()
        {
            //Arrange
            Store store = new Store();
            Player player = new Player();
            double Number = 125;
            double expectedResult = 24.03;
            //Act 
            store.SellIceCubes(player, Number);
            double result = player.wallet.money;
            //Assert
            Assert.AreEqual(expectedResult, result);
           
            

        }
        [TestMethod]
        public void SellIceCubes_Add_To_Inventory()
        {
            //Arrange
            Store store = new Store();
            Player player = new Player();
            double Number = 125;
            int expectedResult = 125;
            //Act 
            store.SellIceCubes(player, Number);
            int result = player.inventory.IceList.Count;
            //Assert
            Assert.AreEqual(expectedResult, result);



        }
    }  
}
