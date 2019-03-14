using ContinuousIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContinuousIntegration.Services
{
	public interface IUserService
	{
		IEnumerable<User> GetUsers();
		Task<User> GetUser(string id);
		Task CreateUser(User user);
		Task UpdateUser(string id, User user);
		void DeleteUser(string id);
	}
}
