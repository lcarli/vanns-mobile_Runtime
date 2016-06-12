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
    public class LevelController : TableController<Level>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            vanns_mobileContext context = new vanns_mobileContext();
            DomainManager = new EntityDomainManager<Level>(context, Request);
        }

        // GET tables/Level
        public IQueryable<Level> GetAllLevel()
        {
            return Query(); 
        }

        // GET tables/Level/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Level> GetLevel(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Level/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Level> PatchLevel(string id, Delta<Level> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Level
        public async Task<IHttpActionResult> PostLevel(Level item)
        {
            Level current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Level/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteLevel(string id)
        {
             return DeleteAsync(id);
        }
    }
}
