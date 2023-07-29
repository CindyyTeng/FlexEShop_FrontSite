using FlexWebAPI.Models;
using FlexWebAPI.Models.DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlexWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAny")]
    public class ActivityController : ControllerBase
    {
        //建立一個全域變數_context
        private readonly FlexContext _context;

        //建構函數，把從DI容器取出的context注入到_context
        public ActivityController(FlexContext context)
        {
            _context = context;
        }

        [HttpGet]
        public string SignUp(string name, string phone)
        {

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(phone))
            {
                return "成功";
            }
            return "失敗";

        }

        //[HttpGet("{id}")]
        //public async Task<MemberDTO> GetMemberInfo(int id)
        //{
        //    MemberDTO dto = await _context.Members.Where(mem => mem.MemberId == id)
        //                                    .Select(mem => new MemberDTO
        //                                    {
        //                                        Name = mem.Name,
        //                                        Mobile = mem.Mobile
        //                                    }).SingleOrDefaultAsync();
        //    return dto;
        //}


        [HttpGet("{id}")]
        public MemberDTO GetMemberInfo(int id)
        {
            MemberDTO dto =  _context.Members.Where(mem => mem.MemberId == id)
                                            .Select(mem => new MemberDTO
                                            {
                                                Name = mem.Name,
                                                Mobile = mem.Mobile
                                            }).Single();
            return dto;
        }




    }
}
