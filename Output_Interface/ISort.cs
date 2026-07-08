using System;
using System.Collections.Generic;
using System.Text;

namespace Output_Interface
{
    internal interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
