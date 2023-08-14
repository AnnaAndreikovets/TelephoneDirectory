using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Data.Interfaces
{
    public interface ICity
    {
        public City GetCity(int index);
    }
}