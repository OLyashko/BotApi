using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BotApi
{
    public class MessageMiddleware
    {
        private readonly RequestDelegate _next;

        public MessageMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)//, MessageService messageService)
        {
            //MessageSender messageService = context.RequestServices.GetService<MessageSender>();
            context.Response.ContentType = "text/html;charset=utf-8";
            //await context.Response.WriteAsync(messageService.Send(context.Request.ToString()));
        }
    }
}
