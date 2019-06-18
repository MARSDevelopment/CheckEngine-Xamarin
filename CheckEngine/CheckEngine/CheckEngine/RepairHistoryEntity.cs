using MK1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckEngine
{
  [Serializable]
  class RepairHistoryEntity : Entity
  {
    public UInt32 LastAirFilterRepairMileage { get; set; }
    public UInt32 LastAlignmentRepairMileage { get; set; }
    public UInt32 LastAlternatorRepairMileage { get; set; }
    public UInt32 LastAutomaticTransmissionFluidChangeMileage { get; set; }
    public UInt32 LastBrakeFluidChangeMileage { get; set; }
    public UInt32 LastCoolantChangeMileage { get; set; }
    public UInt32 LastDiscBrakesRepairMileage { get; set; }
    public UInt32 LastDrumBrakesRepairMileage { get; set; }
    public UInt32 LastManualTransmissionFluidChangeMileage { get; set; }
    public UInt32 LastOilChangeRepairMileage { get; set; }
    public UInt32 LastPowerSteeringFluidChangeMileage { get; set; }
    public UInt32 LastRadiatorFluidChangeMileage { get; set; }
    public UInt32 LastTireRotationRepairMileage { get; set; }
    public UInt32 LastRotorsRepairMileage { get; set; }
    public UInt32 LastSolenoidRepairMileage { get; set; }
    public UInt32 LastStarterRepairMileage { get; set; }
    public UInt32 LastTimingBeltsRepairMileage { get; set; }
    public UInt32 LastTiresRepairMileage { get; set; }
    public UInt32 LastSparkPlugsRepairMileage { get; set; }
    public UInt32 LastFuelInjectorRepairMileage { get; set; }
  }
}
