using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public static List<Vendor> _vendors = new List<Vendor>();

    public Vendor (string nameOfVendor, string descriptionOfVendor)
    {
      Name = nameOfVendor;
      Description = descriptionOfVendor;
      _vendors.Add(this);
      Id = _vendors.Count;
    }
  }
}