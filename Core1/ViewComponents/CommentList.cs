using Core1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core1.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            var commentvalues = new List<UserComment>()
            {
                new UserComment
                {
                    Id = 1,
                    UserName="Sami"
                },
                new UserComment
            {
                Id=2,
                UserName="Göktuğ"
            },
            new UserComment
            {
                Id = 3,
                UserName = "Mücahit"
            }
            };
            return View(commentvalues);

        }

    }

    }

