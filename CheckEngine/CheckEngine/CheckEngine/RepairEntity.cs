using MK1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CheckEngine
{
  [Serializable]
  public class RepairEntity : Entity
  {
    public RepairType RepairType { get; set; }
    public UInt32 Mileage { get; set; }

  }

  public enum RepairType
  {
    [Description("Air Filter")] AirFilter,
    [Description("Alignment")] Alignment,
    [Description("Alternator")] Alternator,
    [Description("Automatic Transmission Fluid")] AutomaticTransmissionFluid,
    [Description("Brake Fluid")] BrakeFluid,
    [Description("Coolant")] Coolant,
    [Description("Disc Brakes")] DiscBrakes,
    [Description("Drum Brakes")] DrumBrakes,
    [Description("Manual Transmission Fluid")] ManualTransmissionFluid,
    [Description("Oil")] Oil,
    [Description("Power Steering Fluid")] PowerSteeringFluid,
    [Description("Radiator Fluid")] RadiatorFluid,
    [Description("Tire Rotation")] TireRotation,
    [Description("Rotors")] Rotors,
    [Description("Solenoid")] Solenoid,
    [Description("Starter")] Starter,
    [Description("Timing Belts")] TimingBelts,
    [Description("Tires")] Tires,
    [Description("Spark Plugs")] SparkPlugs,
    [Description("Fuel Injector")] FuelInjector
  }
}
