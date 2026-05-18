using CoreWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using ControlUserModule = ControlService.UserManagement.ControlUserModule;

namespace CtlUserModule
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class CtlUserModuleController : Controller<ControlUserModule.Model, ControlUserModule.InboxModel>
    {
    }
}
