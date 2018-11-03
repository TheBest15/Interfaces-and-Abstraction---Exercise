using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Interfaces
{
   public interface IPerson : IBirthable
    {
         string Name { get;}
         int Age { get;}

    }
}
