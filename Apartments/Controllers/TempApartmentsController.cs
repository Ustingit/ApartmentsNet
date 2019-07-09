using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using Apartments.Models;
using PagedList;

namespace Apartments.Controllers
{
    public class TempApartmentsController : Controller
    {
        private ApartmentsTemporaryContext db = new ApartmentsTemporaryContext();

        // GET: TempApartments
        public async Task<ActionResult> Index(int page = 1, int pageSize=10)
        {
            var allApartments = db.Apartments
                .Where(x => x.IsActive == true)
                .OrderByDescending(x => x.Id);
            IEnumerable<Models.Postgres.Apartment> apartments = allApartments.Skip((page - 1) * pageSize).Take(pageSize);

            return View(apartments.ToPagedList(page, pageSize));
        }

        // GET: TempApartments/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Postgres.Apartment tempApartment = await db.Apartments.FindAsync(id);
            if (tempApartment == null)
            {
                return HttpNotFound();
            }
            return View(tempApartment);
        }

        // GET: TempApartments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TempApartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Author,Price,Phone,Description,DateCreated,DateActualTo,IsActive,IsDonated,DonateDueDate,InternalComment,ClientId,ParsingSource,ShortId,SourceURL,mainPhotoUrl,photosListUrls,phoneImgURL")] Models.Postgres.Apartment tempApartment)
        {
            if (ModelState.IsValid)
            {
                db.Apartments.Add(tempApartment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tempApartment);
        }

        // GET: TempApartments/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Postgres.Apartment tempApartment = await db.Apartments.FindAsync(id);
            if (tempApartment == null)
            {
                return HttpNotFound();
            }
            return View(tempApartment);
        }

        // POST: TempApartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Author,Price,Phone,Description,DateCreated,DateActualTo,IsActive,IsDonated,DonateDueDate,InternalComment,ClientId,ParsingSource,ShortId,SourceURL,mainPhotoUrl,photosListUrls,phoneImgURL")] TempApartment tempApartment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tempApartment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tempApartment);
        }

        // GET: TempApartments/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Postgres.Apartment tempApartment = await db.Apartments.FindAsync(id);
            if (tempApartment == null)
            {
                return HttpNotFound();
            }
            return View(tempApartment);
        }

        // POST: TempApartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Models.Postgres.Apartment tempApartment = await db.Apartments.FindAsync(id);
            db.Apartments.Remove(tempApartment);
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
