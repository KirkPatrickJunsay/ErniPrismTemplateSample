using ErniPrismSample.Common.Mapper.Mapper;
using ErniPrismSample.Common.Mapper.Profile;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Common.Mapper
{
    public class MapperService : IMapperService
    {
        public MapperService()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<BluetoothProfile>();
                cfg.AddProfile<UserProfile>();
            });
        }

        public TDestination Map<TDestination>(object value)
        {
            return AutoMapper.Mapper.Map<TDestination>(value);
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return AutoMapper.Mapper.Map<TSource, TDestination>(source);
        }
    }
}

