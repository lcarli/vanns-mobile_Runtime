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
    public class EstimateController : TableController<Estimate>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            vanns_mobileContext context = new vanns_mobileContext();
            DomainManager = new EntityDomainManager<Estimate>(context, Request);
        }

        // GET tables/Estimate
        public IQueryable<Estimate> GetAllEstimate()
        {
            return Query(); 
        }

        // GET tables/Estimate/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Estimate> GetEstimate(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Estimate/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Estimate> PatchEstimate(string id, Delta<Estimate> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Estimate
        public async Task<IHttpActionResult> PostEstimate(Estimate item)
        {
            Estimate current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Estimate/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteEstimate(string id)
        {
             return DeleteAsync(id);
        }
    }
}
