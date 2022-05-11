using Microsoft.AspNetCore.Mvc;
using demoapi.Data;
using demoapi.Models;


namespace demoapi.Controllers;


[ApiController]
[Route("api/User")]
public class UserController : ControllerBase
{   private readonly IRepo _repo;
        public UserController(IRepo repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await _repo.GetAllUsers());
        }

        [HttpGet]
        public async Task<IActionResult> GetUserAll()
        {
            return Ok(await _repo.GetAllUsers());
        }
        
      
 
}
