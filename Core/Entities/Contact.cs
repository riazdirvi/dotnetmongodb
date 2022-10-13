namespace Core.Entities
{
    public class Contact
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public string Title { get; set; } = null!;
        public List<string> PhoneNumbers { get; set; } = null!;
    }
}