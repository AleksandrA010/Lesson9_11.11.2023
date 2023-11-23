using System;

namespace LabWork
{
    internal interface ICipher
    {
        string encode(string inputString);
        string decode(string inputString);

    }
}
