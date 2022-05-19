using FingerPrintDataAcessLayer.Data;
using FingerPrintDataAcessLayer.Interface;
using FingerPrintDataAcessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerPrintDataAcessLayer.Repository
{
    public class FingerPrintRepository : IFingerprintSave
    {
        private readonly ApplicationDbContext _db;
        public FingerPrintRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<FingerPrint> Create(FingerPrint entity)
        {
            var obj = await _db.fingerprints.AddAsync(entity);
            _db.SaveChanges();
            return obj.Entity;
        }

        public FingerPrint GetById(int Id)
        {
            return _db.fingerprints.Where(x => x.FingerPrintId == Id).SingleOrDefault();
        }
    }
}
