using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razorsite.Pages
{
    public class VideoModel : PageModel
    {
        private readonly ILogger<VideoModel> _logger;

        public VideoModel(ILogger<VideoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
