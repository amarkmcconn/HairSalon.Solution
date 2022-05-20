using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylists
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
  }
}