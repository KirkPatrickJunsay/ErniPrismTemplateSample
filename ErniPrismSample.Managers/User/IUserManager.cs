using ErniPrismSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Managers.User
{
    public interface IUserManager
    {
        void SaveUser(UserEntity user);
        List<UserEntity> RetrieveAllUser();
    }
}
