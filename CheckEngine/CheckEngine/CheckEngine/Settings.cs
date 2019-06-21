using MK1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CheckEngine
{
  public enum NotificationFrequency
  {
    [Description("Daily")] Daily,
    [Description("Weekly")] Weekly
  }

  [Serializable]
  public class Settings : Entity
  {
    public UInt32 RepairNotificationMileageThreshold { get; set; }
    public bool EnableLockScreenNotifications { get; set; }
    public bool EnableNotificationPanelNotifications { get; set; }
    public NotificationFrequency LockScreenNotificationFrequency { get; set; }
    public NotificationFrequency NotificationPanelNotificationFrequency { get; set; }
  }

  public class ProductContext : Context
  {
    public override Guid ID => new Guid("260F15A4-60D6-425B-8616-861C8E14E527");
    public override string Name => "Check Engine";
  }
}
