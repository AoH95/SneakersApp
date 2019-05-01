using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SneakersApp.Data.Models
{
    public class Role : IdentityRole<int>
    {
        public static string[] Roles = new string[] { "Admin", "Visiteur", "SuperAdmin" };
    }
}
