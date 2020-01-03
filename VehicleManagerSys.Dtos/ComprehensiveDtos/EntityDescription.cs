using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    [AttributeUsage(AttributeTargets.Class |
     AttributeTargets.Constructor |
     AttributeTargets.Field |
     AttributeTargets.Method |
     AttributeTargets.Property,
     AllowMultiple = true)]
    public class EntityDescription : System.Attribute
    {

        private string _description;

        public EntityDescription(string strDescription)
        {
            this._description = strDescription;
        }

        public string Description { get { return _description; } }

    }
}
