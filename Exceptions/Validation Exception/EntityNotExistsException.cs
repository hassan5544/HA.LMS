using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Validation_Exception
{
    public class EntityNotExistsException : Exception
    {
        public EntityNotExistsException(string name) : base(String.Format("Patient name : {0} Dont Exists in the datanase", name))
        {

        }
    }
}
