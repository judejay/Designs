using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Command
{
    public class ElectricWindow
    {

        private bool _open;

        public ElectricWindow() 
        {
            _open = false;  
            Console.WriteLine("Window is closed");
        }

        public virtual bool IsOpen
        {
            get { return _open; }
        }

        public virtual bool IsClosed
        {
            get { return !_open; }
        }

        public virtual void OpenWindow()
        {
            if (IsClosed)
            {
                _open = true;
                Console.WriteLine("Window is open");
            }
        }

        public virtual void CloseWindow()
        {
            if (IsOpen)
            {
                _open = false;
                Console.WriteLine("Window is closed");
            }
        }
    }
}
