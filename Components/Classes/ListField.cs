using BlazorTest.Components.Classes.Interfaces;

namespace BlazorTest.Components.Classes
{
    public class ListField : IFields
    {
        private List<Field> listFields = new();

        
        public List<Field> GetFields() 
        {
            return listFields; 
        }

        public ListField() { }

        public void AddField(Field field)
        {
            if (field is null) throw new ArgumentNullException(nameof(field));
            if (listFields.Any(t => string.Equals(t.FieldID, field.FieldID, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("A field with the same ID already exists.");
            listFields.Add(field);
        }

        public void RemoveField(Field field)
        {
                       listFields.Remove(field);
        }

        public Field? FindFieldByID(string fieldID)
        {
            return listFields.FirstOrDefault(t => string.Equals(t.FieldID, fieldID, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateField(Field updatedField)
        {
            var existingField = FindFieldByID(updatedField.FieldID);
            int index = listFields.IndexOf(existingField);
            listFields[index] = updatedField;
        }
        
        public int CountFields()
        {
            return listFields.Count;
        }
    }
}
