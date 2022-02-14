using System;

namespace NestedTypesSample
{
    public class Order
    {
        private const int MaxItemsCount = 100;
        private int lastItemIndex = -1;
        private readonly OrderItem[] items = new OrderItem[MaxItemsCount];

        public decimal Total
        {
            get
            {
                decimal sum = 0;
                for (int i = 0; i <= lastItemIndex; i++)
                {
                    sum += items[i].ItemTotal;
                }

                return sum;
            }
        }

        public void AddItem(string name, int quantity, decimal price)
        {
            if (lastItemIndex < MaxItemsCount - 1)
            {
                lastItemIndex++;
                items[lastItemIndex] = new OrderItem
                {
                    Name = name,
                    Quantity = quantity,
                    Price = price
                };
            }
            else
            {
                Console.WriteLine("Max items count exceeded, cannot add more products to order!");
            }
        }

        public void Print()
        {
            string productNameHeader = "Produs";
            string quantityHeader = "Cantitate";
            string priceHeader = "Pret";
            Console.WriteLine($"{productNameHeader,-10}{quantityHeader,10}{priceHeader,10}");
            for (int i = 0; i <= lastItemIndex; i++)
            {
                Console.WriteLine($"{items[i].Name,-10}{items[i].Quantity,10}{items[i].Price,10}");
            }

            Console.WriteLine($"Total = {Total}");
        }

        private class OrderItem
        {
            public string Name { get; set; }

            public int Quantity { get; set; }

            public decimal Price { get; set; }

            public decimal ItemTotal
            {
                get
                {
                    return Quantity * Price;
                }
            }
        }
    }
}
