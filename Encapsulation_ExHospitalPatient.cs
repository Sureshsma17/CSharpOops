//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class PatientDetails
//    {
//        private string Name;
//        private int Age;
//        private string MedicalHistory;

//        //read write propertiy for name
//        public string name
//        {
//            get { return Name; }
//            set { Name = value; }
//        }

//        //read only property for age cannot be changed after registration
//        public int age
//        {
//            get { return Age; }

//        }

//        //write only property for medical history can not be read directly for privacy reasons
//        public string medicalhistory
//        {

//            set { MedicalHistory = value; }
//        }

//        //constructor to initialize patient details
//        public PatientDetails(string patientname, int patientage)
//        {
//            this.Name = patientname;
//            this.Age = patientage;
//        }

//        //Encapsulated method to check if patient is eligible for surgery.
//        public bool IsEligibleforSurgery()
//        {
//            // Simple eligibility criteria for demonstration
//            return Age >= 18;

//        }
//        internal class Encapsulation_ExHospitalPatient
//        {
//            static void Main(string[] args)
//            {
//                PatientDetails p = new PatientDetails("ABC", 17);
//                p.MedicalHistory = "Diabatic";
//                p.IsEligibleforSurgery();
//                Console.WriteLine("Patient Name: " + p.name);
//                Console.WriteLine("Patient Age: " + p.age);
//                // Console.WriteLine("Patient Medical History: " + patient.medicalhistory); // Cannot access write-only property
//            }
//        }
//    }
//}
