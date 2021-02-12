using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructors lar bir kere çalışır---İlk Çalışan----Tek çalışan
            Customer customer1 = new Customer { Id = 1, FirstName = "Demir", LastName = "Uğur", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.LastName ="Customer3 Soyadı";
            customer3.FirstName = "Customer3 Adı"; 

            Customer customer2 = new Customer (2,"Ahmet","SoyadAhmet","Ankara");
            //public Customer(int id, string firstname, string lastname, string city)

            Console.WriteLine(customer2.FirstName);//Okumadı
        }


    }
    class Customer
    {
        //Default Constructor
        public Customer()
        {
            
            Console.WriteLine("Yapıcı Blok Çalışmış olmalı Custtomer 1-3 için");

        }
        public Customer(int id, string firstname, string lastname, string city)
        {
            Console.WriteLine("Yapıcı Blok Çalışmış olmalı Custtomer 2 için");
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;

        }
        public int Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string City { get; set; }
    }
}
