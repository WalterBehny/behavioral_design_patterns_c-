using System;

namespace Visitor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.getAssets().Add(new BankAccount(1000, 0.01));
            person.getAssets().Add(new BankAccount(2000, 0.02));
            person.getAssets().Add(new RealEstate(79000, 500));
            person.getAssets().Add(new Loan(40000, 40));

            NetWorthVisitor netWorthVisitor = new NetWorthVisitor();
            IncomeVisitor incomeVisitor = new IncomeVisitor();

            person.accept(netWorthVisitor);
            person.accept(incomeVisitor);

            Console.WriteLine(netWorthVisitor.getTotal());
            Console.WriteLine(incomeVisitor.getAmount());
        }
    }
}
