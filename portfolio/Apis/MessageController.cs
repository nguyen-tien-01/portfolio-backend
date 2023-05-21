using Microsoft.AspNetCore.Mvc;
using portfolio.Entities;
using portfolio.Helper;
using portfolio.Interfaces;
using portfolio.Services;

namespace portfolio.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService messageService;

        public MessageController()
        {
            messageService = new MessageService();
        }

        [HttpGet]
        public IActionResult GetMessage([FromQuery] Pagination pagination = null)
        {
            var query = messageService.GetMessages();
            var messages = PageResult<Message>.ToPageResult(pagination, query).AsEnumerable();
            pagination.TotalCount = query.Count();
            var res = new PageResult<Message>(pagination, messages);
            return Ok(res);
        }
        [HttpPost]
        public IActionResult ThemMessage(Message message)
        {
            var res = messageService.ThemMessage(message);
            return Ok(res);
        }
    }
}
