using System.Collections.Generic;
using System.ComponentModel;

namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId { get; set; }
    public int EngineerId { get; set; }
    public Engineer Engineer { get; set; }

    public int MachineId { get; set; }
    public Machine Machine { get; set; }
    // public List<EngineerMachine> Machines { get; set; }

  }
}
