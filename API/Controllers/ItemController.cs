using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductAPI.Controllers
{
    [RoutePrefix("api/Item")]
    public class ItemController : ApiController
    {
        ProductServices objProductServices = new ProductServices();
        [HttpGet]
        [Route("GetProductCategoryList")]
        public IHttpActionResult GetProductCategoryList(Nullable<int> parentID = null)
        {
            try
            {                
                return Ok(objProductServices.GetProductCategoryList(parentID));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetItemList")]
        public IHttpActionResult GetItemList(int categoryID)
        {
            try
            {
                return Ok(objProductServices.GetItemList(categoryID));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
