using MK1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckEngine
{
  [Serializable]
  public class CarEntity : Entity
  {
    public string Name { get; set; }
    public UInt16 Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public UInt16 CurrentMileage { get; set; }
    public Guid RepairHistoryID { get; set; }
    public Guid RepairScheduleID { get; set; }
  }
}
