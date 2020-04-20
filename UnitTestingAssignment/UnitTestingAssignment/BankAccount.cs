using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingAssignment
{
   public class BankAccount
    {
        private readonly string u_accountnumber;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string accountnumber, double balance)
        {
            u_accountnumber = accountnumber;
            m_balance = balance;
        }

        public string AccountNumber
        {
            get { return u_accountnumber; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            else if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            else if (amount > 4000)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            else
            {
                m_balance -= amount;
            }
            
           
        }

      

    }
}
