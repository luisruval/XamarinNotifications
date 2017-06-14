using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using devxamarinService.DataObjects;
using devxamarinService.Models;
using Microsoft.Azure.NotificationHubs;
using Microsoft.Azure.Mobile.Server.Config;
using devxamarinService.Controllers;

namespace devxamarinService
{
    public partial class demo : System.Web.UI.Page
    {
        TodoItemController todoItemController;
        protected void Page_Load(object sender, EventArgs e)
        {
            todoItemController  = new TodoItemController();
        }

        protected void btnSendNotifications_Click(object sender, EventArgs e)
        {
            // Get the Notification Hubs credentials for the Mobile App.
            string notificationHubName = "devxamarin";
            string notificationHubConnection = "Connection String for DefaultFullSharedAccessSignature";

            // Create a new Notification Hub client.
            NotificationHubClient hub = NotificationHubClient
            .CreateClientFromConnectionString(notificationHubConnection, notificationHubName);

            // Sending the message so that all template registrations that contain "messageParam"
            // will receive the notifications. This includes APNS, GCM, WNS, and MPNS template registrations.
            Dictionary<string, string> templateParams = new Dictionary<string, string>();

            templateParams["messageParam"] = txtToSend.Text;

            try
            {
                // Send the push notification and log the results.
                hub.SendTemplateNotificationAsync(templateParams).Wait();

                // Write the success result to the logs.
               // config.Services.GetTraceWriter().Info(result.State.ToString());
            }
            catch (System.Exception ex)
            {
                /* Write the failure result to the logs.
                config.Services.GetTraceWriter()
                    .Error(ex.Message, null, "Push.SendAsync Error");
                    */
            }
        }
    }
}