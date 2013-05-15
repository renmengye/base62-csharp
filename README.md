base62-csharp
=============

Base62 Encoding C# implementation

Example
=============

        void Encode()
        {
            string s = (new byte[] { 116, 32, 8, 99, 100, 232, 4, 7 }).ToBase62();
        }

        void Decode()
        {
            byte[] b = "T208OsJe107".FromBase62();
        }
