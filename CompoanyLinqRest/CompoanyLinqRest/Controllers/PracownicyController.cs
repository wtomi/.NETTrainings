using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CompoanyLinqRest;

namespace CompoanyLinqRest.Controllers
{
    public class PracownicyController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Pracownicy
        public IQueryable<Pracownik> GetPracownicy()
        {
            return from p in db.Pracownicy
                   orderby p.PlacaPod descending
                   select p;
        }

        // GET: api/Pracownicy/5
        [ResponseType(typeof(Pracownik))]
        public IHttpActionResult GetPracownik(int id)
        {
            Pracownik pracownik = db.Pracownicy.Find(id);
            if (pracownik == null)
            {
                return NotFound();
            }

            return Ok(pracownik);
        }

        // PUT: api/Pracownicy/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPracownik(int id, Pracownik pracownik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pracownik.IdPrac)
            {
                return BadRequest();
            }

            db.Entry(pracownik).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PracownikExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pracownicy
        [ResponseType(typeof(Pracownik))]
        public IHttpActionResult PostPracownik(Pracownik pracownik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pracownicy.Add(pracownik);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pracownik.IdPrac }, pracownik);
        }

        // DELETE: api/Pracownicy/5
        [ResponseType(typeof(Pracownik))]
        public IHttpActionResult DeletePracownik(int id)
        {
            Pracownik pracownik = db.Pracownicy.Find(id);
            if (pracownik == null)
            {
                return NotFound();
            }

            db.Pracownicy.Remove(pracownik);
            db.SaveChanges();

            return Ok(pracownik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PracownikExists(int id)
        {
            return db.Pracownicy.Count(e => e.IdPrac == id) > 0;
        }
    }
}