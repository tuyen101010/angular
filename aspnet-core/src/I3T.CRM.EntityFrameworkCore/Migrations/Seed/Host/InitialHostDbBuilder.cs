using I3T.CRM.EntityFrameworkCore;

namespace I3T.CRM.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly CRMDbContext _context;

        public InitialHostDbBuilder(CRMDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
