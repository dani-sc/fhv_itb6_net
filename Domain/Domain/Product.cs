﻿namespace Domain
{
    public class Product : IId
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Number { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public decimal? Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, Image: {Image}, Number: {Number}, CategoryId: {CategoryId}, SupplierId: {SupplierId}, Price: {Price}";
        }
    }
}
