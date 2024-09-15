using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class BankImplementation : Bank, Promotion
    {
        internal int balance = 20000;

        public void branding()
        {
            Console.WriteLine("Promotion");
        }

        public void Checkbalance()
        {
            if (this.Login(123))
            {
                Console.WriteLine("Balance is {0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid Pincode");
            }
            
        }

        public void Credit(int amount)
        {
            if (this.Login(123)){
                balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid Pincode");
            }
            
        }

        public void Debit(int amount)
        {
            if (this.Login(123))
            {
                balance -= amount;
                Checkbalance();
            }
            else
            {
                Console.WriteLine("Invalid Pincode");
            }
        }

        public bool Login(int pincode)
        {
            if (pincode == 123)
            {
                
                
                return true;
            }

            else
            {
                return false;
            }
        }

        public void marketing()
        {
            Console.WriteLine("Marketing");
        }
    }
}
