using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMania.src.model
{
    public class Auto : Vehicle
    {
        public int horsePower { get; set; }

        public Auto(string model, string plate, int horsePower) : base(model, plate)
        {
            this.horsePower = horsePower;
        }

        public Auto(string model, int horsePower) : this(model, GeneratePlate().ToString(), horsePower) { }

        public Auto(int horsePower) : this("Unknown", GeneratePlate().ToString(), horsePower) { }

        public Auto(string model) : this(model, GeneratePlate().ToString(), GenerateHorsePower()) { }

        public Auto() : this("Unknown", GeneratePlate().ToString(), GenerateHorsePower()) { }

        public void Drift()
        {
            Console.WriteLine("Drifting");
        }

        public override void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine("Horsepower: " + horsePower);
        }

        private static int GenerateHorsePower()
        {
            int limit = 999;
            Random random = new Random();
            int horsePower = random.Next(limit);
            return horsePower;
        }

        public override void Honk()
        {
            Console.WriteLine("*TUUUUT TUUUUT*");
        }
    }
}
