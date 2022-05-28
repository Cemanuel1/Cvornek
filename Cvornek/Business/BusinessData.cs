using Cvornek.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cvornek.Business
{
    public class BusinessData
    {
        public List<FormTb> FormTbList { get; set; }
        public List<Account> AccountList { get; set; }

        public string ErrorCode { get; set; }
        public string ErrorMassage { get; set; }
    }
}