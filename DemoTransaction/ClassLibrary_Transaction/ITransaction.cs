using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Transaction
{
    public interface ITransaction
    {
        bool Debiter(double montantDebit);

        bool Crediter(double montantCredit);

    }
}
