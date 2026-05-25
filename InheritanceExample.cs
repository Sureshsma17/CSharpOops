using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class Branch
    {
        int bid;
        string branchname;
        string baddress;

        public Branch(int bid,string branchname,string baddress)
        { 
            this.bid = bid;
            this.branchname = branchname;
            this.baddress = baddress;
        }
        public void BranchDisplay()
        {
            Console.WriteLine("Branch id is:" + bid);
            Console.WriteLine("Branch Name is:" + branchname);
            Console.WriteLine("Branch Address is:"+baddress);
        }
    }

    class Student:Branch
    {
        int sid;
        string sname;
        string scollege;

        public Student(int sid,string sname,string scollege):base(111,"BBB","Ameerpet")
        {
            this.sid = sid;
            this.sname = sname;
            this.scollege = scollege;

        }
        public void StudentDisplay()
        {
            Console.WriteLine("Student ID is:" + sid);
            Console.WriteLine("Student Name is" + sname);
            Console.WriteLine("Student College is:" + scollege);
            base.BranchDisplay();
        }
    }
    internal class InheritanceExample
    {
        static void Main(string[] args)
        {
            Student obj = new Student(1,"john","IIIT");
            obj.StudentDisplay();
        }
    }
}
