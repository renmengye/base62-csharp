using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base62.Example
{
    class Example
    {
        void Encode()
        {
            string s = (new byte[] { 116, 32, 8, 99, 100, 232, 4, 7 }).ToBase62();
        }

        void Decode()
        {
            byte[] b = "T208OsJe107".FromBase62();
        }
    }
}
