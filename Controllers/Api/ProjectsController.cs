using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Trine.System.Projects;

namespace Trine.Web.Controllers.Api
{
    [RoutePrefix("api/projects")]
    public class ProjectsController : ApiController
    {
        public ProjectsViewModel GetProjects()
        {
            return ProjectSystem.GetProjectsViewModel();
        }
    }
}
