using Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serializer;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WarehouseBehavesLikeASingleton()
        {

            //Arrange
            Warehouse a = Warehouse.Get_Warehouse();
            Warehouse b = Warehouse.Get_Warehouse();

            //act
            a.GetParts().Add(new Nut(10, 1));


            //Assert
            Assert.AreEqual(a.GetParts(), b.GetParts());

        }

        [TestMethod]
        public void CarPartGetsExpectedID()
        {
            //Arrange
            CarPart a = new Nut(125, 0);

            //Assert
            Assert.AreEqual("N-D125", a.Id);
        }

        [TestMethod]
        public void WarehouseAddsPartsCorrectly()
        {
            //Arrange
            Warehouse a = Warehouse.Get_Warehouse();
            CarPart cp1 = new Axle(10.2f, 10.5f, 5);
            CarPart cp2 = new Bolt(5.0f, 2.0f, Bolt.HeadType.ALEM, 5);

            //Act
            a.AddParts(new System.Collections.Generic.List<CarPart>() { cp1, cp2 });

            //Assert
            Assert.IsTrue(a.GetParts().Contains(cp1) && a.GetParts().Contains(cp2));

        }

        [TestMethod]
        public void WarehouseLoadPartsFromIdCorrectly()
        {
            //Arrange
            Warehouse a = Warehouse.Get_Warehouse();
            CarPart cp = new Axle(10f, 20f, 5);
            string aux = "A-L10-D20";

            //Act
            a.LoadObjects(new System.Collections.Generic.List<Entry<string, int>>() { new Entry<string, int>(aux, 5) });

            //Assert
            Assert.IsTrue(cp == a.GetParts()[0]);
        }

        [TestMethod]
        public void CarPartsCompareCorrectly()
        {
            //Arrange
            CarPart a = new Bolt(10f, 20f, Bolt.HeadType.ALEM, 5);
            CarPart b = new Bolt(10f, 20f, Bolt.HeadType.ALEM, 15);
            CarPart c = new Bolt(15f, 20f, Bolt.HeadType.HEX, 5);
            bool result = false;

            //Act
            if(a == b && a.Equals(b))
            {
                if(b != c && a != c)
                {
                    result = true;
                }
            }

            //Assert
            Assert.IsTrue(result);
        }
    }
}
