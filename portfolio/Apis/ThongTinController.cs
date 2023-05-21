using Microsoft.AspNetCore.Mvc;
using portfolio.Entities;
using portfolio.Interfaces;
using portfolio.Services;

namespace portfolio.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThongTinController : ControllerBase
    {
        private readonly IThongTinService thongTinService;

        public ThongTinController()
        {
            thongTinService = new ThongTinService();
        }

        [HttpGet]
        public IActionResult LayThongTin()
        {
            var res = thongTinService.LayThongTin();
            return Ok(res);
        }

        [HttpPut]
        public IActionResult SuaThongTin(ThongTin thongTin)
        {
            var res = thongTinService.SuaThongTin(thongTin);
            return Ok(res);
        }
    }
}
