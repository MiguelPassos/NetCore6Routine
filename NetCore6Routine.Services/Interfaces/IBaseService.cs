using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6Routine.Services.Interfaces
{
    public interface IBaseService
    {
        void Execute();

        string SetMessage();
    }
}
