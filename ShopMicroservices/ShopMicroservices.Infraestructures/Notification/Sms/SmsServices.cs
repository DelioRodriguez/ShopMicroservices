using ShopMicroservices.Infraestructure.Base;
using ShopMicroservices.Infraestructure.Notification.Interfaces;
using ShopMicroservices.Infraestructure.Notification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMicroservices.Infraestructure.Notification.Sms
{
    public class SmsServices : INotificationServices<SmsModel>
    {
        public Task<NotificationResult> Send(SmsModel model)
        {
            throw new NotImplementedException();
        }
    }
}
