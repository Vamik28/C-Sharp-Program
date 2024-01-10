using System;
namespace Vamik
{
    class Human
    {
        //data types by default private;
        string name;
        string gender;
        int age;

        //paremeterize Constructor
        public Human(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        //zero Argument Constructor
        public Human()
        {
           
        }
        public void printInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("gender : " + gender);
        }
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
         public int Age   // property
        {
            get { return age; }   // get method
            set { age = value; }  // set method
        }
         public string Gender   // property
        {
            get { return gender; }   // get method
            set { gender = value; }  // set method
        }
    }
    class program
    {


        static void Main(string[] args)
        {
           Human h1 = new Human();
           h1.Name = "Vamik";
           h1.Age = 21;
           h1.Gender = "Male";
           h1.printInfo();


        }
    }
}