namespace BlazorTest.Components.Classes
{
    public class ListTopic
    {
        public List<Topic> topicsList = new();

        public ListTopic() { }

        public void AddTopic(Topic topic)
        {
            if (topic is null) throw new ArgumentNullException(nameof(topic));
            if (topicsList.Any(t => string.Equals(t.TopicID, topic.TopicID, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("A topic with the same ID already exists.");
            topicsList.Add(topic);
        }

        public void RemoveTopic(Topic topic)
        {
                       topicsList.Remove(topic);
        }

        public Topic? FindTopicByID(string topicID)
        {
            return topicsList.FirstOrDefault(t => string.Equals(t.TopicID, topicID, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateTopic(Topic updatedTopic)
        {
            var existing = FindTopicByID(updatedTopic.TopicID);
            int index = topicsList.IndexOf(existing);
            topicsList[index] = updatedTopic;
        }
        public int Count => topicsList.Count;
    }
}
