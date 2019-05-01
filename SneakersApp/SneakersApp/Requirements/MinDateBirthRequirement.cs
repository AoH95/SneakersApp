using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApp.Requirements
{
    public class MinDateBirthRequirement : IAuthorizationRequirement
    {
        public int MinDateBirth { get; private set; }

        public MinDateBirthRequirement(int minDateBirth) {
            MinDateBirth = minDateBirth;
        }

    }
}
