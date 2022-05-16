using MongoDB.Driver;
using Servicio.api.Libreria.Core.Entities;

namespace Servicio.api.Libreria.Core.ContextMongoDB
{
    public interface IAutorContext
    {
        IMongoCollection<Autor> Autores { get; }
    }
}
