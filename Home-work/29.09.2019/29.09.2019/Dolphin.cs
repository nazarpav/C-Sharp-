﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _29._09._2019
{
    class Dolphin : Fish, Floating
    {
        public Dolphin(Animal_ type, string animalVoise) : base(type, animalVoise) { }
        public string Float()
        {
            return "Float";
        }
    }
}
