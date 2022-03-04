using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Item { get; set; }
    public string Price { get; set; } 
    public int Id { get; }
    public static List<Order> _orders = new List<Order> { };

    public Order(string item, string price)
    {
      Item = item;
      Price = price;
      _orders.Add(this);
      Id = _orders.Count;
    }
  }
}