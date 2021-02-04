using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razorsite.Pages
{
    public class CinemaModel : PageModel
    {
        private readonly ILogger<CinemaModel> _logger;

        public CinemaModel(ILogger<CinemaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
