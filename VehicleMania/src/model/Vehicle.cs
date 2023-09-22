using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMania.src.model
{
    public abstract class Vehicle : IVehicle
    {
        public static List<int> registeredPlate = new List<int>();
        public string plate { get; set; }
        public string model { get; set; }

        private bool isStarted;

        public Vehicle(string model, string plate)
        {
            this.model = model;
            this.plate = plate;
            this.isStarted = false;
            Console.WriteLine("Vehicle model " + this.model + " created sucessfully !");
        }

        public Vehicle(string model) : this(model, GeneratePlate().ToString()) { }

        public Vehicle() : this("Unknown", GeneratePlate().ToString()) { }

        public virtual void Start()
        {
            this.isStarted = true;
            Console.WriteLine(this.GetType().Name + " Vehicle started ! (" + this.plate + ")");
        }

        public virtual void Stop()
        {
            this.isStarted = false;
            Console.WriteLine("Vehicle stopped");
        }

        public virtual void ShowStats()
        {
            Console.WriteLine("\n");
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("Plate: " + plate);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("IsStarted: " + isStarted);
        }

        internal static int GeneratePlate()
        {
            int limit = 999999;
            Random random = new Random();
            int plate = random.Next(limit);
            while (registeredPlate.Contains(plate))
            {
                plate = random.Next(limit);
            }
            registeredPlate.Add(plate);
            return plate;
        }

        public bool IsStarted()
        {
            return this.isStarted;
        }

        public void ThiefAlarm()
        {
            Console.WriteLine("*ALARM NOISES*");
        }

        public abstract void Honk();
    }
}
