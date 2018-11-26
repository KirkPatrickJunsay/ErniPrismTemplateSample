using ErniPrismSample.Entities;
using ErniPrismSample.Repository.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Common.Mapper.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<UserEntity, UserDTO>();
            CreateMap<UserDTO, UserEntity>();
        }
    }
}
