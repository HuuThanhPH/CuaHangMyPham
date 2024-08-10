using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MongoWeb.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; } // Changed to ObjectId if using ObjectId type in MongoDB

        [BsonElement("order_id")]
        public string OrderId { get; set; }

        [BsonElement("email")]
        public string Email { get; set; } // Ensure this matches the field type in MongoDB

        [BsonElement("order_date")]
        public DateTime OrderDate { get; set; }

        [BsonElement("total_amount")]
        public decimal TotalAmount { get; set; }

        [BsonElement("items")]
        public List<OrderItem> Items { get; set; }

        [BsonElement("shipping_address")]
        public string ShippingAddress { get; set; }

        [BsonElement("payment_method")]
        public string PaymentMethod { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }
    }

    public class OrderItem
    {
        [BsonElement("product_id")]
        public string ProductId { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }
    }
}
