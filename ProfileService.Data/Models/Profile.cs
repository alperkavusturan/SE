namespace ProfileService.Data.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public int ProfileTypeId { get; set; }
        public virtual ProfileType ProfileType { get; set; }
    }
}
