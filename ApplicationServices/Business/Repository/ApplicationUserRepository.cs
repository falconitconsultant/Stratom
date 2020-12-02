using ApplicationServices.Business.AppServices;
using ApplicationServices.Business.AppServices.IAppServices;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(StratomContext context)
    : base(context)
        { }
        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }
        public async Task<ApplicationUser> GetAllByStudentId(string id)
        {
            return StratomContext.ApplicationUser.FirstOrDefault(c => c.Id == id);
        }
    }
}
