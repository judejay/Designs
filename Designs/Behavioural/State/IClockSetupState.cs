using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.State
{
    public interface IClockSetupState
    {
        void PreviousValue();
        void NextValue();
        void SelectValue();

        string Instructions { get; }
        int SelectedValue { get; }

    }
}
