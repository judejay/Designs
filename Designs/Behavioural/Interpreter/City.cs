using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Interpreter
{
    public class City
    {
        private string _name;
        private double _latitude, _longitude;

        public City(string name, double latitude, double longitude)
        {
            _name = name;
            _latitude = latitude;
            _longitude = longitude;
        }

        public virtual string Name
        {
            get
            {
                return _name;
            }
        }

        public virtual double Latitude
        {
            get
            {
                return _latitude;
            }
        }

        public virtual double Longitude
        {
            get
            {
                return _longitude;
            }
        }

        public override bool Equals(object otherObject)
        {
            if (this == otherObject)
            {
                return true;
            }
            if ( !(otherObject is City))
            {
                return false;
            }
            City otherCity = (City)otherObject;
            return Name.Equals(otherCity.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name + " (" + Latitude + ", " + Longitude + ")";
        }
    }
}
