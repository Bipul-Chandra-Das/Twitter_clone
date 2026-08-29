using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterClone.Domain.Entities
{
    internal class Notification
    {
        public Guid Id { get; }
        public Guid ReciverId { get; }
        public string Title { get; }
        public string Message { get; }
        public  NotificationType Type { get; }
        public DateTime CreateAt { get; }

        public Notification(Guid Id, Guid ReciverId, string Title, string message, Type NotificationType)
        {
            if (string.IsNullOrWhiteSpace(Title))
            {
                throw new ArgumentException("tittle required");
            }

            if (string.IsNullOrWhiteSpace(Message))
            {
                throw new ArgumentException("message required ");
            }

            Id = Guid.NewGuid();
            this.ReciverId = ReciverId;
            this.Title = Title;
            this.Message = Message;
            Type=Type;
            this.CreateAt = DateTime.UtcNow;
        }
        internal enum NotificationType
        {
            like,
            retweet,
            follow,
            message
        }
    }
}
