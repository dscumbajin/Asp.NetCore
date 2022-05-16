using MongoDB.Driver;
using Servicio.api.Libreria.Core.Entities;

namespace Servicio.api.Libreria.Core.ContextMongoDB
{
    public class AutorContext : IAutorContext
    {
        private IMongoCollection<Autor> _autores;

        public AutorContext(IMongoSettings settings) {

            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Databese);
            _autores = database.GetCollection<Autor>(settings.Collection);
        }


        public IMongoCollection<Autor> Autores => _autores;
    }
}
