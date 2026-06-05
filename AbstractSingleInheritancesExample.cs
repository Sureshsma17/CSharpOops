//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    abstract class Vehicle
//    {
//        protected string vehiclename;

//        public Vehicle(string vehiclename)
//        {
//            this.vehiclename= vehiclename;
//            Console.WriteLine("vehicle is called");
//        }

//        public void ShowVehicleDetails()
//        {
//            Console.WriteLine($"Vehicle name is: {vehiclename}");
//        }

//        public abstract void VehicleType();
//    }

//    abstract class VehicleModel : Vehicle
//    {
//        protected string modelname;

        
//        public VehicleModel(string vehiclename,string modelname):base(vehiclename)
//        {
//            this.modelname= modelname;
//            Console.WriteLine("Vehicle Model is Calling:");
//        }

//        public void DisplayName()
//        {
//            Console.WriteLine($"Modelname is: {modelname}");
//        }

//        public abstract void modeltype();
//    }

//    class VehicleData : VehicleModel
//    {
//        public int vehiclenumber;

//        public VehicleData(string vehiclename, string modelname,int vehiclenumber) : base(vehiclename, modelname)
//        {
//            this.vehiclenumber = vehiclenumber;
//            Console.WriteLine("Vehicle Data is Called:");
//        }

//        public void vehiclenum()
//        {
//            Console.WriteLine("Vehicle Number is:"+vehiclenumber);
//        }

//        public override void VehicleType()
//        {
//            Console.WriteLine("Cars");
//        }

//        public override void modeltype()
//        {
//            Console.WriteLine("Electric");
//        }
//    }
//    internal class AbstractSingleInheritancesExample
//    {
//        static void Main(string[] args)
//        {
//            VehicleData vd = new VehicleData("Toyota","Fortuner",2023);
//            vd.VehicleType();
//            vd.modeltype();
//            vd.DisplayName();
//            vd.ShowVehicleDetails();
//            vd.vehiclenum();
//        }
//    }
//}
