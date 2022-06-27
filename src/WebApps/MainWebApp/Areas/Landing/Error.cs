using Microsoft.AspNetCore.Mvc;

namespace Recruiter.Web.Areas.Landing
{
    public class Error : BaseModel
    {
        #region Handlers

        public override IActionResult Get()
        {
            try 
            { 
                return View(); 
            }
            catch 
            { 
                return LocalRedirect("/error.htm"); 
            }
        }

        #endregion
    }
}
