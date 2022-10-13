using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        [BsonElement("code")]
        public string Code { get; set; } = null!;

        [BsonElement("name")]
        public string Name { get; set; } = null!;
        [BsonElement("address")]
        public string Address { get; set; } = null!;
        [BsonElement("contacts")]
        public List<Contact> Contacts { get; set; } = null!;
    }
}