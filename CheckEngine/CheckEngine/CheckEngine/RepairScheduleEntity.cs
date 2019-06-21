using MK1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckEngine
{
  [Serializable]
  public class RepairScheduleEntity : Entity
  {
    public UInt32 NotificationMileageThreshold { get; set; }
    public UInt32 AirFilterRepairFrequency { get; set; }
    public UInt32 AlignmentRepairFrequency { get; set; }
    public UInt32 AlternatorRepairFrequency { get; set; }
    public UInt32 AutomaticTransmissionFluidChangeFrequency { get; set; }
    public UInt32 BrakeFluidChangeFrequency { get; set; }
    public UInt32 CoolantChangeFrequency { get; set; }
    public UInt32 DiscBrakesRepairFrequency { get; set; }
    public UInt32 DrumBrakesRepairFrequency { get; set; }
    public UInt32 ManualTransmissionFluidChangeFrequency { get; set; }
    public UInt32 OilChangeRepairFrequency { get; set; }
    public UInt32 PowerSteeringFluidChangeFrequency { get; set; }
    public UInt32 RadiatorFluidChangeFrequency { get; set; }
    public UInt32 TireRotationRepairFrequency { get; set; }
    public UInt32 RotorsRepairFrequency { get; set; }
    public UInt32 SolenoidRepairFrequency { get; set; }
    public UInt32 StarterRepairFrequency { get; set; }
    public UInt32 TimingBeltsRepairFrequency { get; set; }
    public UInt32 TiresRepairFrequency { get; set; }
    public UInt32 SparkPlugsRepairFrequency { get; set; }
    public UInt32 FuelInjectorRepairFrequency { get; set; }


    //public RepairEntity AirFilterRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.AirFilter };
    //public RepairEntity AlignmentRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.Alignment };
    //public RepairEntity AlternatorRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.Alternator };
    //public RepairEntity AutomaticTransmissionFluidChangeFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.AutomaticTransmissionFluid };
    //public RepairEntity BrakeFluidChangeFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.BrakeFluid };
    //public RepairEntity CoolantChangeFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.Coolant };
    //public RepairEntity DiscBrakesRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.DiscBrakes };
    //public RepairEntity DrumBrakesRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.DrumBrakes };
    //public RepairEntity ManualTransmissionFluidChangeFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.ManualTransmissionFluid };
    //public RepairEntity OilChangeRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.Oil };
    //public RepairEntity PowerSteeringFluidChangeFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.PowerSteeringFluid};
    //public RepairEntity RadiatorFluidChangeFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.RadiatorFluid };
    //public RepairEntity TireRotationRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.TireRotation };
    //public RepairEntity RotorsRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.Rotors };
    //public RepairEntity SolenoidRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.Solenoid };
    //public RepairEntity StarterRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.Starter };
    //public RepairEntity TimingBeltsRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.TimingBelts };
    //public RepairEntity TiresRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.Tires };
    //public RepairEntity SparkPlugsRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.SparkPlugs };
    //public RepairEntity FuelInjectorRepairFrequency { get; set; } = new RepairEntity() { RepairType = RepairType.FuelInjector };\\


    public List<RepairEntity> RepairFrequencySettings { get; set; } = new List<RepairEntity>();

    public RepairScheduleEntity() { }

    public void InitializeTestSettings()
    {
      NotificationMileageThreshold = 5000;

      foreach (var type in (RepairType[])Enum.GetValues(typeof(RepairType)))
      {
        RepairFrequencySettings.Add(new RepairEntity() { EntityID = Guid.NewGuid(), RepairType = type, Mileage = 30000 });
      }
    }

  }
}
