﻿using DataAccess.Interfaces;
using Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly RealEstateDbContext _db;

        public PropertyRepository(RealEstateDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Property> GetAll()
        {
            return _db.Properties;
        }

        public Property GetById(int id)
        {
            return _db.Properties.SingleOrDefault(x => x.Id == id);
        }
    }
}
