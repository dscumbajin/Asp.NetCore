namespace Servicio.api.Libreria.Core
{
    public interface IMongoSettings
    {
        string Server { get; set; }

        string Databese { get; set; }

        string Collection { get; set; }
    }
}
