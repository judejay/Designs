using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Command
{
    public class Radio
    {
        public const int MinVolume = 0;
        public const int MaxVolume = 10;
        public const int DefaultVolume = 5;

        private int _volume;
        private bool _isOn;

        public Radio()
        {
            _volume = DefaultVolume;
            _isOn = false;
        }

        public virtual bool IsOn
        {
            get { return _isOn; }
        }

        public virtual int Volumne
        {
            get { return _volume; }
        }
        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Radio is on, volume level " + Volumne);
        }

        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Radio is off");
        }

        public void VolumeUp()
        {
            if (IsOn && Volumne < MaxVolume)
            {
                _volume++;
                Console.WriteLine("Radio volume increased to " + Volumne);
            }
        }

        public void VolumeDown()
        {
            if (IsOn && Volumne > MinVolume)
            {
                _volume--;
                Console.WriteLine("Radio volume decreased to " + Volumne);
            }
        }
    }
}
