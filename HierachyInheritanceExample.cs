//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CSharpOops;

//namespace CSharpOops
//{
//    class HeadOffice
//    {
//        int id;
//        string name;
//        public HeadOffice()
//        {
//            id = 111;
//            name = "sai";
//        }
//        public void Headdetails()
//        {
//            Console.WriteLine(" headoffice id is:" + id);
//            Console.WriteLine("name is :" + name);
//        }
//    }
//    class Branch : HeadOffice
//    {
//        int bid;
//        string bname;
//        string blocation;
//        public Branch()
//        {
//            bid = 5636253;
//            bname = "ABN";
//            blocation = "hyderbad";
//        }
//        public void BranchDetail()
//        {
//            Console.WriteLine("Branch Details Information :");
//            Console.WriteLine(" branch  id is:" + bid);
//            Console.WriteLine("Branch name is :" + bname);
//            Console.WriteLine(" Branch Location is :" + blocation);
//        }
//    }
//    class Employee : HeadOffice
//    {
//        int eid;
//        string ename;
//        float esal;
//        public Employee()
//        {
//            eid = 8983;
//            ename = "KNR";
//            esal = 130000;
//        }
//        public void EmpDetails()
//        {
//            Console.WriteLine("Employee Details Method DATA :");
//            Console.WriteLine(" Employee id is:" + eid);
//            Console.WriteLine("Employee name is :" + ename);
//            Console.WriteLine(" Employee Salary  is :" + esal);
//        }
//    }

//}
//internal class HierachyInheritanceExample
//{
//    static void Main(string[] args)
//    {
//        Employee em = new Employee();
//        em.EmpDetails();
//        em.Headdetails();

//        Branch br = new Branch();
//        br.BranchDetail();
//        br.Headdetails();

//    }

//}

