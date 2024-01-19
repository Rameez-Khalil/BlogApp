/*
 * CONTROLLER: 
 *      Admin will be able to perform CRUD operation, using this controller.
 *      Name of the view should get matched with the name of the controller.
 *      AdminTags is the controller name, and inside that there is an Add action which will return view.
 *      
 *      
 *      
 *      
 *      SHARED FILE. 
 *      <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
              Admin
               </a>
                <ul class="dropdown-menu">
               <li><a class="dropdown-item" asp-area="" asp-controller="AdminTags" asp-action="Add"> Add Tag</a></li>
             </ul>
           </li>


        ADMIN VIEW FILE: 
        <div class="bg-secondary bg-opacity-10 py-2">
             <div class="container">
        <h1> Add new Tag - Admin functionality</h1>
            </div>
        </div>


        ADMINTAGS CONTROLLER: 
        using Microsoft.AspNetCore.Mvc;
        namespace Bloggie.Web.Controllers
        {
            public class AdminTagsController : Controller
            {
                [HttpGet]
                public IActionResult Add()
                {
                    return View();
                }
            }
        }
 */