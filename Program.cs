using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            bool menuFlag = true;

            Account accObj = new Account();

            Console.WriteLine(" Account Application ");
            Console.WriteLine("*********************\n");

            while (menuFlag)
            {

                Console.WriteLine("Choose Your Option : \n");
                Console.WriteLine(" 1- Add Account \n 2- Withdraw Money \n 3- Deposit \n 4- Get Balance\n 5- Get Details\n 6- Exit\n");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Account.AddAccount();
                        break;

                    case 2:
                        Console.WriteLine("Enter the amount to be Withdrawn : ");
                        double amount = Convert.ToDouble(Console.ReadLine()); 
                        bool withdrawCheck = Account.WithdrawMoney(amount);

                        if(withdrawCheck)
                        {
                            Console.WriteLine("Money Withdrawn Successfully ....\n");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance !!! Transaction failed\n");
                        }
                        break;

                    case 3:

                        Account.DepositMoney();
                        break;

                    case 4:
                        Account.GetBalance();
                        break;

                    case 5:
                        Account.GetDetails();
                        break;

                    case 6:
                        menuFlag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice !!! Enter a Number between 1 and 5");
                        break;
                       

                }

            }
        }
    }
}
