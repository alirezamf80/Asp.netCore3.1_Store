using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netCore3._1_Store.Data;
using Asp.netCore3._1_Store.Repository;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCore3._1_Store.Services
{
    public class OrderAppRepository:IOrderAppRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderAppRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<OrderApp> FindAll()
        {
            var Orderapps = _db.OrderApps.Include(k => k.Kala)
                .Include(c => c.Customer)
                .ToList();
            return Orderapps;
        }

        public OrderApp FindById(int id)
        {
            var orderapp = _db.OrderApps.Include(c => c.Customer)
                .Include(k => k.Kala).SingleOrDefault(o => o.OrderAppId == id);
            return orderapp;
        }

        public bool IsExists(int id)
        {
            var result = _db.OrderApps.Any(o => o.OrderAppId == id);
            return result;
        }

        public bool Create(OrderApp entity)
        {
            
            _db.OrderApps.Add(entity);
            return Save();

        }

        public bool Update(OrderApp entity)
        {
            _db.OrderApps.Update(entity);
            return Save();
        }

        public bool Delete(OrderApp entity)
        {
            _db.OrderApps.Remove(entity);
            return Save();
        }

        public bool Save()
        {
            var change=_db.SaveChanges();
            return change > 0;
        }

        public ICollection<OrderApp> GetOrderAppByCustomer(string CustomeId)
        {
            var Orderapps = FindAll().Where(c => c.CustomerId == CustomeId).ToList();
            return Orderapps;
        }
    }
}
