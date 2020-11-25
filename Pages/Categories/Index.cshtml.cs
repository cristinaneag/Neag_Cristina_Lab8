using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Neag_Cristina_Lab8.Data;
using Neag_Cristina_Lab8.Models;

namespace Neag_Cristina_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Neag_Cristina_Lab8.Data.Neag_Cristina_Lab8Context _context;

        public IndexModel(Neag_Cristina_Lab8.Data.Neag_Cristina_Lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
