using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeekOutAbstract
{
    public class PlatinumAccount : AccountBase
    {
        public decimal Balance
        {
            get;
            set;
        }

        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Ceiling((Balance / PlatinumBalanceCostPerPoint) + (amount / PlatinumTransactionCostPerPoint)), 0);
        }

        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;
    }
}