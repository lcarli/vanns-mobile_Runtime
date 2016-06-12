using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using vanns_mobileService.DataObjects;
using vanns_mobileService.Models;

namespace vanns_mobileService.Controllers
{
    public class ActivityVanController : TableController<ActivityVan>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            vanns_mobileContext context = new vanns_mobileContext();
            DomainManager = new EntityDomainManager<ActivityVan>(context, Request);
        }

        // GET tables/ActivityVan
        public IQueryable<ActivityVan> GetAllActivityVan()
        {
            return Query(); 
        }

        // GET tables/ActivityVan/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ActivityVan> GetActivityVan(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ActivityVan/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ActivityVan> PatchActivityVan(string id, Delta<ActivityVan> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ActivityVan
        public async Task<IHttpActionResult> PostActivityVan(ActivityVan item)
        {
            ActivityVan current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ActivityVan/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteActivityVan(string id)
        {
             return DeleteAsync(id);
        }
    }
}
