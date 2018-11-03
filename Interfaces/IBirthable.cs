using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Interfaces
{
    interface IBirthable : IIdentifiable
    {
        string Birthdate { get;}
    }
}
