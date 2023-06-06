using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    abstract class Strategy
    {
        public abstract double CostCalc(double cost);
    }

    class Standard : Strategy
    {
        public override double CostCalc(double cost)
        {
            return cost*1;
        }
    }

    class Preferential : Strategy
    {
        public override double CostCalc(double cost)
        {
            return cost*0.75;
        }
    }

    class Penalties : Strategy
    {
        public override double CostCalc(double cost)
        {
            return cost*1.5;
        }
    }
}
