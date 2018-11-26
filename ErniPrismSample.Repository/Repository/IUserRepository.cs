using ErniPrismSample.Repository.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErniPrismSample.Repository.Repository
{
    public interface IUserRepository
    {
        void SaveUser(UserDTO user);
        IEnumerable<UserDTO> RetrieveUsers();
    }
}
