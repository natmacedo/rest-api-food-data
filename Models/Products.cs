using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodApi.Models
{
    [BsonIgnoreExtraElements]

    public class Products
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("code")]
        public Int64 Code { get; set; }

        [BsonElement("imported_t")]
        public DateTime ImportedT { get; set; }

        [BsonElement("url")]
        public string Url { get; set; }

        [BsonElement("creator")]
        public string Creator { get; set; }

        [BsonElement("creator_t")]
        public Int32 CreatorT { get; set; }

        [BsonElement("last_modified_t")]
        public Int32 LastModifiedT { get; set; }

        [BsonElement("product_name")]
        public string ProductName { get; set; }

        [BsonElement("quantity")]
        public string Quantity { get; set; }

        [BsonElement("brands")]
        public string Brands { get; set; }

        [BsonElement("categories")]
        public string Categories { get; set; }

        [BsonElement("labels")]
        public string Labels { get; set; }

        [BsonElement("cities")]
        public string Cities { get; set; }

        [BsonElement("purchase_places")]
        public string PurchasePlaces { get; set; }

        [BsonElement("stores")]
        public string Stores { get; set; }

        [BsonElement("ingredients_text")]
        public string IngredientsText { get; set; }

        [BsonElement("traces")]
        public string Traces { get; set; }

        [BsonElement("serving_size")]
        public string Servingsize { get; set; }

        [BsonElement("serving_quantity")]
        public Int32 ServingQuantity { get; set; }

        [BsonElement("nutriscore_score")]
        public Int32 NutriscoreScore { get; set; }

        [BsonElement("nutriscore_grade")]
        public string NutriscoreGrade { get; set; }

        [BsonElement("main_category")]
        public string MainCategory { get; set; }

        [BsonElement("image_url")]
        public string ImageUrl { get; set; }

    }
}

