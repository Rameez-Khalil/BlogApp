using Bloggie.Web.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers
{
    public class AdminTagsController : Controller
    {

        //Responsible for displaying the view.
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //Capture the data.
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {

            var name = addTagRequest.Name;
            var displayName = addTagRequest.DisplayName;
            return View("Add"); 
        }
    }
}
