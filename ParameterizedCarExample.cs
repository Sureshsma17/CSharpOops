//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class Car
//    {
//        string Model;
//        string Color;
//        short Year;

//        public Car(string model, string color, short year)
//        {
//            Model = model;
//            Color = color;
//            Year = year;

//        }
//        public void DisplayCarDetails()
//        {
//            Console.WriteLine("Model of Car is: " + Model);
//            Console.WriteLine("Color of Car is: " + Color);
//            Console.WriteLine("Manufacturing Year of Car is: " + Year);
//        }
//        public void RestrictCarYear()
//        {
//            if (Year >= 1886)
//            {
//                Console.WriteLine("Car Manufactured Year: " + Year);
//            }
//            else
//            {
//                Console.WriteLine("Car not inveted at this Year: " + Year);
//            }
//        }

//    }
//    internal class ParameterizedCarExample
//    {
//        static void Main(string[] args)
//        {
//            {
//                //Car objcar = new Car("Toyota Vellfire", "White", 2026);
//                //objcar.DisplayCarDetails();
//                Car objRes = new Car("Toyota Vellfire", "White", 1885);
//                objRes.RestrictCarYear();
//            }
//        }
//    }
//}
