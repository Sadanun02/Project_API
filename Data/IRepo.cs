using System.Collections.Generic;
using demoapi.Models;

namespace demoapi.Data
{
    public interface IRepo
    {
        Task<IEnumerable<User>> GetAllUsers();
         
    }

}