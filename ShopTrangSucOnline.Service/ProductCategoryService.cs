﻿using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTrangSucOnline.Service
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IGenericRepository<ProductCategory> _repository;
        public ProductCategoryService(IGenericRepository<ProductCategory> repository)
        {
            _repository = repository;
        }
        public void DeleteProductCategory(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAllProductCategory()
        {
            return _repository.GetAll();
        }

        public ProductCategory GetProductCategory(int id)
        {
            return _repository.GetById(id);
        }

        public void InsertProductCategory(ProductCategory productCategory)
        {
            _repository.Insert(productCategory);
        }

        public void UpdateProductCategory(ProductCategory productCategory)
        {
            _repository.Update(productCategory);
        }
    }
}
