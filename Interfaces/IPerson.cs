using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Interfaces
{
    interface IPerson : IBirthable
    {
         string Name { get;}
         int Age { get;}

    }
}
