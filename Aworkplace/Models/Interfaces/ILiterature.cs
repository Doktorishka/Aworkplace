using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aworkplace.Models.Interfaces
{
    public interface ILiterature
    {
        void AddLiterature();
        void DeleteLiterature();
        void UpdateLiterature();
        int getLastId();
    }
}
