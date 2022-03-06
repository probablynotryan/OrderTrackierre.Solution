using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; } 
    public static List<Vendor> _vendors = new List<Vendor> ();
    public List<Order> Order { get; set; }

    public Vendor (string nameOfVendor, string descriptionOfVendor)
    {
      Name = nameOfVendor;
      Description = descriptionOfVendor;
      _vendors.Add(this);
      Order = new List<Order>{};
      Id = _vendors.Count;
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

    public static Vendor Find(int searchId)
    {
      return _vendors[searchId-1];
    }    
  }
}