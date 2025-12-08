namespace BlazorTest.Components.Classes
{
    public class ListField
    {
        public List<Field> listFields = new();

        public ListField() { }

        public void AddField(Field topic)
        {
            if (topic is null) throw new ArgumentNullException(nameof(topic));
            if (listFields.Any(t => string.Equals(t.FieldID, topic.FieldID, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("A field with the same ID already exists.");
            listFields.Add(topic);
        }

        public void RemoveField(Field topic)
        {
                       listFields.Remove(topic);
        }

        public Field? FindFieldByID(string topicID)
        {
            return listFields.FirstOrDefault(t => string.Equals(t.FieldID, topicID, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateField(Field updatedTopic)
        {
            var existing = FindFieldByID(updatedTopic.FieldID);
            int index = listFields.IndexOf(existing);
            listFields[index] = updatedTopic;
        }
        public int Count => listFields.Count;
    }
}
