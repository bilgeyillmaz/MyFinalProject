using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken //anahtar kelimelerden oluşan bir string değeridir.
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; } // bu tokenın bitiş süresi 
    }
}
