using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppWF.Presentation
{
    [Flags]
    enum Enumchik
    {
        Mon = 1 << 0,
        Tue = 1 << 1,
        Wen = 1 << 2,
        Thr = 1 << 3,
        Fri = 1 << 4,
        Sut = 1 << 5,
        Sun = 1 << 6
    }
}
