using ErniPrismSample.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Common.Bluetooth
{
    public interface IBluetoothService
    {
        bool CheckBluetooth();
        List<BluetoothContract> QueryDevices();
    }
}
