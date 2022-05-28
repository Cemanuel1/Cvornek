using Cvornek.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvornek.Business
{
    public interface IBusiness
    {
        BusinessData GetFormTb();
        BusinessData InsertFormTb(FormTb formTb);
        BusinessData UpdateFormTb(FormTb formTb);
        BusinessData DeleteFormTb(int ID);

        BusinessData GetAccount();
        BusinessData InsertAccount(Account account);
        BusinessData UpdateAccount(Account account);
        BusinessData DeleteAccount(int ID);

    }
}
