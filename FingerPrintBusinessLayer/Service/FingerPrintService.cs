using FingerPrintDataAcessLayer.Interface;
using FingerPrintDataAcessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerPrintBusinessLayer.Service
{
    public class FingerPrintService
    {
        private readonly IFingerprintSave _fingerprintSave;
        public FingerPrintService(IFingerprintSave fingerprintSave)
        {
            _fingerprintSave = fingerprintSave;
        }
        public async Task<FingerPrint> AddNewFingerPrint(FingerPrint finger)
        {
            return await _fingerprintSave.Create(finger);
        }
        public FingerPrint GetFingerPrintById(int id)
        {
            return _fingerprintSave.GetById(id);
        }
    }
}
