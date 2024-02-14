using Microsoft.VisualBasic;


using System;
using System.Security.Cryptography;

 

namespace NexusBackEndAPI
{
    public class NotificationRepository
    {
        public readonly ContextClass contextClass;

        public NotificationRepository(ContextClass contextClass)
        {
            this.contextClass = contextClass;
        }

        public void Add(Notification entity)
        {
           
            try
            {
                entity.notificationId = new Random().Next(1000, 10000).ToString();
                contextClass.notification.Add(entity);
                contextClass.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Delete(string id)
        {
            try
            {
                Notification notification = contextClass.notification.Find(id);
                contextClass.notification.Remove(notification);
                contextClass.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Notification Get(string id)
        {
            try
            {
                return contextClass.notification.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Notification> GetAll()
        {
            try
            {
                return contextClass.notification.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Notification entity)
        {
            try
            {
                contextClass.Update(entity);
                contextClass.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
