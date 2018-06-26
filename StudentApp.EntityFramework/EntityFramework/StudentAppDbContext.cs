using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using StudentApp.Authorization.Roles;
using StudentApp.Authorization.Users;
using StudentApp.MultiTenancy;

namespace StudentApp.EntityFramework
{
    public class StudentAppDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public StudentAppDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in StudentAppDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of StudentAppDbContext since ABP automatically handles it.
         */
        public StudentAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public StudentAppDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public StudentAppDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
