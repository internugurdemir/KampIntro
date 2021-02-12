using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ////int, decimal, float, enum, boolean, value types
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;//sayi1 sayi2'nin değerini aldı 20 oldu
            //sayi2 = 100;
            //Console.WriteLine("sayi1: " + sayi1);

            ////arrays, class interface... reference types
            //int[] sayilar1 = new int[] { 1, 2, 3, 4 };
            //int[] sayilar2 = new int[] { 10, 20, 30, 40 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("sayilar1[0]: " + sayilar1[0]);
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;//Bellektte aynı yeri paylaşıyorlar
            person1.FirstName = "Derin";
            //Console.WriteLine(person2.FirstName+" "+person1.FirstName);//Bellektte aynı yeri paylaşıyorlar
            person2.FirstName = "Quality";
            //Console.WriteLine(person2.FirstName+" "+person1.FirstName);//Bellektte aynı yeri paylaşıyorlar


            Customer customer1 = new Customer();
            customer1.FirstName = "Demir";
            customer1.CreditCardNumber = "45434545354546879";
            
            
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.FirstName = "Ali Veli";

            Person person3 = customer1;

            //Console.WriteLine(person3.FirstName);
            //Console.WriteLine(((Customer)person3).CreditCardNumber);//Boxing yapımı

            PersonManager personManager = new PersonManager();
            personManager.Add(employee1);
            personManager.Add(customer1);
            personManager.Add(person3);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }
    class Employee: Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
