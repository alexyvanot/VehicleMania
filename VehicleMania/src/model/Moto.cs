using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMania.src.model
{
    public class Moto : Vehicle
    {
        public int cynlinder { get; set; }

        public Moto(string model, string plate, int cynlinder) : base(model, plate)
        {
            this.cynlinder = cynlinder;
        }

        public Moto(string model, string plate) : this(model, plate, GenerateCynlinder()) { }

        public Moto(string model, int cynlinder) : this(model, GeneratePlate().ToString(), cynlinder) { }

        public Moto(int cynlinder) : this("Unknown", GeneratePlate().ToString(), cynlinder) { }

        public Moto(string model) : this(model, GeneratePlate().ToString(), GenerateCynlinder()) { }

        public Moto() : this("Unknown", GeneratePlate().ToString(), GenerateCynlinder()) { }

        public void Wheelie()
        {
            Console.WriteLine("Wheelie");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("*Moto noises*");
        }

        public override void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine("Cynlinder: " + cynlinder);
        }

        private static int GenerateCynlinder()
        {
            int limit = 999;
            Random random = new Random();
            int cynlinder = random.Next(limit);
            return cynlinder;
        }

        public override void Honk()
        {
            Console.WriteLine("*BEEP BEEP*");
        }
    }
}
