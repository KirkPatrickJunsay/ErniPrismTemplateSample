using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ErniPrismSample.Common.Bluetooth;
using ErniPrismSample.Contract;

namespace ErniPrismSample.Android.Service
{
    public class BluetoothService : IBluetoothService
    {
        private BluetoothAdapter bluetoothAdapter;

        public bool CheckBluetooth()
        {
            bluetoothAdapter = BluetoothAdapter.DefaultAdapter;

            return (bluetoothAdapter != null && bluetoothAdapter.IsEnabled);
        }
        public List<BluetoothContract> QueryDevices()
        {
            List<BluetoothContract> bluetoothContracts = new List<BluetoothContract>();

            foreach (var record in bluetoothAdapter.BondedDevices)
                bluetoothContracts.Add(new BluetoothContract() { DeviceName = record.Name });

            return bluetoothContracts;
        }
    }
}