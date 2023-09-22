using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VehicleMania.src.model;

namespace VehicleMania.src
{
    public class main
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Choisi le model de ton Auto : ");
            string model = Console.ReadLine();
            Vehicle auto = new Auto(model);
            auto.ShowStats();

            Console.WriteLine("Choisi le model de ta Moto : ");
            model = Console.ReadLine();
            Vehicle moto = new Moto(model);
            moto.ShowStats();

            auto.Start();
            auto.ShowStats();

            moto.Start();
            moto.ShowStats();



        }

    }
}
