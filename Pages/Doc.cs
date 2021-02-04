using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razorsite.Pages
{
    public class DocModel : PageModel
    {
        private readonly ILogger<DocModel> _logger;

        public DocModel(ILogger<DocModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
