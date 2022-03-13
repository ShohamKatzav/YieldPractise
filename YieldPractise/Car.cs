using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldPractise
{
    internal class Car
    {
        public string? Maker;
        public int ModelYear;
        public override string ToString() => $"{ModelYear}, {Maker}";
    }
}
