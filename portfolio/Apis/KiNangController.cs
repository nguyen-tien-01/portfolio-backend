using Microsoft.AspNetCore.Mvc;
using portfolio.Entities;
using portfolio.Interfaces;
using portfolio.Services;

namespace portfolio.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class KiNangController : ControllerBase
    {
        private readonly IKiNangService kiNangService;

        public KiNangController()
        {
            kiNangService = new KiNangService();
        }
         
        [HttpGet]
        public IActionResult LayKiNang()
        {
            var res = kiNangService.LayKiNang();
            return Ok(res);
        }
 
        [HttpPut]
        public IActionResult SuaKiNang(KiNang kiNang)
        {
            var res = kiNangService.SuaKiNang(kiNang);
            return Ok(res);
        }
        [HttpPost]
        public IActionResult ThemKiNang(KiNang kiNang)
        {
            var res = kiNangService.ThemKiNang(kiNang);
            return Ok(res);
        }
        [HttpDelete("{kiNangId}")]
        public IActionResult XoaKiNang(int kiNangId)
        {
            kiNangService.XoaKiNang(kiNangId);
            return Ok();
        }

    }
}

