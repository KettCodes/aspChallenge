using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.Models;

namespace VogCodeChallenge.API.Services
{
    public interface IDataService
    {
        IList<Employee> ListAll { get; }

        IEnumerable<Employee> GetAll { get; }
    }
}
