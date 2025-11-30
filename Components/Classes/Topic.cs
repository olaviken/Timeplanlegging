namespace BlazorTest.Components.Classes
{
    public class Topic
    {
        public string TopicTitle { get; private set; } = string.Empty;
        public string TopicDescription { get; private set; } = string.Empty;


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
