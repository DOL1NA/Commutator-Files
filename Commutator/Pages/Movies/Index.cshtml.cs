using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Commutator.Data;
using Commutator.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Commutator.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Commutator.Data.CommutatorContext _context;

        public IndexModel(Commutator.Data.CommutatorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchStringTitle { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchStringIP { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchStringMac { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchStringVLAN { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchStringSern { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchStringInvn { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchStringKoment { get; set; }


        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString) || s.IP.Contains(SearchString) || s.Mac.Contains(SearchString) || s.VLAN.Contains(SearchString) || s.Sern.Contains(SearchString) || s.Invn.Contains(SearchString) || s.Koment.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(SearchStringTitle))
            {
                movies = movies.Where(s => s.Title.Contains(SearchStringTitle));
            }
            if (!string.IsNullOrEmpty(SearchStringIP))
            {
                movies = movies.Where(s => s.IP.Contains(SearchStringIP));
            }
            if (!string.IsNullOrEmpty(SearchStringMac))
            {
                movies = movies.Where(s => s.Mac.Contains(SearchStringMac));
            }
            if (!string.IsNullOrEmpty(SearchStringVLAN))
            {
                movies = movies.Where(s => s.VLAN.Contains(SearchStringVLAN));
            }
            if (!string.IsNullOrEmpty(SearchStringSern))
            {
                movies = movies.Where(s => s.Sern.Contains(SearchStringSern));
            }
            if (!string.IsNullOrEmpty(SearchStringInvn))
            {
                movies = movies.Where(s => s.Invn.Contains(SearchStringInvn));
            }
            if (!string.IsNullOrEmpty(SearchStringKoment))
            {
                movies = movies.Where(s => s.Koment.Contains(SearchStringKoment));
            }
            Movie = await movies.ToListAsync();
        }
    }
}
