using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperExample.Models
{
    public interface IRepo
    {
        string AddMobile(TBMobileDetails objMD);
        IEnumerable<TBMobileDetails> Allmobilelisting();
    }
}