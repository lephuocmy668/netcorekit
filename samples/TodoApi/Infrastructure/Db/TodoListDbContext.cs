using Microsoft.EntityFrameworkCore;
using NetCoreKit.Infrastructure.EfCore.Db;

namespace NetCoreKit.Samples.TodoAPI.Infrastructure.Db
{
	public class TodoListDbContext : ApplicationDbContext
	{
		public TodoListDbContext(DbContextOptions options) : base(options)
		{
		}
	}
}
