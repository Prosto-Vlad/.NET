using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Equipment
    {
        private string _name;
        private Strategy _strategy_method;
        private Strategy _strategy_conditions;
        private double _base_cost;
        private double _cost;

        public Equipment(string name, Strategy strategy_met, Strategy strategy_cond, double base_cost)
        {
            _name = name;
            _strategy_method = strategy_met;
            _strategy_conditions = strategy_cond;
            _base_cost = base_cost;
            CalcCost();
        }

        public void CalcCost()
        {
            _cost = _strategy_method.CostCalc(_base_cost);
            _cost = _strategy_conditions.CostCalc(_cost);
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                _name + "\n" +
                _cost);
        }
    }
}
