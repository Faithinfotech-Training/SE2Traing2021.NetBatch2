using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class VisitService
    {
        private readonly AppDBContext context;
        private readonly DbSet<Visit> visits;
        public VisitService(AppDBContext context)
        {
            this.context = context;
            this.visits = context.Set<Visit>();
        }

        public void increaseViews(String Page)
        {
            var pageVisits = visits.Where(visit => visit.Page.Equals(Page)).ToList();
            Visit page = null;
            foreach (Visit visit in pageVisits)
            {

                if (visit.Day.ToString("MM/dd/yyyy").Equals(DateTime.Now.ToString("MM/dd/yyyy")))
                {
                    page = visit;
                }
            }

                if (page == null)
                {
                    var newVisit = new Visit();
                    newVisit.Page = Page;
                    visits.Add(newVisit);
                }
                else
                {
                    page.Views += 1;
                    visits.Update(page);
                }
            context.SaveChanges();
        }

        public bool VisitsExists(int id)
        {
            return visits.Any(e => e.Id == id);
        }


    }
}
