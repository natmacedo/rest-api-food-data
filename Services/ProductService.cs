using FoodApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace FoodApi.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Products> _products;

        public ProductService(IProductDatabaseSettings settings)
        {
            //var client = new MongoClient(settings.ConnectionString);
            var client = new MongoClient("mongodb+srv://nat:natalia191785@cluster0.poltn.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("FoodData");

            _products = database.GetCollection<Products>("Products");
        }

        public List<Products> Get() =>
            _products.Find(product => true).ToList();

        public Products Get(string id) =>
            _products.Find<Products>(product => product.Id == id).FirstOrDefault();

        public Products Create(Products product)
        {
            _products.InsertOne(product);
            return product;
        }

        public void Update(string id, Products productIn) =>
            _products.ReplaceOne(product => product.Id == id, productIn);

        public void Remove(Products productIn) =>
            _products.DeleteOne(product => product.Id == productIn.Id);

        public void Remove(string id) =>
            _products.DeleteOne(product => product.Id == id);
    }
}