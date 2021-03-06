﻿using System.Collections.Generic;

namespace SimplCommerce.Core.Domain.Models
{
    public class Product : Content
    {
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string Specification { get; set; }

        public decimal Price { get; set; }

        public decimal? OldPrice { get; set; }

        public int DisplayOrder { get; set; }

        public virtual Media ThumbnailImage { get; set; }

        public virtual IList<ProductMedia> Medias { get; protected set; } = new List<ProductMedia>();

        public virtual IList<ProductVariation> Variations { get; protected set; } = new List<ProductVariation>();

        public virtual IList<ProductAttributeValue> AttributeValues { get; protected set; } = new List<ProductAttributeValue>();

        public virtual IList<ProductOptionValue> OptionValues { get; protected set; } = new List<ProductOptionValue>();

        public virtual IList<ProductCategory> Categories { get; protected set; } = new List<ProductCategory>();

        public long? BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public void AddCategory(ProductCategory category)
        {
            category.Product = this;
            Categories.Add(category);
        }

        public void AddMedia(ProductMedia media)
        {
            media.Product = this;
            Medias.Add(media);
        }

        public void RemoveMedia(ProductMedia media)
        {
            media.Product = null;
            Medias.Remove(media);
        }

        public void AddAttributeValue(ProductAttributeValue attributeValue)
        {
            attributeValue.Product = this;
            AttributeValues.Add(attributeValue);
        }

        public void AddOptionValue(ProductOptionValue optionValue)
        {
            optionValue.Product = this;
            OptionValues.Add(optionValue);
        }

        public void AddProductVariation(ProductVariation variation)
        {
            variation.Product = this;
            Variations.Add(variation);
        }
    }
}