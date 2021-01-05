using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netCore3._1_Store.Data;
using Asp.netCore3._1_Store.Repository;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCore3._1_Store.Services
{
    public class KalaRepository : IKalaRepository
    {
        private ApplicationDbContext _db;
        public KalaRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public ICollection<Kala> FindAll()
        {
            var kalas = _db.Kalas.ToList();
            return kalas;
        }

        public Kala FindById(int id)
        {
            //var kala = _db.Kalas.SingleOrDefault(k => k.KalaId == id);
            var kala = _db.Kalas.Find(id);
            return kala;
        }

        public bool IsExists(int id)
        {
            var result = _db.Kalas.Any(k => k.KalaId == id);
            return result;
        }

        public bool Create(Kala entity)
        {
            _db.Kalas.Add(entity);
            return Save();

        }

        public bool Update(Kala entity)
        {
            _db.Kalas.Update(entity);
            return Save();
        }

        public bool Delete(Kala entity)
        {
            _db.Kalas.Remove(entity);
            return Save();
        }

        public bool Save()
        {
            var change = _db.SaveChanges();
            return change > 0;
        }
    }
}
