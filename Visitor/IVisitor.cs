using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IVisitor
    {

        void visit(RealEstate realEstate);
        void visit(BankAccount bankAccount);
        void visit(Loan loan);
    }
}
