﻿using ApplicationServices.Business.AppServices.IAppServices;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices
{
    public class ActiviteTypeRepository : Repository<ActiviteTypes>, IActiviteTypeRepository
    {
        public ActiviteTypeRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        public async Task<IEnumerable<ActiviteTypes>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomContext.ActiviteTypes.Include(m => m.Fiches).ToListAsync();//StratomContext.ActiviteTypes.Include(m => m.Fiches).Where(m => m.FicheId == ficheId).ToListAsync();
        }

        public async Task<IEnumerable<ActiviteTypes>> GetAllWithFichesAsync()
        {
            return await StratomContext.ActiviteTypes.Include(m => m.Fiches).ToListAsync();
        }

        public async Task<ActiviteTypes> GetWithFichesByIdAsync(int id)
        {
            return await StratomContext.ActiviteTypes.Include(m => m.Fiches).SingleOrDefaultAsync(m => m.Id == id);
        }

        public void Update(ActiviteTypes activiteType)
        {
            var objFromDb = StratomContext.ActiviteTypes.FirstOrDefault(c => c.Id == activiteType.Id);
            objFromDb.Libelle = activiteType.Libelle;
            StratomContext.SaveChanges();
        }

    }
}
