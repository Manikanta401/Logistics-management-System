using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Logistics_Management_System_App.Pages
{
    public class Consignment_bookingModel : PageModel
    {
        public bool hasData = false;
        public string UserName = "";
        public string EmailId = "";
        public void OnGet()
        {
        }
        public void onPost()
        {
            hasData = true;
            UserName = Request.Form["fname"];
            EmailId = Request.Form["gmail"];

        }
    }
}
