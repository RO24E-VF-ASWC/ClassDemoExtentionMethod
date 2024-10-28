using PersonLib.model;


namespace ClassDemoExtentionMethod
{
    public static class ExtensionPerson
    {
        public static int Age(this Person person)
        {
            int year = DateTime.Now.Year;
            return year - person.YearOfBirth;
        }

    }
}
