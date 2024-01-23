/*
 * There are two ways to read data.
 *  Incoming request - Read one after the another.
 *  Model Binding - Dynamically bind the values to an object and read it inside the controller **PREFERRED.
 *  
 *  Inside the addcshtml file add these two names attributes 
 *  
 *   name="name"
 *   name = "displayName"
 *   
 *   
 *   GET THE DATA FROM FORM.
 *   var name = Request.Form["name"];
     var displayName = Request.Form["displayName"];

 //Capture the data - THIS IS NOT A PREFERRED WAY.
        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag()
        {
           var name = Request.Form["name"];
           var displayName = Request.Form["displayName"]; 
           //This will go the add view and then render this.
           return View("Add"); 
        }

 *  
 *  
 *  MODEL BINDING: 
 *          In order to use this approach, we will need to create an object.
 *          Remove the name attributes that were written.
 *          When submitting the model comes as a package in the controller and we can then read the props from it.
 *          
 *          
 *          Create a folder inside the Domain folder name it as "View Model"
 *          Create a cs file inside the Vie Model folder and name it as AddTagRequest.
 *          
 *      ADD THESE TWO PROPS IN THE ADDTAGREQUEST.
 *      
 *      public string Name { get; set; }
        public string DisplayName { get; set; }

        ADD THE FOLLOWING CODE INTO AddCSHTML

        @model Bloggie.Web.Models.ViewModel.AddTagRequest
        @{
            
        }
        
       ASP-FOR tag SHOULD BE USED FOR NAME AND DISPLAYNAME
        <input type="text" class="form-control" id="displayName" asp-for="DisplayName"/>
        <input type="text" class="form-control" id="name" asp-for="Name"/>


    FINAL ADD TAG CONTROLLER
        
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

 */