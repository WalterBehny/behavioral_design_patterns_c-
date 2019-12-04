using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class NetWorthVisitor : IVisitor
    {

        private int total;


        public void visit(RealEstate realEstate)
        {
            total += realEstate.getEstimatedValue();
        }


        public void visit(BankAccount bankAccount)
        {
            total += bankAccount.getAmount();
        }


        public void visit(Loan loan)
        {
            total -= loan.getOwed();
        }

        public int getTotal()
        {
            return total;
        }
    }
}

