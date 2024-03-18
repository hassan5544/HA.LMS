﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Validation_Exception
{
    public class EntityExistsException : Exception
    { 
        public EntityExistsException(string name) : base(String.Format("Patient name : {0} Already Exists " , name))
        {
                        
        }
    }
}
