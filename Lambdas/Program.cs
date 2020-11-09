using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Part 1:
            //Question 1:
            List<int> intList = new List<int>() { 6, 5, 4, 3, 2, 1, 7, 10, 1 };
            List<int> lssFive = intList.Where(z => z < 5).ToList();
            Console.Write("Q1P1: ");
            foreach(int l in lssFive)
            {
                Console.Write(l+" ");
            }
            Console.WriteLine();
            //Question 2:
            Console.Write("Q2P1: ");
            int min = intList.Min();
            Console.WriteLine(min);
            //Question 3:
            Console.Write("Q3P1: ");
            double avgr = intList.Average();
            List<int> lssAvgr = intList.Where(k => k < avgr).ToList();
            foreach(int la in lssAvgr)
            {
                Console.Write(la + " ");
            }
            Console.WriteLine();
            ///Part 2:
            //Question 4:
            Console.WriteLine("Q4P2: ");
            Dictionary<int, string> indexedList = new Dictionary<int, string>();
            indexedList.Add(1, "Green Division");
            indexedList.Add(2, "Yellow Division");
            indexedList.Add(3, "Blue Division");
            indexedList.Add(4, "Pink Division");
            indexedList.Add(5, "Dark Blue Division");

            var hasBlue = indexedList.Where(p => p.Value.Contains("Blue"));
            foreach(KeyValuePair<int,string> hb in hasBlue)
            {
                Console.WriteLine(hb.Key + "," +hb.Value);
            }
            //Question 5:
            Console.WriteLine("Q5P2: ");
            var cologrtFour = indexedList.Where(p => p.Value.TrimEnd("Division".ToCharArray()).Length > 5);
            foreach(KeyValuePair<int,string> cf in cologrtFour)
            {
                Console.WriteLine(cf.Key + "," + cf.Value);
            }
            //Question 6:
            Console.WriteLine("Q6P2: ");
            List<Account> accounts = indexedList.Select(p => new Account(p.Key,p.Value,p.Key*10000)).ToList();
            foreach(Account a in accounts)
            {
                Console.WriteLine(a.id + "," + a.name + "," + a.balance);
            }
            ///Part 3:
            //Question 7:
            Console.Write("Q7P3: ");
            List<Account> accountList = new List<Account>();
            accountList.Add(new Account { id = 123, name = "Eastern Division", balance = 12332.33 });
            accountList.Add(new Account { id = 234, name = "Western Division", balance = 22333333.22 });
            accountList.Add(new Account { id = 345, name = "Northern Division", balance = 2184.34 });
            accountList.Add(new Account { id = 456, name = "Southern Division", balance = 999222.00 });
            accountList.Add(new Account { id = 567, name = "Champlain Wireless Division", balance = 00.01 });
            double avgBalance = accountList.Average(h => h.balance);
            Console.Write(avgBalance+"\n");
            //Question 8 + 9:
            List<Account> accountsgrtTenthousand = accountList.Where(y => y.balance > 10000).ToList();
           
            Console.Write("Q8P3: ");
            double avggrtTenthousand = accountsgrtTenthousand.Average(y => y.balance);
            Console.Write(avggrtTenthousand+"\n");

            Console.WriteLine("Q9P3: ");
            foreach(Account a in accountsgrtTenthousand)
            {
                Console.WriteLine(a.id+","+a.name+","+a.balance);
            }

        }
    }
    class Account
    {
        public int id;
        public string name;
        public double balance; 
        public Account(int id,string name,double balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public Account() { }
        public override string ToString()
        {
            return String.Format("[Account ID:%d , Account name:%s ,  Account balance:%d]\n",id,name,balance);
        }
    }
}

