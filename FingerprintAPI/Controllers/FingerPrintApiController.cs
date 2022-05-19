using FingerPrintBusinessLayer.Service;
using FingerPrintDataAcessLayer.Data;
using FingerPrintDataAcessLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FingerprintAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FingerPrintApiController : ControllerBase
    {
        private readonly FingerPrintService _fingerPrintService;
        public FingerPrintApiController(FingerPrintService fingerPrintService)
        {
            _fingerPrintService = fingerPrintService;

        }
        [HttpPost("FingerPrint")]
        public async Task<Object> CreateFingerPrint([FromBody] FingerPrint fingerPrint)
        {
            try
            {
                await _fingerPrintService.AddNewFingerPrint(fingerPrint);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpGet("GetFingerById")]
        public FingerPrint GetFingerById(int id)
        {
            try
            {
                return _fingerPrintService.GetFingerPrintById(id);

            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
