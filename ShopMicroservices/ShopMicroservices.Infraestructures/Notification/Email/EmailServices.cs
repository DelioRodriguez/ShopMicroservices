using ShopMicroservices.Infraestructure.Base;
using ShopMicroservices.Infraestructure.Notification.Interfaces;
using ShopMicroservices.Infraestructure.Notification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMicroservices.Infraestructure.Notification.Email
{
    public class EmailServices : INotificationServices<EmailModel>
    {
        public Task<NotificationResult> Send(EmailModel model)
        {
            throw new NotImplementedException();
        }
    }

}
