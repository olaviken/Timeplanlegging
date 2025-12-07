namespace BlazorTest.Components.Classes
{
    public class Topic
    {
        public string TopicID { get; private set; } = string.Empty;
        public string TopicTitle { get; private set; } = string.Empty;
        public string TopicDescription { get; private set; } = string.Empty;

        
        public Topic() { }
        public Topic(string topicid, string topictitle, string topicdescription)
        {
            setTopicID(topicid);
            setTopicTitle(topictitle);
            setTopicDescription(topicdescription);
        }

        public void setTopicID(string topicid)
        {
            if (string.IsNullOrWhiteSpace(topicid))
            {
                throw new ArgumentException("Topic ID cannot be empty.");
            }
            TopicID = topicid;
        }

        public void setTopicTitle(string topictitle)
        {
            if (string.IsNullOrWhiteSpace(topictitle))
            {
                throw new ArgumentException("Topic title cannot be empty.");
            }
            TopicTitle = topictitle;
        }
        public void setTopicDescription(string topicdescription)
        {
            if (string.IsNullOrWhiteSpace(topicdescription))
            {
                throw new ArgumentException("Topic description cannot be empty.");
            }
            TopicDescription = topicdescription;
        }
    }
}
