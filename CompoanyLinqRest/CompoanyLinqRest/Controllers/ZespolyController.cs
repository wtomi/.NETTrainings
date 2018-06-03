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
    public class ZespolyController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Zespoly
        public IQueryable<Zespol> GetZespoly()
        {
            return db.Zespoly;
        }

        // GET: api/Zespoly/5
        [ResponseType(typeof(Zespol))]
        public IHttpActionResult GetZespol(int id)
        {
            Zespol zespol = db.Zespoly.Find(id);
            if (zespol == null)
            {
                return NotFound();
            }

            return Ok(zespol);
        }

        // PUT: api/Zespoly/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutZespol(int id, Zespol zespol)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zespol.IdZesp)
            {
                return BadRequest();
            }

            db.Entry(zespol).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZespolExists(id))
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

        // POST: api/Zespoly
        [ResponseType(typeof(Zespol))]
        public IHttpActionResult PostZespol(Zespol zespol)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Zespoly.Add(zespol);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zespol.IdZesp }, zespol);
        }

        // DELETE: api/Zespoly/5
        [ResponseType(typeof(Zespol))]
        public IHttpActionResult DeleteZespol(int id)
        {
            Zespol zespol = db.Zespoly.Find(id);
            if (zespol == null)
            {
                return NotFound();
            }

            db.Zespoly.Remove(zespol);
            db.SaveChanges();

            return Ok(zespol);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ZespolExists(int id)
        {
            return db.Zespoly.Count(e => e.IdZesp == id) > 0;
        }
    }
}