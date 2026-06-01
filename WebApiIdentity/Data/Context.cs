using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiIdentity.Models;

namespace WebApiIdentity.Data
{
    public class Context : IdentityDbContext<User>
    {
        public Context(DbContextOptions<Context> options):base(options){

            
        }
    }
}
