using System;

namespace NestedTypesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.AddItem("Paine", 1, 5M);
            o.AddItem("Apa", 2, 4M);
            o.Print();
        }
    }
}
