using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Loan : IAsset
    {
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        private int owed;
        private int monthlyPayment;

        public Loan(int owed, int monthlyPayment)
        {
            this.owed = owed;
            this.monthlyPayment = monthlyPayment;
        }

        public int getOwed()
        {
            return owed;
        }

        public int getMonthlyPayment()
        {
            return monthlyPayment;
        }

    }
}
