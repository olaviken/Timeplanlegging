namespace BlazorTest.Components.Classes.Lists
{
    using BlazorTest.Components.Classes.Interfaces;
    using System.Collections.Generic;

    public class ListFieldsTest : IFields
    {
        private List<Field> listFields = new List<Field>
        {
            new Field
            {
                FieldID ="1",
                FieldTitle = "Sykepleie",
                FieldDescription = "Studieretning innen helsefag"
            },
            new Field
            {
                FieldID ="2",
                FieldTitle ="Spesialsykepleie",
                FieldDescription ="Videreutdanning for sykepleiere"
            },
            new Field
            {
                FieldID ="3",
                FieldTitle ="Samfunnsmedisin",
                FieldDescription ="Studieretning innen folkehelse og samfunnshelse"
            },
            new Field
            {
                FieldID ="4",
                FieldTitle ="Fysioterapi",
                FieldDescription ="Studieretning innen rehabilitering og bevegelsesfag"
            },
            new Field
            {
                FieldID ="5",
                FieldTitle ="Ergoterapi",
                FieldDescription ="Studieretning innen aktivitet og deltakelse"
            },
            new Field
            {
                FieldID ="6",
                FieldTitle ="Radiografi",
                FieldDescription ="Studieretning innen medisinsk bildediagnostikk"
            },
            new Field
            {
                FieldID ="7",
                FieldTitle ="Ambulansefag",
                FieldDescription ="Studieretning innen akuttmedisin og prehospital omsorg"
            },
            new Field
            {
                FieldID ="8",
                FieldTitle ="Helseadministrasjon",
                FieldDescription ="Studieretning innen ledelse og administrasjon i helsesektoren"
            },

        };

        public void AddField(Field field)
        {
            if (field is null) throw new ArgumentNullException(nameof(field));
            if (listFields.Any(t => string.Equals(t.FieldID, field.FieldID, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("A field with the same ID already exists.");
            listFields.Add(field);
        }

        public int CountFields()
        {
            return listFields.Count;
        }

        public Field? FindFieldByID(string fieldID)
        {
            return listFields.FirstOrDefault(t => string.Equals(t.FieldID, fieldID, StringComparison.OrdinalIgnoreCase));
        }

        public Field? FindFieldByTitle(string fieldTitle)
        {
            return listFields.FirstOrDefault(t => string.Equals(t.FieldTitle, fieldTitle, StringComparison.OrdinalIgnoreCase));
        }

        public List<Field> GetFields()
        {
            return listFields;
        }

        public void RemoveField(Field field)
        {
            listFields.Remove(field);
        }

        public void UpdateField(Field updatedField)
        {
            var existingField = FindFieldByID(updatedField.FieldID);
            int index = listFields.IndexOf(existingField);
            listFields[index] = updatedField;
        }
    }
}
