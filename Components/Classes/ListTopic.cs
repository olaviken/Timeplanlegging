namespace BlazorTest.Components.Classes
{
    public class ListTopic
    {
        public List<Topic> listTopics = new();

        public ListTopic() { }

        public void AddTopic(Topic topic)
        {
            if (topic is null) throw new ArgumentNullException(nameof(topic));
            if (listTopics.Any(t => string.Equals(t.TopicID, topic.TopicID, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("A topic with the same ID already exists.");
            listTopics.Add(topic);
        }

        public void RemoveTopic(Topic topic)
        {
                       listTopics.Remove(topic);
        }

        public Topic? FindTopicByID(string topicID)
        {
            return listTopics.FirstOrDefault(t => string.Equals(t.TopicID, topicID, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateTopic(Topic updatedTopic)
        {
            var existing = FindTopicByID(updatedTopic.TopicID);
            int index = listTopics.IndexOf(existing);
            listTopics[index] = updatedTopic;
        }
        public int Count => listTopics.Count;
    }
}
