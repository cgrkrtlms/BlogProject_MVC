using BlogProject.Business.Abstract;
using BlogProject.DataAccess.Abstract;
using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDAL _notificationDAL; 
        public NotificationManager(INotificationDAL notificationDAL)
        {
            _notificationDAL = notificationDAL;
        }
        public List<Notification> GetAll()
        {
           return _notificationDAL.GetAll();
        }

        public void TAdd(Notification entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Notification entity)
        {
            throw new NotImplementedException();
        }

        public Notification TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}
