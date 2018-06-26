using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using StudentApp.EntityFramework;

namespace StudentApp.Migrator
{
    [DependsOn(typeof(StudentAppDataModule))]
    public class StudentAppMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<StudentAppDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}