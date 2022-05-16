﻿using MongoDB.Driver;
using Servicio.api.Libreria.Core.ContextMongoDB;
using Servicio.api.Libreria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Servicio.api.Libreria.Repository
{
    public class AutorRepository : IAutorRepository
    {
        private readonly IAutorContext _autorContext;

        public AutorRepository(IAutorContext autorContext)
        {
            _autorContext = autorContext;
        }
        public async Task<IEnumerable<Autor>> GetAutores()
        {
            return await _autorContext.Autores.Find(p => true).ToListAsync();
        }
    }
}
