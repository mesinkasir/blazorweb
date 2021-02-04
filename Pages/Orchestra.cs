using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razorsite.Pages
{
    public class OrchestraModel : PageModel
    {
        private readonly ILogger<OrchestraModel> _logger;

        public OrchestraModel(ILogger<OrchestraModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
