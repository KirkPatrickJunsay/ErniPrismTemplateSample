using ErniPrismSample.Common.Bluetooth;
using ErniPrismSample.Common.Mapper.Mapper;
using ErniPrismSample.Contract;
using ErniPrismSample.Entities;
using ErniPrismSample.Managers.Bluetooth;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Managers
{
    public class BluetoothManager:IBluetoothManager
    {
        private readonly IBluetoothService _bluetoothService;
        private readonly IMapperService _mapperService;
        public BluetoothManager(IBluetoothService bluetoothService, IMapperService mapperService)
        {
            _bluetoothService = bluetoothService;
            _mapperService = mapperService;
        }
        public List<BluetoothEntity> GetListOfPairedDevices()
        {
            List<BluetoothEntity> result = new List<BluetoothEntity>();

            if (_bluetoothService.CheckBluetooth())
            {
                List<BluetoothContract> bluetoothDevices = _bluetoothService.QueryDevices();

               result = _mapperService.Map<List<BluetoothEntity>>(bluetoothDevices);
            }

            return result;
        }
    }
}
