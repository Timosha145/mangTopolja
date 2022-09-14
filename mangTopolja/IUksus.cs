using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangTopolja
{
    //    1.    Liides Üksus sisaldab
    interface IUksus
    {
        //1. int-tüüpi parameetriteta meetodit punktideArv;
        int punktideArv();

        //2. String-tüüpi parameetriteta meetodit info.
        string meetodInfo();
    }
}
