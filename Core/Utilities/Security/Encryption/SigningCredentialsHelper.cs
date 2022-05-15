using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)//anahtar olarak bu security key i kullan şifrelemede 
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature); // mysupersecretkeymysupersecretkey byte haline getiriliyor.
        }
    }
}
