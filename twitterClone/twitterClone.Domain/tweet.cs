

namespace twitterClone.Domain.Entities

{
    public class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private string _content;
        private bool _isDeleted;

        public Tweet(Guid authorId, string content)
        {
            _id = Guid.NewGuid();
            _authorId = authorId;
            _content = content;
            _isDeleted = false;
        }

        public Guid ID
        {
            get { return _id; }
        }
        public Guid AuthorId
        {
            get { return _authorId; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }
    }


}
