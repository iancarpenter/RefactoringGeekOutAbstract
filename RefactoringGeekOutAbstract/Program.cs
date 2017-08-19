using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeekOutAbstract
{
    class Program
    {
        static void Main(string[] args)
        {

            SilverAccount silverAccount = new SilverAccount();

            Console.WriteLine($"Silver account starting balance {silverAccount.Balance}"  );
            silverAccount.AddTransaction(100m);
            Console.WriteLine($"Added £100 transaction, Balance is now {silverAccount.Balance}");
            Console.WriteLine($"and reward points is now {silverAccount.RewardPoints}");

            GoldAccount goldAccount = new GoldAccount();

            Console.WriteLine($"Gold account starting balance {goldAccount.Balance}");
            goldAccount.AddTransaction(100m);
            Console.WriteLine($"Added £100 transaction, Balance is now {goldAccount.Balance}");
            Console.WriteLine($"and reward points is now {goldAccount.RewardPoints}");

            PlatinumAccount platinumAccount = new PlatinumAccount();

            Console.WriteLine($"Platinum account starting balance {platinumAccount.Balance}");
            platinumAccount.AddTransaction(100m);
            Console.WriteLine($"Added £100 transaction, Balance is now {platinumAccount.Balance}");
            Console.WriteLine($"and reward points is now {platinumAccount.RewardPoints}");

        }
    }
}
