using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Date { get; set; }
    public string Title { get; set; }
    public string Price { get; set; } 
    public string Description { get; set; }
    public int Id { get; }
    private static List<Order> _orders = new List<Order> { };

    public Order(string date, string title, string price, string description)
    {
      Date = date;
      Title = title;
      Price = price;
      Description = description;
      _orders.Add(this);
      Id = _orders.Count;
    }
    
    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static Order Find(int searchId)
    {
      return _orders[searchId-1];
    }
  }
}