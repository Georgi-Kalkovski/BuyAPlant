namespace BuyAPlant.Web.Areas.Administration.Controllers
{
    using BuyAPlant.Common;
    using BuyAPlant.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
