using Designs.Abstract_Classes;
using Designs.Abstractions;
using Designs.Behavioural.Chain_of_responsibility;
using Designs.Behavioural.Command;
using Designs.Behavioural.Interpreter;
using Designs.Behavioural.Iterator;
using Designs.Behavioural.Mediator;
using Designs.Behavioural.Observer;
using Designs.Behavioural.State;
using Designs.Behavioural.Strategy;
using Designs.Behavioural.Template;
using Designs.Behavioural.Visitor;
using Designs.Concrete_Classes;
using Designs.Creational_Patterns.Abstract_Factory;
using Designs.Creational_Patterns.Builder;
using Designs.Creational_Patterns.Factory;
using Designs.Creational_Patterns.Prototype;
using Designs.Creational_Patterns.Singleton;


//using Designs.Creational_Patterns.Prototype;
using Designs.Enums;
using Designs.Others;
using Designs.Others.Simple_Factory;
using Designs.Stuctural_Patterns.Adapter;
using Designs.Stuctural_Patterns.Bridge;
using Designs.Stuctural_Patterns.Composite;
using Designs.Stuctural_Patterns.Decorator;
using Designs.Stuctural_Patterns.Facade;
using Designs.Stuctural_Patterns.Flyweight;
using Designs.Stuctural_Patterns.Proxy;
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

            //Adapter adapter = new Adapter();
            //adapter.Run();

            //Bridge bridge = new Bridge();
            //bridge.Run(new SportControls(new TurboEngine(2000)));

            //Composite composite = new Composite();
            //composite.Run();

            //Decorator decorator = new Decorator();
            //decorator.Run();
            //Facade facade = new Facade();
            //facade.Run();

            //Flyweight flyweight = new Flyweight();
            //flyweight.Run();

            //Proxy proxy = new Proxy();
            //proxy.Run();
            //ChainOfResponsibility chainOfResponsibility = new ChainOfResponsibility();
            //chainOfResponsibility.Run();

            //Command command = new Command();
            //command.Run();

            //Interpreter interpreter = new Interpreter();
            //interpreter.Run();

            //Iterator interator = new Iterator();
            //interator.Run();

            //Mediator mediator = new Mediator();
            //mediator.Run();

            //Memento memento = new Memento();
            //memento.Run();

            //Observer observer = new Observer();
            //observer.Run();

            //State state = new State();
            //state.Run();

            //Strategy strategy = new Strategy();
            //strategy.Run();

            //Template template = new Template();
            //template.Run();

            //Visitor visitor = new Visitor();
            //visitor.Run();

            //Null_Object nullObject = new Null_Object();
            //nullObject.Run();

            SimpleFactory simpleFactory = new SimpleFactory();
            simpleFactory.Run();
        }
    }
}
