using ContinuousIntegration.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContinuousIntegration.Entities
{
	[Table("User")]
	public class User
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public Status Status { get; set; }
	}
}
