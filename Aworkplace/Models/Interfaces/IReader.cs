using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aworkplace.Models.Interfaces
{
    public interface IReader
    {
        void AddReader();
        void DeleteReader();
        void UpdateReader();
        int getLastIndex();
    }
}
