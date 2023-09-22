using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using VehicleMania.src.model;

namespace VehicleManiaTest.tests
{
    public class VehicleTest
    {
        // Arrange

        private Vehicle a0;
        private Vehicle a1;
        private Vehicle a2;
        private Vehicle a3;
        private Vehicle a4;
        private Vehicle a5;

        private Vehicle m1;
        private Vehicle m2;
        private Vehicle m3;
        private Vehicle m4;
        private Vehicle m5;
        private Vehicle m6;

        public VehicleTest()
        {
            a0 = new Auto();
            a1 = new Auto("LambeauX");
            a2 = new Auto("LambeauX", "1-ABC-123");
            a3 = new Auto("Xrool", 125);
            a4 = new Auto("InDaRoad", "1-CBA-321", 136);
            a5 = new Auto(172);

            
            m1 = new Moto();
            m2 = new Moto("Yomoho");
            m3 = new Moto("Yomoho", "2-ABC-123");
            m4 = new Moto("Bistmut", 85);
            m5 = new Moto("LandrawCore", "2-CBA-321", 96);
            m6 = new Moto(107);
        }

        [Fact]
        public void GetModel()
        {
            // Act
            string model0 = a0.model;

            // Assert
            Assert.Equal("Unknown", model0);
            string model1 = a1.model;
            Assert.Equal("LambeauX", model1);
        }

        [Fact]
        public void GetPlate()
        {
            // Act
            string plate0 = a0.plate;
            // Assert
            Assert.NotEqual("1-ABC-123", plate0);
            Assert.True(plate0.Length <= 6);
            string plate2 = a2.plate;
            Assert.Equal("1-ABC-123", plate2);
        }

        [Fact]
        public void GetHorsePower()
        {
            // Act
            int horsePower0 = ((Auto) a0).horsePower;
            // Assert
            Assert.NotEqual(172, horsePower0);
            Assert.True(horsePower0 <= 999);
            int horsePower1 = ((Auto) a1).horsePower;
            Assert.True(horsePower1 <= 999);
            Assert.True(horsePower1 >= 0);
        }


    }
}
