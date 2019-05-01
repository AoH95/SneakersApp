using Microsoft.AspNetCore.Authorization;
using SneakersApp.Requirements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApp.Handlers
{
    public class MinDateBirthHandlers : AuthorizationHandler<MinDateBirthRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinDateBirthRequirement requirement)
        {
            if (!context.User.HasClaim(c => c.Type == "BirthDate"))
                return Task.CompletedTask;

            var date = int.Parse(
                context.User.Claims.First(claim => claim.Type == "BirthDate").Value 
            );

            if (date >= requirement.MinDateBirth)
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
