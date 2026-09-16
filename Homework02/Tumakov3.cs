using System;
class Programm
{   
    enum AccountType
    {
        Current,
        Savings
    }
    struct BankAccount
    {
        public string Number;
        public AccountType Type;
        public double Balance;
    }
    enum University
    {
        KGU,
        KAI,
        KNTI
    }
    struct Worker
    {
        public string Name;
        public University University;
    }
    static void Main()
    {
        //#3.1

        AccountType account = AccountType.Current;
        Console.WriteLine("#3.1");
        Console.WriteLine("Bank account type:" + account);

        //#3.2

        BankAccount bankAccont = new BankAccount();
        bankAccont.Number = "123456789";
        bankAccont.Type = AccountType.Savings;
        bankAccont.Balance = 25000.50;
        Console.WriteLine();
        Console.WriteLine("#3.2");
        Console.WriteLine("Account number:" +  bankAccont.Type);
        Console.WriteLine("Balance:" + bankAccont.Balance);

        //#3.1

        Worker worker = new Worker();
        worker.Name = "Dasha";
        worker.University = University.KAI;
        Console.WriteLine();
        Console.WriteLine("Homework 3.1");
        Console.WriteLine("Worker name:" + worker.Name );
        Console.WriteLine("University:" + worker.University);
    }
}
   