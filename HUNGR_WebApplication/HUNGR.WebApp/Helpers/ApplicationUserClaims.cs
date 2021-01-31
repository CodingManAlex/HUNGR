using HUNGR.WebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Helpers
{
    public class ApplicationUserClaims : UserClaimsPrincipalFactory<ApplicationUser,IdentityRole>
    {
        public ApplicationUserClaims(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> options):base(userManager,roleManager, options)
        {

        }
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("UserFirstName", user.FirstName ?? ""));
            identity.AddClaim(new Claim("UserLastName", user.LastName ?? ""));
            identity.AddClaim(new Claim("UserId", user.Id ?? ""));
            identity.AddClaim(new Claim("UserProfilePic", user.ProfileImage ?? "~/images/defaultProfileImage.png"));
            return identity; 
        }

    }
}
