using System.Linq;
using StudentApp.EntityFramework;
using StudentApp.MultiTenancy;

namespace StudentApp.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly StudentAppDbContext _context;

        public DefaultTenantCreator(StudentAppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
