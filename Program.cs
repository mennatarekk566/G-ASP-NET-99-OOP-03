using System.Text;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace G_ASP_NET_99_OOP_03
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            #region first question 
            //a)  What is the difference between Method Overloading and Method Overriding?

            // Overloading means having multiple methods with the same name but different parameters,
            //in the same class. It's decided at compile time.


            //Overriding means a child class redefines a method it inherited from its parent,
            //with the exact same signature.It's decided at run time

            //b)  What is the difference between Static Binding and Dynamic Binding?
            // Static binding is when the compiler decides which method to call at compile time
            //Dynamic binding is when the method to call is decided at run time, based on the actual object
            #endregion



            #region question2
            //a)  What is the purpose of the sealed keyword when applied to a class?
            //It stops other classes from inheriting from it. Once a class is sealed, it can't be a base class anymore.

            //b)  What is the difference between a sealed class and a sealed method?
            //A sealed method only blocks further overriding of that one method, 
            //in a class that itself can still be inherited normally.


            //c)Can a sealed method be overridden? Why?
            //No.A sealed method(used with override) stops the overriding chain 
            //no subclass further down can override it again.
            #endregion




            #region  question3 partical 
            //Driver driver = new Driver("D001", "Ahmed Mohamed", "0100000000");

            //DeliveryCenter center = new DeliveryCenter("Cairo Center");
            //center.Driver = driver;

            //DeliveryAddress addr1 = new DeliveryAddress("Street 1", "Cairo", "Egypt");
            //StandardShipment standard = new StandardShipment("SH001", "Laptop", 3, 80, addr1);

            //DeliveryAddress addr2 = new DeliveryAddress("Street 2", "Giza", "Egypt");
            //ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, addr2, 30);

            //DeliveryAddress addr3 = new DeliveryAddress("Street 3", "Berlin", "Germany");
            //InternationalShipment international = new InternationalShipment("SH003", "Television", 8, 120, addr3, "Germany", 100);

            //center.AddShipment(standard);
            //center.AddShipment(express);
            //center.AddShipment(international);

            //center.PrintAllShipments();

            //Console.WriteLine("Printing Using DeliveryHelper...");
            #endregion


        }
    }
}
