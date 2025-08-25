using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSystemWithStrategyAfter
{
    internal interface ISortStrategy
    {
        void Sort(int[] array);
    }
}
