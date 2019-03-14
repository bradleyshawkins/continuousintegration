using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContinuousIntegration.Entities;
using ContinuousIntegration.Models;

namespace ContinuousIntegration.Services
{
	public class UserService : IUserService
	{
		private readonly DataContext _dataContext;

		public UserService(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public async Task CreateUser(Models.User user)
		{
			var u = _dataContext.Users.Add(new Entities.User()
			{
				Name = user.Name,
				Status = user.Status
			});
			_dataContext.SaveChangesAsync();
		}

		public void DeleteUser(string id)
		{
			var user = new Entities.User()
			{
				Id = id
			};

			_dataContext.Users.Attach(user);
			_dataContext.Users.Remove(user);

			_dataContext.SaveChanges();
		}

		public async Task<Models.User> GetUser(string id)
		{
			var user = await _dataContext.Users.FindAsync(id);
			if (user == null)
				return null;
			return new Models.User()
			{
				Id = user.Id,
				Name = user.Name,
				Status = user.Status
			};
		}

		public IEnumerable<Models.User> GetUsers()
		{
			var users = _dataContext.Users;

			if (users == null)
			{
				return null;
			}

			return users.Select(x => new Models.User()
			{
				Id = x.Id,
				Name = x.Name,
				Status = x.Status
			}).ToArray();
			
		}

		public async Task UpdateUser(string id, Models.User user)
		{
			var newUser = new Entities.User()
			{
				Id = id,
				Name = user.Name,
				Status = user.Status
			};

			_dataContext.Users.Attach(newUser);
			_dataContext.Users.Update(newUser);

			await _dataContext.SaveChangesAsync();

			return;
		}
	}
}
