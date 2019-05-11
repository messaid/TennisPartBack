using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TennisPartCore.Models;

namespace TennisPartCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfilController : ControllerBase
    {
        private UserManager<Joueur> _userManager;
        public UserProfilController(UserManager<Joueur> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        public async Task<Object> GetUserProfil()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);

            return new
            {
                user.FullName,
                user.Email,
                user.UserName
            };

        }

    }
}