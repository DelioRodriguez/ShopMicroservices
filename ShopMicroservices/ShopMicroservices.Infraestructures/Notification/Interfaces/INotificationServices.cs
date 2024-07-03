using ShopMicroservices.Infraestructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMicroservices.Infraestructure.Notification.Interfaces
{
    public interface INotificationServices<TModel> where TModel : class
    {
        public Task<NotificationResult> Send(TModel model);
    }
}
