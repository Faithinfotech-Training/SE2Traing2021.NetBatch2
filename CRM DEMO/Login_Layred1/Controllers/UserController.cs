using DomainLayer.Models.BindingModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Entities;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Layred1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            this._user = user;

        }

        //RegisterUser
        [HttpPost("RegisterUser")]
        public async Task<object> RegisterUser([FromBody] AddUpdateRegisterUserBindingModel model)
        {
            return Ok(await _user.RegisterUser(model));
        }

        [HttpPost("Login")]
        public async Task<object> Login([FromBody] loginBindingModel model)
        {
          return Ok(await _user.Login(model));
        }

        [HttpPost("AddRole")]
        public async Task<Object> AddRole([FromBody] AddRoleBindingModel model)
        {
            return Ok(await _user.AddRole(model));
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllUsers")]
        
        public async Task<object> GetAllUsers()
        {
            return Ok(await _user.GetAllUsers());
        }



        //GetAllUsers
        //Login
        //AddRole
        //GetRoles
        //GenerateToken
    }
}
