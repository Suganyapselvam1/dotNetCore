using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace dotNetCoreWebApp_MVC_.Views.Home
{

    public class RazorPageModel : PageModel
    {
        private readonly ILogger<RazorPageModel> _logger;

        public RazorPageModel(ILogger<RazorPageModel> logger)
        {
            _logger = logger;
        }
        public string Message { get; set; }
        public void OnGet()
        {
            Message += $" Server time is { DateTime.Now }";
        }
    }
}
