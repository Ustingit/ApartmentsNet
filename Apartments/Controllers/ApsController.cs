using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Apartments.Models.Postgres;
using PagedList;

namespace Apartments.Controllers
{
    public class ApsController : Controller
    {
        private Models.ApartmentsTemporaryContext db = new Models.ApartmentsTemporaryContext();
        
        public async Task<ActionResult> Index(int page = 1, int pageSize = 9)
        {
            var allApartments = db.Apartments
                    .Where(x => x.IsActive == true)
                    .OrderByDescending(x => x.Id);

            var all = await allApartments.ToListAsync();
            var temp = await allApartments.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            DomainApartment aps = new DomainApartment
            {
                Apartments = temp,
                PageInfo = new Models.PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = all.Count }
            };

            return View(aps);
        }

        // GET: Aps/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apartment apartment = await db.Apartments.FindAsync(id);
            if (apartment == null)
            {
                return HttpNotFound();
            }
            return View(apartment);
        }

        // GET: Aps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Price,Phone,Description,DateCreated,DateActualTo,IsActive,IsDonated,DonateDueDate,ParsingSource,ShortId,SourceURL,mainPhotoUrl,phoneImgURL,Comment,Information,AuthorId,AddressId,photosListUrls")] Apartment apartment)
        {
            if (ModelState.IsValid)
            {
                db.Apartments.Add(apartment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(apartment);
        }

        // GET: Aps/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apartment apartment = await db.Apartments.FindAsync(id);
            if (apartment == null)
            {
                return HttpNotFound();
            }
            return View(apartment);
        }

        // POST: Aps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Price,Phone,Description,DateCreated,DateActualTo,IsActive,IsDonated,DonateDueDate,ParsingSource,ShortId,SourceURL,mainPhotoUrl,phoneImgURL,Comment,Information,AuthorId,AddressId,photosListUrls")] Apartment apartment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apartment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(apartment);
        }

        // GET: Aps/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apartment apartment = await db.Apartments.FindAsync(id);
            if (apartment == null)
            {
                return HttpNotFound();
            }
            return View(apartment);
        }

        // POST: Aps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Apartment apartment = await db.Apartments.FindAsync(id);
            db.Apartments.Remove(apartment);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
