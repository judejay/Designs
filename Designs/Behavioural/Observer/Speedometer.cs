using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Observer
{
    public class Speedometer
    {
        public event EventHandler ValueChanged;

        private int _currentSpeed;
        public Speedometer()
        {
            _currentSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                _currentSpeed = value;
                OnValueChanged();
            }
            get
            {
                return _currentSpeed;
            }
        }

        protected virtual void OnValueChanged()
        {
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
