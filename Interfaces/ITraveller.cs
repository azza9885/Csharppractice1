using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ITraveller
    {
        string GetStarting_Location();

        string GetDestination();

        double DetermineMiles();
    }
}
