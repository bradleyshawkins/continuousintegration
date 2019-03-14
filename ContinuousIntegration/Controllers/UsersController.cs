using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContinuousIntegration.Models;
using ContinuousIntegration.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContinuousIntegration.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{

		private readonly IUserService _userService;

		public UsersController(IUserService userService)
		{
			_userService = userService;
		}
		// GET: api/Employee
		[HttpGet]
		public IEnumerable<User> Get()
		{
			var users = _userService.GetUsers();
			return users;
		}

		// GET: api/Employee/5
		[HttpGet("{id}", Name = "Get")]
		public async Task<ActionResult<User>> GetUser(string id)
		{
			var user = await _userService.GetUser(id);
			if (user == null)
				return NotFound();
			return user;
		}

		// POST: api/Employee
		[HttpPost]
		public async void Post([FromBody] User user)
		{
			await _userService.CreateUser(user);
		}

		// PUT: api/Employee/5
		[HttpPut("{id}")]
		public void Put(string id, User user)
		{
			_userService.UpdateUser(id, user);
		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			_userService.DeleteUser(id);
		}
	}
}
