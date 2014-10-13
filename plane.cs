using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace epan_training_laba_1
{
    public abstract class Plane
    {
        public abstract int GetFuelRate();
        public abstract int GetFlyLength();
        public abstract void Print();
    }
}
