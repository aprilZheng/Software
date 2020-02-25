using System;

namespace inheritance
{
    public class Person
    {
        protected string name;
        protected int age;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Person's Constructor.");
        }

        public void printName()
        {
            Console.WriteLine("Person's name:{0}",name);
        }
    }

    public class Programmer:Person
    {
        private string language;

        public Programmer(string name, int age, string language) : base(name, age)//调用base构造函数
        {
            this.name = name;
            this.age = age;
            this.language = language;
            Console.WriteLine("Programmer's Constructor.");
        }
        public void printName()
        {
            Console.WriteLine("Programmer's name:{0}", name);
            //调用base的所有member
            base.printName();
        }
        public void function()//public的main function才能用，protected的只是继承的class可以用
        {
            base.printName();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer("Jack",25,"C#");

            p.printName();
            p.function();

            Console.ReadLine();
        }
    }
}
