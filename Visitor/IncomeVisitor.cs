using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class IncomeVisitor : IVisitor
    {
        private double amount;

        public void visit(RealEstate realEstate)
        {
            amount += realEstate.getMonthlyRent();
        }

        public void visit(BankAccount bankAccount)
        {
            amount += bankAccount.getAmount() * bankAccount.getMonthlyInterest();
        }

        public void visit(Loan loan)
        {
            amount -= loan.getMonthlyPayment();
        }

        public double getAmount()
        {
            return amount;
        }
    }
}
