﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using vanns_mobileService.DataObjects;
using vanns_mobileService.Models;

namespace vanns_mobileService.Controllers
{
    public class TripController : TableController<Trip>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            vanns_mobileContext context = new vanns_mobileContext();
            DomainManager = new EntityDomainManager<Trip>(context, Request);
        }

        // GET tables/Trip
        public IQueryable<Trip> GetAllTrip()
        {
            return Query(); 
        }

        // GET tables/Trip/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Trip> GetTrip(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Trip/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Trip> PatchTrip(string id, Delta<Trip> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Trip
        public async Task<IHttpActionResult> PostTrip(Trip item)
        {
            Trip current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Trip/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTrip(string id)
        {
             return DeleteAsync(id);
        }
    }
}
