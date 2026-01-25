namespace BlazorTest.Components.Classes.Interfaces
{
    public interface IFields
    {
        List<Field> GetFields();

        

        void AddField(Field field);
        void RemoveField(Field field);
        Field? FindFieldByID(string fieldID);
        Field? FindFieldByTitle(string fieldTitle);
        void UpdateField(Field updatedField);

        int CountFields();


    }
}
