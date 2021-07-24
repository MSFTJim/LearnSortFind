using System;
using System.Collections.Generic;

namespace myfirstsort
{


    class Program
    {
        static void Main(string[] args)
        {
            int dog = 0;


            Console.WriteLine("Hello World!");

            List<Item> myItemList = InitialDBLoad();
            //List<Item> myItemList = new();

            Console.WriteLine("\nBefore sort by item ID:");
            foreach (Item anItem in myItemList)
            {
                Console.WriteLine(anItem);
            }

            myItemList.Sort();

            Console.WriteLine("\nAfter sort by item ID:");
            foreach (Item anItem in myItemList)
            {
                Console.WriteLine(anItem);
            }

            dog++;

            Item FoundItem = myItemList.Find(e => e.Id == 3);
            //Item FoundItem = myItemList.Find(e => e.Name == "Wine");
            Console.WriteLine("\nResult of Find");
            Console.WriteLine(FoundItem);

            FoundItem = myItemList.Find(x => x.Name.Contains("Martini"));

            Console.WriteLine("\nResult of Find");
            Console.WriteLine(FoundItem);
            dog++;

        }


        public class Item : IComparable<Item>, IEquatable<Item>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public double Rating { get; set; }

            public bool Equals(Item other)
            {
                if (other == null) return false;
                return (this.Id.Equals(other.Id));
            }



            public int CompareTo(Item compareItem)
            {
                // A null value means that this object is greater.
                if (compareItem == null)
                    return 1;

                else
                    return this.Id.CompareTo(compareItem.Id);
            }

            public override string ToString()
            {
                return "ID: " + Id + ", Name: " + Name + ", Price: " + Price + ", Rating: " + Rating;
            }

        }

        public static List<Item> InitialDBLoad()
        {
            List<Item> _itemList = new();
            _itemList.Add(new Item() { Id = 4, Name = "Martini", Price = 15.25, Rating = 4.8 });
            _itemList.Add(new Item() { Id = 2, Name = "Manhattan", Price = 15.50, Rating = 4.5 });
            _itemList.Add(new Item() { Id = 1, Name = "Domestic Beer", Price = 8.50, Rating = 3.0 });
            _itemList.Add(new Item() { Id = 3, Name = "Wine", Price = 10.00, Rating = 3.5 });

            return _itemList;

        }


    } // end class program
} // end namespace 
