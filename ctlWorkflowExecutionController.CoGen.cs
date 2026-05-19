using CoreService.Engine;
using CoreWeb.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CtlWorkflowExecution
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class ctlWorkflowExecutionController: Controller<ControlService.CtlWorkflowExecution.Model, ControlService.CtlWorkflowExecution.InboxModel>
    {
    }
}
