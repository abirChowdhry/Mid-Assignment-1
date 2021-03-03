using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class AccountNumberGenerate
    { 
        static int accountNumber = 0;


        public int AccNumGenerate()
        {
            accountNumber = accountNumber + 1;
            return accountNumber;
        }
    }
}
