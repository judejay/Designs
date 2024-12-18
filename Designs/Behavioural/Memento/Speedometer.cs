﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Memento
{
    [Serializable]
    public class Speedometer
    {
        private int _currentSpeed;
        private int _previousSpeed;

        public Speedometer()
        {
            _currentSpeed = 0;
            _previousSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                _previousSpeed = _currentSpeed;
                _currentSpeed = value;
            }
            get
            {
                return _currentSpeed;
            }
        }

        //Only defined to help testing
        public virtual int PreviousSpeed()
        {
            return _previousSpeed;
        }
    }
    


}
