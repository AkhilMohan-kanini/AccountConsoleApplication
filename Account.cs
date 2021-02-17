using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountConsoleApplication
{
    class Account
    {
        private int _id;
        private string _accountType;
        private double _balance;

        public int ID { get { return _id; } set { _id = value; } }
        public string AccountType { get => _accountType; set => _accountType = value; }

        static List<Account> AccountList = new List<Account>();
        
        public double Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                if(value<0)
                {
                    _balance = 0;
                }
                else
                {
                    _balance = value;
                }
            }
        }

        public Account() { }

        public Account(int id , string accountType , double balance)
        {
            this.ID = id;
            this.AccountType = accountType;
            this.Balance = balance;
        }

        public static void AddAccount()
        {
            Console.WriteLine("Add an Account :\n");

            Console.WriteLine("Enter ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Type : ");
            string accountType = Console.ReadLine();

            Console.WriteLine("Enter Balance : ");
            double balance = Convert.ToDouble(Console.ReadLine());

            AccountList.Add(new Account(id, accountType, balance));

            Console.WriteLine("Account added Successfully...");
        }

        public static Boolean WithdrawMoney(double amount)
        {
            Console.WriteLine("Withdraw Amount : \n");

            Console.WriteLine("Enter ID :");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach(Account account in AccountList)
            {

                if(account.ID == id)
                {
                    if(account.Balance > amount)
                    {
                        account.Balance -= amount;
                        Console.WriteLine("Updated Balance : " + account.Balance);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            Console.WriteLine("\nInvalid ID \n");
            return false;

        }

        public static void DepositMoney()
        {
            Console.WriteLine("Deposit Money : \n");
            Console.WriteLine("Enter the ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the money to be deposited : ");
            double amount = Convert.ToDouble(Console.ReadLine());

            foreach(Account account in AccountList)
            {
                if(account.ID  == id)
                {
                    account.Balance += amount;
                    Console.WriteLine("Updated Balance : " + account.Balance);
                    Console.WriteLine("Money Deposited Successfully !!!\n");
                    return;
                }
            }

            Console.WriteLine("\n Invalid ID !!! Enter Valid ID\n");

        }

        public static void GetBalance()
        {
            Console.WriteLine("Get Balance : ");

            Console.WriteLine("Enter the Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Account account in AccountList)
            {
                if (account.ID == id)
                {
                    Console.WriteLine(" Balance : " + account.Balance);
                    return;
                }

            }

            Console.WriteLine("\nInvalid Id !!! Enter Valid ID\n ");
        }

        public static void GetDetails()
        {
            Console.WriteLine("Displaying Details : ");

            Console.WriteLine("Enter ID :");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Account account in AccountList)
            {
                if (account.ID == id)
                {
                    Console.WriteLine("Account Type : " + account.AccountType);
                    Console.WriteLine(" Balance : " + account.Balance +"\n");
                    return;
                }

            }

            Console.WriteLine("\nInvalid Id !!! Enter Valid ID\n ");
        }
    }                                                                                                                                                                                                                                                                                       
                                                                                                                                                                                                                                                                                                                                                                                             }
                                                                                                                                