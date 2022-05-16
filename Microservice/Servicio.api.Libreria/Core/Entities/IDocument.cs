using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Servicio.api.Libreria.Core.Entities
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }

        DateTime CreatedDate{ get; }
    }
}
