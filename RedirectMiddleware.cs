using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class RedirectMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            //if (context.Request.Path.StartsWithSegments(new PathString("/oidc/callbacks")))
            //{
            //    var redirect = "?p=" + context.Request.Path +
            //                   "&q=" + context.Request.QueryString.ToString().Substring(1).Replace("&", "~and~");
            //    context.Response.Redirect(redirect);
            //    return;
            //}
            await next(context);
        }
    }
}
