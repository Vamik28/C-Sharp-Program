using System;
using System.Dynamic;
using System.Formats.Asn1;
using System.Security.Cryptography;
namespace Vamik
{

  
   abstract class Shape{
       abstract public void Area();
       abstract public void Perimeter();
    }
    class Rectangle : Shape{
        double length,breadth,area,perimeter;
        public Rectangle(double length,double breadth){
            this.length = length;
            this.breadth = breadth;
        }
        public double Length{
            get{return length;}
            set{length = value;}
        }
        public double Breadth{
            get{return breadth;}
            set{breadth = value;}
        }
        
        public override void Area(){
             area = length*breadth;
             Console.WriteLine("Area = " + area);
        }
        public override void Perimeter(){
             perimeter =  2*(length+breadth);
             Console.WriteLine("Perimeter = "+ perimeter);
             
        }
    }
    class vehicle{

        public vehicle(){
            Console.WriteLine("I am in Vehicle Constructor");
        }
        public void sound(){
              Console.WriteLine("I am in vehicle Class");
        }
    }
    class Car : vehicle{
        string name ;
        public Car(string name){
            Console.WriteLine("I am in Car parameterized Contructor");
        }
        public Car(){
            Console.WriteLine("I am in Car Contructor");
        }
        public void sound(){
            Console.WriteLine("I am in a Car Class");
        }
    }
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
           Rectangle r1 = new Rectangle(30.2,60.5);
            r1.Area();
            r1.Perimeter();
            vehicle v1  = new vehicle();
            v1.sound();
            Car c1 = new Car("i20");
            

        }
    }
}