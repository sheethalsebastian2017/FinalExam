//using System;
//using System.Collections.Generic;
//using System.Data.Entity.Infrastructure;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web.Mvc;

//namespace VbFinal.Controllers
//{
//    public class VbPlayers : ApiController
//    {
//        DbModel db;

//        public VbPlayers(DbModel db)
//        {
//            this.db = db;
//        }
//        // GET api/<controller>
//        public IEnumerable<VbPlayers> Get()
//        {
//           // return db.VbPlayer.OrderBy(p => p.Name).ToList();
//        }

//        // GET api/<controller>/5
//        public ActionResult Get(int id)
//        {
//           // var VbPlayer = db.VbPlayers.SingleOrDefault(p => p.playertd == id);

//           // if (VbPlayer == null)
//            {
//                //return NotFound();
//            }
//            else
//            {
//             //   return Ok(VbPlayer);
//            }
//        }

//        // POST api/<controller>
//        public void Post([FromBody]string value)
//        {

//            if (!ModelState.IsValid)
//            {
//                return BadRequest();
//            }
//            else
//            {
//                db..Add(Vbplayer);
//                db.SaveChanges();
//                return CreatedAtAction("Post", new { id = VbPlayers.vbplayerId }, VbPlayers);
//            }
//        }

//        // PUT api/<controller>/5
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE api/<controller>/5
//        public void Delete(int id)
//        {
//        }
//    }
//}