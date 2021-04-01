using Dependecy_Xam.Services;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Dependecy_Xam.ViewModels
{
    public class DeviceViewModel
    {
        public string Title { get; set; } = "Device Orientation";
        public string Text { get; set; }
        public ICommand DeviceOrientationCommand { get; }
        public IDeviceOrientationService deviceOrientation;
        public DeviceViewModel(IDeviceOrientationService deviceOrientationService)
        {
            deviceOrientation = deviceOrientationService;
            Text = deviceOrientationService.GetOrientation().ToString();
            DeviceOrientationCommand = new DelegateCommand(() => deviceOrientationService.GetOrientation());
        }
    }
}
