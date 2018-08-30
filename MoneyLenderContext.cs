using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MoneyLenderBackend.DomainModel;

namespace MoneyLenderBackend {
    public class MoneyLenderContext : DbContext {
        public MoneyLenderContext (DbContextOptions<MoneyLenderContext> options) : base (options) {

        }
        public DbSet<User> User { get; set; }

    }
}