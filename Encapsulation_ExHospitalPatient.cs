using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class PatientDetails
    {
        private string Name;
        private int Age;
        private string MedicalHistory;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public string medicalHistory
        {
            get { return MedicalHistory; }
            set { MedicalHistory = value; }
        }

        public PatientDetails(string name, int age, string medicalHistory)
        {
            Name = name;
            Age = age;
            MedicalHistory = medicalHistory;
        }
    }
    internal class Encapsulation_ExHospitalPatient
    {
        static void Main(string[] args)
        {
            PatientDetails patient = new PatientDetails("ABC", 30, "No known allergies");
            Console.WriteLine("Patient Name: " + patient.name);
            Console.WriteLine("Patient Age: " + patient.age);
            Console.WriteLine("Patient Medical History: " + patient.medicalHistory);
        }
    }
}
