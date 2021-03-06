using System;

namespace HomeWork
{

    class Address
    {
        int index;
        public int Index
        {
            set { index = value; }
            get { return index; }
        }
        string country;
        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        string city;
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        string street;
        public string Street
        {
            set { street = value; }
            get { return street; }
        }
        string house;
        public string House
        {
            set { house = value; }
            get { return house; }
        }
        string apartement;
        public string Apartement
        {
            set { apartement = value; }
            get { return apartement; }
        }
    }

    /*class Program
    {
        static void Main()
        {
            Address instance = new Address();
            instance.Index = 1234;
            instance.House = "House1";
            instance.Street = "Street1";
            instance.City = "City1";
            instance.Country = "Country";
            instance.Apartement = "Apartement";

            Console.WriteLine(instance.Index);
            Console.WriteLine(instance.House);
            Console.WriteLine(instance.Street);
            Console.WriteLine(instance.City);
            Console.WriteLine(instance.Country);
            Console.WriteLine(instance.Apartement);

            Console.ReadLine();
        }
    }*/
}
