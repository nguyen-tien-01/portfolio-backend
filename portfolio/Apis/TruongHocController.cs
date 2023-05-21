using Microsoft.AspNetCore.Mvc;
using portfolio.Entities;
using portfolio.Interfaces;
using portfolio.Services;

namespace portfolio.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruongHocController : ControllerBase
    {
        private readonly ITruongHocService truongHocService;
        public TruongHocController()
        {
            truongHocService = new TruongHocService();
        }
        [HttpGet]
        public IActionResult LayTruongHoc()
        {
            var res = truongHocService.LayTruongHoc();
            return Ok(res);
        }

        [HttpPut]
        public IActionResult SuaTruongHoc(TruongHoc truongHoc)
        {
            var res = truongHocService.SuaTruongHoc(truongHoc);
            return Ok(res);
        }
        [HttpPost]
        public IActionResult ThemTruongHoc(TruongHoc truongHoc)
        {
            var res = truongHocService.ThemTruongHoc(truongHoc);
            return Ok(res);
        }
        [HttpDelete("{truongHocId}")]
        public IActionResult XoaTruongHoc(int truongHocId)
        {
            truongHocService.XoaTruongHoc(truongHocId);
            return Ok();
        }
    }
}
