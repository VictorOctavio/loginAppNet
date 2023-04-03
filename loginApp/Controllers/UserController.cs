using Microsoft.AspNetCore.Mvc;
using loginApp.Models.UserDto;
using loginApp.Models;
using System.Xml.Linq;

namespace loginApp.Controllers
{
    
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        [Route("/")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<UserDto>> createUser([FromBody] UserDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (user == null)
            {
                return BadRequest();
            }

            return Ok(new UserDto()
            {
                name = "byOct1"
            });

        }

    }
}
