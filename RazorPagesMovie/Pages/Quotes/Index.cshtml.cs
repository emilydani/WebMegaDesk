using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Models;

namespace MegaDesk.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        //private readonly MegaDesk.Models.MegaDeskContext _context;
        private readonly MegaDesk.Models.MegaDeskContext _context;
        public IndexModel(MegaDesk.Models.MegaDeskContext context)
        {
            _context = context;
        }

        //public IList<Desk> Quote { get;set; }
        //public string SearchString { get; set; }
        //public SelectList Genres { get; set; }
        //public string QuoteGenre { get; set; }
       
        //public IList<Desk> Desk { get; set; }
        public PaginatedList<Desk> Desk { get; set; }
        public string SearchString { get; set; }
        public string KeySearchString { get; set; }
        public SelectList Quote { get; set; }
        public string Quotes { get; set; }
        public string CurrentSort { get;  set; }

        //Add sorting
        public string QuoteSort { get; set; }
        public string DateSort { get; set; }
        //public string CurrentFilter { get; set; }

        public async Task OnGetAsync(string Quotes, string keySearchString, string searchString, string sortOrder, int? pageIndex)


        {
            CurrentSort = sortOrder;
            QuoteSort = String.IsNullOrEmpty(sortOrder) ? "Quote_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            //Added for pages
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = SearchString;
            }
            // Use LINQ to get list of Quotes.
            //IQueryable<string> QuoteQuery = from m in _context.Quote

            //                                select m.Quote;
            IQueryable<Desk> QuoteQuery = from s in _context.Quote
                                            select s;
            //var Quotes = from m in _context.Quote
            //             select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                QuoteQuery = QuoteQuery.Where(s => s.name.Contains(searchString));
            }
            //if (!String.IsNullOrEmpty(keySearchString))
            //{
            //    QuoteQuery = QuoteQuery.Where(x => x.Note.Contains(keySearchString));
            //}
            switch (sortOrder)
            {
                case "Quote_desc":
                    QuoteQuery = QuoteQuery.OrderByDescending(s => s.name);
                    break;
                case "Date":
                    QuoteQuery = QuoteQuery.OrderBy(s => s.DateAdded);
                    break;

                default:
                    QuoteQuery = QuoteQuery.OrderBy(s => s.name);
                    break;
            }

            
            //Desk = await QuoteQuery.AsNoTracking().ToListAsync();
            
            SearchString = searchString;
            int pageSize = 5;
            Desk = await PaginatedList<Desk>.CreateAsync(QuoteQuery.AsNoTracking(), pageIndex ?? 1, pageSize);

        }
        //public async Task OnGetAsync(string sortOrder)
        //{
        //    QuoteSort = String.IsNullOrEmpty(sortOrder) ? "Quote_desc" : "";
        //    DateSort = sortOrder == "Date" ? "date_desc" : "Date";

        //    IQueryable<Desk> QuoteOrder = from s in _context.Quote
        //                                    select s;

        //    switch (sortOrder)
        //    {
        //        case "Quote_desc":
        //            QuoteOrder = QuoteOrder.OrderByDescending(s => s.Quote);
        //            break;
        //        case "Date":
        //            QuoteOrder = QuoteOrder.OrderBy(s => s.DateAdded);
        //            break;

        //        default:
        //            QuoteOrder = QuoteOrder.OrderBy(s => s.Quote);
        //            break;
        //    }

        //    Desk = await QuoteOrder.AsNoTracking().ToListAsync();
        //}
    }
}
