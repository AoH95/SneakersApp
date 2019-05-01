using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApp.Class.Validator
{
    public class EmailDomainValidator<TUser> : IUserValidator<TUser> where TUser : IdentityUser
    {
        private readonly List<string> _allowedDomains = new List<string>
        {
            "gmail.com",
        };

        public Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user)
        {
            if (_allowedDomains.Any(allowed =>
                   user.Email.EndsWith(allowed, StringComparison.CurrentCultureIgnoreCase)))
            {
                return Task.FromResult(IdentityResult.Success);
            }

            return Task.FromResult(
                IdentityResult.Failed(new IdentityError
                {
                    Code = "InvalidDomain",
                    Description = "Domain is invalid."
                }));
        }
    }
}
