namespace BlazorTest.Components.Classes
{
    public class Field
    {
        public string FieldID { get; private set; } = string.Empty;
        public string FieldTitle { get; private set; } = string.Empty;
        public string FieldDescription { get; private set; } = string.Empty;

        
        public Field() { }
        public Field(string fieldid, string fieldtitle, string fielddescription)
        {
            setFieldID(fieldid);
            setFieldTitle(fieldtitle);
            setFieldDescription(fielddescription);
        }

        public void setFieldID(string fieldid)
        {
            if (string.IsNullOrWhiteSpace(fieldid))
            {
                throw new ArgumentException("Field ID cannot be empty.");
            }
            FieldID = fieldid;
        }

        public void setFieldTitle(string fieldtitle)
        {
            if (string.IsNullOrWhiteSpace(fieldtitle))
            {
                throw new ArgumentException("Field title cannot be empty.");
            }
            FieldTitle = fieldtitle;
        }
        public void setFieldDescription(string fielddescription)
        {
            if (string.IsNullOrWhiteSpace(fielddescription))
            {
                throw new ArgumentException("Field description cannot be empty.");
            }
            FieldDescription = fielddescription;
        }
    }
}
