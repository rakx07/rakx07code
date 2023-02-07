using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB_APPLICATION.Pages
{
    public class Contact1Model : PageModel
    {
        public bool hasData = false;
        public string FirstName = "";
        public string Lastname = "";
        public string Message = "";

        public void OnGet()
        {
        }

       public  void OnPost()
        {
        hasData= true;
            FirstName = Request.Form["firstname"];
            Lastname = Request.Form["lastname"];
            Message = Request.Form["message"];
        }
    }
}
