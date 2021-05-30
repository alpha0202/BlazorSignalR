using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSignalR.Server
{
    public class TextHub : Hub
    {
        public async Task Send(string text)
        {
            await Clients.All.SendAsync("ReceiveInformation", text);

        }

    }
}
