using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DateTime_Core_App.Pages
{
    public class IndexModel : PageModel
    {
        public string Time { get; set; }
        public string Today { get; set; }
        public void OnGet()
        {
            Time = DateTime.Now.ToShortTimeString();
           Today = DateTime.Today.ToShortDateString();
        }
    }
}