// Template: Base Controller (ApiControllerBase.t4) version 0.1

using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiApplication.ContainerControllerContract.Models;

// Do not modify this file. This code was generated by RAML Web Api 2 Scaffolder

namespace WebApiApplication.ContainerControllerContract
{
    [RoutePrefix("containers")]
    public partial class ContainersController : ApiController
    {


        		/// <param name="pages">The number of pages to return</param>
		/// <param name="genre">filter the container by genre</param>
        [HttpGet]
        [Route("")]
        public virtual IHttpActionResult GetBase([FromUri] decimal? pages = null,[FromUri] string genre = null)
        {
            // Do not modify this code
            return ((IContainersController)this).Get(pages,genre);
        }

        		/// <param name="json"></param>
		/// <param name="pages">The number of pages to return</param>
        [HttpPost]
        [Route("")]
        public virtual IHttpActionResult PostBase(string json,[FromUri] decimal? pages = null)
        {
            // Do not modify this code
            return ((IContainersController)this).Post(json,pages);
        }

        		/// <param name="containerId"></param>
		/// <returns>ContainerIdGetOKResponseContent</returns>
        [ResponseType(typeof(ContainerIdGetOKResponseContent))]
        [HttpGet]
        [Route("{containerId}")]
        public virtual IHttpActionResult GetByContainerIdBase([FromUri] string containerId)
        {
            // Do not modify this code
            return ((IContainersController)this).GetByContainerId(containerId);
        }

        /// <summary>
		/// This method will *delete* an **individual container** 
		/// </summary>
		/// <param name="containerId"></param>
        [HttpDelete]
        [Route("{containerId}")]
        public virtual IHttpActionResult DeleteBase([FromUri] string containerId)
        {
            // Do not modify this code
            return ((IContainersController)this).Delete(containerId);
        }
    }
}
