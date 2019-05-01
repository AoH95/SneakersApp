using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApp.Models
{
    public class SneakersJWTTokens
    {
        public const string Issuer = "Sneakers";
        public const string Audience = "ApiUser";
        public const string Key = "ASOLIDKEYFORASOLIDAPPLICATION.ATLEASTWETRIEDANDWETRIEDHARD.";

        public const string AuthSchemes =
            "Identity.Application" + "," + JwtBearerDefaults.AuthenticationScheme;
    }
}
