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
    public class SchoolDriverController : TableController<SchoolDriver>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            vanns_mobileContext context = new vanns_mobileContext();
            DomainManager = new EntityDomainManager<SchoolDriver>(context, Request);
        }

        // GET tables/SchoolDriver
        public IQueryable<SchoolDriver> GetAllSchoolDriver()
        {
            return Query(); 
        }

        // GET tables/SchoolDriver/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SchoolDriver> GetSchoolDriver(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/SchoolDriver/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<SchoolDriver> PatchSchoolDriver(string id, Delta<SchoolDriver> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/SchoolDriver
        public async Task<IHttpActionResult> PostSchoolDriver(SchoolDriver item)
        {
            SchoolDriver current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/SchoolDriver/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteSchoolDriver(string id)
        {
             return DeleteAsync(id);
        }
    }
}
