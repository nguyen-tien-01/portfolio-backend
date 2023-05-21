using Microsoft.AspNetCore.Mvc;
using portfolio.Entities;
using portfolio.Interfaces;
using portfolio.Services;

namespace portfolio.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongViecController : ControllerBase
    {
        private readonly ICongViecService congViecService;
        public CongViecController()
        {
            congViecService = new CongViecService();
        }
        [HttpGet]
        public IActionResult LayCongViec()
        {
            var res = congViecService.LayCongViec();
            return Ok(res);
        }

        [HttpPut]
        public IActionResult SuaCongViec(CongViec congViec)
        {
            var res = congViecService.SuaCongViec(congViec);
            return Ok(res);
        }
        [HttpPost]
        public IActionResult ThemCongViec(CongViec congViec)
        {
            var res = congViecService.ThemCongViec(congViec);
            return Ok(res);
        }
        [HttpDelete("{congViecId}")]
        public IActionResult XoaCongViec(int congViecId)
        {
            congViecService.XoaCongViec(congViecId);
            return Ok();
        }
    }
}
