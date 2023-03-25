using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string EngineerDetails { get; set; }
    public List<Machine> Machines { get; set; }
  }
}