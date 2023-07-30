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

        //從會員Id自動帶入會員資訊
        [HttpGet("{id}")]
        public MemberDTO GetMemberInfo(int id)
        {
            MemberDTO dto = _context.Members.Where(mem => mem.MemberId == id)
                                            .Select(mem => new MemberDTO
                                            {
                                                Name = mem.Name,
                                                Mobile = mem.Mobile
                                            }).Single();
            return dto;
        }

        //按下報名按鈕，資料是否成功回傳
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


        [HttpGet("index")]
        public IEnumerable<ActivityIndexDTO> GetAll()
        {
            if (!_context.Activities.Any())
            {
                return null;
            }

            var dtos = _context.Activities.Select(act => new ActivityIndexDTO
            {
                ActivityName = act.ActivityName,
                ActivityDate = act.ActivityDate,
                ImgPath = GetImgPath(act.ActivityId, _context) // 调用方法获取图片路径
            });

            return dtos;
        }

        // 新增一个方法，用于获取图片路径
        private static string GetImgPath(int activityId, FlexContext context)
        {
            var image = context.ActivityImgs.FirstOrDefault(a => a.fk_ActivityId == activityId);
            if (image != null)
            {
                return image.ImgPath;
            }
            return string.Empty;
        }

        //public async Task<IEnumerable<ActivityIndexDTO>> GetAll()
        //{
        //    if (!_context.Activities.Any())
        //    {
        //        return null;
        //    }

        //    var activities = _context.Activities.ToList();
        //    var tasks = activities.Select(act => GetActivityDTOAsync(act));
        //    var dtos = await Task.WhenAll(tasks);

        //    return dtos;
        //}

        //private async Task<ActivityIndexDTO> GetActivityDTOAsync(Activity activity)
        //{
        //    var imgPath = await GetImgPathAsync(activity.ActivityId);
        //    return new ActivityIndexDTO
        //    {
        //        ActivityName = activity.ActivityName,
        //        ActivityDate = activity.ActivityDate,
        //        ImgPath = imgPath
        //    };
        //}

        //private async Task<string> GetImgPathAsync(int activityId)
        //{
        //    var image = await _context.ActivityImgs.FirstOrDefaultAsync(a => a.fk_ActivityId == activityId);
        //    if (image != null)
        //    {
        //        return image.ToString();
        //    }
        //    return string.Empty;
        //}





    }
}
