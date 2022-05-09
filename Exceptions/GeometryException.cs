using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Exceptions
{
    public class GeometryException : Exception
    {
        public GeometryException(string message) : base(message) { }
    }
}
