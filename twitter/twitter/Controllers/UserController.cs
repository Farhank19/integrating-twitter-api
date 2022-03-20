using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using twitter.DAO;
using twitter.Model;

namespace twitter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDAO dao;
        private readonly IConfiguration configuration;

        public UserController(UserDAO dao, IConfiguration configuration)
        {
            this.dao = dao;
            this.configuration = configuration;

        }
        [HttpGet]
        [Route("GetAllUserDetaile")]
        public IActionResult GetAllUserDetaile()
        {
            return Ok(dao.GetAllUserDetaile().Result);
        }

        [HttpGet]
        [Route("GetUserDetaile/{id}")]
        public IActionResult GetUserDetaile(int id)
        {
            return Ok(dao.GetUserDetaile(id).Result);
        }
        
        [HttpGet]
        [Route("GetUserTweets/{data}")]
        public IActionResult GetUserTweets(string data)
        {
            return Ok(dao.GetUserTweets(data).Result);
        }

        [HttpGet]
        [Route("GetTweet/{data}")]
        public IActionResult GetTweet(long data)
        {
            return Ok(dao.GetTweet(data).Result);
        }

        [HttpPost]
        [Route("SignUp")]
        public IActionResult SignUp(User obj)
        {
            return Ok(dao.SignUp(obj).Result);
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(User obj)
        {
            return Ok(dao.Login(obj).Result);
        }
        [HttpPost]
        [Route("PostTweet")]
        public IActionResult PostTweet(String obj)
        {
            return Ok(dao.PostTweet(obj).Result);
        }
        [HttpPost]
        [Route("DeleteTweet")]
        public IActionResult DeleteTweet(long obj)
        {
            return Ok(dao.DeleteTweet(obj).Result);
        }
    }
}
