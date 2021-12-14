using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PartialView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialView.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        List<Films> Films = new List<Films>
        {
            new Films { Title = "The Avengers", Duration = "3 hour", Description = "Nick Fury is compelled to launch the Avengers Initiative when Loki poses a threat to planet Earth. His squad of superheroes put their minds together to accomplish the task." },
            new Films { Title = "Avengers endgame", Duration = "3 hour", Description = "After Thanos, an intergalactic warlord, disintegrates half of the universe, the Avengers must reunite and assemble again to reinvigorate their trounced allies and restore balance." },
            new Films { Title = "Avengers: infinity war", Duration = "3 hour", Description = "The Avengers must stop Thanos, an intergalactic warlord, from getting his hands on all the infinity stones. However, Thanos is prepared to go to any lengths to carry out his insane plan." }
          };

        public List<Films> FilmList { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            FilmList = Films;
        }


        public void OnGet()
        {

        }
    }
}
