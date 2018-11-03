using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Interfaces
{
   public interface IBirthable : IIdentifiable
    {
        string Birthdate { get;}
    }
}
