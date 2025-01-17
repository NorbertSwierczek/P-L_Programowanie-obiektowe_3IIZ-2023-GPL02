using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public interface IOsoba
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void GetFullName();
    }
}