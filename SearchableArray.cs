using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNumberSort
{
    internal interface SearchableArray
    {
    void Add(int element);
    void Remove(int element);
    int IndexOf(int element);
    }
}
