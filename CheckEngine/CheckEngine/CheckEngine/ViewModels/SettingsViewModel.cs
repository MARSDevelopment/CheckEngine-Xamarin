using MK1.MVVM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CheckEngine.ViewModels
{
  class SettingsViewModel : ViewModel
  {

    #region Public Properties

    private UInt32 repairNotificationMileageThreshold;
    public UInt32 RepairNotificationMileageThreshold
    {
      get { return repairNotificationMileageThreshold; }
      set
      {
        if (repairNotificationMileageThreshold != value)
        {
          repairNotificationMileageThreshold = value;
          OnPropertyChanged();
        }
      }
    }

    private bool enableLockScreenNotifications;
    public bool EnableLockScreenNotifications
    {
      get { return enableLockScreenNotifications; }
      set
      {
        if (enableLockScreenNotifications != value)
        {
          enableLockScreenNotifications = value;
          OnPropertyChanged();
        }
      }
    }

    private bool enableNotificationPanelNotifications;
    public bool EnableNotificationPanelNotifications
    {
      get { return enableNotificationPanelNotifications; }
      set
      {
        if (enableNotificationPanelNotifications != value)
        {
          enableNotificationPanelNotifications = value;
          OnPropertyChanged();
        }
      }
    }

    private NotificationFrequency lockScreenNotificationFrequency;
    public NotificationFrequency LockScreenNotificationFrequency
    {
      get { return lockScreenNotificationFrequency; }
      set
      {
        if (lockScreenNotificationFrequency != value)
        {
          lockScreenNotificationFrequency = value;
          OnPropertyChanged();
        }
      }
    }

    private NotificationFrequency notificationPanelNotificationFrequency;
    public NotificationFrequency NotificationPanelNotificationFrequency
    {
      get { return notificationPanelNotificationFrequency; }
      set
      {
        if (notificationPanelNotificationFrequency != value)
        {
          notificationPanelNotificationFrequency = value;
          OnPropertyChanged();
        }
      }
    }
    #endregion

    /// <summary>
    /// The command to toggle the checkbox
    /// </summary>
    public ICommand ToggleCheckBox { get; set; }


    /// <summary>
    /// Default Constructor
    /// </summary>
    public SettingsViewModel()
    {
      // Create commands
      this.ToggleCheckBox = new RelayCommand(Toggle);
    }



    private void Toggle()
    {

    }
  }
}
