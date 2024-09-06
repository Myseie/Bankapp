
using System;

namespace Bankapp
{


    public class BankAccount
    {
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }


        public BankAccount(int accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} kr har satts in på ditt konto {AccountNumber}");
            }
            else
            {
                Console.WriteLine("Beloppet måste vara POSITIVT.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Otillräckligt saldo för detta uttag");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Beloppet måste vara större än 0");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"{amount} kr har tagit ut från konto {AccountNumber}");

            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Saldo för konto {AccountNumber}: {Balance} kr");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet har startat");
            BankAccount account = new BankAccount(123456);

            Console.WriteLine("Programmet har startat");

            while (true)
            {
                Console.WriteLine("\nVälj ett alternativ:");
                Console.WriteLine("1. Visa saldo");
                Console.WriteLine("2. Sätt in pengar");
                Console.WriteLine("3. Ta ut pengar");
                Console.WriteLine("4. Avsluta");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        account.ShowBalance();
                        break;

                    case 2:

                        Console.WriteLine("Ange belopp att sätta in :");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case 3:
                        Console.WriteLine("Ange belopp att ta ut:");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Ogiltligt Val. Försök igen");
                        break;



                }
            }
        }
    }



}