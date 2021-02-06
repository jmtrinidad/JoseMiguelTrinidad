using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Infrastructure.Filter
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
                return;
            }
            await next();
        }

        // TENEMOS QUE REGISTRAR ESTA VALIDACIONES EN LA CLASE Statup que es el (Middleware) 
        //COPIA ESTAS LINEAS:

        //services.AddMvc(option=>{option.Filters.Add<ValidationFilter>();});
    }
}
