using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpPitchCounter.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public int pitchCount;
        
        private int incrimentPitchCount(int pitchCount)
        {
            return pitchCount + 1;
        }

        private int decrimentPitchCount(int pitch)
        {
            return pitch - 1;
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostIncrimentPitchCounter(int pitch)
        {
            pitchCount = incrimentPitchCount(pitch);
            return Page();
        }
        public IActionResult OnPostDecrimentPitchCounter(int pitch)
        {
            if (pitch > 0)
            {
                pitchCount = decrimentPitchCount(pitch);
            }
            return Page();
        }

    }
}
