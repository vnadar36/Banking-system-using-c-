using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    interface balance
    {
        void checkbalance(int x);
    }
    interface withdraw
    {
        void withdraw(int y);
    }
    interface deposit
    {
        void amtdep(int z);
    }
    class Program
    {
        int bal, wit, dep;
        public void checkbalance(int x)
        {
            bal=x;
            Console.WriteLine("Balance Amoun: {0}", bal);
        }
        public void withdraw(int y)
        {
            wit = y;
            Console.WriteLine("Withdrawn Amount: {0}", wit);
            bal = bal - wit;
            Console.WriteLine("Balance Amount: {0}", bal);
        }
        public void amtdep(int z)
        {
            dep = z;
            Console.WriteLine("Deposited Amount: {0}", bal);
            bal = bal + dep;
            Console.WriteLine("Balance Amount: {0}", bal);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Bank");
            Program p = new Program();
            int min = 1000;
            p.checkbalance(1000);
            Console.WriteLine("Enter amount to withdrawan:");
            int w;
            w = int.Parse(Console.ReadLine());
            p.withdraw(w);
            Console.WriteLine("Enter amount to deposited:");
            int d;
            d = int.Parse(Console.ReadLine());
            p.amtdep(d);
            Console.ReadLine();
        }
    }
}
