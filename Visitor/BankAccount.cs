using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class BankAccount : IAsset
    {
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        private int amount;
        private double monthlyInterest;

        public BankAccount(int amount, double monthlyInterest)
        {
            this.amount = amount;
            this.monthlyInterest = monthlyInterest;
        }

        public int getAmount()
        {
            return amount;
        }

        public double getMonthlyInterest()
        {
            return monthlyInterest;
        }
    }

}
