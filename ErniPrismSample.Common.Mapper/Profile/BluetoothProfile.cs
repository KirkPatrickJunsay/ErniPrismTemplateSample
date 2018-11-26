using ErniPrismSample.Contract;
using ErniPrismSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Common.Mapper.Profile
{
    public class BluetoothProfile : AutoMapper.Profile
    {
        public BluetoothProfile()
        {
            CreateMap<BluetoothEntity, BluetoothContract>();
            CreateMap<BluetoothContract, BluetoothEntity>();
        }
    }
}
