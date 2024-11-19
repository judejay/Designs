using Designs.Abstract_Classes;
using Designs.Abstractions;
using Designs.Concrete_Classes;
using Designs.Creational_Patterns.Abstract_Factory;
using Designs.Creational_Patterns.Builder;
using Designs.Creational_Patterns.Factory;
using Designs.Creational_Patterns.Prototype;
using Designs.Creational_Patterns.Singleton;


//using Designs.Creational_Patterns.Prototype;
using Designs.Enums;
using Designs.Stuctural_Patterns.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Designs.Creational_Patterns.Factory.VehicleFactory;

namespace Designs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //AbstractFactory factory = new AbstractFactory();
            //factory.CreateVehicle();

            //Builder builder = new Builder();
            //builder.CreateBuilder();

            //Factory factory = new Factory();
            //factory.CreateFactory();

            //Prototype prototype = new Prototype();
            //prototype.Run();

            //Singleton singleton = new Singleton();
            //singleton.Run();

            Adapter adapter = new Adapter();
            adapter.Run();
        }
    }
}
