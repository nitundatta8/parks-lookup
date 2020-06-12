
namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string State { get; set; }
    public string Agency { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public bool Campsites { get; set; }
  }
}