using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace WebService
{
    public class SecurityHeader : SoapHeader
    {
        public string SecurityKey
        {
            get;
            set;
        }

    }
}