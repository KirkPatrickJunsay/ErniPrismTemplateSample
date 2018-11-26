using ErniPrismSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Managers.Bluetooth
{
    public interface IBluetoothManager
    {
        List<BluetoothEntity> GetListOfPairedDevices();
    }
}
