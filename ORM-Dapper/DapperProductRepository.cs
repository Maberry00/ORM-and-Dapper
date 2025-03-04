﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    internal class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection conn;

        public DapperProductRepository(IDbConnection conn)
        {
            this.conn = conn;
        }

        public IEnumerable<Product> GetAllProducts() 
        {
            return conn.Query<Product>("SELECT * FROM products;");
        }
    }
}
