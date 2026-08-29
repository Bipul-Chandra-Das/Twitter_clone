using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterClone.Domain.Entities
{
    internal class Bookmark
    {
        public Guid Id { get; }
        public Guid userId { get; }
        public Guid postId { get; }
        public DateTime createAt { get; }

        public Bookmark(Guid userId,Guid postId)
        {
            if (userId == Guid.Empty)
                throw new ArgumentException("userID required");
            if (postId == Guid.Empty)
                throw new ArgumentException("postId required");

            this.Id = Guid.NewGuid();
            this.postId = postId;
            this.userId = userId;
            createAt = DateTime.UtcNow;


        }
      
    }
}
