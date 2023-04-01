using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "You must include a name for the engineer!")]
    public string Name { get; set; }
    public string EngineerDetails { get; set; }

    public List<EngineerMachine> JoinEntities { get; set; }

    public List<Machine> Machines { get; set; }

  }
}