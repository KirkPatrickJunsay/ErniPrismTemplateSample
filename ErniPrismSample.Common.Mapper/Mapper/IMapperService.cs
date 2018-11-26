using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Common.Mapper.Mapper
{
    public interface IMapperService
    {
        TDestination Map<TDestination>(object value);

        TDestination Map<TSource, TDestination>(TSource source);
    }
}
