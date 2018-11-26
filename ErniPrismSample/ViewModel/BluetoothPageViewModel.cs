using ErniPrismSample.Entities;
using ErniPrismSample.Managers.Bluetooth;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.ViewModel
{
    public class BluetoothPageViewModel
    {
        private IBluetoothManager _bluetoothManager;
        public List<BluetoothEntity> BluetoothDevices { get; set; } = new List<BluetoothEntity>();
        public BluetoothPageViewModel(IBluetoothManager bluetoothManager)
        {
            _bluetoothManager = bluetoothManager;
            BluetoothDevices = _bluetoothManager.GetListOfPairedDevices();
        }
    }
}
