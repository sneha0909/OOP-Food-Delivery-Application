using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public interface IEventNotifier
    {
        void NotifyAboutEventByType(EventType type, string message);
        string GetLastNotification();
    }

    public enum EventType
    {
        OrderReceived,
        OrderPreparation,
        OrderDispatched,
        OrderOntheWay,
        OrderDelivered,
        FeedbackReceived,


    }
}
