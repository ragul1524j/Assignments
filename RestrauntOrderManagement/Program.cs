using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrauntOrderManagement
{
    public class Restraunt
    {
        public int OrderId;
        public string CustomerName;
        public decimal TotalAmount;

        public Restraunt(int id, string name, decimal total)
        {
            OrderId = id;
            CustomerName = name;
            TotalAmount = total;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList OrderList = new ArrayList();
            Restraunt restraunt = new Restraunt(101, "Ragul", 2445);
            OrderList.Add(restraunt);
            OrderList.Add(new Restraunt(102, "Keerthick", 1235));

            while (true)
            {
                Console.WriteLine("Enter the Choice : ");
                int ch;
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.Write("\nEnter the Order Details\n");
                        Console.Write("OrderId : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("CustomerName : ");
                        string name = Console.ReadLine();
                        Console.Write("TotalAmount : ");
                        decimal total = Convert.ToDecimal(Console.ReadLine());

                        // ✅ Create a new object for each order
                        Restraunt newOrder = new Restraunt(id, name, total);
                        OrderList.Add(newOrder);
                        break;

                    case 2:
                        Console.WriteLine("\nDisplaying the Orders");

                        foreach (Restraunt item in OrderList)
                        {
                            Console.WriteLine($"\nOrderId : {item.OrderId}\nCustomerName : {item.CustomerName}\nTotalAmount : {item.TotalAmount}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nSearch an Order by OrderId");
                        Console.WriteLine("Enter the Id to search");
                        int orderId = Convert.ToInt32(Console.ReadLine());
                        Restraunt foundOrderId = null;

                        foreach (Restraunt item in OrderList)
                        {
                            if (item.OrderId == orderId)
                            {
                                foundOrderId = item;
                                break;
                            }
                        }
                        if (foundOrderId != null)
                        {
                            Console.Write($"\nOrderId : {foundOrderId.OrderId}\nCustomerName : {foundOrderId.CustomerName}\nTotalAmount : {foundOrderId.TotalAmount}");
                        }
                        else
                        {
                            Console.WriteLine("OrderId Couldn't Found");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nEnter the orderId to Remove ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        Restraunt RemoveId = null;
                        foreach (Restraunt item in OrderList)
                        {
                            if (item.OrderId == removeId)
                            {
                                RemoveId = item;
                                break;
                            }
                        }
                        if (RemoveId != null)
                        {
                            OrderList.Remove(RemoveId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Id");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nTotal Number Of Order : " + OrderList.Count);
                        break;

                    case 6:
                        Console.WriteLine("\nReversing the List of Order List");
                        OrderList.Reverse();
                        foreach (Restraunt item in OrderList)
                        {
                            Console.WriteLine($"\nOrderId : {item.OrderId}\nCustomerName : {item.CustomerName}\nTotalAmount : {item.TotalAmount}");
                        }
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}