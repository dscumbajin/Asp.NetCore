namespace Servicio.api.Libreria.Core
{
    public class MongoSettings: IMongoSettings
    {
        public string Server { get; set; }

        public string Databese { get; set; }

        public string Collection { get; set; }
    }
}
