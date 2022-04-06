using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;
using UserAPI.Repository;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repo;
        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("addNewUser")]
        public ActionResult RegisterUser(User model)
        {
           bool IsAdded= _repo.AddNewUser(model);
            return Ok(IsAdded);
        }
        
        [HttpGet]
        [Route("getAllUsers")]
        public ActionResult GetAllUsers()
        {
            var Users=_repo.GetAllUsers();
            return Ok(Users);
        }
        [HttpPost]
        [Route("login")]
        public ActionResult Login(UserCred cred)
        {
            bool IsLogin=_repo.UserLogin(cred.Email,cred.Password);
            return Ok(IsLogin);

        }
    }
}
